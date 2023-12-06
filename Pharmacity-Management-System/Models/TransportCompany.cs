using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacity_Management_System.Models
{
    public class TransportCompany
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(name: "distanceCost", TypeName = "Money")]
        public decimal distanceCost { get; set; }

        [Column(name: "weightCost", TypeName = "Money")]
        public decimal weightCost { get; set; }

        [Column(name: "discount", TypeName = "int")]
        public int discount { get; set; }
    }

    public class TransportCompanyConfiguration : EntityTypeConfiguration<TransportCompany>
    {
        public TransportCompanyConfiguration()
        {
            this.ToTable("m_transport_company");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
