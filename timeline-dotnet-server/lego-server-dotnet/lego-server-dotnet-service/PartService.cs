using lego_server_dotnet_data;
using System;

namespace lego_server_dotnet_service
{
    public class PartService
    {
        private LegoCatalogDbContext _db;

        public PartService(LegoCatalogDbContext legoDbContext)
        {
            _db = legoDbContext;

        }
    }
}
