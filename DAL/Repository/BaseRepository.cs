using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Repository
{
    public class BaseRepository
    {
        private string _connectionString = @"Data Source=DESKTOP-RGPQP6I\\TFTIC2014;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /*public BaseRepository()
        {
            _connectionString = @"Data Source=DESKTOP-RGPQP6I\\TFTIC2014;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }*/

        internal SqlConnection Connection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
