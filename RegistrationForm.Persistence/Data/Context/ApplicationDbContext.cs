using Microsoft.EntityFrameworkCore;
using RegistrationForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Persistence.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder
        //        .Entity<Address>()
        //        .HasOne<User>(p => p.User)
        //        .WithMany(s => s.Addresses)
        //        .HasForeignKey(x=>x.UserId);

        //    base.OnModelCreating(builder);
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<GovernateUserCount> GovernateUserCounts { get; set; }
        
    }
}
