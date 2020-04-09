using System;
namespace FunBooksAndVideosWebApi.Services
{
    public interface ICustomerService
    {
        void ActivateMembership(int customerId, Membership membership);
    }
}
