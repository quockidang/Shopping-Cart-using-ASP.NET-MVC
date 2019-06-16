using AutoMapper;
using MyShop.Model.Models;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<ProductCategory, ProductCategoryViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<ProductTag, ProductTagViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<Tag, TagViewModel>());
        }
    }
}