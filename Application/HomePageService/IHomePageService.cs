﻿using Application.Catalogs.CatalohItems.GetCatalogItemPLP;
using Application.Catalogs.CatalohItems.UriComposer;
using Application.Interfaces.Contexts;
using Domain.Banners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HomePageService
{
    public interface IHomePageService
    {
        HomePageDto GetData();
    }

    public class HomePageService : IHomePageService
    {
        private readonly IDataBaseContext context;
        private readonly IUriComposerService uriComposerService;
        private readonly IGetCatalogItemPLPService getCatalogItemPLPService;

        

        public HomePageService(IDataBaseContext context
            , IUriComposerService uriComposerService
            , IGetCatalogItemPLPService getCatalogItemPLPService )
        {
            this.context = context;
            this.uriComposerService = uriComposerService;
            this.getCatalogItemPLPService = getCatalogItemPLPService;
        }


        public HomePageDto GetData()
        {
            var banners = context.Banners.Where(p => p.IsActive == true)
                .OrderBy(p => p.Priority)
                .ThenByDescending(p => p.Id)
                .Select(p => new BannerDto
                {
                    Id = p.Id,
                    Image = uriComposerService.ComposeImageUri(p.Image),
                    Link = p.Link,
                    Position = p.Position,
                }).ToList();

            var Bestselling = getCatalogItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.Bestselling
            }).Data.ToList();

            var MostPopular = getCatalogItemPLPService.Execute(new CatlogPLPRequestDto
            {
                AvailableStock = true,
                page = 1,
                pageSize = 20,
                SortType = SortType.MostPopular
            }).Data.ToList();

            return new HomePageDto
            {
                Banners = banners,
                bestSellers = Bestselling,
                MostPopular = MostPopular,
            };
        }
    }

    public class HomePageDto
    {
        public List<BannerDto> Banners { get; set; }
        public List<CatalogPLPDto> MostPopular { get; set; }
        public List<CatalogPLPDto> bestSellers { get; set; }


    }

    public class BannerDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public Position Position { get; set; }
    }
}
