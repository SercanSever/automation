using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Automation.Business.Abstract
{
    public interface IProductManager
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        List<ProductDetailDto> GetProductDetails();
        ProductDetailDto GetProductDetailsById(int id);
    }
}
