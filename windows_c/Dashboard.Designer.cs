namespace windows_c
{
    partial class Form1
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Lucida Calligraphy", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button5.Location = new System.Drawing.Point(-3, 0);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(548, 138);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "WORKITO";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(45, 220);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(182, 65);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Register Employee";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(291, 220);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(182, 65);
            this.Button2.TabIndex = 15;
            this.Button2.Text = "Find User";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(528, 220);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(182, 65);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "Projects";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(774, 218);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 66);
            this.button4.TabIndex = 17;
            this.button4.Text = "Advance Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(1173, 36);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 65);
            this.button6.TabIndex = 46;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1526, 863);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button6;
    }
}

