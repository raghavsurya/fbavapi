using System;
namespace FunBooksAndVideosWebApi.Entity
{
    public interface IBusinessRules
    {
        void Apply(Order order);
    }
}
