using CarRentail.Domain.Entities;
using CarRentail.Domain.Entities.Auth;
using CarRentail.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace CarRentail.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=CATALIN; Database=CarRentail; Integrated Security=True; TrustServerCertificate=True");
        }


        public DbSet<HybridCar> HybridCars { get; set; }
        public DbSet<ElectricCar> ElectricCars { get; set; }
        public DbSet<CombustionCar> CombustionCars { get; set; }
        public DbSet<ElectricMotorcycle> ElectricMotorcycles { get; set; }
        public DbSet<CombustionMotorcycle> CombustionMotorcycles { get; set; }

        public DbSet<CarInspection> CarInspections { get; set; }

        public DbSet<RentalProc> RentalRegistration { get; set; } 

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}