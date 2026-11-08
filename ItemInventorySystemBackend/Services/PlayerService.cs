namespace ItemInventorySystemBackend.Services;

public class PlayerService : IPlayerService
{
    
    private static List<Player> _players = new List<Player>()
    {
        new Player {Id = 1, Budget = 10000, Email="john.connor@gmail.com", FirstName = "John", LastName = "Connor", Password = "johncon123", UserName = "johncon123"},
        new Player {Id = 2, Budget = 10000, Email="rehab.room@gmail.com", FirstName = "Oh", LastName = "Rehab", Password = "rehabroom", UserName = "rehabroom"}
    };
    
    public List<Player>? GetPlayers()
    {
        return _players;
    }

    public Player? GetPlayer(int id)
    {
        var player = _players.FirstOrDefault(p => p.Id == id);
        if (player == null) return null;
        return player;
    }

    public List<Player>? UpdatePlayer(int id, Player body)
    {
        var player = _players.FirstOrDefault(p => p.Id == id);
        if (player == null) return null;
        
        player.Budget = body.Budget ??  player.Budget;
        player.Email = body.Email ?? player.Email;
        player.FirstName = body.FirstName ?? player.FirstName;
        player.LastName = body.LastName ?? player.LastName;
        player.UserName = body.UserName ?? player.UserName;
        player.Password = body.Password ?? player.Password;
            
        return _players;
    }

    public List<Player>? DeletePlayer(int id)
    {
        var player = _players.FirstOrDefault(p => p.Id == id);
        if (player == null) return null;
            
        _players.Remove(player);
            
        return _players;
    }

    public List<Player> CreatePlayer(Player player)
    {
        _players.Add(player);
        return _players;
    }
}