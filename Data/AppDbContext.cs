using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project.Entities;
using ProjectBE.Entities;
using StackExchange.Redis;

namespace Project.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brands> brands { get; set; }
        public DbSet<Cars> cars { get; set; }
        public DbSet<CarTypes> carTypes { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<OrderCars> orderCars { get; set; }
        public DbSet<WishList> wishLists { get; set; }
        public DbSet<RefreshToken> refreshTokens { get; set; }

        private readonly IConfiguration _configuration;

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                          // .UseLazyLoadingProxies()
                          //   .UseSqlServer(_configuration.GetConnectionString("DefaultConnectionString"))
                          .LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entity.GetTableName() ?? throw new Exception("Table name not found.");
                if (tableName.StartsWith("AspNet"))
                {
                    entity.SetTableName(tableName.Substring(6));
                }
            }

            modelBuilder.Entity<Cars>()
                        .HasOne(a => a.Brands)
                        .WithMany(a => a.Cars)
                        .HasForeignKey(c => c.BrandId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cars>()
                        .HasOne(a => a.CarTypes)
                        .WithMany(t => t.Cars)
                        .HasForeignKey(a => a.CarTypeId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cars>()
                        .Property(c => c.CreatedAt)
                        .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Orders>()
                        .HasOne(a => a.Users)
                        .WithMany()
                        .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Orders>()
                        .HasMany(a => a.OrderCars)
                        .WithOne()
                        .HasForeignKey(a => a.OrderId);

            modelBuilder.Entity<Orders>()
                        .Property(o => o.CreatedAt)
                        .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Orders>()
                        .Property(o => o.CodeOrder)
                        .HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Users>()
                        .Property(u => u.CreatedAt)
                        .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<OrderCars>()
                        .HasKey(rc => new { rc.OrderId, rc.CarId });

            modelBuilder.Entity<OrderCars>()
                        .HasOne(rc => rc.Car)
                        .WithMany(c => c.OrderCars)
                        .HasForeignKey(rc => rc.CarId);

            modelBuilder.Entity<WishList>()
                        .HasKey(w => new { w.Userid, w.Carid });


            modelBuilder.Entity<WishList>()
                        .HasOne(w => w.Users)
                        .WithMany()
                        .HasForeignKey(w => w.Userid);

            modelBuilder.Entity<WishList>()
                        .HasOne(w => w.Cars)
                        .WithMany(c => c.WishList)
                        .HasForeignKey(w => w.Carid);


            modelBuilder.Entity<CarTypes>().HasData(
                new CarTypes { Id = 11, Name = "Manual" },         // Xe số
                new CarTypes { Id = 12, Name = "Scooter" },        // Xe tay ga
                new CarTypes { Id = 13, Name = "Clutch Bike" },    // Xe côn tay
                new CarTypes { Id = 14, Name = "Electric Bike" },  // Xe điện
                new CarTypes { Id = 15, Name = "Motorbike" }       // Xe mô tô phân khối lớn
            );


            modelBuilder.Entity<Brands>().HasData(
                new Brands { Id = 11, Name = "Honda" },
                new Brands { Id = 12, Name = "Yamaha" },
                new Brands { Id = 13, Name = "Suzuki" },
                new Brands { Id = 14, Name = "SYM" },
                new Brands { Id = 15, Name = "VinFast" },
                new Brands { Id = 16, Name = "Piaggio" }
            );

            modelBuilder.Entity<Cars>().HasData(
                new Cars
                {
                    Id = 1,
                    Name = "Honda Wave Alpha",
                    BrandId = 11,
                    CarTypeId = 11,
                    PricePerDay = 18000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "33E-33333"
                },
                new Cars
                {
                    Id = 2,
                    Name = "Honda Vision",
                    BrandId = 11,
                    CarTypeId = 12,
                    PricePerDay = 31000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "35G-55555"
                },
                new Cars
                {
                    Id = 3,
                    Name = "Yamaha Sirius",
                    BrandId = 12,
                    CarTypeId = 11,
                    PricePerDay = 19000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "34F-44444"
                },
                new Cars
                {
                    Id = 4,
                    Name = "Yamaha Exciter 155",
                    BrandId = 12,
                    CarTypeId = 13,
                    PricePerDay = 47000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "33E-33333"
                },
                new Cars
                {
                    Id = 5,
                    Name = "Suzuki Raider R150",
                    BrandId = 13,
                    CarTypeId = 13,
                    PricePerDay = 50000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "32D-22222"
                },
                new Cars
                {
                    Id = 6,
                    Name = "SYM Elegant 50",
                    BrandId = 14,
                    CarTypeId = 11,
                    PricePerDay = 17000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "31C-11111"
                },
                new Cars
                {
                    Id = 7,
                    Name = "VinFast Klara",
                    BrandId = 15,
                    CarTypeId = 14,
                    PricePerDay = 39000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "30B-67890"
                },
                new Cars
                {
                    Id = 8,
                    Name = "Piaggio Liberty",
                    BrandId = 16,
                    CarTypeId = 12,
                    PricePerDay = 56000000,
                    CreatedAt = DateTime.Now,
                    ImageUrl = "https://cafefcdn.com/203337114487263232/2024/11/21/scv-white-4-front-left-3601-1732167139690-1732167139799857346954.jpg",
                    Status = CarStatusEnum.Available,
                    LicensePlate = "29A-12345"
                }
            );
        }
    }
}