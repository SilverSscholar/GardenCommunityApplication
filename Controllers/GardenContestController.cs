using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardenContestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
