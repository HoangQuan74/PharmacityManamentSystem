using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pharmacity_Management_System.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=PharmacityManagement")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<StorageRequirements> StorageRequirements { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<Animals> Animals { get; set; }
        public DbSet<UsageByAnimal> UsageByAnimal { get; set; }
        public DbSet<BusinessPartners> BusinessPartners { get; set; }
        public DbSet<Warehouses> Warehouses { get; set; }
        public DbSet<Shelfs> Shelfs { get; set; }
        public DbSet<ShelfLevels> ShelfLevels { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Deliveries> Deliveries { get; set; }
        public DbSet<DetailDeliveries> DetailDeliveries { get; set; }
        public DbSet<TransportCompany> TransportCompany { get; set; }
        public DbSet<Revenues> Revenues { get; set; }
        public DbSet<OtherExpenses> OtherExpenses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Thêm các cấu hình tại đây
            modelBuilder.Configurations.Add(new UsersConfiguration());
            modelBuilder.Configurations.Add(new ProductsConfiguration());
            modelBuilder.Configurations.Add(new StorageRequirementsConfiguration());
            modelBuilder.Configurations.Add(new UnitsConfiguration());
            modelBuilder.Configurations.Add(new AnimalsConfiguration());
            modelBuilder.Configurations.Add(new UsageByAnimalConfiguration());
            modelBuilder.Configurations.Add(new BusinessPartnersConfiguration());
            modelBuilder.Configurations.Add(new WarehousesConfiguration());
            modelBuilder.Configurations.Add(new ShelfsConfiguration());
            modelBuilder.Configurations.Add(new ShelfLevelsConfiguration());
            modelBuilder.Configurations.Add(new BillsConfiguration());
            modelBuilder.Configurations.Add(new PaymentsConfiguration());
            modelBuilder.Configurations.Add(new BillDetailsConfiguration());
            modelBuilder.Configurations.Add(new DeliveriesConfiguration());
            modelBuilder.Configurations.Add(new DetailDeliveriesConfiguration());
            modelBuilder.Configurations.Add(new TransportCompanyConfiguration());
            modelBuilder.Configurations.Add(new RevenuesConfiguration());
            modelBuilder.Configurations.Add(new OtherExpensesConfiguration());
        }
    }
}
