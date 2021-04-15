using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Entities.Concrete
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string RoleName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
