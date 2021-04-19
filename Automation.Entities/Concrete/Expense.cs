using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Expense : IEntity
    {
        [Key]
        public int ExpenseId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(300)]
        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "Açıklama 300 Karakteri Geçemez")]
        public string ExpenseDescription { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal ExpenseTotal { get; set; }
    }
}
