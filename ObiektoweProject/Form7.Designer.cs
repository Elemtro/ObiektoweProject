﻿namespace ObiektoweProject
{
    partial class Form7
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
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 93);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(722, 58);
            label3.TabIndex = 6;
            label3.Text = "Nowy użytkownik został stworzony!";
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(402, 200);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(306, 183);
            button2.TabIndex = 9;
            button2.Text = "Załogować się";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(21, 200);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(306, 183);
            button1.TabIndex = 8;
            button1.Text = "Wyjść z programu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 502);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form7";
            Text = "Form7";
            FormClosing += Form7_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private Button button1;
    }
}