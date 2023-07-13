using Domain.Common;

namespace Domain.Entities {
    public class User : BaseEntity {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!; 
        public string LastName { get; set;} = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!; 
        public string Prefix { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public virtual ICollection<Role> Roles { get; set; } = null!;
        public virtual ICollection<Borrower>? Borrowers { get; set; }
    }
}
