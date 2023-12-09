using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Pharmacity_Management_System.Models
{
    public class DetailDeliveries
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [ForeignKey("Deliveries")]
        [Column("deliveryId", TypeName = "int")]
        public int deliveryId { get; set; }
        public Deliveries Deliveries { get; set; }

        [ForeignKey("Payments")]
        [Column("paymentId", TypeName = "int")]
        public int paymentId { get; set; }
        public Payments Payments { get; set; }

        [Column(name: "thDelivery", TypeName = "int")]
        public int thDelivery { get; set; }

        [Column(name: "status", TypeName = "bit")]
        public bool status { get; set; }

        [Column(name: "startDeliveryTime", TypeName = "DATETIME")]
        public DateTime startDeliveryTime { get; set; }

        [Column(name: "endDeliveryTime", TypeName = "DATETIME")]
        public DateTime endDeliveryTime { get; set; }

        [Column(name: "costDelivery", TypeName = "Money")]
        public decimal costDelivery { get; set; }

        [Column(name: "weight", TypeName = "varchar(50)")]
        public string weight { get; set; }

        [Column(name: "distance", TypeName = "varchar(50)")]
        public string distance { get; set; }

        [Column(name: "deliveryLocation", TypeName = "varchar(200)")]
        public string deliveryLocation { get; set; }

        [ForeignKey("TransportCompany")]
        [Column("transportId", TypeName = "int")]
        public int transportId { get; set; }
        public TransportCompany TransportCompany { get; set; }
    }

    public class DetailDeliveriesConfiguration : EntityTypeConfiguration<DetailDeliveries>
    {
        public DetailDeliveriesConfiguration()
        {
            this.ToTable("t_detail_deliveries");
            this.HasKey(x => x.id);
            this.Property(x => x.weight).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.distance).HasColumnType("varchar").HasMaxLength(50);
            this.Property(x => x.deliveryLocation).HasColumnType("varchar").HasMaxLength(200);
        }
    }
}
