using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Example.Models
{
    public enum Rating
    {
        Horrible=1,
        [Display(Name = "Very Bad")]
        VeryBad,
        Bad,
        [Display(Name = "Worse Than Average")]
        WorseThanAverage,
        Average,
        [Display(Name = "Better Than Average")]
        BetterThanAverage,
        Good,
        [Display(Name = "Very Good")]
        VeryGood,
        Amazing,
        Masterpiece
    }
}
