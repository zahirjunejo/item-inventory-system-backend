namespace ItemInventorySystemBackend.Services;

public class PlayerService : IPlayerService
{
    
    private static List<Player> _players = new List<Player>()
    {
        new Player {Id = 1, Budget = 10000, Email="john.connor@gmail.com", FirstName = "John", LastName = "Connor", Password = "johncon123", UserName = "johncon123"},
        new Player {Id = 2, Budget = 10000, Email="rehab.room@gmail.com", FirstName = "Oh", LastName = "Rehab", Password = "rehabroom", UserName = "rehabroom"}
    };
    
    public List<Player> GetPlayers()
    {
        return _players;
    }

    public Player? GetPlayer(int id)
    {
        var player = _players.FirstOrDefault(p => p.Id == id);
        if (player == null) return null;
        return player;
    }

    public List<Player> UpdatePlayer(int id, Player body)
    {
        throw new NotImplementedException();
    }

    public List<Player> DeletePlayer(int id)
    {
        throw new NotImplementedException();
    }

    public List<Player> CreatePlayer(Player player)
    {
        throw new NotImplementedException();
    }
}