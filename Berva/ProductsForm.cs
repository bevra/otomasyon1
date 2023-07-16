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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        DbstokEntities db = new DbstokEntities();

        public int id = 0;

      

        public void FetchData()
        {
            dataProductsView.DataSource = db.Products.ToList();
            dataProductsView.DataSource = (from product in db.Products
                                           select new
                                           {
                                               product.id,
                                               product.name,
                                               product.quantity,
                                               product.price,
                                               product.status,
                                           }).ToList();
            dataProductsView.Columns[0].HeaderText = "Id";
            dataProductsView.Columns[1].HeaderText = "Ürün Adı";
            dataProductsView.Columns[2].HeaderText = "Adet";
            dataProductsView.Columns[3].HeaderText = "Fiyat";
            dataProductsView.Columns[4].HeaderText = "Durum";
        }

        public void CleanData()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            cmbStatus.SelectedIndex = 0;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
           Products add = new Products();

            add.name = txtName.Text;
            add.price = int.Parse(txtPrice.Text);
            add.quantity = int.Parse(txtQuantity.Text);
            add.status = bool.Parse(cmbStatus.SelectedValue.ToString());

            db.Products.Add(add);
            db.SaveChanges();
            FetchData();
            CleanData();
            MessageBox.Show("Ürün başarıyla kaydedildi.");
        }
        public class Statu
        {
            public string text { get; set; }
            public bool boolean { get; set; }
        }

       



        private void ProductsForm_Load(object sender, EventArgs e)
        {
            List<Statu> status = new List<Statu>();
            status.Add(new Statu { text = "Tedarik edilebilir", boolean = true }) ;
            status.Add(new Statu { text = "Tedarik edilemez", boolean = false });
            cmbStatus.ValueMember = "boolean";
            cmbStatus.DisplayMember = "text";
            cmbStatus.DataSource = status;
            CleanData();
            FetchData();


        }

        private void btnFetchList_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
               
               var message =  MessageBox.Show("Emin misiniz?", "MessageBox title", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                
                if(message == DialogResult.OK)
                {
                    var findedProduct = db.Products.Find(id);
                    db.Products.Remove(findedProduct);
                    db.SaveChanges();
                    CleanData();
                    FetchData();
                    id = 0;
                }
                
            } 
            
        }

        private void dataProductsView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dataProductsView.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtName.Text = row.Cells[1].Value.ToString();
                txtQuantity.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();

                if (bool.Parse(cmbStatus.SelectedValue.ToString()) == true)
                {
                    cmbStatus.SelectedIndex = 0;
                }
                else
                {
                    cmbStatus.SelectedIndex = 1;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var findedProduct = db.Products.Find(id);
                if (findedProduct != null)
                {
                    findedProduct.name = txtName.Text;
                    findedProduct.price = int.Parse(txtPrice.Text);
                    findedProduct.quantity = int.Parse(txtQuantity.Text);
                    findedProduct.status = bool.Parse(cmbStatus.SelectedValue.ToString());

                    try
                    {
                        db.SaveChanges();
                        FetchData();
                        CleanData();
                        id = 0;
                        MessageBox.Show("Ürün güncellendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
           
            List<Products> searchResults = db.Products
                .Where(product => product.name.Contains(searchTerm))
                .ToList();

            dataProductsView.DataSource = searchResults;
        }

       
    }
}
