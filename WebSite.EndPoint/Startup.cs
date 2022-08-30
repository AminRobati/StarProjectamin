

using Application.BasketsService;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Catalogs.CatalohItems.GetCatalogItemPDP;
using Application.Catalogs.CatalohItems.GetCatalogItemPLP;
using Application.Catalogs.CatalohItems.UriComposer;
using Application.Catalogs.GetMenuItem;
using Application.Commetns.Commands;
using Application.Discounts;
using Application.HomePageService;
using Application.Interfaces.Contexts;
using Application.Orders;
using Application.Orders.CustomerOrdersServices;
using Application.Payments;
using Application.Users;
using Application.Visitors.SaveVisitorInfo;
using Application.Visitors.VisitorOnline;
using Infrastructure.IdentityConfigs;
using Infrastructure.MappingProfile;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Contexts;
using Persistence.Contexts.MongoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Hubs;
using WebSite.EndPoint.Midlewares;
using WebSite.EndPoint.Utilities.Filters;
using WebSite.EndPoint.Utilities.Middlewares;

namespace WebSite.EndPoint
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddMediatR(typeof(SendCommentCommand).Assembly);


            #region  Connection String
            services.AddTransient<IDataBaseContext, DataBaseContext>();

            string connection = Configuration["ConnectionString:SqlServer"];
            services.AddDbContext<DataBaseContext>(option => option.UseSqlServer(connection));


            services.AddDistributedSqlServerCache(option =>
            {
                option.ConnectionString = connection;
                option.SchemaName = "dbo";
                option.TableName = "CacheData";
            });




            services.AddTransient<IIdentityDatabaseContext, IdentityDatabaseContext>();

            services.AddIdentityService(Configuration);
            services.AddAuthorization(); 
            services.ConfigureApplicationCookie(option =>
            {
                option.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                option.LoginPath = "/account/login";
                option.AccessDeniedPath = "/Account/AccessDenied";
                option.SlidingExpiration = true;
            });
            #endregion
            services.AddTransient(typeof(IMongoDbContext<>), typeof(MongoDbContext<>));
            services.AddTransient<ISaveVisitorInfoService, SaveVisitorInfoService>();
            services.AddTransient<IIVisitorOnlineService,   VisitorOnlineService>();
            services.AddTransient<IGetMenuItemService,  GetMenuItemService>();
            services.AddTransient<IGetCatalogItemPLPService, GetCatalogItemPLPService>();
            services.AddTransient<IUriComposerService, UriComposerService>();
            services.AddTransient<IGetCatalogItemPDPService, GetCatalogItemPDPService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddScoped<SaveVisitorFilter>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddTransient<IUserAddressService, UserAddressService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IDiscountService, DiscountService>();
            services.AddTransient<IDiscountHistoryService , DiscountHistoryService>();
            services.AddTransient<ICatalogItemService, CatalogItemService>();
            services.AddTransient<ICustomerOrdersService, CustomerOrdersService>(); 
            services.AddTransient<IHomePageService, HomePageService>();
            services.AddSignalR();

            //mapper
            services.AddAutoMapper(typeof(CatalogMappingProfile));
            services.AddAutoMapper(typeof(UserMappingProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCustomExceptionHandler();
            app.UseSetVisitorId();
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                  endpoints.MapControllerRoute(
                     name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHub<OnlineVisitorHub>("/chathub");
            });
        }
    }
}
