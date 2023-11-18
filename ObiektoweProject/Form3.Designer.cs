namespace ObiektoweProject
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 440);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 0;
            label1.Text = "Nie posiadasz konta?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(177, 103);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(177, 220);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 2;
            label3.Text = "Hasło";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(177, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(488, 51);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(177, 267);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(488, 51);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(177, 342);
            button1.Name = "button1";
            button1.Size = new Size(488, 56);
            button1.TabIndex = 5;
            button1.Text = "Załogować się";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(435, 431);
            button2.Name = "button2";
            button2.Size = new Size(230, 50);
            button2.TabIndex = 6;
            button2.Text = "Utwórz konto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(353, 107);
            label4.Name = "label4";
            label4.Size = new Size(312, 29);
            label4.TabIndex = 7;
            label4.Text = "Nieprawidlowy login lub hasło";
            label4.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 627);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}