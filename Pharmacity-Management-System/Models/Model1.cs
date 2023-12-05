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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Thêm các cấu hình tại đây
            modelBuilder.Configurations.Add(new UsersConfiguration());
        }
    }
}
