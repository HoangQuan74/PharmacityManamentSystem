using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacity_Management_System.Models
{
    public abstract class BaseModel
    {
        [Column(name: "createdAt", TypeName = "DATETIME")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(name: "updatedAt", TypeName = "DATETIME")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Column(name: "isDeleted", TypeName = "int")]
        public int? IsDeleted { get; set; } = 0;
    }
}
