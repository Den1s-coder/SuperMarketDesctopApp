using SuperMarketDesctopApp.Forms.PaymentsForms;
using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Model.Event;
using SuperMarketDesctopApp.Model.Payments.Interface;

namespace SuperMarketDesctopApp.Model.Payments.Retail
{
    internal struct CashPayment : IPaymentForm
    {
        double Amount;

        public CashPayment()
        {

        }

        public event EventHandler<CustomerServedEvent> CustomerServed;

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (LoyaltyCard == true) Amount -= Amount * 0.05;

            if (CourierDelivery == true) Amount += 250;

            PayableForm payableForm = new PayableForm(Amount, cashRegister, onlineFormat, this);
            payableForm.ShowDialog();

            Basket.Clear();

            OnCustomerServed(new CustomerServedEvent(Amount));
        }

        public void OnCustomerServed(CustomerServedEvent e)
        {
            CustomerServed?.Invoke(this, e);
        }
    }
}
