using GardenCommunityApplication.Data;
using GardenCommunityApplication.Interfaces;
using GardenCommunityApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace GardenCommunityApplication.Repository
{
    public class GardenContestRepository : IGardenContestRepository
    {
        private readonly ApplicationDbContext _context;
        public GardenContestRepository(ApplicationDbContext context)
        {
          _context = context;
        }
        public bool Add(GardenContest gardenContest)
        {
            _context.Add(gardenContest);
            return Save();
        }

        public bool Delete(GardenContest gardenContest)
        {
            _context.Remove(gardenContest);
            return Save();
        }

        public async Task<IEnumerable<GardenContest>> GetAll()
        {
            return await _context.GardenContests.ToListAsync();
        }

        public async Task<GardenContest> GetByIdAsync(int id)
        {
            return await _context.GardenContests.Include(i => i.Address).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<GardenContest>> GetGardenContestByCity(string city)
        {
        return await _context.GardenContests.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(GardenContest gardenContest)
        {
            _context.Update(gardenContest);
            return Save();
        }
    }
}

