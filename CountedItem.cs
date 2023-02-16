using System.Net.Mail;

namespace Mini_Project;

public class CountedItem
{
    public Item TheItem;
    public int Quantity;

    public CountedItem(Item theitem, int quantity)
    {
        this.TheItem = theitem;
        this.Quantity = quantity;
    }


}