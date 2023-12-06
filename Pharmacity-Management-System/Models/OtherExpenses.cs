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
    public class OtherExpenses
    {
        [Key]
        [Column(name: "id", TypeName = "int")]
        public int id { get; set; }

        [Column(name: "name", TypeName = "varchar(100)")]
        public string name { get; set; }

        [Column(name: "amount", TypeName = "Money")]
        public decimal amount { get; set; }

        [Column(name: "expenseDate", TypeName = "DATETIME")]
        public DateTime expenseDate { get; set; }
    }

    public class OtherExpensesConfiguration : EntityTypeConfiguration<OtherExpenses>
    {
        public OtherExpensesConfiguration()
        {
            this.ToTable("t_other_expenses");
            this.HasKey(x => x.id);
            this.Property(x => x.name).HasColumnType("varchar").HasMaxLength(100);

        }
    }
}
