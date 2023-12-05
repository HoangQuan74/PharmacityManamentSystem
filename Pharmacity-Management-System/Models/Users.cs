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

namespace Pharmacity_Management_System.Models
{
    public class Users : BaseModel
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }
        [Column(name: "fullName", TypeName = "varchar(100)")]
        public string fullName { get; set; }
        [Column(name: "email", TypeName = "varchar(50)")]
        public string email { get; set; }
    }

    public class UsersConfiguration : EntityTypeConfiguration<Users>
    {
        public UsersConfiguration()
        {
            // Các cấu hình của bạn ở đây
            // Ví dụ:
            this.ToTable("Users"); // Đặt tên bảng là "Users"
            this.HasKey(x => x.id); // Đặt khóa chính
            this.Property(x => x.fullName).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.email).HasColumnType("varchar").HasMaxLength(50);

            // Các cấu hình khác tùy thuộc vào yêu cầu của bạn
        }
    }
}
