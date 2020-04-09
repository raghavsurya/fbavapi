using System;
using FunBooksAndVideosWebApi.Entity;
using FunBooksAndVideosWebApi.RequestResponse;


namespace FunBooksAndVideosWebApi.Mapping
{
    public interface IMappingService
    {
        Order Map(PurchaseOrderDto purchaseOrderDto);
    }
}
