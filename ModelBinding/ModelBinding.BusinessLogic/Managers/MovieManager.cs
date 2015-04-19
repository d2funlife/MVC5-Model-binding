#region Using statements

using ModelBinding.Contracts.Mangers;
using ModelBinding.Core.Entities;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace ModelBinding.BusinessLogic.Managers
{
    public class MovieManager : IMovieManger
    {
        private readonly IList<Movie> movieTable;

        public MovieManager()
        {
            this.movieTable = new List<Movie>
            {
                new Movie{Id = 1, Title = "Форсаж 7", Director = "Джеймс Ван", Year = 2015, Rating = 7.414},
                new Movie{Id = 2, Title = "Мстители: Эра Альтрона", Director = "Джосс Уидон", Year = 2015, Rating = 8.254},
                new Movie{Id = 3, Title = "Звёздные войны: Пробуждение силы", Director = "Джей Джей Абрамс", Year = 2015, Rating = 0},
                new Movie{Id = 4, Title = "Kingsman: Секретная служба", Director = "Мэттью Вон", Year = 2014, Rating = 8.0}
            };
        }

        public Movie GetMovie(int id)
        {
            return this.movieTable.FirstOrDefault(model => model.Id == id);
        }
    }
}