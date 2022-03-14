using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.admin.Controllers
{
    [Area(nameof(admin))]
    public class DashboardController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
