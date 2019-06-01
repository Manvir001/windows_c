namespace windows_c
{
    partial class finn_bruker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finn_bruker));
            this.SøkLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DepartmentText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SøkLabel
            // 
            this.SøkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SøkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SøkLabel.Location = new System.Drawing.Point(360, 124);
            this.SøkLabel.Name = "SøkLabel";
            this.SøkLabel.Size = new System.Drawing.Size(242, 26);
            this.SøkLabel.TabIndex = 14;
            this.SøkLabel.Text = "Employees List:";
            this.SøkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SøkLabel.Click += new System.EventHandler(this.SøkLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Find Employee";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "Projects";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Advance Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(582, 471);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 47);
            this.button7.TabIndex = 8;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(363, 471);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 47);
            this.button8.TabIndex = 7;
            this.button8.Text = "Save Changes";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 72);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(363, 304);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(333, 20);
            this.LastnameBox.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LastName.Location = new System.Drawing.Point(363, 278);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(88, 23);
            this.LastName.TabIndex = 17;
            this.LastName.Text = "Last name";
            this.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(363, 255);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(333, 20);
            this.FirstNameBox.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstName.Location = new System.Drawing.Point(363, 229);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(88, 23);
            this.FirstName.TabIndex = 16;
            this.FirstName.Text = "First name";
            this.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(363, 206);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(333, 20);
            this.EmailBox.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Email.Location = new System.Drawing.Point(363, 180);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(88, 23);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassBox2
            // 
            this.PassBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PassBox2.Location = new System.Drawing.Point(363, 358);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.Size = new System.Drawing.Size(333, 20);
            this.PassBox2.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(363, 332);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(88, 23);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DepartmentText
            // 
            this.DepartmentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepartmentText.Location = new System.Drawing.Point(363, 380);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(122, 23);
            this.DepartmentText.TabIndex = 19;
            this.DepartmentText.Text = "Department:";
            this.DepartmentText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(543, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Role:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(363, 416);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(546, 416);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(843, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 56);
            this.button5.TabIndex = 57;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // finn_bruker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1017, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SøkLabel);
            this.Name = "finn_bruker";
            this.Text = "finn_bruker";
            this.Load += new System.EventHandler(this.Finn_bruker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label SøkLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox LastnameBox;
        internal System.Windows.Forms.Label LastName;
        internal System.Windows.Forms.TextBox FirstNameBox;
        internal System.Windows.Forms.Label FirstName;
        internal System.Windows.Forms.TextBox EmailBox;
        internal System.Windows.Forms.Label Email;
        internal System.Windows.Forms.TextBox PassBox2;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label DepartmentText;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Button button5;
    }
}