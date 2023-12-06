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
    public class UsageByAnimal : BaseModel
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }


        [ForeignKey("Products")]
        [Column("productId", TypeName = "int")]
        public int productId { get; set; }
        public Products Products { get; set; }


        [ForeignKey("Animals")]
        [Column("animalId", TypeName = "int")]
        public int animalId { get; set; }
        public Animals Animals { get; set; }
    }

    public class UsageByAnimalConfiguration : EntityTypeConfiguration<UsageByAnimal>
    {
        public UsageByAnimalConfiguration()
        {
            this.ToTable("t_usage_by_animal");
            this.HasKey(x => x.id);
        }
    }
}
