﻿namespace windows_c
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
            this.Button5 = new System.Windows.Forms.Button();
            this.SøkLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.BackgroundImage = global::windows_c.Properties.Resources.Pensive_Parakeet;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Lucida Calligraphy", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button5.Location = new System.Drawing.Point(-1, 0);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(365, 90);
            this.Button5.TabIndex = 14;
            this.Button5.Text = "WORKITO";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // SøkLabel
            // 
            this.SøkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SøkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SøkLabel.Image = global::windows_c.Properties.Resources.Pensive_Parakeet;
            this.SøkLabel.Location = new System.Drawing.Point(218, 115);
            this.SøkLabel.Name = "SøkLabel";
            this.SøkLabel.Size = new System.Drawing.Size(93, 23);
            this.SøkLabel.TabIndex = 16;
            this.SøkLabel.Text = "Søk Ansatt:";
            this.SøkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SøkLabel.Click += new System.EventHandler(this.SøkLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Register bruker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "Finn bruker";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "Projects";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // finn_bruker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::windows_c.Properties.Resources.Pensive_Parakeet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SøkLabel);
            this.Controls.Add(this.Button5);
            this.Name = "finn_bruker";
            this.Text = "finn_bruker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Label SøkLabel;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}