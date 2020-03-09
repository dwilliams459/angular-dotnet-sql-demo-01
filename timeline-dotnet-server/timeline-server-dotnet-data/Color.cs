using System;
using System.ComponentModel.DataAnnotations;

namespace timeline_server_dotnet_data
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string RGB { get; set; }
        public string Type { get; set; }
        public int? Parts { get; set; }
        public int? InSets { get; set; }
        public int? Wanted { get; set; }
        public int? ForSale { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }

    }
}