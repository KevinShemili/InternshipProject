using Application.Interfaces.Excel;
using Application.Persistance;
using Application.Persistance.Common;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderMatrixCases.Commands {

    public class CreateLenderMatrixCommand : IRequest<bool> {
        public IFormFile File = null!;
    }

    public class CreateLenderMatrixCommandHandler : IRequestHandler<CreateLenderMatrixCommand, bool> {

        private readonly IExcelService _excelService;
        private readonly ILenderMatrixRepository _lenderMatrixRepository;
        private readonly IProductRepository _productRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public CreateLenderMatrixCommandHandler(IExcelService excelService,
                                                ILenderMatrixRepository lenderMatrixRepository,
                                                IProductRepository productRepository,
                                                ILenderRepository lenderRepository,
                                                IMapper mapper,
                                                IUnitOfWork unitOfWork,
                                                IStringLocalizer<LocalizationResources> localization) {
            _excelService = excelService;
            _lenderMatrixRepository = lenderMatrixRepository;
            _productRepository = productRepository;
            _lenderRepository = lenderRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _localization = localization;
        }

        public async Task<bool> Handle(CreateLenderMatrixCommand request, CancellationToken cancellationToken) {

            var matrices = _mapper.Map<List<LenderMatrix>>(await _excelService.ReadMatrix(request.File));

            foreach (var matrix in matrices) {
                if (await _productRepository.ContainsAsync(matrix.ProductId) is false)
                    throw new NoSuchEntityExistsException(string.Format(_localization.GetString("ProductTypeDoesntExist").Value,
                                                                        matrix.ProductId));

                else if (await _lenderRepository.ContainsAsync(matrix.LenderId) is false)
                    throw new NoSuchEntityExistsException(string.Format(_localization.GetString("LenderDoesntExist").Value,
                                                                        matrix.LenderId));

                await _lenderMatrixRepository.UploadAsync(matrix);
            }

            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }

    public class CreateLenderMatrixCommandValidator : AbstractValidator<CreateLenderMatrixCommand> {
        public CreateLenderMatrixCommandValidator() {
            RuleFor(x => x.File.FileName)
                .Must(y => IsSupported(y))
                .WithMessage("IncorrectExcelFormat");
        }

        private bool IsSupported(string fileName) {
            var supported = new List<string> { ".xlsx", ".xlsm" };

            var fileExtension = Path.GetExtension(fileName);
            return supported.Contains(fileExtension);
        }
    }
}
