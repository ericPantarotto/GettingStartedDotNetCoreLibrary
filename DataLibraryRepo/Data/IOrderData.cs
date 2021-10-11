﻿using DataLibraryRepo.Models;
using System.Threading.Tasks;

namespace DataLibraryRepo.Data
{
    public interface IOrderData
    {
        int CreateOrder(OrderModel order);
        void DeleteOrder(int orderId);
        OrderModel GetOrderById(int orderId);
        void UpdateOrderName(OrderModel order);
    }
}