using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lego_server_dotnet_domain
{
    public class ItemType
    {
        [Key]
        public string ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
    }
}
