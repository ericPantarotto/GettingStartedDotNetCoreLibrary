﻿using BlazorServerDALibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Data
{
    public interface IPersonDataService
    {
        Task<int> CreatePerson(IPersonModel person);
        Task DeletePerson(int personId);
        List<PersonModel> ReadPeople();
        Task<IEnumerable<PersonModel>> ReadPeopleAsync();
        Task<int> UpdatePerson(IPersonModel person);
    }
}