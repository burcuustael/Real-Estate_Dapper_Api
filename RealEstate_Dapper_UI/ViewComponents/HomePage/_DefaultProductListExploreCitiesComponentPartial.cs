using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultProductListExploreCitiesComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
