using BlazorServerDALibrary.Models;
using BlazorServerDALibrary.RepoDB;
using Microsoft.Extensions.Configuration;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerDALibrary.Repositories
{
    public class PersonRepository : BaseRepository<PersonModel, SqlConnection>, IPersonRepository
    {
        public PersonRepository(IConfiguration config)
            : base(config.GetConnectionString("SQLDB"))
        {
            SqlServerBootstrap.Initialize();
            new ModelMapper().ModelMap();
        }

        //public async Task<IEnumerable<PersonModel>> LoadPeople()
        //{
        //    try
        //    {
        //        return await QueryAllAsync();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //}

        public IEnumerable<PersonModel> LoadPeople()
        {
            return QueryAll();
        }

        //public void MergeDefault(DefaultsModel defaultModel)
        //{
        //    DeleteDefaults();
        //    Merge(defaultModel, qualifiers: r => new { r.HourlyRate, r.MinimumHours });
        //}
        //public void DeleteDefaults()
        //{
        //    DeleteAll();
        //}
    }
}
