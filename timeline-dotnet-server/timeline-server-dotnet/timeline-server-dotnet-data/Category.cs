using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace timeline_server_dotnet_data
{
    [Table("Category")]
    public class Category 
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string SubCategory { get; set; }
    }
}

