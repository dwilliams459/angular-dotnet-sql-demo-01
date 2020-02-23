using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lego_server_dotnet_domain
{
    [Table("PartsCatalog")]
    public class Part
    {
        [Key]
        public int PartId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }

        [ForeignKey("ItemTypeId")]
        public ItemType ItemType { get; set; }
        public string ItemTypeId { get; set; }
        
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public decimal ItemWeight { get; set; }
        public decimal ItemDimensionX { get; set; }
        public decimal ItemDimensionY { get; set; }
        public decimal ItemDimensionZ { get; set; }
        public string ImageLink { get; set; }
        public string IconLink { get; set; }
    }
}
