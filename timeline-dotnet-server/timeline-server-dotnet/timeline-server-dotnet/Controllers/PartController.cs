using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using timeline_server_dotnet_data;

namespace timeline_server_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private PartsCatalogDbContext _context;

        public PartController(PartsCatalogDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Part>> Get()
        {
            return await _context.Parts.Include(p => p.Category).Include(p => p.ItemType).Take(25).ToListAsync();   // .Include(p => p.Category)
        }

        [HttpGet]
        [Route("search")]
        public async Task<List<Part>> GetSearch(PartSearchCriteria searchCriteria = null)
        {
            var partQuery = (_context.Parts.Include(p => p.Category).Include(p => p.ItemType)).Where(p => true);

            if (searchCriteria.PartId != null && searchCriteria.PartId > 0)
            {
                partQuery = partQuery.Where(p => p.PartId.Equals(searchCriteria.PartId));
            }
            else if (searchCriteria.ItemId != null && searchCriteria.ItemId.Length > 0)
            {
                partQuery = partQuery.Where(p => p.ItemId == searchCriteria.ItemId);
            }
            else
            {
                if (searchCriteria.ItemName != null && searchCriteria.ItemName.Length > 0)
                {
                    partQuery = partQuery.Where(p => p.ItemName.Contains(searchCriteria.ItemName));
                }
                if (searchCriteria.CategoryName != null && searchCriteria.CategoryName.Length > 0)
                    partQuery = partQuery.Where(p => p.Category.Name.Contains(searchCriteria.CategoryName));
            }

            if (searchCriteria.Page > 0)
            {
                partQuery = partQuery.Skip(searchCriteria.Page * searchCriteria.PageSize);
            }

            var parts = await partQuery.Take(searchCriteria.PageSize).ToListAsync();
            return (parts == null) ? new List<Part>() : parts;
        }
    }
}
