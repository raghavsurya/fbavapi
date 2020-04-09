using System;
using FunBooksAndVideosWebApi.Entity;

namespace FunBooksAndVideosWebApi.Services
{
    public interface IPurchaseOrderService
    {
        void Process(Order order);
    }
}
