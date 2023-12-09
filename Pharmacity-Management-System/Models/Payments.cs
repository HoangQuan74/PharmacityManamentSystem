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
using System.Reflection.Emit;

namespace Pharmacity_Management_System.Models
{
    public class Payments
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }
        
        [Column(name: "paymentNumber", TypeName = "int")]
        public int paymentNumber { get; set; }

        [Column(name: "paymentDate", TypeName = "DATETIME")]
        public DateTime paymentDate { get; set; }

        [Column(name: "paymentAmout", TypeName = "Money")]
        public decimal paymentAmout { get; set; }

        [ForeignKey("Bills")]
        [Column("billId", TypeName = "int")]
        public int billId { get; set; }
        public Bills Bills { get; set; }
    }

    public class PaymentsConfiguration : EntityTypeConfiguration<Payments>
    {
        public PaymentsConfiguration()
        {
            this.ToTable("t_payments");
            this.HasKey(x => x.id);
            this.HasRequired(p => p.Bills)
                .WithMany()
                .HasForeignKey(p => p.billId)
                .WillCascadeOnDelete(false);
        }
    }
}
