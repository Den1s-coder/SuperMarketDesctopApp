using SuperMarketDesctopApp.Model.Classes;

namespace SuperMarketDesctopApp.Model.Payments.Interface
{
    public interface IPaymentForm
    {
        void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat);
    }
}
