using System;
using FunBooksAndVideosWebApi.Entity;
using FunBooksAndVideosWebApi.RequestResponse;
using System.Collections.Generic;

namespace FunBooksAndVideosWebApi.Mapping
{
    public class MappingService: IMappingService
    {
        public MappingService()
        {
        }

        public Order Map(PurchaseOrderDto purchaseOrderDto)
        {
            var order = new Order();

            order.CustomerInfo = new Customer { Id = purchaseOrderDto.CustomerId };
            order.Id = purchaseOrderDto.Id;
            order.Total = purchaseOrderDto.TotalAmount;
            order.ItemLines = MapItemLines(purchaseOrderDto.ItemLines);

            return order;
        }

        public List<(OrderType orderType, string name)> MapItemLines(List<(ItemType itemType, string itemName)> sourceTuple)
        {
            var tupleDao = new List<(OrderType orderType, string name)>();

            foreach (var item in sourceTuple)
            {
                tupleDao.Add((MapEnum(item.itemType), item.itemName));
            }
            return tupleDao;
        }

        public OrderType MapEnum(ItemType source)
        {
            return (OrderType)source;
        }
    }
}
