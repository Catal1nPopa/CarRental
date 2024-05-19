using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Entities.Auth;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

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
            var checkUser = vehicleRepository.GetUser(user);
            if (checkUser != null)
            {
                return "existent";
            }
            vehicleRepository.AddUser(user);
            addClient(user);
            return "Inregistrare cu succes";
        }

        public async Task<string> updatePassword(User user)
        { 
            var checkUser = vehicleRepository.GetUser(user);
            if (checkUser != null)
            {
                user.Id = checkUser.Id;
                user.role = checkUser.role;
                vehicleRepository.UpdateUser(user);
                return "date actualizate cu succes";
            }

            return "Utilizatorul nu a fost gasit";
        }

        public void addClient(User user)
        {
            Client client = new Client();
            client.Name = user.username;
            client.RegisterDateTime = DateTime.Now;
            client.PhoneNumber = "";
            vehicleRepository.AddClient(client);
        }

        public async Task<string> updateRole(User user)
        {
            var checkUser = vehicleRepository.GetUser(user);
            if (checkUser != null)
            {
                user.Id = checkUser.Id;
                //user.role = checkUser.role;
                vehicleRepository.UpdateRoleUser(user);
                return "date actualizate cu succes";
            }

            return "Utilizatorul nu a fost gasit";
        }

    }
}
