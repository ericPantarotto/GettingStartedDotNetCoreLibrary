using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerDALibrary.Data;
using BlazorServerDALibrary.DataAccess;
using BlazorServerDALibrary.Models;
using BlazorServerDALibrary.RepoDB;
using Microsoft.Extensions.Configuration;

namespace ConsoleUI
{
    public class AppBS
    {
        private readonly IPersonDataService _personService;
        private readonly IPersonDataAccess _personDataAccess;

        public AppBS(IPersonDataService personService, IPersonDataAccess personDataAccess)
        {
            new ModelMapper().ModelMap();
            
            _personService = personService;
            _personDataAccess = personDataAccess;
        }

        public async Task Run()
        //public void Run()
        {
            try
            {

                //Create
                //IPersonModel person = new PersonModel
                //{
                //    //Id = 1,
                //    FirstName = "abobo",
                //    LastName = "Lolo",
                //    DateOfBirth = new DateTime(1970, 06, 06)
                //};

                //await _personService.CreatePerson(person);

                //Read
                var personList = await _personService.ReadPeopleAsync();
                //var personList =  _personService.ReadPeople();

                //Update
                //IPersonModel person = new PersonModel
                //{
                //    Id = 2002,
                //    FirstName = "Abobo",
                //    LastName = "lolo",
                //    DateOfBirth = new DateTime(1970, 06, 07)
                //};
                //await _personService.UpdatePerson(person);

                //Delete
                await _personService.DeletePerson(2);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
