using Microsoft.AspNetCore.Mvc;

namespace ItemInventorySystemBackend.Services;

public interface IPlayerService
{
    List<Player>? GetPlayers();
    Player? GetPlayer(int id);
    List<Player>? UpdatePlayer(int id, Player body);
    List<Player>? DeletePlayer(int id);
    List<Player> CreatePlayer(Player player);

}