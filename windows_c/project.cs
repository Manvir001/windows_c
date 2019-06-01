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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
        MySqlCommand cmd;
        MySqlDataReader dr;


        private void Button1_Click(object sender, EventArgs e)
        {
            reg_bruker obj = new reg_bruker();
            this.Hide();
            obj.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            finn_bruker obj = new finn_bruker();
            this.Hide();
            obj.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            advanced_settings obj = new advanced_settings();
            this.Hide();
            obj.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
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
                    dataCommand.CommandText = "Insert INTO project (name, description) VALUES (@NameText, @DescriptionText)";
                    // dataCommand.CommandText = "Insert INTO role (name, description) VALUES (@RoleText, @RoleDescriptionText)";
                    //dataCommand.CommandText = "Insert INTO permission (name, description) VALUES (@PermissionNameText, @PermissionText)";
                    //dataCommand.CommandText = "Insert INTO user (username, password ) VALUES (@username, @password)";
                    dataCommand.CommandType = CommandType.Text;
                    //dataCommand.Parameters.AddWithValue("@firstname", this.FirstNameBox.Text);
                    // dataCommand.Parameters.AddWithValue("@lastname", this.LastnameBox.Text);
                    //dataCommand.Parameters.AddWithValue("@email", this.EmailBox.Text);
                    //dataCommand.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
                    //dataCommand.Parameters.AddWithValue("@password", this.PassBox2.Text);
                    dataCommand.Parameters.AddWithValue("@NameText", this.NameText.Text);
                    dataCommand.Parameters.AddWithValue("@DescriptionText", this.DescriptionText.Text);
                    //dataCommand.Parameters.AddWithValue("@RoleText", this.RoleText.Text);
                    //dataCommand.Parameters.AddWithValue("@RoleDescriptionText", this.RoleDescriptionText.Text);
                    // dataCommand.Parameters.AddWithValue("@PermissionText", this.PermissionText.Text);
                    // dataCommand.Parameters.AddWithValue("@PermissionNameText", this.PermissionNameText.Text);

                    
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
                NameText.Text = "";
                DescriptionText.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
