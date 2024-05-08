using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities.Auth;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CarRentail.Application.Services
{
    public class UserServices(IVehicleRepository vehicleRepository) : IUserServices
    {
        public async Task<string> login(User userData)
        {
            try
            {
                var user = vehicleRepository.GetUser(userData);
                if (user != null)
                {
                    if (userData.password.Equals(user.password))
                    {
                        return await Task.Run(() => Jwt.GenerateToken(user));
                    }
                }
                return "error";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> register(User user)
        {
            vehicleRepository.AddUser(user);
            return "Inregistrare cu succes";
        }

    }
}
