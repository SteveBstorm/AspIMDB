using System;
using System.Collections.Generic;
using System.Text;

using local = LocalModel.Models;
using dal = DAL.Models;
using System.Runtime.CompilerServices;
using LocalModel.Services;

namespace LocalModel.Tools
{
    public static class Mappers
    {
        static PersonService _service = new PersonService();

        public static local.Movie toLocal(this dal.Movie m)
        {
            return new local.Movie {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                ReleaseYear = m.ReleaseYear,
                Realisator = _service.GetOne(m.RealisatorID),
                Scenarist = _service.GetOne(m.ScenaristID)
            };
        }

        public static local.Person toLocal(this dal.Person p)
        {
            return new local.Person
            {
                Id = p.Id,
                LastName = p.LastName,
                FirstName = p.FirstName
            };
        }
    }
}
