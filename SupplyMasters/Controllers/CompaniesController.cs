using Microsoft.AspNetCore.Mvc;

namespace SupplyMasters.Controllers
{
    public class CompaniesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
