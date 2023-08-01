namespace Application.Persistance.Common {
    public interface IUnitOfWork {
        Task SaveChangesAsync();
    }
}
