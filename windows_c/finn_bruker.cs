using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_c
{
    public partial class finn_bruker : Form
    {
        public finn_bruker()
        {
            
            InitializeComponent();
            Fillcombo();
        }

        MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
        //MySqlCommand cmd;
        //MySqlDataReader dr;

        void Fillcombo()
        {

            //comboBox1.Items.Clear();
            //string Sql = "SELECT CONCAT(id,'--',lastname,', ',firstname) AS name FROM user";

            
           // MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
            con.Open();
            string Sql = "SELECT * FROM user";
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {

                string name = DR.GetString(0);
                comboBox1.Items.Add(name);
            }
            con.Close();
        }

        void Fillcombo1()
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

        private void SøkLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg_bruker obj = new reg_bruker();
            this.Hide();
            obj.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            advanced_settings obj = new advanced_settings();
            this.Hide();
            obj.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM user WHERE id = '" + comboBox1.SelectedItem + "'";
            MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {

                //string sid = DR.GetInt32(0).ToString();
                string sFirstname = DR.GetString(1);
                string sLastname = DR.GetString(2);
                string sEmail = DR.GetString(3);
                string sPassword = DR.GetString(4);
                string sDepartmentname = DR.GetString(5);
                string SRolename = DR.GetString(6);

                FirstNameBox.Text = sFirstname;
                LastnameBox.Text = sLastname;
                EmailBox.Text = sEmail;
                PassBox2.Text = sPassword;
                comboBox3.Text = sDepartmentname;
                comboBox2.Text = SRolename;

            }
        } 

        private void Finn_bruker_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            project obj = new project();
            this.Hide();
            obj.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
             {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete FROM user WHERE id='" + comboBox1.SelectedItem + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record deleted successfully");
                    }
            //textbox clear
          
            comboBox1.Text = "";
            FirstNameBox.Text = "";
            LastnameBox.Text = "";
            EmailBox.Text = "";
            PassBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
            

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE user SET firstname='"+FirstNameBox.Text+"', lastname='"+ LastnameBox.Text + "', email='"+ EmailBox.Text + "',  password='"+ PassBox2.Text + "', Department_name='"+comboBox3.Text+"', Role_name='"+ comboBox2.Text + "' WHERE id='" + comboBox1.SelectedItem + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record updated successfully");
                FirstNameBox.Text = "";
                LastnameBox.Text = "";
                PassBox2.Text = "";
                EmailBox.Text = "";

            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }
    }
}
