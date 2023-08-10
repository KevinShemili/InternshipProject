using Application.Interfaces.Excel;
using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderMatrixCases.Queries {

    public class GenerateLenderMatrixQuery : IRequest<FileStreamResult> {
        public Guid ProductId { get; set; }
        public Guid LenderId { get; set; }
    }

    public class GenerateLenderMatrixQueryHandler : IRequestHandler<GenerateLenderMatrixQuery, FileStreamResult> {

        private readonly IProductRepository _productRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IExcelService _excelService;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public GenerateLenderMatrixQueryHandler(ILenderRepository lenderRepository, IProductRepository productRepository, IExcelService excelService, IStringLocalizer<LocalizationResources> localization) {
            _lenderRepository = lenderRepository;
            _productRepository = productRepository;
            _excelService = excelService;
            _localization = localization;
        }

        public async Task<FileStreamResult> Handle(GenerateLenderMatrixQuery request, CancellationToken cancellationToken) {

            if (await _productRepository.ContainsAsync(request.ProductId) is false)
                throw new NoSuchEntityExistsException(string.Format(_localization.GetString("ProductTypeDoesntExist").Value,
                                                                        request.ProductId));

            if (await _lenderRepository.ContainsAsync(request.LenderId) is false)
                throw new NoSuchEntityExistsException(string.Format(_localization.GetString("LenderDoesntExist").Value,
                                                                        request.LenderId));

            var product = await _productRepository.GetByIdAsync(request.ProductId);
            var lender = await _lenderRepository.GetByIdAsync(request.LenderId);

            return _excelService.GenerateMatrixTemplate(lender, product);
        }
    }

    public class GenerateLenderMatrixQueryValidator : AbstractValidator<GenerateLenderMatrixQuery> {
        public GenerateLenderMatrixQueryValidator() {
            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.LenderId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }

}
