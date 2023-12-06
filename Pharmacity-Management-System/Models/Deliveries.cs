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
    public class Deliveries : BaseModel
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [ForeignKey("Bills")]
        [Column("billId", TypeName = "int")]
        public int billId { get; set; }
        public Bills Bills { get; set; }

        [Column(name: "numberOfDeliveries", TypeName = "int")]
        public int numberOfDeliveries { get; set; }

        [Column(name: "status", TypeName = "bit")]
        public bool status { get; set; }

        [Column(name: "totalCost", TypeName = "Money")]
        public decimal cost { get; set; }
    }

    public class DeliveriesConfiguration : EntityTypeConfiguration<Deliveries>
    {
        public DeliveriesConfiguration()
        {
            this.ToTable("t_deliveries");
            this.HasKey(x => x.id);
        }
    }
}
