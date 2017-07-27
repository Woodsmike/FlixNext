using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlixNext.Models
{
    public class MovieList
    {
        [Key]
        public int MovieListID { get; set; }
        public string ListName { get; set; }
        public DateTime UpdateDate { get; set; }

        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        [ForeignKey("RentedMovie")]
        public int RentedMovieID { get; set; }
        public virtual ICollection<RentedMovie> RentedMovies { get; set; }

        [ForeignKey("BoughtMovie")]
        public int BoughtMovieID { get; set; }
        public virtual ICollection<BoughtMovie> BoughtMovies { get; set; }
    }
}