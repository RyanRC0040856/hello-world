﻿namespace hello_world
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbxname = new System.Windows.Forms.TextBox();
            this.txtbxname2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbxname
            // 
            this.txtbxname.Location = new System.Drawing.Point(135, 12);
            this.txtbxname.Name = "txtbxname";
            this.txtbxname.Size = new System.Drawing.Size(153, 20);
            this.txtbxname.TabIndex = 1;
            this.txtbxname.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtbxname2
            // 
            this.txtbxname2.Location = new System.Drawing.Point(135, 48);
            this.txtbxname2.Name = "txtbxname2";
            this.txtbxname2.Size = new System.Drawing.Size(153, 20);
            this.txtbxname2.TabIndex = 2;
            this.txtbxname2.TextChanged += new System.EventHandler(this.Txtbxname2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 826);
            this.Controls.Add(this.txtbxname2);
            this.Controls.Add(this.txtbxname);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbxname;
        private System.Windows.Forms.TextBox txtbxname2;
    }
}

