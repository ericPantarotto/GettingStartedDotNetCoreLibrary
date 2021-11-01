using DataLibraryRepo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibraryRepo.Data
{
    public interface IOrderData
    {
        int CreateOrder(OrderModel order);
        void DeleteOrder(int orderId);
        OrderModel GetOrderById(int orderId);
        List<OrderModel> GetOrdersAll();
        void UpdateOrderName(OrderModel order);
    }
}