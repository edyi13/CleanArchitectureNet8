using CleanArchitectrure.Domain.Entities;

namespace CleanArchitectrure.Application.Interface.Persistence
{
    public interface IUserRepository
    {
        Task<User> GetAync(string client);
        Task<bool> InsertAync(User user);
    }
}
