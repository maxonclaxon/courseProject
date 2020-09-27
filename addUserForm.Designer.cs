namespace BDidz
{
    partial class addUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUserForm));
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_license = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_bank = new System.Windows.Forms.TextBox();
            this.textBox_carNum = new System.Windows.Forms.TextBox();
            this.textBox_carModel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(12, 12);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(257, 20);
            this.textBox_login.TabIndex = 0;
            this.textBox_login.Text = "Логин";
            this.textBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(12, 38);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(257, 20);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "Пароль";
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_license
            // 
            this.textBox_license.Location = new System.Drawing.Point(12, 64);
            this.textBox_license.Name = "textBox_license";
            this.textBox_license.Size = new System.Drawing.Size(257, 20);
            this.textBox_license.TabIndex = 2;
            this.textBox_license.Text = "Права";
            this.textBox_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 90);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(257, 20);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.Text = "Имя";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(12, 116);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(257, 20);
            this.textBox_pass.TabIndex = 4;
            this.textBox_pass.Text = "Паспорт";
            this.textBox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(12, 142);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(257, 20);
            this.textBox_number.TabIndex = 5;
            this.textBox_number.Text = "Номер телефона";
            this.textBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_bank
            // 
            this.textBox_bank.Location = new System.Drawing.Point(12, 168);
            this.textBox_bank.Name = "textBox_bank";
            this.textBox_bank.Size = new System.Drawing.Size(257, 20);
            this.textBox_bank.TabIndex = 6;
            this.textBox_bank.Text = "Банковская карта";
            this.textBox_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_carNum
            // 
            this.textBox_carNum.Location = new System.Drawing.Point(12, 194);
            this.textBox_carNum.Name = "textBox_carNum";
            this.textBox_carNum.Size = new System.Drawing.Size(257, 20);
            this.textBox_carNum.TabIndex = 7;
            this.textBox_carNum.Text = "Номер машины";
            this.textBox_carNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_carModel
            // 
            this.textBox_carModel.Location = new System.Drawing.Point(12, 220);
            this.textBox_carModel.Name = "textBox_carModel";
            this.textBox_carModel.Size = new System.Drawing.Size(257, 20);
            this.textBox_carModel.TabIndex = 8;
            this.textBox_carModel.Text = "Модель машины";
            this.textBox_carModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_carModel);
            this.Controls.Add(this.textBox_carNum);
            this.Controls.Add(this.textBox_bank);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_license);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addUserForm";
            this.Text = "Регистрация пользователя";
            this.Load += new System.EventHandler(this.addUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_license;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_bank;
        private System.Windows.Forms.TextBox textBox_carNum;
        private System.Windows.Forms.TextBox textBox_carModel;
        private System.Windows.Forms.Button button1;
    }
}