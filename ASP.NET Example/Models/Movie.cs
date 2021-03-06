﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Example.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public String Title { get; set; }
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
        public Rating Rating { get; set; }
    }
}
