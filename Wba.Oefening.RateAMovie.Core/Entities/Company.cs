using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Company
    {
        public long Id { get; set; }

        public string Name { get; set; }
        //Many Movies
        public ICollection<Movie> Movies { get; set; }
    }
}
