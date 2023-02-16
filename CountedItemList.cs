namespace Mini_Project;

public class CountedItemList
{
    public List<CountedItem> TheCountedItemList;

    public CountedItemList()
    {
        TheCountedItemList = new List<CountedItem>();
        

    }

    public void AddItem(Item item)
    {
        item = Item(World.ITEM_ID_RAT_TAIL);
    }
}