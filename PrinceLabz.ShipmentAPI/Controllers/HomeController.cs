using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrinceLabz.ShipmentAPI.Model;

namespace PrinceLabz.ShipmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HomeController : ControllerBase
    {
        public List<Product> _lst { get; set; }
        public HomeController()
        {
            List<Product> lst = new List<Product>();
            lst.Add(new Product() { Title = "title 1", Description = "des1" });
            lst.Add(new Product() { Title = "title 2", Description = "des2 " });
            _lst = lst;
        }
        public IActionResult Get()
        {
            return new JsonResult(_lst);
        }
    }
}