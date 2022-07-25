using GardenCommunityApplication.Models;

namespace GardenCommunityApplication.Interfaces
{
    public interface IGardenContestRepository
    {
        Task<IEnumerable<GardenContest>> GetAll();

        Task<GardenContest> GetByIdAsync(int id);
        Task<IEnumerable<GardenContest>> GetGardenContestByCity(string city);
        bool Add(GardenContest gardenContest);
        bool Update(GardenContest gardenContest);
        bool Delete(GardenContest gardenContest);
        bool Save();
    }
}
