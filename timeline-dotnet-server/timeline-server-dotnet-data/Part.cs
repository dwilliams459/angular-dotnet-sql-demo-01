using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace timeline_server_dotnet_data 
{
    [Table("PartsCatalog")]
    public class Part 
    {
        public int PartId { get; set; }

        [Key]
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        
        public string ItemTypeId { get; set; }
        [ForeignKey("ItemTypeId")]
        public ItemType ItemType { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        
        public decimal? ItemWeight { get; set; }
        public decimal? ItemDimensionX { get; set; }
        public decimal? ItemDimensionY { get; set; }
        public decimal? ItemDimensionZ { get; set; }
        public string ImageLink { get; set; }
        public string IconLink { get; set; }
    }
}