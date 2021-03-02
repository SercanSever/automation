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
        public string CustomerName { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string CustomerSurname { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(20)]
        public string CustomerCity { get; set; }
        [Column(TypeName = "NVarChar")]
        [StringLength(50)]
        public string CustomerEmail { get; set; }
        public bool IsActive { get; set; }
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
