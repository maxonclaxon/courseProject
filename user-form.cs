using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace BDidz
{
    public partial class user_form : Form
    {
        SqlConnection connection;
        string login;
        SqlCommand command;
        SqlDataReader reader;
        bool forgived = false;
        public user_form(string login, string password, SqlConnection connection)
        {
            this.connection = connection;
            this.login = login;
            TopMost = true;
            InitializeComponent();
        }
        private void getvalueinfo()
        {
            string query = "select Profile_amount, owner.Owner_fullName from Profile join Owner on owner.Profile_login=Profile.Profile_login where Profile.Profile_login='" + login + "'";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                label_amount.Text = reader.GetValue(0).ToString() + " Руб";
                label_name.Text = reader.GetValue(1).ToString();
                this.Text = "Пользователь "+label_name.Text;
            }
            reader.Close();
        }
        private void getCarInfo()
        {
            getvalueinfo();
            Thread.Sleep(200);
            string num = comboBox_cars.Items[comboBox_cars.SelectedIndex].ToString();
            num = num.Substring(num.IndexOf(' '));
            if (num.Contains(' ')) num = num.Replace(" ", "");
            string query = "getCarInfo";
            command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@carNum", num);
            reader = command.ExecuteReader();
            bool parked = false;
            while (reader.Read())
            {
                parked = true;
                label_parkUntill.Show();
                label_parkUntillTime.Text = reader.GetValue(0).ToString();
                label_parkUntillTime.Show();
                label_ParkingTimeRemeaning.Show();
                label_parkingPlace.Show();
                if (textBox_hours.Visible) textBox_hours.Hide();
                var a = (int)reader.GetValue(1);
                if ((int)reader.GetValue(1)>0)
                {
                    forgived = false;
                    button_park.Text = "Забрать досрочно";
                    if ((int)reader.GetValue(1) >60)
                    {
                        label_ParkingTimeRemeaning.Text = "Времени осталось:                 " + ((int)reader.GetValue(1) / 60).ToString() + "ч";
                    }
                    else label_ParkingTimeRemeaning.Text = "Времени осталось:                 " + ((int)reader.GetValue(1)).ToString() + "м";
                }
                else
                {
                    forgived = true;
                    button_park.Text = "Забрать машину";
                    label_ParkingTimeRemeaning.Text = "Вы опоздали на " + ((int)reader.GetValue(1)).ToString() + "м. Штраф: "+ (int)reader.GetValue(1)+" р";
                }
                label_parkingPlace.Text = "Ваше парковочное место: Место:" + reader.GetValue(2).ToString() + "  Этаж: " + reader.GetValue(3).ToString();
                int valueAmount;
                int.TryParse(string.Join("", label_ParkingTimeRemeaning.Text.Where(c => char.IsDigit(c))), out valueAmount);
                if (valueAmount < 120) { label_ParkingTimeRemeaning.BackColor = Color.DarkOrange;label_ParkingTimeRemeaning.Text = label_ParkingTimeRemeaning.Text + " Не забудьте забрать тс"; }
                else { label_ParkingTimeRemeaning.BackColor = Color.FromArgb(255, 240, 240, 240); }
                label_Parking.Text ="Парковка: "+ reader.GetValue(4).ToString();
                label_Parking.Show();
            }
            if (parked == false) {
                button_park.Text = "Поставить на стоянку";
                label_parkUntill.Hide();
                label_parkUntillTime.Hide();
                label_ParkingTimeRemeaning.Hide();
                label_parkingPlace.Hide();
                label_Parking.Hide();
            };
            reader.Close();
            command.CommandType = CommandType.Text;
        }
        void toggleBalance()
        {
            if (!button_addToBalance.Visible)
            {
                button_addToBalance.Show();
                label_addToValue1.Show();
                label_addToValue2.Show();
                textBox_addToValue_Card.Show();
                textBox_AddToAmount.Show();
            }
            else
            {
                button_addToBalance.Hide();
                label_addToValue1.Hide();
                label_addToValue2.Hide();
                textBox_addToValue_Card.Hide();
                textBox_AddToAmount.Hide();
            }
        }
        private void user_form_Load(object sender, EventArgs e)
        {
            
            string query = "getAccInfo";
            command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@login", login);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                if(i==0) label_car.Text = reader.GetValue(0).ToString()+" " + reader.GetValue(1).ToString();
                else if(i==1) { comboBox_cars.Items.Add(label_car.Text);label_car.Hide();comboBox_cars.Items.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString()); }
                else comboBox_cars.Items.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
                i++;
            }
            if (i == 1) { comboBox_cars.Items.Add(label_car.Text); comboBox_cars.Hide();}
            if (i == 0) label_car.Text = "Нет машин";
            reader.Close();

            if (i > 0)
            {
                comboBox_cars.SelectedIndex = 0;
                getCarInfo();
            }

            command.CommandType = CommandType.Text;
            query = "select Parking.Address from Parking";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Parkings.Items.Add(reader.GetValue(0));
            }
            reader.Close();
        }

        private void button_park_Click(object sender, EventArgs e)
        {
            if(button_park.Text== "Забрать досрочно"|| button_park.Text == "Забрать машину")
            {
                DialogResult res=DialogResult.Yes;
                if (button_park.Text == "Забрать досрочно")
                {
                    res = MessageBox.Show(
                "Вы уверены? Парковочное место будет потеряно. На ваш баланс вернется сумма равная кол-во неиспользованных часов * 2.5р",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                }
                

                if (res == DialogResult.Yes)
                {
                    string num = comboBox_cars.Items[comboBox_cars.SelectedIndex].ToString();
                    num = num.Substring(num.IndexOf(' '));
                    while (num.Contains(' ')) num = num.Replace(" ", "");
                    string query;
                    if (forgived) query = "unParkVehicleInTime"; else query = "unParkVehicle";
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@carNum", num);
                    command.ExecuteNonQuery();
                    command.CommandType = CommandType.Text;
                    label_parkUntill.Hide();
                    label_parkUntillTime.Hide();
                    label_Parking.Hide();
                    getCarInfo();
                    return;

                }
                else return;
            }
            else
            {
                if (!textBox_hours.Visible)
                {
                    textBox_hours.Show();
                    comboBox_Parkings.Show();
                }
                else
                {
                    if (comboBox_Parkings.SelectedIndex < 0) { MessageBox.Show("Выберите парковку!");return; };
                    string query = "showFreePlaces";
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@address", comboBox_Parkings.Items[comboBox_Parkings.SelectedIndex].ToString());
                    reader = command.ExecuteReader();
                    int counter=0;
                    while (reader.Read())
                    {
                        counter++;
                    }
                    reader.Close();
                    if (counter < 1) { MessageBox.Show("На данной парковке свободных мест нет!");return; }
                    DialogResult res = MessageBox.Show(
                        "Вы подтверждаете операцию? Вам будет выделенно парковочное место на " + textBox_hours.Text + " часов",
                        "Подтверждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    if (res == DialogResult.Yes)
                    {
                        string num = comboBox_cars.Items[comboBox_cars.SelectedIndex].ToString();
                        num = num.Substring(num.IndexOf(' '));
                        while (num.Contains(' ')) num = num.Replace(" ", "");
                        query = "Add_new_stand";
                        command = new SqlCommand(query, connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@car_number", num);
                        command.Parameters.AddWithValue("@time_to", textBox_hours.Text);
                        command.Parameters.AddWithValue("@Parking", comboBox_Parkings.SelectedIndex+1);
                        command.ExecuteNonQuery();
                        getCarInfo();
                        label_cost.Hide();
                        comboBox_Parkings.Hide();
                    }
                    else textBox_hours.Hide();
                }
            }
            getvalueinfo();

        }

        private void textBox_hours_TextChanged(object sender, EventArgs e)
        {
            if (textBox_hours.Text == "") return;
            label_cost.Show();
            label_cost.Text = Convert.ToInt32(textBox_hours.Text)>15? "Стоимость стоянки на "+textBox_hours.Text+ " часов с учетом скидки 20% будет " + Convert.ToInt32(textBox_hours.Text) * 5 * 0.8 : "Стоимость стоянки на " + textBox_hours.Text + " часов будет " + (Convert.ToInt32(textBox_hours.Text) * 5).ToString();
            double valueCost=0;
            if(Convert.ToInt32(textBox_hours.Text) * 5  < 16)
            {
                valueCost = Convert.ToInt32(textBox_hours.Text) * 5;
            }
            else
            {
                valueCost = Convert.ToInt32(textBox_hours.Text) * 5 * 0.8;
            }
            string amount = "";
            int valueAmount;
            if (label_amount.Text.Contains(','))
            {
                amount = label_amount.Text.Substring(0, label_amount.Text.IndexOf(','));
                int.TryParse(string.Join("", amount.Where(c => char.IsDigit(c))), out valueAmount);
            }
            
            else int.TryParse(string.Join("", label_amount.Text.Where(c => char.IsDigit(c))), out valueAmount);
            if (valueAmount < valueCost) { button_park.Enabled = false; label_balance.Show(); }
            else { button_park.Enabled = true; label_balance.Hide(); if (button_addToBalance.Visible) toggleBalance(); };
            
        }

        private void textBox_hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void comboBox_cars_SelectedValueChanged(object sender, EventArgs e)
        {
            getCarInfo();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            toggleBalance();
        }

        private void button_addToBalance_Click(object sender, EventArgs e)
        {
            if (!(textBox_AddToAmount.Text != "" && textBox_addToValue_Card.Text != "")) 
            {
                if (textBox_addToValue_Card.Text == "") textBox_addToValue_Card.BackColor = Color.FromArgb(239, 123, 123);
                else textBox_addToValue_Card.BackColor = Color.FromArgb(255, 255, 255);
                if(textBox_AddToAmount.Text=="") textBox_AddToAmount.BackColor = Color.FromArgb(239, 123, 123);
                else textBox_AddToAmount.BackColor = Color.FromArgb(255, 255, 255);
                return;
            };
            int valueAmount;
            int.TryParse(string.Join("", textBox_AddToAmount.Text.Where(c => char.IsDigit(c))), out valueAmount);
            string query = "addToBalance";
            command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@value", textBox_AddToAmount.Text);
            command.Parameters.AddWithValue("@login", login);
            command.ExecuteNonQuery();
            command.CommandType = CommandType.Text;
            getvalueinfo();
            toggleBalance();
            textBox_addToValue_Card.BackColor = Color.FromArgb(255, 255, 255);
            textBox_AddToAmount.BackColor = Color.FromArgb(255, 255, 255);
            MessageBox.Show("Баланс успешно пополнен!");
        }

        private void textBox_hours_Leave(object sender, EventArgs e)
        {
            label_cost.Hide();
        }

        private void textBox_hours_Enter(object sender, EventArgs e)
        {
            label_cost.Show();
        }
    }
}
