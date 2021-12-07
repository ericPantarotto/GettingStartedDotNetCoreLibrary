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

        public void Run()
        //public async Task Run()
        {
            try
            {
                //var personList =  _personService.ReadPeople();

                //var personListAsync = await _personDataAccess.GetPeople();
                var personList = _personDataAccess.GetPeople();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
