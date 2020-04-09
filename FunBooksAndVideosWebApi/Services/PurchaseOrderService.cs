using System;
using System.Collections.Generic;
using FunBooksAndVideosWebApi.Entity;

namespace FunBooksAndVideosWebApi.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private IBusinessRules _businessRules;

        public PurchaseOrderService(IBusinessRules businessRules)
        {
            _businessRules = businessRules;
        }

        public void Process(Order order)
        {
            foreach(var itemLine in order.ItemLines)
            {
                if(itemLine.orderType == OrderType.BookMembership || itemLine.orderType == OrderType.VideoMembership)
                {
                    _businessRules = new ActivateMembership();
                }
                else
                {
                    _businessRules = new ShippingSlip();
                }
                _businessRules.Apply(order);
            }
        }
    }
}
