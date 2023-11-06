using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Rating
    {
        public long Id { get; set; }

        public byte Score { get; set; }

        public string Review { get; set; }
        //one user
        public User User { get; set; }
        //unshadowed foreign key
        public long UserId { get; set; }
        //one Movie
        public Movie Movie { get; set; }
        //unshadowed MovieId
        public long MovieId { get; set; }
    }
}
