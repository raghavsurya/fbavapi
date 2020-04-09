using System;
using System.Collections.Generic;
using FunBooksAndVideosWebApi.Entity;

namespace FunBooksAndVideosWebApi.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IBusinessRules _businessRules;

        public PurchaseOrderService(IBusinessRules businessRules)
        {
            _businessRules = businessRules;
        }

        public void Process(Order order)
        {
            _businessRules.Apply(order);
        }
    }
}
