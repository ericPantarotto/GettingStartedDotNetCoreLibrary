using BlazorServerDALibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Repositories
{
    public interface IPersonRepository
    {
        //Task<IEnumerable<PersonModel>> LoadPeople();
        IEnumerable<PersonModel> LoadPeople();

    }
}