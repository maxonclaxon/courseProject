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
    public partial class addUserForm : Form
    {
        SqlConnection connection;
        public addUserForm(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Profile where Profile_login = '" + textBox_login.Text+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int counter = 0;
            while (reader.Read())
            {
                counter++;
            }
            if(counter>0) { MessageBox.Show("Пользователь с таким логином уже существует"); return; }
            query = "Add_new_user";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter loginParam = new SqlParameter{ ParameterName = "@login", Value = textBox_login.Text};
            command.Parameters.Add(loginParam);

            SqlParameter PasswordParam = new SqlParameter{ ParameterName = "@password", Value = textBox_password.Text };
            command.Parameters.Add(PasswordParam);

            SqlParameter licenceParam = new SqlParameter{ ParameterName = "@license", Value = textBox_license.Text };
            command.Parameters.Add(licenceParam);

            SqlParameter fullnameParam = new SqlParameter { ParameterName = "@fullname", Value = textBox_name.Text };
            command.Parameters.Add(fullnameParam);

            SqlParameter passParam = new SqlParameter{ ParameterName = "@pass", Value = textBox_pass.Text };
            command.Parameters.Add(passParam);


            SqlParameter phoneParam = new SqlParameter { ParameterName = "@phonenumber", Value = textBox_number.Text };
            command.Parameters.Add(phoneParam);

            SqlParameter bankParam = new SqlParameter { ParameterName = "@bankcard", Value = textBox_bank.Text };
            command.Parameters.Add(bankParam);

            SqlParameter carNumParam = new SqlParameter { ParameterName = "@carnumber", Value = textBox_carNum.Text };
            command.Parameters.Add(carNumParam);

            SqlParameter carModParam = new SqlParameter {  ParameterName = "@carmodel", Value = textBox_carModel.Text };
            command.Parameters.Add(carModParam);

            var result = command.ExecuteNonQuery();
            MessageBox.Show("Пользователь добавлен!");
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {
            textBox_login.Text = "dmitry";
            textBox_password.Text = "Peskov";
            textBox_license.Text = "1234563256";
            textBox_name.Text = "Александр";
            textBox_pass.Text = "14125413591981582312984398";
            textBox_number.Text = "12345678923";
            textBox_bank.Text = "1029384758692847";
            textBox_carNum.Text = "123857293";
            textBox_carModel.Text = "subaru";
        }
    }
}
