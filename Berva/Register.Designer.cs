
namespace Berva
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAdmin.Location = new System.Drawing.Point(106, 126);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(141, 36);
            this.btnAddAdmin.TabIndex = 10;
            this.btnAddAdmin.Text = "Kayıt Ol";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(57, 64);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(37, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Şifre:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(17, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 13);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Kullanıcı Adı:";
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Location = new System.Drawing.Point(106, 92);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(141, 20);
            this.txtPasswordAgain.TabIndex = 13;
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordAgain.Location = new System.Drawing.Point(16, 99);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(81, 13);
            this.lblPasswordAgain.TabIndex = 14;
            this.lblPasswordAgain.Text = "Şifre Tekrarı:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(269, 182);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.lblPasswordAgain);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.Label lblPasswordAgain;
    }
}