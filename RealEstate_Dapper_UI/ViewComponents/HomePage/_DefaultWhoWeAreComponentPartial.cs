using Microsoft.AspNetCore.Mvc;


namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial : ViewComponent
    {
            
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View();
        }
    }
}
