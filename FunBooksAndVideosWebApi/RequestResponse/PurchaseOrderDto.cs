using System;
using System.Collections.Generic;

namespace FunBooksAndVideosWebApi.RequestResponse
{
    public class PurchaseOrderDto
    {
        public long Id { get; set; }
        public double TotalAmount { get; set; }
        public long CustomerId { get; set; }
        public List<(ItemType itemType, string name)> ItemLines { get; set; } //Tuple of item and item type
    }

    public enum ItemType
    {
        Book, //Physical
        Video,
        BookMembership,
        VideoMembership
    }

}
