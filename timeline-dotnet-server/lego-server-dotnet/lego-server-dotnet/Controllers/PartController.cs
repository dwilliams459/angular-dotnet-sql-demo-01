using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lego_server_dotnet_data;
using lego_server_dotnet_domain;
using lego_server_dotnet_service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lego_server_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly LegoCatalogDbContext Db;
        private readonly PartService _partService;

        public PartController(LegoCatalogDbContext legoCatalogDb, PartService partService)
        {
            Db = legoCatalogDb;
            _partService = partService;
        }

        [HttpGet]
        public async Task<List<Part>> Get()
        {
            return await Db.Parts.Take(100).ToListAsync();
        }

        [HttpGet]
        [Route("{partId}")]
        public async Task<Part> Part(int partId)
        {
            return await Db.Parts.FirstOrDefaultAsync(p => p.PartId == partId);
        }

        [HttpGet]
        [Route("{itemId}")]
        public async Task<Part> Item(string itemId)
        {
            return await Db.Parts.FirstOrDefaultAsync(p => p.ItemId == itemId);
        }
    }
}
