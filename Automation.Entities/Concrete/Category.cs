using Automation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
