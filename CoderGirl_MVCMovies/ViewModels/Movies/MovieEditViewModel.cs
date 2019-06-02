using CoderGirl_MVCMovies.Data;
using CoderGirl_MVCMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.ViewModels.Movies
{
    public class MovieEditViewModel
    {
        public static MovieEditViewModel GetModel(int id)
        {
            Movie movie = (Movie)RepositoryFactory.GetMovieRepository().GetById(id);
            return new MovieEditViewModel
            {
                Name = movie.Name,
                DirectorId = movie.DirectorId,
                Year = movie.Year
            };
        }

        public string Name { get; set; }
        public int DirectorId { get; set; }
        public int Year { get; set; }

        public void Persist(int id)
        {
            Movie movie = new Movie
            {
                Name = this.Name,
                DirectorId = this.DirectorId,
                Year = this.Year
            };
            RepositoryFactory.GetMovieRepository().Update(movie);
        }
    }
}
