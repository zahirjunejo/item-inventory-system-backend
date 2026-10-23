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
    public class PlayerController : ControllerBase
    {
        private static List<Player> _players = new List<Player>()
        {
            new Player {Id = 1, Budget = 10000, Email="john.connor@gmail.com", FirstName = "John", LastName = "Connor", Password = "johncon123", UserName = "johncon123"},
            new Player {Id = 2, Budget = 10000, Email="rehab.room@gmail.com", FirstName = "Oh", LastName = "Rehab", Password = "rehabroom", UserName = "rehabroom"}
        };

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetPlayers()
        {
            return Ok(_players);
        }   
    }
}
