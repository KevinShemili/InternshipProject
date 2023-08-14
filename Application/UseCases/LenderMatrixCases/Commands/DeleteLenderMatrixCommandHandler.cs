using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LenderMatrixCases.Commands {

    public class DeleteLenderMatrixCommand : IRequest<bool> {
        public Guid ProductId { get; set; }
        public Guid LenderId { get; set; }
    }

    public class DeleteLenderMatrixCommandHandler : IRequestHandler<DeleteLenderMatrixCommand, bool> {

        private readonly ILenderMatrixRepository _lenderMatrixRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteLenderMatrixCommandHandler(ILenderMatrixRepository lenderMatrixRepository, IUnitOfWork unitOfWork) {
            _lenderMatrixRepository = lenderMatrixRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteLenderMatrixCommand request, CancellationToken cancellationToken) {

            if (await _lenderMatrixRepository.ContainsAsync(request.LenderId, request.ProductId) is false)
                throw new NoSuchEntityExistsException("");

            await _lenderMatrixRepository.DeleteAsync(request.ProductId, request.LenderId);
            var flag = await _unitOfWork.SaveChangesAsync();

            if (flag is false) {
                throw new Exception();
            }

            return true;
        }
    }

    public class DeleteLenderMatrixCommandValidator : AbstractValidator<DeleteLenderMatrixCommand> {
        public DeleteLenderMatrixCommandValidator() {
            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.LenderId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
