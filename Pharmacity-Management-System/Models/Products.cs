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
    public class Products : BaseModel
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(name: "productType", TypeName = "int")]
        public int productType { get; set; }

        [Column("productForm", TypeName = "varchar(100)")]
        public string productForm { get; set; }

        [Column("uses", TypeName = "varchar(500)")]
        public string uses { get; set; }

        [Column("ingredient", TypeName = "varchar(200)")]
        public string ingredient { get; set; }

        [Column("specificGravity", TypeName = "int")]
        public int? specificGravity { get; set; }

        [Column("price", TypeName = "money")]
        public decimal price { get; set; }

        [ForeignKey("StorageRequirements")]
        [Column("storeReqId", TypeName = "int")]
        public int storeReqId { get; set; }
        public StorageRequirements StorageRequirements { get; set; }

        [ForeignKey("Units")]
        [Column("unitId", TypeName = "int")]
        public int unitId { get; set; }
        public Units Units { get; set; }
    }

    public class ProductsConfiguration : EntityTypeConfiguration<Products>
    {
        public ProductsConfiguration()
        {
            this.ToTable("t_products");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.productForm).HasColumnType("varchar").HasMaxLength(100);
            this.Property(x => x.uses).HasColumnType("varchar").HasMaxLength(500);
            this.Property(x => x.ingredient).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
