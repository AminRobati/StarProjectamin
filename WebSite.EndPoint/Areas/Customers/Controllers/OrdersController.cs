﻿using Application.Orders.CustomerOrdersServices;
using Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.EndPoint.Areas.Customers.Controllers
{
    [Authorize]
    [Area("Customers")]
    public class OrdersController : Controller
    {
        private readonly ICustomerOrdersService customerOrdersService;
        private readonly UserManager<User> userManager;

        public OrdersController(ICustomerOrdersService customerOrdersService
            , UserManager<User> userManager)
        {
            this.customerOrdersService = customerOrdersService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var user = userManager.GetUserAsync(User).Result;
            var orders = customerOrdersService.GetMyOrder(user.Id);
            return View(orders);
        }
    }
}
