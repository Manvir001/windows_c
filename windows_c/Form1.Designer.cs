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
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.BackgroundImage = global::windows_c.Properties.Resources.Pensive_Parakeet;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Lucida Calligraphy", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button5.Location = new System.Drawing.Point(-2, 0);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(365, 90);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "WORKITO";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(26, 96);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(121, 42);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Register Bruker";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(26, 156);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(121, 44);
            this.Button2.TabIndex = 15;
            this.Button2.Text = "Finn Bruker";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(26, 218);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(121, 44);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "Projects";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::windows_c.Properties.Resources.Pensive_Parakeet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
    }
}

