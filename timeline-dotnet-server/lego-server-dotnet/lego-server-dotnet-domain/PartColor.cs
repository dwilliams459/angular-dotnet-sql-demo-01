using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lego_server_dotnet_domain
{
    public class PartColor
    {
        [Key]
        public int PartColorId { get; set; }

        [ForeignKey("ItemId")]
        public Part Part { get; set; }
        public string ItemId { get; set; }

        public string Color { get; set; }
        public string CodeName { get; set; }
    }
}
