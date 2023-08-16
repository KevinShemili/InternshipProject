using Application.Exceptions.ServerErrors;
using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LenderMatrixCases.Commands {

    public class DeleteLenderMatrixCommand : IRequest<bool> {
        public Guid ProductId { get; set; }
        public Guid LenderId { get; set; }
    }

    public class DeleteLenderMatrixCommandHandler : IRequestHandler<DeleteLenderMatrixCommand, bool> {

        private readonly ILenderMatrixRepository _lenderMatrixRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public DeleteLenderMatrixCommandHandler(ILenderMatrixRepository lenderMatrixRepository,
                                                IUnitOfWork unitOfWork,
                                                IStringLocalizer<LocalizationResources> localization) {
            _lenderMatrixRepository = lenderMatrixRepository;
            _unitOfWork = unitOfWork;
            _localization = localization;
        }

        public async Task<bool> Handle(DeleteLenderMatrixCommand request, CancellationToken cancellationToken) {

            if (await _lenderMatrixRepository.ContainsAsync(request.LenderId, request.ProductId) is false)
                throw new NoSuchEntityExistsException("");

            await _lenderMatrixRepository.DeleteAsync(request.ProductId, request.LenderId);

            var flag = await _unitOfWork.SaveChangesAsync();
            if (flag is false)
                throw new DatabaseException(_localization.GetString("DatabaseException"));

            return true;
        }
    }

    public class DeleteLenderMatrixCommandValidator : AbstractValidator<DeleteLenderMatrixCommand> {
        public DeleteLenderMatrixCommandValidator() {
            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("EmptyProductId");

            RuleFor(x => x.LenderId)
                .NotEmpty().WithMessage("EmptyLenderId");
        }
    }
}
