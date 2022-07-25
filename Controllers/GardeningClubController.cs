using GardenCommunityApplication.Data;
using GardenCommunityApplication.Models;
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
            List <GardeningClub> gardeningClubs = _context.GardeningClubs.ToList();
            return View(gardeningClubs);
        }
    }
}
