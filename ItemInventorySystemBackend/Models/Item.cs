namespace ItemInventorySystemBackend.Models;

public class Item
{
  public int Id { get; set; }
  public int PlayerId { get; set; }
  public string Name { get; set; } = string.Empty;
}