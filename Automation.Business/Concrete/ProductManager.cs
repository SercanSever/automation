using Automation.Business.Abstract;
using Automation.DataAccess.Abstract;
using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Automation.Business.Concrete
{
    public class ProductManager : IProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            CheckStockStatus(product);
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(x => x.ProductId == id);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetail();
        }

        public void Update(Product product)
        {
            CheckStockStatus(product);
            _productDal.Update(product);
        }

        private void CheckStockStatus(Product product)
        {
            if (product.UnitInStock <= 2)
            {
                product.StockStatus = false;
            }
            else
            {
                product.StockStatus = true;
            }
        }
    }
}
