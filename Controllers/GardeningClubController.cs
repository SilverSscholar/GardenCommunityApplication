using GardenCommunityApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardeningClubController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GardeningClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var gardeningclub = _context.GardeningClubs.ToList();
            return View(gardeningclub);
        }
    }
}
