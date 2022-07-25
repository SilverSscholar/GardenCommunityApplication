using GardenCommunityApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GardenCommunityApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<GardeningClub> GardeningClubs { get; set; }
        public DbSet<GardenContest> GardenContests { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}