using DataLibraryRepo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibraryRepo.Data
{
    public interface IFoodData
    {
        List<FoodModel> GetFood();
    }
}