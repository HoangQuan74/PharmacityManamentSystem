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
    public class StorageRequirements : BaseModel
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(name: "maxTemperature", TypeName = "int")]
        public int? maxTemperature { get; set; }

        [Column(name: "minTemperature", TypeName = "int")]
        public int? minTemperature { get; set; }

        [Column(name: "maxHumidity", TypeName = "int")]
        public int? maxHumidity { get; set; }

        [Column(name: "minHumidity", TypeName = "int")]
        public int? minHumidity { get; set; }
    }

    public class StorageRequirementsConfiguration : EntityTypeConfiguration<StorageRequirements>
    {
        public StorageRequirementsConfiguration()
        {
            this.ToTable("m_storage_requirements");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
