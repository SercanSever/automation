using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Kategori Adı 50 Karakteri Geçemez")]
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
