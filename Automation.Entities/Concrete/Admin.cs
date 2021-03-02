using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Admin : IEntity
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string AdminName { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string AdminPassword { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string AdminAuth { get; set; }
    }
}
