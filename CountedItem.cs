﻿namespace MiniProject
{
    public class CountedItem
    {
        public Item TheItem { get; set; }
        public int Quantity { get; set; }
        public CountedItem(Item theitem, int quantity)
        {
            TheItem = theitem;
            Quantity = quantity;
        }
    }
}
