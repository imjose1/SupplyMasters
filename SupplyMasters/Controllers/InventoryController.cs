using Microsoft.AspNetCore.Mvc;

namespace SupplyMasters.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
