using Automation.Core.Entities;
using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Invoice : IEntity
    {
        [Key]
        public int InvoiceId { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string InvoiceSerial { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string InvoiceOrder { get; set; }
        public DateTime InvoiceDate { get; set; }
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string InvoiceHour { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string InvoiceDeliverer { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string InvoiceReceiver { get; set; }
        public bool IsActive { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
