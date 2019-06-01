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
        MySqlCommand cmd;
        MySqlDataReader dr;

        void Fillcombo()
        {
            string Sql = "SELECT firstname FROM user";
            MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(Sql, con);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);

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
    }
}
