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
    public partial class userSearchForm : Form
    {
        SqlConnection connection; 
        DataSet ds;
        SqlDataAdapter Adapter;
        string login = "";
        int deleteStatement = 0;
        public userSearchForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void userSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string query = "select top 1 P.Profile_login as 'Логин',  P.Profile_amount as 'Финансы', Own.Owner_fullName as 'Имя', Own.Owner_phoneNumber as 'Номер',Own.Owner_license as 'Номер прав', (select COUNT(Car_number)from Car where Car.Owner_license=Own.Owner_license) as 'Кол-во машин' from Profile as P join Owner as Own on Own.Profile_login=P.Profile_login join Car as C on C.Owner_license=Own.Owner_license where";
            int counter = 0;
            if (textBox_licence.Text != "номер прав") { if (counter > 0) query += " and "; query += " Own.Owner_license='" + textBox_licence.Text + "'"; counter++; };
            if (textBox_login.Text != "Логин") { if (counter > 0) query += " and "; query += " P.Profile_login = '" + textBox_login.Text+"'";counter++; }
            if (textBox_number.Text != "Номер телефона") { if (counter > 0) query += " and "; query += " Own.Owner_phoneNumber = '" + textBox_number.Text + "'"; counter++; }
            if(textBox_carNum.Text!="Номер машины") { if (counter > 0) query += " and "; query += " C.Car_number = '" + textBox_carNum.Text + "'"; counter++; }
            ds = new DataSet();
            Adapter = new SqlDataAdapter(query, connection);
            Adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0) { MessageBox.Show("пользователь не найден");return; }

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Show();
            button_addCar.Show();
            button_deleteCar.Show();
            button_deleteProfile.Show();
            login = dataGridView1.Rows[0].Cells[0].Value.ToString();
            query = "select car_model, car_number from Profile as P join Owner as Own on Own.Profile_login=P.Profile_login join Car as C on C.Owner_license=Own.Owner_license where P.Profile_login='"+login+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_carSelecting.Items.Add(reader.GetValue(0) + " " + reader.GetValue(1));
            }
            reader.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addCar_Click(object sender, EventArgs e)
        {

            AddNewCarForm newCar = new AddNewCarForm(dataGridView1.Rows[0].Cells[4].Value.ToString(), connection);
            newCar.ShowDialog();
        }

        private void button_deleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
           "Вы уверены? Аккаунт пользователя будет удален",
           "Подтверждение",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.No) return;
            string query = "deleteProfile";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login", login);
            cmd.BeginExecuteNonQuery();
            this.Close();
        }

        private void button_deleteCar_Click(object sender, EventArgs e)
        {
            if (deleteStatement == 0)
            {
                deleteStatement = 1;
                comboBox_carSelecting.Show();
            }
            else
            {
                if (comboBox_carSelecting.SelectedIndex < 0) { if (deleteStatement == 3) { comboBox_carSelecting.Hide(); deleteStatement = 0; } MessageBox.Show("Выберите машину для удаления!");  deleteStatement = 3;return; }
                DialogResult res = MessageBox.Show(
           "Вы уверены? Машина будет удалена с аккаунта пользователя",
           "Подтверждение",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
                if (res == DialogResult.No) return;
                string query = "deleteCar";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                string carnum = comboBox_carSelecting.Items[comboBox_carSelecting.SelectedIndex].ToString().Substring(comboBox_carSelecting.Items[comboBox_carSelecting.SelectedIndex].ToString().IndexOf(' '));
                carnum=carnum.Replace(" ", "");
                cmd.Parameters.AddWithValue("@carNum", carnum);
                cmd.BeginExecuteNonQuery();
                ds = new DataSet();
                query = "select top 1 P.Profile_login as 'Логин',  P.Profile_amount as 'Финансы', Own.Owner_fullName as 'Имя', Own.Owner_phoneNumber as 'Номер',Own.Owner_license as 'Номер прав', (select COUNT(Car_number)from Car where Car.Owner_license=Own.Owner_license) as 'Кол-во машин' from Profile as P join Owner as Own on Own.Profile_login=P.Profile_login join Car as C on C.Owner_license=Own.Owner_license where P.Profile_login = '"+login+"'";
                Adapter = new SqlDataAdapter(query, connection);
                Adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
