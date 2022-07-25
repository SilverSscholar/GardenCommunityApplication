using GardenCommunityApplication.Data;
using GardenCommunityApplication.Interfaces;
using GardenCommunityApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GardenCommunityApplication.Controllers
{
    public class GardenContestController : Controller
    {
        
        private readonly IGardenContestRepository _gardenContestRepository;
        public GardenContestController( IGardenContestRepository gardenContestRepository)
        {
            
            _gardenContestRepository = gardenContestRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<GardenContest> gardencontests = await _gardenContestRepository.GetAll();
            return View(gardencontests);
        }
        public async Task<IActionResult> Detail(int id)
        {
            GardenContest gardenContest = await _gardenContestRepository.GetByIdAsync(id);
            return View(gardenContest);
        }
    }
}
