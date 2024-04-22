using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using CarRentail.Infrastructure.Repositories;

namespace CarRentail.Application.DBRequests
{
    public class DeleteVehicle
    {
        public static string DeleteData(IVehicleRepository vehicleRepository, int id, VehicleType.VehicleTypes types)
        {
            switch (types)
            {
                case VehicleType.VehicleTypes.HybridCar:
                    vehicleRepository.DeleteHybridCar(id);
                    return "Masina a fost stearsa cu succes";
                case VehicleType.VehicleTypes.CombustionCar:
                    vehicleRepository.DeleteCombustionCar(id);
                    return "Masina a fost stearsa cu succes";
                case VehicleType.VehicleTypes.ElectricCar:
                    vehicleRepository.DeleteElectricCar(id);
                    return "Masina a fost stearsa cu succes";
                case VehicleType.VehicleTypes.ElectricMotorcycle:
                    vehicleRepository.DeleteElectricMotorcycle(id);
                    return "Motocicleta a fost stearsa cu succes";
                case VehicleType.VehicleTypes.CombustionMotorcycle:
                    vehicleRepository.DeleteCombustionMotorcycle(id);
                    return "Motocicleta a fost stearsa cu succes";
                default:
                    return "Eroare la stergerea vehicolului";

            }
        }
    }
}
