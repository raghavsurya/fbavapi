using System;
using System.Collections.Generic;

namespace FunBooksAndVideosWebApi.Entity
{
    public class Order
    {
        public long Id { get; set; }
        public double Total { get; set; }
        public List<(OrderType orderType, string name)> ItemLines { get; set; }
        public Customer CustomerInfo { get; set; }

        public bool IsMembershipProduct(OrderType orderType)
        {
            return orderType == OrderType.BookMembership || orderType == OrderType.VideoMembership;
        }
    }
}
