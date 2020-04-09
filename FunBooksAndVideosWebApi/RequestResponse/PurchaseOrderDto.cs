using System;
using System.Collections.Generic;

namespace FunBooksAndVideosWebApi.RequestResponse
{
    public class PurchaseOrderDto
    {
        public long Id { get; set; }
        public double TotalAmount { get; set; }
        public long CustomerId { get; set; }
        public List<ItemLine> ItemLines { get; set; } //Tuple of item and item type
    }

    public class ItemLine
    {
        public ItemType ItemType { get; set; }
        public string Name { get; set; }
    }

    public enum ItemType
    {
        None = 0,
        Video = 1, //Physical
        Book = 2,
        BookMembership = 3,
        VideoMembership = 4
    }

}
