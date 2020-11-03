using DAL.Interface;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Repository
{
    public class PersonRepo : BaseRepository, IPersonRepository<Person>
    {
        public PersonRepo()
        {
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            using (SqlConnection c = Connection())
            {
                c.Open();
                using (SqlCommand cmd = c.CreateCommand())
                {

                    cmd.CommandText = "SELECT * FROM Person";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Person
                            {
                                Id = (int)reader["Id"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString()
                            };
                        }
                    }
                }
            }
        }

        public Person GetOne(int Id)
        {
            Person person = new Person();
            using (SqlConnection c = Connection())
            {
                using (SqlCommand cmd = c.CreateCommand())
                {
                    c.Open();
                    cmd.CommandText = "SELECT * FROM Person WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.Id = (int)reader["Id"];
                            person.LastName = reader["LastName"].ToString();
                            person.FirstName = reader["FirstName"].ToString();
                        }
                    }
                }
            }
            return person;
        }

        public void Insert(Person c)
        {
            throw new NotImplementedException();
        }

        public void Update(Person c)
        {
            throw new NotImplementedException();
        }
    }
}
