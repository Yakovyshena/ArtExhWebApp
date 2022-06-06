using Microsoft.EntityFrameworkCore;
using ArtExhWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ArtExhWebApp.Models
{
    public class ExhibitionContext : DbContext
    {
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Exhibition> Exhibitions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
        public virtual DbSet<Painting> Paintings { get; set; }
        public virtual DbSet<ArtExhibition> ArtExhibitions { get; set; }

        public ExhibitionContext(DbContextOptions<ExhibitionContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
