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
    public class Bills
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "typeBill", TypeName = "int")]
        public int typeBill { get; set; }

        [Column(name: "paymentDeadline", TypeName = "DATETIME")]
        public DateTime? paymentDeadline { get; set; }

        [Column(name: "status", TypeName = "bit")]
        public bool status { get; set; }

        [Column(name: "numberOfPayments", TypeName = "int")]
        public int numberOfPayments { get; set; }

        [Column(name: "totalAmount", TypeName = "Money")]
        public decimal totalAmount { get; set; }

        [Column(name: "owed", TypeName = "Money")]
        public decimal owed { get; set; }

        [Column(name: "totalDiscount", TypeName = "int")]
        public int totalDiscount { get; set; }

        [Column(name: "deposit", TypeName = "Money")]
        public decimal deposit { get; set; }

        [ForeignKey("Users")]
        [Column("userId", TypeName = "int")]
        public int userId { get; set; }
        public Users Users { get; set; }

        [ForeignKey("BusinessPartners")]
        [Column("partnerId", TypeName = "int")]
        public int partnerId { get; set; }
        public BusinessPartners BusinessPartners { get; set; }
    }

    public class BillsConfiguration : EntityTypeConfiguration<Bills>
    {
        public BillsConfiguration()
        {
            this.ToTable("t_bills");
            this.HasKey(x => x.id);
        }
    }
}
