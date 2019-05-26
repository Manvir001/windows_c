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

        //MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;password=2b9affd9; database=d304238");
        //MySqlCommand cmd;
        //MySqlDataReader dr;

        /*private String getUsername()
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
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("user id=d304238;server=mysql02.fastname.no;database=d304238;persistsecurityinfo=True;password=2b9affd9");
            MySqlDataAdapter mda = new MySqlDataAdapter("Select count(*) From user Where id ='" + textBox2.Text + "' and password ='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            mda.Fill(dt);

            if (dt.Rows[0][0].ToString() != "1")
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