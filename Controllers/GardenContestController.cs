using GardenCommunityApplication.Data;
using GardenCommunityApplication.Models;
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
            List<GardenContest> gardencontests = _context.GardenContests.ToList();
            return View(gardencontests);
        }
    }
}
