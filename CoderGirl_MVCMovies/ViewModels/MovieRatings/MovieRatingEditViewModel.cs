using CoderGirl_MVCMovies.Data;
using CoderGirl_MVCMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.ViewModels.MovieRatings
{
    public class MovieRatingEditViewModel
    {
        public static MovieRatingEditViewModel GetModel(int id)
        {
            MovieRating movieRating = (MovieRating)RepositoryFactory.GetMovieRatingRepository().GetById(id);
            return new MovieRatingEditViewModel
            {
                Id = movieRating.Id,
                MovieName = movieRating.MovieName,
                Rating = movieRating.Rating,
                MovieId = movieRating.MovieId
            };
        }

        public int Id { get; set; }
        public string MovieName { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; }

        public void Persist(int id)
        {
            MovieRating movieRating = new MovieRating
            {
                Id = this.Id,
                MovieName = this.MovieName,
                Rating = this.Rating,
                MovieId = this.MovieId
            };
            RepositoryFactory.GetMovieRatingRepository().Update(movieRating);
        }
    }
}
