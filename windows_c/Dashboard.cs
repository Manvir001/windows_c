﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            finn_bruker obj = new finn_bruker();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)

        {
            advanced_settings obj = new advanced_settings();
            this.Hide();
            obj.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            reg_bruker obj = new reg_bruker();
            this.Hide();
            obj.Show();
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }
    }
}
