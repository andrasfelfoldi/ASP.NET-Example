using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Example.Models
{
    public class Movie
    {
        [Required, MinLength(1), MaxLength(50)]
        public String Title { get; set; }
        public String ReleaseYear { get; set; }
        public Rating Rating { get; set; }
    }
}
