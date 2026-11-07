using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemInventorySystemBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemInventorySystemBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        
        public ItemController(IItemService itemServices)
        {
            this._itemService = itemServices;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            return Ok(_itemService.GetItems());
        }

        // [HttpPut("{id}")]
        // public async Task<ActionResult<List<Item>>> UpdateItem(int id, Item body)
        // {
        //     var item = _items.FirstOrDefault(i => i.Id == id);
        //     if (item == null) return NotFound();
        //
        //     item.Name = body.Name ?? item.Name;
        //
        //     return Ok(_items);
        // }
        
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<List<Item>>> DeleteItem(int id)
        // {
        //     var item = _items.FirstOrDefault(i => i.Id == id);
        //     if (item == null) return NotFound();
        //
        //     _items.Remove(item);
        //
        //     return Ok(_items);
        // }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = _itemService.GetItem(id);
            if (item == null) return NotFound("Item not found.");
        
            return Ok(item);
        }

        // [HttpPost]
        // public async Task<ActionResult<List<Item>>> CreateItem(Item item)
        // {
        //     _items.Add(item);
        //     return Ok(_items);
        // }
    }
}
