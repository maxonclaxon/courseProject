namespace BDidz
{
    partial class userSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_licence = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_carNum = new System.Windows.Forms.TextBox();
            this.button_addCar = new System.Windows.Forms.Button();
            this.button_deleteProfile = new System.Windows.Forms.Button();
            this.button_deleteCar = new System.Windows.Forms.Button();
            this.comboBox_carSelecting = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите информацию для поиска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(448, 615);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_licence
            // 
            this.textBox_licence.Location = new System.Drawing.Point(418, 25);
            this.textBox_licence.Name = "textBox_licence";
            this.textBox_licence.Size = new System.Drawing.Size(100, 20);
            this.textBox_licence.TabIndex = 2;
            this.textBox_licence.Text = "номер прав";
            this.textBox_licence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(418, 51);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 3;
            this.textBox_login.Text = "Логин";
            this.textBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(418, 77);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 20);
            this.textBox_number.TabIndex = 5;
            this.textBox_number.Text = "Номер телефона";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 584);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // textBox_carNum
            // 
            this.textBox_carNum.Location = new System.Drawing.Point(418, 103);
            this.textBox_carNum.Name = "textBox_carNum";
            this.textBox_carNum.Size = new System.Drawing.Size(100, 20);
            this.textBox_carNum.TabIndex = 7;
            this.textBox_carNum.Text = "Номер машины";
            this.textBox_carNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_addCar
            // 
            this.button_addCar.Location = new System.Drawing.Point(767, 615);
            this.button_addCar.Name = "button_addCar";
            this.button_addCar.Size = new System.Drawing.Size(198, 23);
            this.button_addCar.TabIndex = 8;
            this.button_addCar.Text = "Добавить пользователю машину";
            this.button_addCar.UseVisualStyleBackColor = true;
            this.button_addCar.Visible = false;
            this.button_addCar.Click += new System.EventHandler(this.button_addCar_Click);
            // 
            // button_deleteProfile
            // 
            this.button_deleteProfile.Location = new System.Drawing.Point(12, 615);
            this.button_deleteProfile.Name = "button_deleteProfile";
            this.button_deleteProfile.Size = new System.Drawing.Size(137, 23);
            this.button_deleteProfile.TabIndex = 9;
            this.button_deleteProfile.Text = "Удалить пользователя";
            this.button_deleteProfile.UseVisualStyleBackColor = true;
            this.button_deleteProfile.Visible = false;
            this.button_deleteProfile.Click += new System.EventHandler(this.button_deleteProfile_Click);
            // 
            // button_deleteCar
            // 
            this.button_deleteCar.Location = new System.Drawing.Point(155, 615);
            this.button_deleteCar.Name = "button_deleteCar";
            this.button_deleteCar.Size = new System.Drawing.Size(137, 23);
            this.button_deleteCar.TabIndex = 10;
            this.button_deleteCar.Text = "Удалить машину";
            this.button_deleteCar.UseVisualStyleBackColor = true;
            this.button_deleteCar.Visible = false;
            this.button_deleteCar.Click += new System.EventHandler(this.button_deleteCar_Click);
            // 
            // comboBox_carSelecting
            // 
            this.comboBox_carSelecting.FormattingEnabled = true;
            this.comboBox_carSelecting.Location = new System.Drawing.Point(298, 617);
            this.comboBox_carSelecting.Name = "comboBox_carSelecting";
            this.comboBox_carSelecting.Size = new System.Drawing.Size(121, 21);
            this.comboBox_carSelecting.TabIndex = 11;
            this.comboBox_carSelecting.Text = "Выберите машину";
            this.comboBox_carSelecting.Visible = false;
            // 
            // userSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 650);
            this.Controls.Add(this.comboBox_carSelecting);
            this.Controls.Add(this.button_deleteCar);
            this.Controls.Add(this.button_deleteProfile);
            this.Controls.Add(this.button_addCar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_licence);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_carNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userSearchForm";
            this.Text = "Найти пользователя";
            this.Load += new System.EventHandler(this.userSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_licence;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_carNum;
        private System.Windows.Forms.Button button_addCar;
        private System.Windows.Forms.Button button_deleteProfile;
        private System.Windows.Forms.Button button_deleteCar;
        private System.Windows.Forms.ComboBox comboBox_carSelecting;
    }
}