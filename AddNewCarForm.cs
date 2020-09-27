using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDidz
{
    public partial class AddNewCarForm : Form
    {
        string license = "";
        SqlConnection connection;
        public AddNewCarForm(string license, SqlConnection connection)
        {
            InitializeComponent();
            this.license = license;
            this.connection = connection;
        }

        private void AddNewCarForm_Load(object sender, EventArgs e)
        {

        }

        private void button_addCar_Click(object sender, EventArgs e)
        {
            if (textBox_carNum.Text != "Номер машины"&&textBox_carModel.Text!= "Модель машины")
            {
                string query = "select * from Car where Car_number="+ textBox_carNum.Text.ToString();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader read = cmd.ExecuteReader();
                int counter=0;
                while (read.Read())
                {
                    counter++;
                }
                read.Close();
                if (counter > 0) { MessageBox.Show("Данная машина уже зарегистрирована!");return; }
                query = "addNewCar";
                cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@carNumber", textBox_carNum.Text.ToString());
                cmd.Parameters.AddWithValue("@carModel", textBox_carModel.Text.ToString());
                cmd.Parameters.AddWithValue("@license", license);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Машина добавлена!");


            }
            else
            {
                textBox_carNum.BackColor = Color.DarkOrange;
                textBox_carModel.BackColor = Color.DarkOrange;
            }
        }
    }
}
