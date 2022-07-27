using GardenCommunityApplication.Data;
using GardenCommunityApplication.Interfaces;
using GardenCommunityApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardeningClubController : Controller
    {

        private readonly IGardeningClubRepository _gardeningClubRepository;


        public GardeningClubController(IGardeningClubRepository gardeningClubRepository)
        {
            _gardeningClubRepository = gardeningClubRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<GardeningClub> gardeningClubs = await _gardeningClubRepository.GetAll();
            return View(gardeningClubs);
        }
        public async Task<IActionResult> Detail(int id)
        {
            GardeningClub gardeningClub = await _gardeningClubRepository.GetByIdAsync(id);
            return View(gardeningClub);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GardeningClub gardeningclub)
        {
            if (!ModelState.IsValid)
            {
                return View(gardeningclub);
            }
            _gardeningClubRepository.Add(gardeningclub);
            return RedirectToAction("Index");
        }
       


    }

}
