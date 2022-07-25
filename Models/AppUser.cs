using System.ComponentModel.DataAnnotations;

namespace GardenCommunityApplication.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public int? Flowers { get; set; }
        public int? Veggies { get; set; }
        public Address? Address { get; set; }
    }
}
