using CarRentail.Domain.Entities.Auth;

namespace CarRentail.Application.Services
{
    public interface IUserServices
    {
        Task<string> login(User  user);
        Task<string> register(User user);
        Task<string> updatePassword(User user);
    }
}
