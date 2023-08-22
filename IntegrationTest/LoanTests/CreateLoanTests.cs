using Application.Exceptions.ClientErrors;
using Application.UseCases.LoanJourney.Commands;
using IntegrationTest.Configurations;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTest.LoanTests {
    public class CreateLoanTests : BaseIntegrationTest {
        public CreateLoanTests(IntegrationTestWebFactory factory) : base(factory) {
        }

        [Fact]
        public async void HandleCreateLoan_WrongApplication_ThrowsNotFoundException() {

            // Arrange
            var command = new CreateLoanCommand {
                ApplicationId = Guid.Parse("23EADAC2-3BBB-421B-9A5B-AFF07EB74C41"),
                LenderId = Guid.Parse("0F3C377F-89AD-4FD6-AF55-62F783B0EA52")
            };

            // Act && Assert
            await Assert.ThrowsAsync<NotFoundException>(async () => await _mediator.Send(command));
        }

        [Fact]
        public async void HandleCreateLoan_WrongLender_ThrowsNotFoundException() {

            // Arrange
            var command = new CreateLoanCommand {
                ApplicationId = Guid.Parse("9038FF25-5A61-46D0-BC8F-B49F23E42280"),
                LenderId = Guid.Parse("23EADAC2-3BBB-421B-9A5B-AFF07EB74C41")
            };

            // Act && Assert
            await Assert.ThrowsAsync<NotFoundException>(async () => await _mediator.Send(command));
        }

        [Fact]
        public async void HandleCreateLoan_AlreadyApprovedApplication_ThrowsConflictException() {

            // Arrange
            var command = new CreateLoanCommand {
                ApplicationId = Guid.Parse("6205D644-9F93-4C6A-B406-E39F4BE629BF"),
                LenderId = Guid.Parse("0F3C377F-89AD-4FD6-AF55-62F783B0EA52")
            };

            // Act && Assert
            await Assert.ThrowsAsync<ConflictException>(async () => await _mediator.Send(command));
        }

        [Fact]
        public async void HandleCreateLoan_UneligibleLender_ThrowsConflictException() {

            // Arrange
            var command = new CreateLoanCommand {
                ApplicationId = Guid.Parse("9F5317CF-689A-42BC-90C5-9BBCA58E1605"),
                LenderId = Guid.Parse("7F83C404-EFEE-4900-98EE-38D3C95DAF56") // ineligible due to company type
            };

            // Act && Assert
            await Assert.ThrowsAsync<InvalidRequestException>(async () => await _mediator.Send(command));
        }

        [Fact]
        public async void HandleCreateLoan_HappyPath_CreatesLoan() {

            // Arrange
            var command = new CreateLoanCommand {
                ApplicationId = Guid.Parse("9F5317CF-689A-42BC-90C5-9BBCA58E1605"),
                LenderId = Guid.Parse("0F3C377F-89AD-4FD6-AF55-62F783B0EA52")
            };

            // Act
            var result = await _mediator.Send(command);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Id.ToString());
            Assert.NotNull(result.InterestRate.ToString());
            Assert.NotNull(result.RequestedAmount.ToString());
            Assert.NotNull(result.ReferenceRate.ToString());
            Assert.NotNull(result.Status.ToString());
            Assert.NotNull(result.Tenor.ToString());

            var loan = await _dbContext.Loans.FirstOrDefaultAsync(x => x.Id == result.Id);
            Assert.NotNull(loan);
            Assert.Equal(command.ApplicationId, loan.ApplicationId);

            _ = _dbContext.Remove(loan);
            await _dbContext.SaveChangesAsync();
        }
    }
}
