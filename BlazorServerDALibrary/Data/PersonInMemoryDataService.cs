using BlazorServerDALibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Data
{
    public class PersonInMemoryDataService : IPersonDataService
    {
        private readonly List<IPersonModel> people = new List<IPersonModel>();

        private int currentId = 0;
        public async Task<int> CreatePerson(IPersonModel person)
        {
            await Task.Run(() =>
            {
                currentId += 1;
                person.Id = currentId;
                people.Add(person);
            });
            return await Task.FromResult(currentId);
        }

        public async Task DeletePerson(int personId)
        {
            await Task.Run(() => { people.Remove(people.Where(x => x.Id == personId).FirstOrDefault()); });
        }

        public List<PersonModel> ReadPeople()
        {
            throw new NotImplementedException();
        }

        public async Task<List<IPersonModel>> ReadPeopleAsync()
        {
            return await Task.FromResult(people);
        }

        public async Task<int> UpdatePerson(IPersonModel person)
        {
            var p = people.Where(p => p.Id == person.Id).FirstOrDefault();
            await Task.Run(() =>
            {
                if (p != null)
                {
                    p.FirstName = person.FirstName;
                    p.LastName = person.LastName;
                    p.DateOfBirth = person.DateOfBirth;
                }
            });
            return await Task.FromResult(p.Id);
        }
    }
}
