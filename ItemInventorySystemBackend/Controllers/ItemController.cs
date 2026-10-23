using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemInventorySystemBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemInventorySystemBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private List<Item>  _items = new List<Item>
        {
            new Item { Id = 1, Name = "Bandage", PlayerId = 1},
            new Item { Id = 2, Name = "Pills", PlayerId = 1},
            new Item { Id = 3, Name = "First Aid Kit", PlayerId = 2},
            new Item { Id = 4, Name = "Mask", PlayerId = 2},
        };

        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            return Ok(_items);
        }
        
    }
}
