namespace ItemInventorySystemBackend.Services;

public interface IItemService
{
    List<Item>? GetItems();
    List<Item>? UpdateItem(int id, Item body);
    List<Item>? DeleteItem(int id);
    Item? GetItem(int id);
    List<Item> CreateItem(Item item);
}