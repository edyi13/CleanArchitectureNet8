using CleanArchitectrure.Application.Interface.Persistence;

namespace CleanArchitectrure.Persistence.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; }

        public ICustomerRepository Customers { get; }

        public UnitOfWork(IUserRepository users, ICustomerRepository customers)
        {
            Users = users ?? throw new ArgumentNullException(nameof(users));
            Customers = customers ?? throw new ArgumentNullException(nameof(customers));
        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
