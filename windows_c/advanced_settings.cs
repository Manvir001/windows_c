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
    public partial class advanced_settings : Form
    {
        public advanced_settings()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=mysql02.fastname.no;user id=d304238;persistsecurityinfo=True;database=d304238;password=2b9affd9");
        MySqlCommand cmd;
        MySqlDataReader dr;


        private void advanced_settings_Load(object sender, EventArgs e)
        {

        }

        private void DepartmentText_TextChanged(object sender, EventArgs e)
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
                dataCommand.CommandText = "Insert INTO department (name, description) VALUES (@DepartmentText, @DescriptionText)";
               // dataCommand.CommandText = "Insert INTO role (name, description) VALUES (@RoleText, @RoleDescriptionText)";
                //dataCommand.CommandText = "Insert INTO permission (name, description) VALUES (@PermissionNameText, @PermissionText)";
                //dataCommand.CommandText = "Insert INTO user (username, password ) VALUES (@username, @password)";
                dataCommand.CommandType = CommandType.Text;
                //dataCommand.Parameters.AddWithValue("@firstname", this.FirstNameBox.Text);
               // dataCommand.Parameters.AddWithValue("@lastname", this.LastnameBox.Text);
                //dataCommand.Parameters.AddWithValue("@email", this.EmailBox.Text);
                //dataCommand.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
                //dataCommand.Parameters.AddWithValue("@password", this.PassBox2.Text);
                dataCommand.Parameters.AddWithValue("@DepartmentText", this.DepartmentText.Text);
                dataCommand.Parameters.AddWithValue("@DescriptionText", this.DescriptionText.Text);
                dataCommand.Parameters.AddWithValue("@RoleText", this.RoleText.Text);
                dataCommand.Parameters.AddWithValue("@RoleDescriptionText", this.RoleDescriptionText.Text);
               // dataCommand.Parameters.AddWithValue("@PermissionText", this.PermissionText.Text);
               // dataCommand.Parameters.AddWithValue("@PermissionNameText", this.PermissionNameText.Text);
                dataCommand.ExecuteNonQuery();
                transakcija.Commit();
                MessageBox.Show("Department is successfully registered");
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
            DepartmentText.Text = "";
            DescriptionText.Text = "";
        }

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
            project obj = new project();
            this.Hide();
            obj.Show();
        }

        private void RegisterRoleButton_Click(object sender, EventArgs e)
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
                //dataCommand.CommandText = "Insert INTO department (name, description) VALUES (@DepartmentText, @DescriptionText)";
                dataCommand.CommandText = "Insert INTO role (name, description) VALUES (@RoleText, @RoleDescriptionText)";
                //dataCommand.CommandText = "Insert INTO permission (name, description) VALUES (@PermissionNameText, @PermissionText)";
                //dataCommand.CommandText = "Insert INTO user (username, password ) VALUES (@username, @password)";
                dataCommand.CommandType = CommandType.Text;
                //dataCommand.Parameters.AddWithValue("@firstname", this.FirstNameBox.Text);
                // dataCommand.Parameters.AddWithValue("@lastname", this.LastnameBox.Text);
                //dataCommand.Parameters.AddWithValue("@email", this.EmailBox.Text);
                //dataCommand.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
                //dataCommand.Parameters.AddWithValue("@password", this.PassBox2.Text);
                //dataCommand.Parameters.AddWithValue("@DepartmentText", this.DepartmentText.Text);
                //dataCommand.Parameters.AddWithValue("@DescriptionText", this.DescriptionText.Text);
                dataCommand.Parameters.AddWithValue("@RoleText", this.RoleText.Text);
                dataCommand.Parameters.AddWithValue("@RoleDescriptionText", this.RoleDescriptionText.Text);
                // dataCommand.Parameters.AddWithValue("@PermissionText", this.PermissionText.Text);
                // dataCommand.Parameters.AddWithValue("@PermissionNameText", this.PermissionNameText.Text);
                dataCommand.ExecuteNonQuery();
                transakcija.Commit();
                MessageBox.Show("Role is successfully registered");
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
            RoleText.Text = "";
            RoleDescriptionText.Text = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void DepartmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoleDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }
    }
}
