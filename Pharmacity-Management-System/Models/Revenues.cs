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
    public class Revenues
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "Month", TypeName = "DATETIME")]
        public DateTime Month { get; set; } = DateTime.Now;

        [Column(name: "totalIncome", TypeName = "Money")]
        public decimal totalIncome { get; set; }

        [Column(name: "totalExpense", TypeName = "Money")]
        public decimal totalExpense { get; set; }

        [Column(name: "profit", TypeName = "Money")]
        public decimal profit { get; set; }
    }

    public class RevenuesConfiguration : EntityTypeConfiguration<Revenues>
    {
        public RevenuesConfiguration()
        {
            this.ToTable("t_revenues");
            this.HasKey(x => x.id);
        }
    }
}
