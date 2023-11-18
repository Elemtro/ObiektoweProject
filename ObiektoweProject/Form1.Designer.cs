using System;
using Npgsql;
namespace ObiektoweProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(238, 153);
            label1.Name = "label1";
            label1.Size = new Size(407, 97);
            label1.TabIndex = 2;
            label1.Text = "Kim jesteś?";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Calibri", 28F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(494, 317);
            button2.Name = "button2";
            button2.Size = new Size(298, 212);
            button2.TabIndex = 5;
            button2.Text = "Uczeń";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Calibri", 28F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(102, 317);
            button1.Name = "button1";
            button1.Size = new Size(298, 212);
            button1.TabIndex = 6;
            button1.Text = "Pracownik";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 52);
            label2.Name = "label2";
            label2.Size = new Size(690, 64);
            label2.TabIndex = 7;
            label2.Text = "Witam w systemie Szkoła 2077!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 627);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
    }
}