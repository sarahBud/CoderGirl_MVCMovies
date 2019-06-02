using CoderGirl_MVCMovies.Data;
using CoderGirl_MVCMovies.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_MVCMovies.ViewModels.Movies
{
    public class MovieListItemViewModel
    {
        public static List<MovieListItemViewModel> GetMovieList()
        {
            return RepositoryFactory.GetMovieRepository()
                .GetModels()
                .Cast<Movie>()
                .Select(movie => GetMovieListItemFromMovie(movie))
                .ToList();
        }

        private static MovieListItemViewModel GetMovieListItemFromMovie(Movie movie)
        {
            return new MovieListItemViewModel
            {
                Name = movie.Name,
                DirectorId = movie.DirectorId,
                Year = movie.Year

            };
        }

        public string Name { get; set; }
        public int DirectorId { get; set; }
        public  List<Director> directors { get; set; }
        public int Year { get; set; }
    }
}
