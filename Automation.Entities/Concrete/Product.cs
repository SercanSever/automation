using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Ürün adı boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Ürün adı 50 Karakteri Geçemez")]
        public string ProductName { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Ürün stok adedi boş bırakılamaz.")]
        public int UnitInStock { get; set; }
        [Required(ErrorMessage = "Ürün fiyatı boş bırakılamaz.")]
        public decimal UnitPrice { get; set; }
        public string ProductImage { get; set; }
        public bool StockStatus { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
