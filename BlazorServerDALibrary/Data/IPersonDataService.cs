using BlazorServerDALibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Data
{
    public interface IPersonDataService
    {
        Task<int> CreatePerson(PersonModel person);
        List<PersonModel> ReadPeople();
        Task<IEnumerable<PersonModel>> ReadPeopleAsync();
        Task<int> UpdatePerson(PersonModel person);
    }
}