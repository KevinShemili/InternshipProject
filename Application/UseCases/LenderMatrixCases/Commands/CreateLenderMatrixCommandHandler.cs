﻿using Application.Interfaces.Excel;
using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderMatrixCases.Commands {

    public class CreateLenderMatrixCommand : IRequest<bool> {
        public Guid LenderId { get; set; }
        public Guid ProductId { get; set; }

        public IFormFile File = null!;
    }

    public class CreateLenderMatrixCommandHandler : IRequestHandler<CreateLenderMatrixCommand, bool> {

        private readonly IExcelService _excelService;
        private readonly ILenderMatrixRepository _lenderMatrixRepository;
        private readonly IProductRepository _productRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public CreateLenderMatrixCommandHandler(IExcelService excelService,
                                                ILenderMatrixRepository lenderMatrixRepository,
                                                IProductRepository productRepository,
                                                ILenderRepository lenderRepository,
                                                IUnitOfWork unitOfWork,
                                                IStringLocalizer<LocalizationResources> localization) {
            _excelService = excelService;
            _lenderMatrixRepository = lenderMatrixRepository;
            _productRepository = productRepository;
            _lenderRepository = lenderRepository;
            _unitOfWork = unitOfWork;
            _localization = localization;
        }

        public async Task<bool> Handle(CreateLenderMatrixCommand request, CancellationToken cancellationToken) {

            if (await _lenderRepository.ContainsAsync(request.LenderId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("LenderDoesntExist").Value);

            if (await _productRepository.ContainsAsync(request.ProductId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("ProductTypeDoesntExist").Value);

            if (await _lenderMatrixRepository.ContainsAsync(request.LenderId, request.ProductId) is true)
                throw new ForbiddenException(_localization.GetString("MatrixAlreadyExists").Value);

            var matrices = await _excelService.ReadMatrix(request.File, request.LenderId, request.ProductId);
            await _lenderMatrixRepository.CreateAsync(matrices);

            var flag = await _unitOfWork.SaveChangesAsync();
            if (flag is false)
                throw new Exception();

            return true;
        }
    }

    public class CreateLenderMatrixCommandValidator : AbstractValidator<CreateLenderMatrixCommand> {
        public CreateLenderMatrixCommandValidator() {
            RuleFor(x => x.LenderId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.File.FileName)
                .Must(y => IsSupported(y))
                .WithMessage("IncorrectExcelFormat");
        }

        private static bool IsSupported(string fileName) {
            var supported = new List<string> { ".xlsx", ".xlsm" };

            var fileExtension = Path.GetExtension(fileName);
            return supported.Contains(fileExtension);
        }
    }
}
