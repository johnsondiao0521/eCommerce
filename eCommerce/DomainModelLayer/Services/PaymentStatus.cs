
namespace eCommerce.DomainModelLayer.Services
{
    public enum PaymentStatus
    {
        OK = 100,
        UnpaidBalance = 101,
        NoActiveCreditCardAvailable = 102
    }
}
