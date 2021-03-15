using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Entities.Concrete
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="NVarChar")]
        [StringLength(500)]
        public string Content { get; set; }
        public bool Status { get; set; }

    }
}
