using System;
using FunBooksAndVideosWebApi.Services;

namespace FunBooksAndVideosWebApi.Entity
{
    public class ActivateMembership : IBusinessRules
    {
        private IMembershipActivationService memberShipService;

        public ActivateMembership(IMembershipActivationService _memberShipService)
        {
            this.memberShipService = _memberShipService;
        }

        public void Apply(Order order)
        {
            if (order.ItemLines.Exists(s => s.orderType == OrderType.BookMembership) || order.ItemLines.Exists(s => s.orderType == OrderType.VideoMembership))
            {
                memberShipService.ActivateMembership(order.CustomerInfo.Id);
            }
           
        }
    }
}
