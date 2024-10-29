using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstBasic.Models;
using System.Collections.Generic;

namespace Pratik_CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-MQI8H1N\SQLEXPRESS;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
            }
        }
    }
}
