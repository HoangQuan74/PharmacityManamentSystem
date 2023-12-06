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
    public class Units : BaseModel
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }
    }

    public class UnitsConfiguration : EntityTypeConfiguration<Units>
    {
        public UnitsConfiguration()
        {
            this.ToTable("m_units");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
