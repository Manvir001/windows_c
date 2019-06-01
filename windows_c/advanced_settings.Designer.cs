namespace windows_c
{
    partial class advanced_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(advanced_settings));
            this.button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.DepartmentText = new System.Windows.Forms.TextBox();
            this.RoleText = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RoleDescriptionLabel = new System.Windows.Forms.Label();
            this.RoleDescriptionText = new System.Windows.Forms.TextBox();
            this.RegisterRoleButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "Advance Settings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(41, 302);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(108, 42);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "Projects";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(41, 237);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(108, 42);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "Find Employee";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(41, 170);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 42);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Register Employee";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RoleLabel
            // 
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoleLabel.Location = new System.Drawing.Point(611, 179);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(147, 35);
            this.RoleLabel.TabIndex = 13;
            this.RoleLabel.Text = "Name new role:";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepartmentLabel.Location = new System.Drawing.Point(240, 179);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(173, 35);
            this.DepartmentLabel.TabIndex = 11;
            this.DepartmentLabel.Text = "Name new department:";
            this.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DepartmentLabel.Click += new System.EventHandler(this.DepartmentLabel_Click);
            // 
            // DepartmentText
            // 
            this.DepartmentText.Location = new System.Drawing.Point(243, 217);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(333, 20);
            this.DepartmentText.TabIndex = 0;
            this.DepartmentText.TextChanged += new System.EventHandler(this.DepartmentText_TextChanged);
            // 
            // RoleText
            // 
            this.RoleText.Location = new System.Drawing.Point(614, 217);
            this.RoleText.Name = "RoleText";
            this.RoleText.Size = new System.Drawing.Size(333, 20);
            this.RoleText.TabIndex = 3;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(463, 362);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(114, 47);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register Department";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(244, 286);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(333, 20);
            this.DescriptionText.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptionLabel.Location = new System.Drawing.Point(241, 255);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(86, 24);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Description:";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoleDescriptionLabel
            // 
            this.RoleDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoleDescriptionLabel.Location = new System.Drawing.Point(611, 255);
            this.RoleDescriptionLabel.Name = "RoleDescriptionLabel";
            this.RoleDescriptionLabel.Size = new System.Drawing.Size(86, 24);
            this.RoleDescriptionLabel.TabIndex = 14;
            this.RoleDescriptionLabel.Text = "Description:";
            this.RoleDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoleDescriptionLabel.Click += new System.EventHandler(this.RoleDescriptionLabel_Click);
            // 
            // RoleDescriptionText
            // 
            this.RoleDescriptionText.Location = new System.Drawing.Point(614, 286);
            this.RoleDescriptionText.Name = "RoleDescriptionText";
            this.RoleDescriptionText.Size = new System.Drawing.Size(333, 20);
            this.RoleDescriptionText.TabIndex = 4;
            // 
            // RegisterRoleButton
            // 
            this.RegisterRoleButton.Location = new System.Drawing.Point(833, 362);
            this.RegisterRoleButton.Name = "RegisterRoleButton";
            this.RegisterRoleButton.Size = new System.Drawing.Size(114, 47);
            this.RegisterRoleButton.TabIndex = 5;
            this.RegisterRoleButton.Text = "Register Role";
            this.RegisterRoleButton.UseVisualStyleBackColor = true;
            this.RegisterRoleButton.Click += new System.EventHandler(this.RegisterRoleButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(843, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 56);
            this.button6.TabIndex = 10;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 72);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // advanced_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1017, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.RegisterRoleButton);
            this.Controls.Add(this.RoleDescriptionText);
            this.Controls.Add(this.RoleDescriptionLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RoleText);
            this.Controls.Add(this.DepartmentText);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "advanced_settings";
            this.Text = "Advanced Settings";
            this.Load += new System.EventHandler(this.advanced_settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label RoleLabel;
        internal System.Windows.Forms.Label DepartmentLabel;
        internal System.Windows.Forms.TextBox DepartmentText;
        internal System.Windows.Forms.TextBox RoleText;
        private System.Windows.Forms.Button RegisterButton;
        internal System.Windows.Forms.TextBox DescriptionText;
        internal System.Windows.Forms.Label DescriptionLabel;
        internal System.Windows.Forms.Label RoleDescriptionLabel;
        internal System.Windows.Forms.TextBox RoleDescriptionText;
        private System.Windows.Forms.Button RegisterRoleButton;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}