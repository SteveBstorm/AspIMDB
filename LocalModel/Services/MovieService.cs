using DAL.Repository;
using local = LocalModel.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using LocalModel.Tools;
using System.Linq;

namespace LocalModel.Services
{
    public class MovieService
    {
        private MovieRepo _repo;
        public MovieService()
        {
            _repo = new MovieRepo(); 

        }

        public local.Movie GetOne(int Id)
        {
            return _repo.GetOne(Id).toLocal();
        }

        public IEnumerable<local.Movie> GetAll()
        {
            return _repo.GetAll().Select(x => x.toLocal());
        }
           
    }
}
