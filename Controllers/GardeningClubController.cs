using GardenCommunityApplication.Data;
using GardenCommunityApplication.Interfaces;
using GardenCommunityApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardeningClubController : Controller
    {
        
        private readonly IGardeningClubRepository _gardeningClubRepository;
        public GardeningClubController( IGardeningClubRepository gardeningClubRepository)
        {
            _gardeningClubRepository = gardeningClubRepository;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<GardeningClub> gardeningClub = await _gardeningClubRepository.GetAll();
            return View(gardeningClub);
        }
        public async Task<IActionResult> Detail(int id)
        {
            GardeningClub gardeningClub = await _gardeningClubRepository.GetByIdAsync(id);
            return View(gardeningClub);
        }
    }
}
