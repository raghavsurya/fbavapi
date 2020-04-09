using System;
namespace FunBooksAndVideosWebApi.Entity
{
    public class Customer
    {
       public long Id { get; set; }

        public bool IsValidCustomer(int id)
        {
            return true;
        }
    }
}
