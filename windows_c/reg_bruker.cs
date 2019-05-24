using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace windows_c
{
    public partial class reg_bruker : Form
    {
        public reg_bruker()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            finn_bruker  obj = new finn_bruker();
            this.Hide();
            obj.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MySqlConnection dataConnection = new MySqlConnection();
            dataConnection.ConnectionString = "server=localhost;user id=root;database=workito_db";
            dataConnection.Open();
            MySqlTransaction transakcija = dataConnection.BeginTransaction();
            MySqlCommand dataCommand = new MySqlCommand();
            dataCommand.Connection = dataConnection;
            dataCommand.Transaction = transakcija;
            try
            {
                dataCommand.CommandText = "Insert INTO user (firstname, lastname, email, password, Department_name, Role_name ) VALUES (@firstname, @lastname, @email, @password, @Department_name, @Role_name)";
                //dataCommand.CommandText = "Insert INTO user (username, password ) VALUES (@username, @password)";
                dataCommand.CommandType = CommandType.Text;
                dataCommand.Parameters.AddWithValue("@firstname", this.FirstNameBox.Text);
                dataCommand.Parameters.AddWithValue("@lastname", this.LastnameBox.Text);
                dataCommand.Parameters.AddWithValue("@email", this.Email.Text);
                dataCommand.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
                dataCommand.Parameters.AddWithValue("@password", this.PassBox2.Text);
                dataCommand.Parameters.AddWithValue("@Department_name", this.PassBox2.Text);
                dataCommand.Parameters.AddWithValue("@Role_name", this.PassBox2.Text);
                dataCommand.ExecuteNonQuery();
                transakcija.Commit();
                MessageBox.Show("Registration Successfull");
            }
            catch (Exception eks)
            {
                transakcija.Rollback();
                MessageBox.Show("Registration Error\n" + eks.Message);
            }
            finally
            {
                dataCommand.Connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
