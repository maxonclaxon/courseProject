using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace BDidz
{
    public partial class admin_panel : Form
    {
        static string login;
        static string password;
        SqlConnection connection;
        DataSet ds;
        SqlDataAdapter Adapter;
        public admin_panel(string login, string password, SqlConnection connection)
        {
            InitializeComponent();
            login = login;
            password = password;
            this.connection = connection;
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            var query = "SELECT Address from Parking";
            SqlCommand Addresses = new SqlCommand(query, connection);
            SqlDataReader reader = Addresses.ExecuteReader();
            while (reader.Read())
            {
                comboBox_parkings.Items.Add(reader.GetValue(0));
            }
            reader.Close();
        }
        private void button_showProfiles_Click(object sender, EventArgs e)
        {
            showProfs();
        }
        private void showProfs()
        {
            string query = "SELECT Profile_login, Profile_type, Profile_blocked, Profile_amount FROM Profile ORDER BY Profile_login";
            ds = new DataSet();
            Adapter = new SqlDataAdapter(query, connection);
            Adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
        }
        private void button_freePlaces_Click(object sender, EventArgs e)
        {
            string query = "showFreePlaces";
            ds = new DataSet();
            Adapter = new SqlDataAdapter(query, connection);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (comboBox_parkings.SelectedIndex < 0) comboBox_parkings.SelectedIndex = 0;
            Adapter.SelectCommand.Parameters.AddWithValue("@address", comboBox_parkings.Items[comboBox_parkings.SelectedIndex].ToString());
            Adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Adapter.SelectCommand.CommandType = CommandType.Text;
        }

        private void button_searchProfile_Click(object sender, EventArgs e)
        {
            userSearchForm search = new userSearchForm(connection);
            search.ShowDialog();
            search.Close();
            search.Dispose();
        }

        private void button_addUser_Click(object sender, EventArgs e)
        {
            addUserForm addform = new addUserForm(connection);
            addform.ShowDialog();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = dataGridView1.CurrentRow.Index;
            int indexcell = dataGridView1.CurrentCell.ColumnIndex;
            string login = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            bool profType = (bool)dataGridView1.Rows[indexrow].Cells[1].Value;
            bool blocked = (bool)dataGridView1.Rows[indexrow].Cells[2].Value;
            float amountt = 0;
            string amount = dataGridView1.Rows[indexrow].Cells[3].Value.ToString();
            if (amount.Contains(','))
            {
                string []args = amount.Split(',');
                if (args.Length > 2)
                {
                    for(int i = 2; i < args.Length; i++)
                    {
                        args[1] += args[i];
                    }
                }
                int len = args[1].Length;
                int val1;
                int.TryParse(string.Join("", args[0].Where(c => char.IsDigit(c))), out val1);
                int val2;
                int.TryParse(string.Join("", args[1].Where(c => char.IsDigit(c))), out val2);
                float num = (float)val2/((float)Math.Pow(10, len));
                amountt = val1;
                amountt+= num;
                
            }
            else
            {
                int val;
                int.TryParse(string.Join("", dataGridView1.Rows[indexrow].Cells[3].Value.ToString().Where(c => char.IsDigit(c))), out val);
                amountt = val;
            }


            SqlCommand update = new SqlCommand("changeProfileInfo", connection);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@login", login);
            update.Parameters.AddWithValue("@type", profType);
            update.Parameters.AddWithValue("@blocked", blocked);
            update.Parameters.AddWithValue("@amount", amountt);
            update.ExecuteNonQuery();
        }
    }
}
