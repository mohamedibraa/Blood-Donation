﻿namespace Donation_Blood
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Blood1 = new System.Windows.Forms.TextBox();
            this.Quanity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.Location = new System.Drawing.Point(50, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Updata";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blood Quanity";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(231, 466);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Blood1
            // 
            this.Blood1.Location = new System.Drawing.Point(240, 92);
            this.Blood1.Multiline = true;
            this.Blood1.Name = "Blood1";
            this.Blood1.Size = new System.Drawing.Size(235, 37);
            this.Blood1.TabIndex = 7;
            // 
            // Quanity
            // 
            this.Quanity.Location = new System.Drawing.Point(240, 184);
            this.Quanity.Multiline = true;
            this.Quanity.Name = "Quanity";
            this.Quanity.Size = new System.Drawing.Size(235, 37);
            this.Quanity.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "BloodType";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(435, 466);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 54);
            this.button5.TabIndex = 9;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Quanity);
            this.groupBox1.Controls.Add(this.Blood1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(167, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 325);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hospital Requriments";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Blood1;
        private System.Windows.Forms.TextBox Quanity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}