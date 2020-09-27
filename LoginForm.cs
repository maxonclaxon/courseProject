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
using MaterialSkin.Controls;

namespace BDidz
{
    public partial class Form1 : MaterialForm 
    {
        public Form1()
        {
            InitializeComponent();
        }
        int statement;
        static string servername = "SQLEXPRESS";
        static string bdname = "bd_labs";
        string connectionString = @"Data Source=.\" + servername + ";Initial catalog=" + bdname + "; Integrated Security=True; MultipleActiveResultSets=True; ";
        SqlConnection connection;

        private void Form1_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                for(int i=0; i < 3; i++) { Console.Beep(); Thread.Sleep(200); Close();return; }
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string query = "getProfile";
            SqlCommand checkprofile = new SqlCommand(query, connection);
            checkprofile.CommandType = CommandType.StoredProcedure;
            checkprofile.Parameters.AddWithValue("@login", textBox_login.Text);
            checkprofile.Parameters.AddWithValue("@password", textBox_password.Text);
            SqlDataReader result = checkprofile.ExecuteReader();
            bool isLogged = false;
            while (result.Read())
            {
                var login = (string) result.GetValue(0);
                var password = (string) result.GetValue(1);
                bool type = (bool) result.GetValue(2);
                
                isLogged = true;
                if ((bool)result.GetValue(3) == true) { MessageBox.Show("Профиль заблокирован! Обратитесь к администратору"); return; }
                if (type == true) { admin_panel panel = new admin_panel(login,password,connection); result.Close(); this.Hide(); panel.ShowDialog(); this.Close(); return; }
                else { user_form userform = new user_form(login, password, connection); result.Close(); this.Hide();userform.ShowDialog();this.Close();  return; }             
            }
            if (!isLogged)
            {
                MessageBox.Show("Не верный логин и/или пароль");
                button1.Show();
            }
            result.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (statement == 0)
            {
                textBox_login.Text = "Введите номер телефона";
                textBox_password.PasswordChar = '\0';
                textBox_password.Text = "Введите номер вод. удост.";
                statement = 1;
                button_confirm.Enabled = false;
                return;
            }
            if (statement == 1)
            {
                if(textBox_login.Text!= "Введите номер телефона"&&textBox_password.Text!= "Введите номер вод. удост.")
                {
                    textBox_login.BackColor = Color.White;
                    textBox_password.BackColor = Color.White;
                    string query = "select Profile_password,Profile.Profile_login from Profile join Owner as O " +
                        "on O.Profile_login=Profile.Profile_login " +
                        "where O.Owner_license=" + textBox_password.Text + " and O.Owner_phoneNumber=" + textBox_login.Text;
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read()) { MessageBox.Show("Ваш логин: " + read.GetValue(1) + "\n Пароль: " + read.GetValue(0)); }
                    read.Close();
                    button_confirm.Enabled = true;
                    statement = 0;
                    textBox_password.PasswordChar = '*';
                    textBox_login.Text = "Логин";
                    textBox_password.Text = "Пароль";
                    button1.Hide();
                }
                else
                {
                    textBox_login.BackColor = Color.DarkOrange;
                    textBox_password.BackColor = Color.DarkOrange;
                }
            }
        }
    }
}
