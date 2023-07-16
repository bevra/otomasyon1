using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berva
{
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsFrom = new ProductsForm();
            productsFrom.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
