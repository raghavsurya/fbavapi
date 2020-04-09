using System;
namespace FunBooksAndVideosWebApi.Entity
{
    public class ShippingSlip : IBusinessRules
    {
        public ShippingSlip()
        {
        }

        public void Apply(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
