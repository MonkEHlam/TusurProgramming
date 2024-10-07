using ObjectOrientedPractice.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }
    }
}
