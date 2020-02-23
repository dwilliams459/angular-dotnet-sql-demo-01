using System;

namespace timeline_server_dotnet_data
{
    public class PartSearchCriteria : SearchCriteria
    {
        public int? PartId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string CategoryName { get; set; }
    }
}