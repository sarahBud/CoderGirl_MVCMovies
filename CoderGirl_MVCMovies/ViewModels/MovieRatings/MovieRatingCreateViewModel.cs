using CoderGirl_MVCMovies.Data;
using CoderGirl_MVCMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.ViewModels.MovieRatings
{
    public class MovieRatingCreateViewModel
    {
        private List<MovieRating> movieRating;

        public MovieRatingCreateViewModel(List<MovieRating> movieRating)
        {
            this.movieRating = movieRating;
        }

        public static MovieRatingCreateViewModel GetMovieRatingCreateViewModel()
        {
            List<MovieRating> movieRating = RepositoryFactory.GetMovieRatingRepository()
                .GetModels()
                .Cast<MovieRating>()
                .ToList();
            return new MovieRatingCreateViewModel(movieRating);
        }

        public int Id { get; set; }
        public string MovieName { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; }

        public void Persist()
        {
            MovieRating movieRating = new MovieRating
            {
                Id = this.Id,
                MovieName = this.MovieName,
                Rating = this.Rating,
                MovieId = this.MovieId
            };
            RepositoryFactory.GetMovieRatingRepository().Save(movieRating);
        }
    }
}
