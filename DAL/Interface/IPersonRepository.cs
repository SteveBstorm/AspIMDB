using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IPersonRepository<Person>
    {
        IEnumerable<Person> GetAll();
        Person GetOne(int Id);
        void Insert(Person c);
        void Update(Person c);
        void Delete(int Id);
    }
}
