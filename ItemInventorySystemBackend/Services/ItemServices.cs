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

    public List<Item>? UpdateItem(int id, Item body)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item == null) return null;
        
        item.Name = body.Name ?? item.Name;
        
        return _items;
    }

    public List<Item>? DeleteItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item == null) return null;
        
        _items.Remove(item);
        
        return _items;
    }

    public Item? GetItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item == null) return null;
        
        return item;
    }

    public List<Item> CreateItem(Item item)
    {
        _items.Add(item);
        return _items;
    }
}