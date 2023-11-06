using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Movie
    {
        //[Key]
        public long Id { get; set; }

        //[Required]
        //[MaxLength(200)]
        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }
        //many ratings
        public ICollection<Rating> Ratings { get; set; }
        //one company
        public Company Company { get; set; }
        //unshadowed foreign key
        public long CompanyId { get; set; }
        //has many directors
        public ICollection<Director> Directors { get; set; }
        //actors
        public ICollection<MovieActor> Actors { get; set; }
    }
}
