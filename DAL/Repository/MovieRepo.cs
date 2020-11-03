using DAL.Interface;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Repository
{
    public class MovieRepo : BaseRepository, IMovieRepository<Movie>
    {
        public MovieRepo()
        {
        }

        public void Delete(int Id)
        {
            using (SqlConnection c = Connection())
            {
                using (SqlCommand cmd = c.CreateCommand())
                {
                    c.Open();
                    if (c.State == System.Data.ConnectionState.Open)
                    {
                        cmd.CommandText = "DELETE FROM Movie WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("Id", Id);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                    else
                    {
                        throw new Exception("Erreur de connexion à la DB");
                    }
                }
            }
        }

        public IEnumerable<Movie> GetAll()
        {
            using (SqlConnection c = Connection())
            {
                c.Open();
                using (SqlCommand cmd = c.CreateCommand())
                {
                    
                    cmd.CommandText = "SELECT * FROM Movie";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Movie
                            {
                                Id = (int)reader["Id"],
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                ReleaseYear = (int)reader["ReleaseYear"],
                                RealisatorID = (int)reader["RealisatorID"],
                                ScenaristID = (int)reader["ScenaristID"],
                            };
                        }
                    }
                }
            }
        }

        public Movie GetOne(int Id)
        {
            Movie m = new Movie();
            using (SqlConnection c = Connection())
            {
                c.Open();
                using (SqlCommand cmd = c.CreateCommand())
                {

                    cmd.CommandText = "SELECT * FROM Movie WHERE Id = @id";
                    cmd.Parameters.AddWithValue("id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            m.Id = (int)reader["Id"];
                            m.Title = reader["Title"].ToString();
                            m.Description = reader["Description"].ToString();
                            m.ReleaseYear = (int)reader["ReleaseYear"];
                            m.RealisatorID = (int)reader["RealisatorID"];
                            m.ScenaristID = (int)reader["ScenaristID"];
                         
                        }
                    }
                }
            return m;
            }
        }

        public void Insert(Movie c)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie c)
        {
            throw new NotImplementedException();
        }

       

        public IEnumerable<Movie> GetByRealisatorId(int Id)
        {
            using (SqlConnection c = Connection())
            {
                c.Open();
                using (SqlCommand cmd = c.CreateCommand())
                {

                    cmd.CommandText = $"SELECT * FROM Movie WHERE RealisatorID = @id";
                    cmd.Parameters.AddWithValue("id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Movie
                            {
                                Id = (int)reader["Id"],
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                ReleaseYear = (int)reader["ReleaseYear"],
                                RealisatorID = (int)reader["RealisatorID"],
                                ScenaristID = (int)reader["ScenaristID"],
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Movie> GetByScenaristId(int Id)
        {
            using (SqlConnection c = Connection())
            {
                c.Open();
                using (SqlCommand cmd = c.CreateCommand())
                {

                    cmd.CommandText = $"SELECT * FROM Movie WHERE ScenaristID = @id";
                    cmd.Parameters.AddWithValue("id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Movie
                            {
                                Id = (int)reader["Id"],
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                ReleaseYear = (int)reader["ReleaseYear"],
                                RealisatorID = (int)reader["RealisatorID"],
                                ScenaristID = (int)reader["ScenaristID"],
                            };
                        }
                    }
                }
            }
        }
    }
}
