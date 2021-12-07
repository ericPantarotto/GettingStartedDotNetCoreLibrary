using BlazorServerDALibrary.Models;
using BlazorServerDALibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.DataAccess
{
    public class PersonDataAccess : IPersonDataAccess
    {
        private readonly IPersonRepository _repository;

        public PersonDataAccess(IPersonRepository repository)
        {
            _repository = repository;
        }
        //public async Task<IEnumerable<PersonModel>> GetPeople()
        //{
        //    return await _repository.LoadPeople();
        //}
        public IEnumerable<PersonModel> GetPeople()
        {
            return _repository.LoadPeople();
        }
    }
}
