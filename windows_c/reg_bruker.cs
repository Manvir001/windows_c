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
            Fillcombo();
            Fillcombo2();
        }

        MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
        MySqlCommand cmd;
        MySqlDataReader dr;


        void Fillcombo()
        {
            string Sql = "SELECT name FROM department";
            MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

            }
        }


        void Fillcombo2()
        {
            string Sql = "SELECT name FROM role";
            MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox2.Items.Add(DR[0]);

            }
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
            dataConnection.ConnectionString = "server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9";
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
                dataCommand.Parameters.AddWithValue("@email", this.EmailBox.Text);
                //dataCommand.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
                dataCommand.Parameters.AddWithValue("@password", this.PassBox2.Text);
                dataCommand.Parameters.AddWithValue("@Department_name", this.comboBox1.Text);
                dataCommand.Parameters.AddWithValue("@Role_name", this.comboBox2.Text);
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
            //textbox clear
            FirstNameBox.Text = "";
            LastnameBox.Text = "";
            EmailBox.Text = "";
            PassBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PassBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reg_bruker_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            advanced_settings obj = new advanced_settings();
            this.Hide();
            obj.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            project obj = new project();
            this.Hide();
            obj.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
