﻿namespace DriverInstallerWinForms
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(230, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 118);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 133);
            label1.Name = "label1";
            label1.Size = new Size(365, 38);
            label1.TabIndex = 2;
            label1.Text = "Install Printers and Drivers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 186);
            label2.Name = "label2";
            label2.Size = new Size(478, 40);
            label2.TabIndex = 3;
            label2.Text = "Welcome!This tool will seamlessly install the printers and drivers you've\nrented directly onto your computer.Let's get started";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 247);
            label3.Name = "label3";
            label3.Size = new Size(468, 40);
            label3.TabIndex = 4;
            label3.Text = "If you need any assistance with these details,please call 301-359-6804\nto speak directly to one of our support representatives.";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(313, 305);
            button1.Name = "button1";
            button1.Size = new Size(182, 29);
            button1.TabIndex = 5;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 401);
            label4.Name = "label4";
            label4.Size = new Size(254, 20);
            label4.TabIndex = 6;
            label4.Text = "Copyright (c) 2024 - We Rent Copiers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}