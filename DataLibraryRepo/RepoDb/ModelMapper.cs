using DataLibraryRepo.Models;
using RepoDb;


namespace BillTimeLibrary.RepoDB
{
    //https://repodb.net/mapper/fluentmapper
    public class ModelMapper
    {
        private static bool _modelMapped = false;

        public void ModelMap()
        {
            if (!SqlServerBootstrap.IsInitialized)
            {
                SqlServerBootstrap.Initialize();
            }

            if (_modelMapped) return;

            FluentMapper
                .Entity<FoodModel>()
                .Table("[dbo].[Food]");

            FluentMapper
               .Entity<OrderModel>()
               .Table("[dbo].[Order]");

            _modelMapped = true;
        }
    }
}
