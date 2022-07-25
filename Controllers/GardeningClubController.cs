using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardeningClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
