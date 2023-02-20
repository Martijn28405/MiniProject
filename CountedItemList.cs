using System.Linq;

namespace MiniProject
{
    public class CountedItemList
    {
        public List<CountedItem> TheCountedItemList;

        public CountedItemList()
        {
            TheCountedItemList = new List<CountedItem>();
        }

        public void AddItem(Item item)
        {
            CountedItem countedItem = FindItemInCountedItemList(item);

            // If the item isn't in the list, it creates a new CountedItem and adds it to the list.
            if (countedItem == null)
            {
                countedItem = new CountedItem(item, 0);
                TheCountedItemList.Add(countedItem);
            }
            // If it's already in the list it updates the quantity.
            countedItem.Quantity++;
        }

        public void AddCountedItem(CountedItem countedItem)
        {
            CountedItem existingCountedItem = FindItemInCountedItemList(countedItem.TheItem);

            if (existingCountedItem == null)
            {
                TheCountedItemList.Add(countedItem);
            }
            else
            {
                existingCountedItem.Quantity += countedItem.Quantity;
            }
        }

        public override string ToString()
        {
            string allItems = "";

            foreach (CountedItem item in TheCountedItemList)
            {
                allItems += $"{item.Quantity}x {item.TheItem.Name}\n";
            }

            return allItems;
        }

        // Private can only get accessed within the current class.
        private CountedItem FindItemInCountedItemList(Item item)
        {
            // Grabs the first result from the TheCountedItemList and puts it in the currentCountedItem.
            // Example: currentCountedItem = TheCountedItemList[0]
            foreach (CountedItem currentCountedItem in TheCountedItemList)
            {
                if (currentCountedItem.TheItem.ID == item.ID)
                {
                    return currentCountedItem;
                }
            }

            return null;
        }
    }
}