using SuperMarketDesctopApp.Model.Classes;
using SuperMarketDesctopApp.Forms.PaymentsForms;
using SuperMarketDesctopApp.Model.Payments.Interface;

namespace SuperMarketDesctopApp.Model.Payments.Retail
{
    internal struct СourierPayment : IPaymentForm
    {
        double Amount;

        public СourierPayment()
        {
        }

        public void Count(List<Product> Basket, bool LoyaltyCard, bool CourierDelivery, CashRegister cashRegister, string onlineFormat)
        {
            CourierDelivery = true;

            foreach (var product in Basket)
            {
                Amount += product.GetPrice();
            }

            if (CourierDelivery == true) Amount += 250;

            string PaymentFormat = "Кур'єром";

            PayableForm payableForm = new PayableForm(Amount,cashRegister,PaymentFormat, onlineFormat);
            payableForm.ShowDialog();

            Basket.Clear();
        }
    }
}
