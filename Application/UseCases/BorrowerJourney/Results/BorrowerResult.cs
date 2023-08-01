namespace Application.UseCases.BorrowerJourney.Results {
    public class BorrowerResult {
        public Guid Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string CompanyType { get; set; } = null!;
    }
}
