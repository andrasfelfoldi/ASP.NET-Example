using ASP.NET_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Example.Services
{
    interface IMovieDbService
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        Movie AddMovie(Movie movie);
        Movie EditMovie(Movie movie);
        Movie DeleteMovie(int id);
    }
}
