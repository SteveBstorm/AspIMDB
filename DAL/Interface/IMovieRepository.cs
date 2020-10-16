using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IMovieRepository<Movie>
    {
        IEnumerable<Movie> GetAll();
        Movie GetOne(int Id);
        void Insert(Movie c);
        void Update(Movie c);
        void Delete(int Id);
    }
}
