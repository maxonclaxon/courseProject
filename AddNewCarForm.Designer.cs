namespace BDidz
{
    partial class AddNewCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCarForm));
            this.textBox_carNum = new System.Windows.Forms.TextBox();
            this.textBox_carModel = new System.Windows.Forms.TextBox();
            this.button_addCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_carNum
            // 
            this.textBox_carNum.Location = new System.Drawing.Point(12, 12);
            this.textBox_carNum.Name = "textBox_carNum";
            this.textBox_carNum.Size = new System.Drawing.Size(249, 20);
            this.textBox_carNum.TabIndex = 0;
            this.textBox_carNum.Text = "Номер машины";
            this.textBox_carNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_carModel
            // 
            this.textBox_carModel.Location = new System.Drawing.Point(12, 60);
            this.textBox_carModel.Name = "textBox_carModel";
            this.textBox_carModel.Size = new System.Drawing.Size(249, 20);
            this.textBox_carModel.TabIndex = 1;
            this.textBox_carModel.Text = "Модель машины";
            this.textBox_carModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_addCar
            // 
            this.button_addCar.Location = new System.Drawing.Point(12, 267);
            this.button_addCar.Name = "button_addCar";
            this.button_addCar.Size = new System.Drawing.Size(249, 79);
            this.button_addCar.TabIndex = 3;
            this.button_addCar.Text = "Добавить машину";
            this.button_addCar.UseVisualStyleBackColor = true;
            this.button_addCar.Click += new System.EventHandler(this.button_addCar_Click);
            // 
            // AddNewCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 358);
            this.Controls.Add(this.button_addCar);
            this.Controls.Add(this.textBox_carModel);
            this.Controls.Add(this.textBox_carNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewCarForm";
            this.Text = "Добавление автомобиля";
            this.Load += new System.EventHandler(this.AddNewCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_carNum;
        private System.Windows.Forms.TextBox textBox_carModel;
        private System.Windows.Forms.Button button_addCar;
    }
}