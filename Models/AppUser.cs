using System.ComponentModel.DataAnnotations;

namespace GardenCommunityApplication.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public int? Flowers { get; set; }
        public int? Veggies { get; set; }
        public Address? Address { get; set; }
        public ICollection<GardeningClub> GardeningClubs { get; set; }
        public ICollection<GardenContest> GardenContests { get; set; }
    }
}
