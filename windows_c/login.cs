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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=workito_db");
        MySqlCommand cmd;
        MySqlDataReader dr;

        private String getUsername()
        {
            //fetch data from the database
            con.Open();
            String syntax = "SELECT id FROM user";
            cmd = new MySqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private String getPassword()
        {
            //fetch data from the database
            con.Open();
            String syntax = "SELECT password FROM user";
            cmd = new MySqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUsername();
            String Uname = getUsername(), Upass = getPassword(), name, password;
            name = textBox1.Text;
            password = textBox2.Text;

            if (name.Equals(Uname) && password.Equals(Upass))
            {
                //login
                label4.Hide();
                Form1 obj = new Form1();
                this.Hide();
                obj.Show();
            }
            else
            {
                //login failed
                label4.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
