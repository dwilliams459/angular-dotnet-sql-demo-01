using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lego_server_dotnet_domain
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string SubCategory { get; set; }
    }
}
