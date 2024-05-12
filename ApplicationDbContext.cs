using Microsoft.EntityFrameworkCore;
using oop3.Models;


namespace oop3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           // Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        public DbSet<Film> Films { get; set; } 
        public DbSet<Year> Year { get; set; } 
        public DbSet<Genre> Genre { get; set; } 
        public DbSet<Producer> Producer { get; set; } 
        public DbSet<oop3.Models.Film> Film { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Year>().ToTable("Year");
        //    modelBuilder.Entity<Film>().ToTable("Films");
        //    modelBuilder.Entity<Genre>().ToTable("Genre");
        //    //modelBuilder.Entity<Producer>().ToTable("Producers");
        //}
        //public DbSet<oop3.Models.Genre> Genre { get; set; } = default!;
    }
}
