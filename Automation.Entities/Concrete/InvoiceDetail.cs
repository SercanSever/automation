using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class InvoiceDetail : IEntity
    {
        [Key]
        public int InvoiceContentId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(300)]
        public string InvoiceContentDescription { get; set; }
        public int InvoiceContentQuantity { get; set; }
        public int InvoiceContentUnitPrice { get; set; }
        public decimal InvoiceContentTotal { get; set; }
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

    }
}
