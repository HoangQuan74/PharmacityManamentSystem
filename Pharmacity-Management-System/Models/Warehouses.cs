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
    public class Warehouses
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(name: "address", TypeName = "varchar(200)")]
        public string address { get; set; }


        [ForeignKey("StorageRequirements")]
        [Column("storeReqId", TypeName = "int")]
        public int storeReqId { get; set; }
        public StorageRequirements StorageRequirements { get; set; }
    }

    public class WarehousesConfiguration : EntityTypeConfiguration<Warehouses>
    {
        public WarehousesConfiguration()
        {
            this.ToTable("m_warehouses");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.address).HasColumnType("varchar").HasMaxLength(200);
        }
    }
}
