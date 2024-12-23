using SuperMarketDesctopApp.Forms.PaymentsForms;
using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;
using SuperMarketDesctopApp.Model.Payments.Interface;

namespace SuperMarketDesctopApp.Model.Payments.Bulk
{
    internal struct BulkCashPayment : IPaymentForm
    {
        CashRegister CashRegister;

        double Amount;

        double Rest;

        public BulkCashPayment()
        {

        }

        public event EventHandler<CustomerServedEvent> CustomerServed;

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.08;

            if (CourierDelivery == true) Amount += 50;

            PayableForm payableForm = new PayableForm(Amount, cashRegister, onlineFormat,this);
            payableForm.ShowDialog();

            Basket.Clear();

        }

        public void OnCustomerServed(CustomerServedEvent e)
        {
            CustomerServed?.Invoke(this, e);
        }
    }
}
