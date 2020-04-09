using System;
namespace FunBooksAndVideosWebApi.Services
{
    public interface IMembershipActivationService
    {
        void ActivateMembership(long customerId);
    }
}
