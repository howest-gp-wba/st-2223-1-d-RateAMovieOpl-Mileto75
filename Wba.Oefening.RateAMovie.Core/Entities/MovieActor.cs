using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class MovieActor
    {
        public Actor Actor { get; set; }
        public long ActorId { get; set; }
        public Movie Movie { get; set; }
        public long MovieId { get; set; }
        public string Role { get; set; }
    }
}
