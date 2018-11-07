using ASP.NET_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Example.ViewModels
{
    public class IndexModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
