using System;
using System.ComponentModel.DataAnnotations;

namespace timeline_server_dotnet_data
{
    public class ItemType 
    {
        [Key]
        public string ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
    }
}