using Automation.DataAccess.Abstract;
using Automation.DataAccess.Context;
using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Automation.DataAccess.Concrete
{
    public class ProductDal : EfEntityRepositoryBase<Product, AutomationContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.Category.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 Brand = p.Brand,
                                 ProductImage = p.ProductImage,
                                 StockStatus = p.StockStatus,
                                 UnitInStock = p.UnitInStock,
                                 UnitPrice = p.UnitPrice,
                                 IsActive = p.IsActive
                             };
                return result.ToList();
            }
        }
        public ProductDetailDto GetProductDetailById(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (AutomationContext context = new AutomationContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.Category.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 Brand = p.Brand,
                                 ProductImage = p.ProductImage,
                                 StockStatus = p.StockStatus,
                                 UnitInStock = p.UnitInStock,
                                 UnitPrice = p.UnitPrice,
                                 IsActive = p.IsActive
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
