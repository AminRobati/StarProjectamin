using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalohItems.AddNewCatalogItem;
using Application.Catalogs.GetMenuItem;
using AutoMapper;
using Domain.Catalogs;
using System.Linq;

namespace Infrastructure.MappingProfile
{
    public class CatalogMappingProfile : Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<CatalogType, CatalogTypeDto>().ReverseMap();

            CreateMap<CatalogType, CatalogTypeListDto>()
                .ForMember(dest => dest.SubTypeCount, option =>
                 option.MapFrom(src => src.SubType.Count));

            CreateMap<CatalogType, MenuItemDto>()
                .ForMember(dest => dest.Name, opt =>
                 opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.ParentId, opt =>
                 opt.MapFrom(src => src.ParentCatalogTypeId))
                .ForMember(dest => dest.SubMenu, opt =>
                opt.MapFrom(src => src.SubType));
            //----------------------
            // پروفایل مپ افزودن مورد جدید

            CreateMap<AddNewCatalogItemFeature_dto, CatalogItemFeature>();
            //CreateMap<CatalogItemFeature, AddNewCatalogItemFeature_dto>();
            
            CreateMap<AddNewCatalogItemImage_Dto, CatalogItemImage>();
            //CreateMap<CatalogItemImage, AddNewCatalogItemImage_Dto>();

            CreateMap<AddNewCatalogItemDto, CatalogItem>()
                .ForMember(dest => dest.CatalogItemFeatures, opt =>
                opt.MapFrom(src => src.Features))
                 .ForMember(dest => dest.CatalogItemImages, opt =>
                 opt.MapFrom(src => src.Images));

            //-------------------
            CreateMap<CatalogBrand, CatalogBrandDto>().ReverseMap();
            CreateMap<CatalogType, CatalogTypeDto>().ReverseMap();
        }
    }
}
