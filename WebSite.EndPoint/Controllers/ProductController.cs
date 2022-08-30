using Application.Catalogs.CatalohItems.GetCatalogItemPDP;
using Application.Catalogs.CatalohItems.GetCatalogItemPLP;
using Application.Commetns.Commands;
using Application.Commetns.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetCatalogItemPLPService getCatalogItemPLPService;
        private readonly IGetCatalogItemPDPService getCatalogItemPDPService;
        private readonly IMediator mediator;

        public ProductController(IGetCatalogItemPLPService getCatalogItemPLPService , 
            IGetCatalogItemPDPService getCatalogItemPDPService
            , IMediator mediator)
        {
            this.getCatalogItemPLPService = getCatalogItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
            this.mediator = mediator;
        }
        public IActionResult Index(CatlogPLPRequestDto catlogPLPRequestDto)
        {
            var data = getCatalogItemPLPService.Execute(catlogPLPRequestDto);
            return View(data);
        }

        public IActionResult Details(int Id)
        {
            var data = getCatalogItemPDPService.Execute(Id);
            return View(data);
        }

        //public IActionResult SendComment(CommentDto commentDto, int Id)
        //{
        //    SendCommentCommand sendComment = new SendCommentCommand(commentDto);
        //    var result = mediator.Send(sendComment).Result;
        //    return RedirectToAction(nameof(Details), new { Id = Id });

        //}
    }



}

