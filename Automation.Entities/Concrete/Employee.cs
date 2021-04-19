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
        [Required(ErrorMessage = "Personel adı boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Personel Adı 50 Karakteri Geçemez")]
        public string EmployeeName { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Personel soyadı boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Personel soydı 50 Karakteri Geçemez")]
        public string EmployeeSurname { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Personel telefonu boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Personel telefonu 50 Karakteri Geçemez")]
        public string EmployeePhone { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(200)]
        public string EmployeeImage { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(200)]
        [Required(ErrorMessage = "Personel adresi boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Personel adresi 50 Karakteri Geçemez")]
        public string EmployeeAdress { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(200)]
        [Required(ErrorMessage = "Personel maili boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Personel maili 50 Karakteri Geçemez")]
        public string EmployeeEmail { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
        [Required]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
