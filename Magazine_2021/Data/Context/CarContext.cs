using Magazine_2021.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Magazine_2021.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
            Database.EnsureCreated(); //создаем БД при первом обращении к ней
        }

        public DbSet<Car> CarTable { get; set; }
        public DbSet<Category> CategoryTable { get; set; }
    }
}
