using CarRent.Car.Domain;
using Microsoft.EntityFrameworkCore;
using Type = CarRent.Car.Domain.Type;

namespace CarRent.Car.Infrastructure.Persistence
{
    public class CarContext : DbContext
    {
        public DbSet<Domain.Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("CarRent"));
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Car>()
                .HasKey(car => car.Id);
            modelBuilder.Entity<Domain.Car>()
                .Property(car => car.Id)
                .HasColumnName("Id");
            modelBuilder.Entity<Domain.Car>()
                .HasOne(car => car.Brand)
                .WithMany(brand => brand.Cars)
                .HasForeignKey(car => car.BrandId);
            modelBuilder.Entity<Domain.Car>()
                .HasOne(car => car.CarClass)
                .WithMany(carClass => carClass.Cars)
                .HasForeignKey(car => car.CarClassId);
            modelBuilder.Entity<Domain.Car>()
                .HasOne(car => car.Type)
                .WithMany(type => type.Cars)
                .HasForeignKey(car => car.TypeId);
            modelBuilder.Entity<Brand>()
                .HasKey(brand => brand.Id);
            modelBuilder.Entity<Brand>()
                .Property(brand => brand.Id)
                .HasColumnName("Id");
            modelBuilder.Entity<CarClass>()
                .HasKey(carClass => carClass.Id);
            modelBuilder.Entity<CarClass>()
                .Property(carClass => carClass.Id)
                .HasColumnName("Id");
            modelBuilder.Entity<Type>()
                .HasKey(type => type.Id);
            modelBuilder.Entity<Type>()
                .Property(type => type.Id)
                .HasColumnName("Id");

            #region Add Cars
            //var cars = new List<Domain.Car>
            //{
            //    new()
            //    {
            //        CarNumber = "12AX",
            //        Brand = new()
            //        {
            //            Name = "BMW"
            //        },
            //        CarClass = new()
            //        {
            //            Name = "SUV",
            //            DailyPrice = 265
            //        },
            //        Type = new()
            //        {
            //            Name = "X3"
            //        }
            //    },
            //    new()
            //    {
            //        CarNumber = "69ER",
            //        Brand = new()
            //        {
            //            Name = "Audi"
            //        },
            //        CarClass = new()
            //        {
            //            Name = "Sport",
            //            DailyPrice = 856
            //        },
            //        Type = new()
            //        {
            //            Name = "R8"
            //        }
            //    },
            //};

            //foreach (var car in cars)
            //    modelBuilder.Entity<Domain.Car>().HasData(car);
            #endregion
        }
    }
}
