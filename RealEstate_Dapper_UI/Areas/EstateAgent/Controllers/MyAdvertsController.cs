using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class MyAdvertsController : Controller
    {
        // GET: MyAdvertsController
        public ActionResult Index()
        {
            return View();
        }

    }
}