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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        DbstokEntities db = new DbstokEntities();

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "" | txtCustomerSurname.Text.Trim() == "")
            {
                MessageBox.Show("Müşteri adı ve/veya soyadı boş girilemez!");
            }

            Customers customers = new Customers();

            customers.name = txtCustomerName.Text;
            customers.surname = txtCustomerSurname.Text;
            customers.city = int.Parse(cmbCity.SelectedValue.ToString());

            db.Customers.Add(customers);
            db.SaveChanges();
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            cmbCity.SelectedIndex = 0;
            MessageBox.Show("Müşteri başarıyla eklendi.");
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            var cities = (from city in db.Cities
                          select new
                          {
                              city.id,
                              city.name
                          }).ToList();

            cmbCity.ValueMember = "id";
            cmbCity.DisplayMember = "name";
            cmbCity.DataSource = cities;
        }
    }
}
