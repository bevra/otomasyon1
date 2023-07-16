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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        DbstokEntities db = new DbstokEntities(); 

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtPasswordAgain.Text.Trim() != "")
            {
                if(txtUserName.Text.Trim().Length < 4)
                {
                     MessageBox.Show("Kullanıcı adı minimum 4 karekter içermelidir.");
                    return;
                }

                if (txtPassword.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Şifre minimum 6 karekter içermelidir.");
                    return;
                }

                if (txtPassword.Text == txtPasswordAgain.Text)
                {
                    var findedAdmin = (from user in db.Admins where user.user_name == txtUserName.Text
                     select new
                     {
                        user.user_name,
                     }).FirstOrDefault();

                    if(findedAdmin == null)
                    {
                        Admins add = new Admins();

                        add.user_name = txtUserName.Text.Trim();
                        add.password = txtPassword.Text.Trim();


                        db.Admins.Add(add);
                        db.SaveChanges();
                        var message =  MessageBox.Show("Kullanıcı başarıyla kaydoldu", "Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                       
                        if (message == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten mevcut.");

                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                    txtPassword.Text = "";
                    txtPasswordAgain.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre alanları boş girilemez.");
            }
        }
    }
}
