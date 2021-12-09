using BlazorServerDALibrary.Models;
using RepoDb;


namespace BlazorServerDALibrary.RepoDB
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
                .Entity<IPersonModel>()
                .Table("[dbo].[People]");
            FluentMapper
                .Entity<PersonModel>()
                .Table("[dbo].[People]"); ;

            _modelMapped = true;
        }
    }
}
