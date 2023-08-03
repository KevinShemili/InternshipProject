using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.BorrowerJourney.Commands {

    public class DeleteBorrowerCommand : IRequest<bool> {
        public Guid Id { get; set; }
    }

    public class DeleteBorrowerCommandHandler : IRequestHandler<DeleteBorrowerCommand, bool> {

        private readonly IBorrowerRepository _borrowerRepository;
        private readonly ICompanyProfileRepository _companyProfileRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public DeleteBorrowerCommandHandler(IBorrowerRepository borrowerRepository,
            ICompanyProfileRepository companyProfileRepository,
            IUnitOfWork unitOfWork,
            IStringLocalizer<LocalizationResources> localizer) {
            _borrowerRepository = borrowerRepository;
            _companyProfileRepository = companyProfileRepository;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<bool> Handle(DeleteBorrowerCommand request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("BorrowerDoesntExist").Value);

            var companyProfile = await _borrowerRepository.GetCompanyProfile(request.Id);
            await _companyProfileRepository.DeleteAsync(companyProfile.Id);
            await _borrowerRepository.DeleteAsync(request.Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }

    public class DeleteBorrowerCommandValidator : AbstractValidator<DeleteBorrowerCommand> {
        public DeleteBorrowerCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
