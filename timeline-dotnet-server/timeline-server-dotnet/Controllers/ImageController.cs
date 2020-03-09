using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace timeline_server_dotnet.Controllers
{
    public class ImageController : Controller
    {
        private string sourcePath = "F:\\LegoImages";        
        
        // GET: /<controller>/
        [HttpGet]
        [Route("{name}")]
        public IActionResult Index(string name)
        {
            var path = Path.Combine(sourcePath, name);  // Server.MapPath("/Images");
            return base.File(path, "image/png");
        }
    }
}
