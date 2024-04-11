namespace CleanArchitectrure.Application.Interface.Persistence
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        ICustomerRepository Customers { get; }
    }
}
