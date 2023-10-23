using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Located by a lake side.",
                    ImageUrl ="",
                    Occupancy=5,
                    Rate=200,
                    sqft=550,
                    Amenity="",
                    CreateDate=DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Vinyard Villa",
                    Details = "Five star experience is assured",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    sqft = 550,
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "City Villa",
                    Details = "Most recently built villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    sqft = 550,
                    Amenity = "",
                    CreateDate = DateTime.Now
                }
                );
        }
    }
}
