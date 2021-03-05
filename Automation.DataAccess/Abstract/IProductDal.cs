using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Automation.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetail(Expression<Func<ProductDetailDto, bool>> filter = null);
        ProductDetailDto GetProductDetailById(Expression<Func<ProductDetailDto, bool>> filter = null);
    }
}
