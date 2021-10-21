using System;

namespace DataLibraryRepo.Models
{
    public interface IOrderModel
    {
        int Id { get; set; }
        string OrderName { get; set; }
        DateTime OrderDate { get; set; }
        int FoodId { get; set; }
        int Quantity { get; set; }
        decimal Total { get; set; }
    }
}
