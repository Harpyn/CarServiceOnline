using CarServiceCare.DataAccess.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace CarServiceCare.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options){}

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarInsurance> CarInsurances { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Refueling> Refuelings { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<STK> STK { get; set; }
        public DbSet<TireChange> TireChanges { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
    }
}
