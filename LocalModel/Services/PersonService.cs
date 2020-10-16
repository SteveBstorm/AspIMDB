using DAL.Repository;
using local = LocalModel.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using LocalModel.Tools;

namespace LocalModel.Services
{
    public class PersonService
    {
        private PersonRepo _repo;
        public PersonService()
        {
            _repo = new PersonRepo(); 

        }

        public local.Person GetOne(int Id)
        {
           return _repo.GetOne(Id).toLocal() ;
        }
           
    }
}
