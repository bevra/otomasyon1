
namespace Berva
{
    partial class CustomersForm
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(18, 43);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Müşterinin Adı:";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerSurname.Location = new System.Drawing.Point(-2, 76);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(111, 13);
            this.lblCustomerSurname.TabIndex = 5;
            this.lblCustomerSurname.Text = "Müşterinin Soyadı:";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(116, 69);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(141, 20);
            this.txtCustomerSurname.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(116, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(141, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(116, 101);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(141, 21);
            this.cmbCity.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(69, 104);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Şehir:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.Location = new System.Drawing.Point(116, 139);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(141, 36);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(118)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(276, 184);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.lblCustomerSurname);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}