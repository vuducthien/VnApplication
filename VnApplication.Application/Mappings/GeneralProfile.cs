using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VnApplication.Application.Features.Products.Commands.CreateProduct;
using VnApplication.Application.Features.Products.Queries.GetAllProducts;
using VnApplication.Domain.Entities;

namespace VnApplication.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
