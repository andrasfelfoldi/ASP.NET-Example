using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Example.Data;
using ASP.NET_Example.Models;

namespace ASP.NET_Example.Services
{
    public class MovieDbService : IMovieDbService
    {
        private MovieDbContext _context;

        public MovieDbService(MovieDbContext context)
        {
            _context = context;
        }

        public Movie AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public Movie DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Movie EditMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(movie => movie.Title);
        }
    }
}
