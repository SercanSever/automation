using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Müşteri adı boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Müşteri Adı 50 Karakteri Geçemez")]
        public string CustomerName { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Müşteri soyadı boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Müşteri soyadı 50 Karakteri Geçemez")]
        public string CustomerSurname { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(20)]
        [Required(ErrorMessage = "Müşteri şehri boş bırakılamaz.")]
        [MaxLength(20, ErrorMessage = "Müşteri şehri 20 Karakteri Geçemez")]
        public string CustomerCity { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Müşteri maili boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Müşteri maili 50 Karakteri Geçemez")]
        public string CustomerEmail { get; set; }
        public DateTime DateOfRegister { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
