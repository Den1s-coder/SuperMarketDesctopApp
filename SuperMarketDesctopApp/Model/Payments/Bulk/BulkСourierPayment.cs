using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Forms.PaymentsForms;
using SuperMarketDesctopApp.Model.Payments.Interface;
using SuperMarketDesctopApp.Model.Event;

namespace SuperMarketDesctopApp.Model.Payments.Bulk
{
    internal struct BulkСourierPayment : IPaymentForm
    {

        double Amount;

        public BulkСourierPayment()
        {
        }

        public event EventHandler<CustomerServedEvent> CustomerServed;

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            CourierDelivery = true;

            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (CourierDelivery == true) Amount += 0;

            PayableForm payableForm = new PayableForm(Amount, cashRegister, onlineFormat,this);
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
