using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SongsListTutorial.Models {
    public class Song {
        public int SongId { get; set; }
        
        [Required(ErrorMessage = "Please enter a song name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1900, 2021, ErrorMessage = "Year must be bewteen 1900 and 2021.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "The rating range must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage ="Please enter a genre.")]
        public string GenreID { get; set; } //foreign key to Genre model
        public Genre Genre { get; set; }
    }
}
