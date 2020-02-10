using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using timeline_server_dotnet.data;

namespace timeline_server_dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private timelineDbContext _context;

        public EventController(timeline_server_dotnet.data.timelineDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            var events = _context.Events.ToList();
            return events;
        }

        [HttpGet("{id}")]
        public async Task<Event> Get(int id)
        {
            if (id > 0)
            {
                return await _context.Events.Where(e => e.ID == id).FirstOrDefaultAsync();
            }
            else
            {
                return await _context.Events.FirstOrDefaultAsync();
            }
        }

        [HttpPost]
        public async Task<int> Insert([FromBody] Event newEvent)
        {
            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();

            return newEvent.ID;
        }
    }
}