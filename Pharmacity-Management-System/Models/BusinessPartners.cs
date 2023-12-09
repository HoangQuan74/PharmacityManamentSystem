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
    public class BusinessPartners
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "fullName", TypeName = "varchar(100)")]
        public string fullName { get; set; }

        [Column(name: "email", TypeName = "varchar(50)")]
        public string email { get; set; }

        [Column(name: "typePartner", TypeName = "int")]
        public int typePartner { get; set; }

        [Column(name: "phone", TypeName = "varchar(20)")]
        public string phone { get; set; }

        [Column(name: "address", TypeName = "varchar(200)")]
        public string address { get; set; }

        [Column(name: "discount", TypeName = "int")]
        public int discount { get; set; }
    }

    public class BusinessPartnersConfiguration : EntityTypeConfiguration<BusinessPartners>
    {
        public BusinessPartnersConfiguration()
        {
            this.ToTable("t_business_partners");
            this.HasKey(x => x.id);
            this.Property(x => x.fullName).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.email).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.phone).HasColumnType("varchar").HasMaxLength(20);
            this.Property(x => x.address).HasColumnType("varchar").HasMaxLength(200);
        }
    }
}
