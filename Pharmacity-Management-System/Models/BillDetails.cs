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
    public class BillDetails
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [ForeignKey("Products")]
        [Column("productId", TypeName = "int")]
        public int productId { get; set; }
        public Products Products { get; set; }

        [Column(name: "quantity", TypeName = "int")]
        public int quantity { get; set; }

        [ForeignKey("Bills")]
        [Column("billId", TypeName = "int")]
        public int billId { get; set; }
        public Bills Bills { get; set; }
    }

    public class BillDetailsConfiguration : EntityTypeConfiguration<BillDetails>
    {
        public BillDetailsConfiguration()
        {
            this.ToTable("t_bill_details");
            this.HasKey(x => x.id);
        }
    }
}
