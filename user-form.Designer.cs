namespace BDidz
{
    partial class user_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_form));
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.comboBox_cars = new System.Windows.Forms.ComboBox();
            this.button_park = new System.Windows.Forms.Button();
            this.label_car = new System.Windows.Forms.Label();
            this.label_parkUntill = new System.Windows.Forms.Label();
            this.label_parkUntillTime = new System.Windows.Forms.Label();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.textBox_addToValue_Card = new System.Windows.Forms.TextBox();
            this.textBox_AddToAmount = new System.Windows.Forms.TextBox();
            this.button_addToBalance = new System.Windows.Forms.Button();
            this.label_addToValue1 = new System.Windows.Forms.Label();
            this.label_addToValue2 = new System.Windows.Forms.Label();
            this.label_parkingPlace = new System.Windows.Forms.Label();
            this.label_ParkingTimeRemeaning = new System.Windows.Forms.Label();
            this.comboBox_Parkings = new System.Windows.Forms.ComboBox();
            this.label_Parking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(12, 13);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Остаток на счёте:";
            // 
            // label_amount
            // 
            this.label_amount.Location = new System.Drawing.Point(250, 5);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(95, 21);
            this.label_amount.TabIndex = 2;
            this.label_amount.Text = "value";
            this.label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_cars
            // 
            this.comboBox_cars.FormattingEnabled = true;
            this.comboBox_cars.Location = new System.Drawing.Point(12, 43);
            this.comboBox_cars.Name = "comboBox_cars";
            this.comboBox_cars.Size = new System.Drawing.Size(131, 21);
            this.comboBox_cars.TabIndex = 3;
            this.comboBox_cars.Text = "Выберите машину";
            this.comboBox_cars.SelectedValueChanged += new System.EventHandler(this.comboBox_cars_SelectedValueChanged);
            // 
            // button_park
            // 
            this.button_park.Location = new System.Drawing.Point(12, 70);
            this.button_park.Name = "button_park";
            this.button_park.Size = new System.Drawing.Size(131, 20);
            this.button_park.TabIndex = 4;
            this.button_park.Text = "Поставить на стоянку";
            this.button_park.UseVisualStyleBackColor = true;
            this.button_park.Click += new System.EventHandler(this.button_park_Click);
            // 
            // label_car
            // 
            this.label_car.AutoSize = true;
            this.label_car.Location = new System.Drawing.Point(12, 46);
            this.label_car.Name = "label_car";
            this.label_car.Size = new System.Drawing.Size(48, 13);
            this.label_car.TabIndex = 5;
            this.label_car.Text = "Машина";
            // 
            // label_parkUntill
            // 
            this.label_parkUntill.AutoSize = true;
            this.label_parkUntill.Location = new System.Drawing.Point(161, 91);
            this.label_parkUntill.Name = "label_parkUntill";
            this.label_parkUntill.Size = new System.Drawing.Size(64, 13);
            this.label_parkUntill.TabIndex = 6;
            this.label_parkUntill.Text = "Стоянка до";
            this.label_parkUntill.Visible = false;
            // 
            // label_parkUntillTime
            // 
            this.label_parkUntillTime.Location = new System.Drawing.Point(146, 104);
            this.label_parkUntillTime.Name = "label_parkUntillTime";
            this.label_parkUntillTime.Size = new System.Drawing.Size(142, 26);
            this.label_parkUntillTime.TabIndex = 7;
            this.label_parkUntillTime.Text = "Стоянка до";
            this.label_parkUntillTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_parkUntillTime.Visible = false;
            // 
            // textBox_hours
            // 
            this.textBox_hours.Location = new System.Drawing.Point(149, 68);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(127, 20);
            this.textBox_hours.TabIndex = 8;
            this.textBox_hours.Text = "На сколько часов";
            this.textBox_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_hours.Visible = false;
            this.textBox_hours.TextChanged += new System.EventHandler(this.textBox_hours_TextChanged);
            this.textBox_hours.Enter += new System.EventHandler(this.textBox_hours_Enter);
            this.textBox_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hours_KeyPress);
            this.textBox_hours.Leave += new System.EventHandler(this.textBox_hours_Leave);
            // 
            // label_cost
            // 
            this.label_cost.Location = new System.Drawing.Point(146, 104);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(130, 44);
            this.label_cost.TabIndex = 9;
            this.label_cost.Text = "Стоимость";
            this.label_cost.Visible = false;
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_balance.Location = new System.Drawing.Point(250, 25);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(99, 13);
            this.label_balance.TabIndex = 10;
            this.label_balance.Text = "пополнить баланс";
            this.label_balance.Visible = false;
            this.label_balance.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_addToValue_Card
            // 
            this.textBox_addToValue_Card.Location = new System.Drawing.Point(83, 211);
            this.textBox_addToValue_Card.Name = "textBox_addToValue_Card";
            this.textBox_addToValue_Card.Size = new System.Drawing.Size(193, 20);
            this.textBox_addToValue_Card.TabIndex = 11;
            this.textBox_addToValue_Card.Visible = false;
            // 
            // textBox_AddToAmount
            // 
            this.textBox_AddToAmount.Location = new System.Drawing.Point(83, 261);
            this.textBox_AddToAmount.Name = "textBox_AddToAmount";
            this.textBox_AddToAmount.Size = new System.Drawing.Size(193, 20);
            this.textBox_AddToAmount.TabIndex = 12;
            this.textBox_AddToAmount.Visible = false;
            // 
            // button_addToBalance
            // 
            this.button_addToBalance.Location = new System.Drawing.Point(83, 303);
            this.button_addToBalance.Name = "button_addToBalance";
            this.button_addToBalance.Size = new System.Drawing.Size(193, 45);
            this.button_addToBalance.TabIndex = 13;
            this.button_addToBalance.Text = "Пополнить баланс!";
            this.button_addToBalance.UseVisualStyleBackColor = true;
            this.button_addToBalance.Visible = false;
            this.button_addToBalance.Click += new System.EventHandler(this.button_addToBalance_Click);
            // 
            // label_addToValue1
            // 
            this.label_addToValue1.Location = new System.Drawing.Point(80, 195);
            this.label_addToValue1.Name = "label_addToValue1";
            this.label_addToValue1.Size = new System.Drawing.Size(196, 13);
            this.label_addToValue1.TabIndex = 14;
            this.label_addToValue1.Text = "Номер карты";
            this.label_addToValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_addToValue1.Visible = false;
            // 
            // label_addToValue2
            // 
            this.label_addToValue2.Location = new System.Drawing.Point(80, 245);
            this.label_addToValue2.Name = "label_addToValue2";
            this.label_addToValue2.Size = new System.Drawing.Size(196, 13);
            this.label_addToValue2.TabIndex = 15;
            this.label_addToValue2.Text = "Сумма пополнения";
            this.label_addToValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_addToValue2.Visible = false;
            // 
            // label_parkingPlace
            // 
            this.label_parkingPlace.AutoSize = true;
            this.label_parkingPlace.Location = new System.Drawing.Point(25, 156);
            this.label_parkingPlace.Name = "label_parkingPlace";
            this.label_parkingPlace.Size = new System.Drawing.Size(106, 13);
            this.label_parkingPlace.TabIndex = 16;
            this.label_parkingPlace.Text = "парковочное место";
            // 
            // label_ParkingTimeRemeaning
            // 
            this.label_ParkingTimeRemeaning.AutoSize = true;
            this.label_ParkingTimeRemeaning.Location = new System.Drawing.Point(25, 182);
            this.label_ParkingTimeRemeaning.Name = "label_ParkingTimeRemeaning";
            this.label_ParkingTimeRemeaning.Size = new System.Drawing.Size(88, 13);
            this.label_ParkingTimeRemeaning.TabIndex = 17;
            this.label_ParkingTimeRemeaning.Text = "Осталось часов";
            // 
            // comboBox_Parkings
            // 
            this.comboBox_Parkings.FormattingEnabled = true;
            this.comboBox_Parkings.Location = new System.Drawing.Point(149, 41);
            this.comboBox_Parkings.Name = "comboBox_Parkings";
            this.comboBox_Parkings.Size = new System.Drawing.Size(127, 21);
            this.comboBox_Parkings.TabIndex = 18;
            this.comboBox_Parkings.Text = "Выберите Парковку";
            this.comboBox_Parkings.Visible = false;
            // 
            // label_Parking
            // 
            this.label_Parking.AutoSize = true;
            this.label_Parking.Location = new System.Drawing.Point(25, 135);
            this.label_Parking.Name = "label_Parking";
            this.label_Parking.Size = new System.Drawing.Size(57, 13);
            this.label_Parking.TabIndex = 19;
            this.label_Parking.Text = "Парковка";
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 355);
            this.Controls.Add(this.label_Parking);
            this.Controls.Add(this.comboBox_Parkings);
            this.Controls.Add(this.label_ParkingTimeRemeaning);
            this.Controls.Add(this.label_parkingPlace);
            this.Controls.Add(this.label_addToValue2);
            this.Controls.Add(this.label_addToValue1);
            this.Controls.Add(this.button_addToBalance);
            this.Controls.Add(this.textBox_AddToAmount);
            this.Controls.Add(this.textBox_addToValue_Card);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.textBox_hours);
            this.Controls.Add(this.label_parkUntillTime);
            this.Controls.Add(this.label_parkUntill);
            this.Controls.Add(this.label_car);
            this.Controls.Add(this.button_park);
            this.Controls.Add(this.comboBox_cars);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "user_form";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.user_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.ComboBox comboBox_cars;
        private System.Windows.Forms.Button button_park;
        private System.Windows.Forms.Label label_car;
        private System.Windows.Forms.Label label_parkUntill;
        private System.Windows.Forms.Label label_parkUntillTime;
        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.TextBox textBox_addToValue_Card;
        private System.Windows.Forms.TextBox textBox_AddToAmount;
        private System.Windows.Forms.Button button_addToBalance;
        private System.Windows.Forms.Label label_addToValue1;
        private System.Windows.Forms.Label label_addToValue2;
        private System.Windows.Forms.Label label_parkingPlace;
        private System.Windows.Forms.Label label_ParkingTimeRemeaning;
        private System.Windows.Forms.ComboBox comboBox_Parkings;
        private System.Windows.Forms.Label label_Parking;
    }
}