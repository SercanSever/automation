using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using Core.DataAccess;
using System.Collections.Generic;

namespace Automation.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetail();
    }
}
