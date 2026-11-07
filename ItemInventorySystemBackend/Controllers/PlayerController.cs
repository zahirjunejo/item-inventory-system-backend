using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = _players.FirstOrDefault(p => p.Id == id);
            if (player == null) return NotFound();
            return Ok(player);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Player>>> UpdatePlayer(int id, Player body)
        {
            var player = _players.FirstOrDefault(p => p.Id == id);
            if (player == null) return NotFound();

            player.Budget = body.Budget;
            player.Email = body.Email ?? player.Email;
            player.FirstName = body.FirstName ?? player.FirstName;
            player.LastName = body.LastName ?? player.LastName;
            player.UserName = body.UserName ?? player.UserName;
            player.Password = body.Password ?? player.Password;
            
            return Ok(_players);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Player>>> DeletePlayer(int id)
        {
            var player = _players.FirstOrDefault(p => p.Id == id);
            if (player == null) return NotFound();
            
            _players.Remove(player);
            
            return Ok(_players);
        }
        
        [HttpPost]
        public async Task<ActionResult<List<Player>>> CreatePlayer(Player player)
        {
            _players.Add(player);
            return Ok(_players);
        }
    }
}
