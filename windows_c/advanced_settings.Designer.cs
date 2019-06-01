﻿namespace windows_c
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
            this.Button5 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Lucida Calligraphy", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button5.Location = new System.Drawing.Point(0, 0);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(548, 138);
            this.Button5.TabIndex = 14;
            this.Button5.Text = "WORKITO";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(860, 146);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 66);
            this.button4.TabIndex = 21;
            this.button4.Text = "Advance Settings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(614, 148);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(182, 65);
            this.Button3.TabIndex = 20;
            this.Button3.Text = "Projects";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(376, 148);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(182, 65);
            this.Button2.TabIndex = 19;
            this.Button2.Text = "Find Employee";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(130, 148);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(182, 65);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Register Employee";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RoleLabel
            // 
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoleLabel.Location = new System.Drawing.Point(609, 249);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(140, 54);
            this.RoleLabel.TabIndex = 34;
            this.RoleLabel.Text = "New Role:";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepartmentLabel.Location = new System.Drawing.Point(130, 249);
            this.DepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(160, 54);
            this.DepartmentLabel.TabIndex = 33;
            this.DepartmentLabel.Text = "New Department:";
            this.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DepartmentText
            // 
            this.DepartmentText.Location = new System.Drawing.Point(130, 334);
            this.DepartmentText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepartmentText.Name = "DepartmentText";
            this.DepartmentText.Size = new System.Drawing.Size(328, 26);
            this.DepartmentText.TabIndex = 35;
            this.DepartmentText.TextChanged += new System.EventHandler(this.DepartmentText_TextChanged);
            // 
            // RoleText
            // 
            this.RoleText.Location = new System.Drawing.Point(614, 334);
            this.RoleText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoleText.Name = "RoleText";
            this.RoleText.Size = new System.Drawing.Size(328, 26);
            this.RoleText.TabIndex = 36;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(290, 525);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(171, 72);
            this.RegisterButton.TabIndex = 37;
            this.RegisterButton.Text = "Register Department";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(130, 440);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(328, 26);
            this.DescriptionText.TabIndex = 38;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptionLabel.Location = new System.Drawing.Point(130, 382);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(129, 38);
            this.DescriptionLabel.TabIndex = 39;
            this.DescriptionLabel.Text = "Description:";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoleDescriptionLabel
            // 
            this.RoleDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoleDescriptionLabel.Location = new System.Drawing.Point(609, 382);
            this.RoleDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleDescriptionLabel.Name = "RoleDescriptionLabel";
            this.RoleDescriptionLabel.Size = new System.Drawing.Size(129, 38);
            this.RoleDescriptionLabel.TabIndex = 40;
            this.RoleDescriptionLabel.Text = "Description:";
            this.RoleDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoleDescriptionText
            // 
            this.RoleDescriptionText.Location = new System.Drawing.Point(614, 440);
            this.RoleDescriptionText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoleDescriptionText.Name = "RoleDescriptionText";
            this.RoleDescriptionText.Size = new System.Drawing.Size(328, 26);
            this.RoleDescriptionText.TabIndex = 41;
            // 
            // RegisterRoleButton
            // 
            this.RegisterRoleButton.Location = new System.Drawing.Point(772, 525);
            this.RegisterRoleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterRoleButton.Name = "RegisterRoleButton";
            this.RegisterRoleButton.Size = new System.Drawing.Size(171, 72);
            this.RegisterRoleButton.TabIndex = 44;
            this.RegisterRoleButton.Text = "Register Role";
            this.RegisterRoleButton.UseVisualStyleBackColor = true;
            this.RegisterRoleButton.Click += new System.EventHandler(this.RegisterRoleButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1130, 29);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 65);
            this.button6.TabIndex = 48;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // advanced_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1526, 863);
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
            this.Controls.Add(this.Button5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "advanced_settings";
            this.Text = "Advanced Settings";
            this.Load += new System.EventHandler(this.advanced_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
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
    }
}