﻿using Automation.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automation.Entities.Concrete
{
    public class Department : IEntity
    {
        [Key]
        public int DepartmentId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
