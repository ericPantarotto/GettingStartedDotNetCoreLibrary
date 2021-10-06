﻿using DataLibraryRepo.Models;
using Microsoft.Extensions.Configuration;
using RepoDb;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataLibraryRepo.Data
{
    public class OrderData : IOrderData
    {

        private readonly string _connectionString;
        private readonly IConfiguration _config;
        public OrderData(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("sqlserver");
        }

        public void CreateOrder(OrderModel order)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                //bulkmerge can only be used with a list of objects

                connection.Merge(order
                    , qualifiers: r => new { r.OrderName, r.OrderDate });

            }
        }

        public void UpdateOrderName(OrderModel order)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Merge(order
                    , qualifiers: r => new { r.Id });
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Delete<OrderModel>(orderId);
            }

        }

        public OrderModel GetOrderById(int orderId)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<OrderModel>(c => c.Id == orderId).FirstOrDefault();
            }
        }
    }
}