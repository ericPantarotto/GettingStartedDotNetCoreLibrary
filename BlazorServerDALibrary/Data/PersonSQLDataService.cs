using BlazorServerDALibrary.Models;
using Microsoft.Extensions.Configuration;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Data
{
    public class PersonSQLDataService : IPersonDataService
    {
        private readonly string _connectionString;
        private readonly IConfiguration _config;
        public PersonSQLDataService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("SQLDB");
        }

        public async Task<int> CreatePerson(PersonModel person)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            var id = await connection.MergeAsync(person
                   , qualifiers: q => new { q.FirstName, q.LastName });

            return Convert.ToInt32(id);
        }

        public List<PersonModel> ReadPeople()
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            return connection.QueryAll<PersonModel>().ToList();
        }
    }
}
