using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Employee : IEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string EmployeeSurname { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string EmployeePhone { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(200)]
        public string EmployeeImage { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(200)]
        public string EmployeeAdress { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(200)]
        public string EmployeeEmail { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
