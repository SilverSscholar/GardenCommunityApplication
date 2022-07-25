using GardenCommunityApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardenContestController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GardenContestController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var gardeningcontest = _context.GardenContests.ToList();
            return View(gardeningcontest);
        }
    }
}
