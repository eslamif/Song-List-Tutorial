using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsListTutorial.Models {
    public class SongContext : DbContext {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public SongContext(DbContextOptions<SongContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = "M", Name = "Metal" },
                new Genre { GenreID = "R", Name = "Rap" },
                new Genre { GenreID = "H", Name = "Hi Hop" },
                new Genre { GenreID = "RC", Name = "Rock" }
            );

            modelBuilder.Entity<Song>().HasData(
                new Song {
                    SongId = 1,
                    Name = "Master of Puppets",
                    Year = 1980,
                    Rating = 5,
                    GenreID = "M"
                },
                new Song {
                    SongId = 2,
                    Name = "Wonderwall",
                    Year = 1990,
                    Rating = 4,
                    GenreID = "RC"

                },
                new Song {
                    SongId = 3,
                    Name = "Lose Yourself",
                    Year = 2005,
                    Rating = 1,
                    GenreID = "R"
                }
            );
        }
    }
}
