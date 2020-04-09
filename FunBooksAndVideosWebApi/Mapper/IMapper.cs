using System;
using FunBooksAndVideosWebApi.Entity;
using FunBooksAndVideosWebApi.RequestResponse;

namespace FunBooksAndVideosWebApi.Mapper
{
    public interface IMapperService
    {
        Order Map(PurchaseOrderDto purchaseOrderDto);
    }
}
