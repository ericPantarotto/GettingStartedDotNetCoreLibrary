using BlazorServerDALibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.DataAccess
{
    public interface IPersonDataAccess
    {
        //Task<IEnumerable<PersonModel>> GetPeople();
        IEnumerable<PersonModel> GetPeople();
    }
}