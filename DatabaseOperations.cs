using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2001MicroService;
using Microsoft.EntityFrameworkCore;


namespace _2001MicroService
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>()
                .HasOne(u => u.Activity)
                .WithMany(a => a.Users)
                .HasForeignKey(u => u.ActivityID);
        }
    }
}
