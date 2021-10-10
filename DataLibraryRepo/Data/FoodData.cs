using DataLibraryRepo.Models;
using Microsoft.Extensions.Configuration;
using RepoDb;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataLibraryRepo.Data
{
    public class FoodData : IFoodData
    {
        private readonly string _connectionString;
        private readonly IConfiguration _config;
        public FoodData(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("sqlserver");
        }

        public List<FoodModel> GetFood()
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            return connection.QueryAll<FoodModel>().ToList();
            
        }

        public FoodModel GetFoodById(int foodId)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<FoodModel>(c => c.Id == foodId).FirstOrDefault();
            }
        }
        
    }
}
