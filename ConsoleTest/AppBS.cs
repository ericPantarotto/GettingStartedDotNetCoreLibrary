using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerDALibrary.Data;
using BlazorServerDALibrary.Models;
using BlazorServerDALibrary.RepoDB;
using Microsoft.Extensions.Configuration;

namespace ConsoleUI
{
    public class AppBS
    {
        private readonly IPersonDataService _personService;
        public AppBS(IPersonDataService personService)
        {
            new ModelMapper().ModelMap();
            
            _personService = personService;
        }

        public void Run()
        {
            try
            {
                var personList =  _personService.ReadPeople();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
