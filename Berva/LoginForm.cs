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

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "bevra";
            txtPassword.Text = "123456";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            DbstokEntities db = new DbstokEntities();
            var query = from person in db.Admins where person.user_name == txtUserName.Text && person.password == txtPassword.Text select person;
            if (query.Any())
            {
                PanelForm panelForm = new PanelForm();
                txtUserName.Text = "";
                txtPassword.Text = "";
                panelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı ad veya şifre hatalı.");
            }
        }
    }
}
