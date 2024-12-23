namespace SuperMarketDesctopApp.Model.Event
{
    public class CustomerServedEvent
    {
        public double TotalAmount { get; }

        public CustomerServedEvent(double totalAmount)
        {
            TotalAmount = totalAmount;
        }
    }
}
