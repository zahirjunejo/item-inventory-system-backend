namespace ItemInventorySystemBackend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Player> Players { get; set; }
    public DbSet<Item> Items { get; set; }
}