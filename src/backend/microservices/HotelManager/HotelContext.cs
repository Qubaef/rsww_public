using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Shared.Config;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;

namespace HotelManager
{
    public class HotelContext : DbContext
    {
        public DbSet<HotelStaticData> Hotels { get; set; }
        public DbSet<RoomReservation> RoomReservation { get; set; }
        
        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelStaticData>().ToTable("Hotels");
            modelBuilder.Entity<RoomReservation>().ToTable("RoomReservation");
            base.OnModelCreating(modelBuilder);
        }
    }
}