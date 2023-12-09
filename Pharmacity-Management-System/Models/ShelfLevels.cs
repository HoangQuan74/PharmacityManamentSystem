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
    public class ShelfLevels
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(name: "volume", TypeName = "int")]
        public int volume { get; set; }

        [Column(name: "status", TypeName = "bit")]
        public bool status { get; set; }

        [ForeignKey("Shelfs")]
        [Column("shelfId", TypeName = "int")]
        public int shelfId { get; set; }
        public Shelfs Shelfs { get; set; }
    }

    public class ShelfLevelsConfiguration : EntityTypeConfiguration<ShelfLevels>
    {
        public ShelfLevelsConfiguration()
        {
            this.ToTable("m_shelf_levels");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
