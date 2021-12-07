using BlazorServerDALibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Data
{
    public interface IPersonDataService
    {
        Task<int> CreatePerson(IPersonModel person);
        Task<List<IPersonModel>> ReadPeople();
    }
}