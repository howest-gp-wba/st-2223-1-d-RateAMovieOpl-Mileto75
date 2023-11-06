using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Actor
    {
        public long Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public ICollection<MovieActor> Movies { get; set; }
    }
}
