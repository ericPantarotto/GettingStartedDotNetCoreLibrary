using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillTimeLibrary.RepoDB;
using DataLibraryRepo.Data;
using DataLibraryRepo.Models;
using Microsoft.Extensions.Configuration;

namespace ConsoleUI
{
    public class App
    {

        private readonly IConfiguration _config;
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;
        public App(IConfiguration config, 
                   IOrderData orderData, 
                   IFoodData foodData)
        {
            new ModelMapper().ModelMap();
            
            _config = config;
            _foodData = foodData;
            _orderData = orderData;
            
 
        }

        public void Run()
        {
            var foodList = _foodData.GetFood();

            
             int id = _orderData.CreateOrder(new OrderModel{
                 FoodId = 1,
                 OrderName = "Rico",
                 Quantity = 5,
                 

            });
        }
    }
}
