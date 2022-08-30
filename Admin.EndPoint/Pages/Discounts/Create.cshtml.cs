using Admin.EndPoint.Binders;
using Application.Discounts.AddNewDiscountServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Application.Discounts.AddNewDiscountServices.AddNewDiscountService;

namespace Admin.EndPoint.Pages.Discounts
{
    public class CreateModel : PageModel
    {
        private readonly IAddNewDiscountService addNewDiscountService;

        public CreateModel(IAddNewDiscountService addNewDiscountService)
        {
            this.addNewDiscountService = addNewDiscountService;
        }

        [ModelBinder(BinderType = typeof(DiscountEntityBinder))]
        [BindProperty]
        public AddNewDiscountDto model { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            addNewDiscountService.Execute(model);
        }
    }
}
