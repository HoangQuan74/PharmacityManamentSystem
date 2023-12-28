using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Reflection;

namespace Pharmacity_Management_System.Models
{
    public class Users
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "fullName", TypeName = "varchar(100)")]
        public string fullName { get; set; }

        [Column(name: "email", TypeName = "varchar(50)")]
        public string email { get; set; }

        [Column(name: "employeeType", TypeName = "int")]
        public int employeeType { get; set; }

        [Column(name: "phone", TypeName = "varchar(20)")]
        public string phone { get; set; }

        [Column(name: "cccd", TypeName = "varchar(20)")]
        public string cccd { get; set; }

        [Column(name: "userName", TypeName = "varchar(50)")]
        public string userName { get; set; }

        [Column(name: "password", TypeName = "varchar(100)")]
        public string password { get; set; }

        [Column(name: "salary", TypeName = "Money")]
        public decimal salary { get; set; }

        [Column(name: "gender", TypeName = "varchar(50)")]
        public string gender { get; set; }

    }

    public class UsersConfiguration : EntityTypeConfiguration<Users>
    {
        public UsersConfiguration()
        {
            // Các cấu hình của bạn ở đây
            // Ví dụ:
            this.ToTable("t_users"); // Đặt tên bảng là "Users"
            this.HasKey(x => x.id); // Đặt khóa chính
            this.Property(x => x.fullName).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.email).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.phone).HasColumnType("varchar").HasMaxLength(20);
            this.Property(x => x.cccd).HasColumnType("varchar").HasMaxLength(20);
            this.Property(x => x.userName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.password).HasColumnType("varchar").HasMaxLength(100);

            // Các cấu hình khác tùy thuộc vào yêu cầu của bạn
        }
    }
}
