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
                var personList = await _personService.ReadPeopleAsync();
                //var personList =  _personService.ReadPeople();

                //Upadte
                //var person = new PersonModel
                //{
                //    //Id = 1,
                //    FirstName = "Rico",
                //    LastName = "Carlier",
                //    DateOfBirth = new DateTime(2021, 12, 7)
                //};

                //await _personService.CreatePerson(person);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
