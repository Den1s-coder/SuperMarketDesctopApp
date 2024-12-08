using SuperMarketDesctopApp.Classes;

namespace SuperMarketDesctopApp.Forms
{
    public partial class SuperMarketForm : Form
    {
        SuperMarket  
        public SuperMarketForm()
        {
            InitializeComponent();
        }

        private void LoadProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                listBox1.Items.Add(product);
            }
        }
    }
}
