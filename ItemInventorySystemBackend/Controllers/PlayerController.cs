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
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerServices)
        {
            this._playerService = playerServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetPlayers()
        {
            return Ok(_playerService.GetPlayers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = _playerService.GetPlayer(id);
            if (player == null) return NotFound("Player not found.");
            return Ok(player);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Player>>> UpdatePlayer(int id, Player body)
        {
            var _players = _playerService.UpdatePlayer(id, body);
            if (_players == null) return NotFound("No such player exists.");
        
            return Ok(_players);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Player>>> DeletePlayer(int id)
        {
            var _players = _playerService.DeletePlayer(id);
            if (_players == null) return NotFound("No such player exists.");
            
            return Ok(_players);
        }
        
        // [HttpPost]
        // public async Task<ActionResult<List<Player>>> CreatePlayer(Player player)
        // {
        //     _players.Add(player);
        //     return Ok(_players);
        // }
    }
}
