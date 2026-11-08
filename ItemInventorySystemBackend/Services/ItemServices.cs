namespace ItemInventorySystemBackend.Services;

public class ItemServices : IItemService
{
    
    private static List<Item>  _items = new List<Item>
    {
        new Item { Id = 1, Name = "Bandage", PlayerId = 1},
        new Item { Id = 2, Name = "Pills", PlayerId = 1},
        new Item { Id = 3, Name = "First Aid Kit", PlayerId = 2},
        new Item { Id = 4, Name = "Mask", PlayerId = 2},
    };
    
    public List<Item>? GetItems()
    {
        return _items;
    }

    public List<Item> UpdateItem(int id, Item body)
    {
        throw new NotImplementedException();
    }

    public List<Item> DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public Item? GetItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item == null) return null;
        
        return item;
    }

    public List<Item> CreateItem(Item item)
    {
        throw new NotImplementedException();
    }
}