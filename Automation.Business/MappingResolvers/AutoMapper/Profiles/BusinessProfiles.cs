using AutoMapper;
using Automation.Entities.Concrete;
using Automation.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Business.MappingResolvers.AutoMapper.Profiles
{
    public class BusinessProfiles : Profile
    {
        public BusinessProfiles()
        {
            CreateMap<Product, ProductDetailDto>();
            CreateMap<ProductDetailDto, Product>();
        }
    }
}
