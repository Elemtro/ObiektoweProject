namespace ObiektoweProject
{
    partial class Form4
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(302, 33);
            label2.TabIndex = 2;
            label2.Text = "Wybierz stanowisko pracy:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kierownik", "Ksiegowy", "Lekarz", "Nauczyciel" });
            comboBox1.Location = new Point(426, 34);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 41);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(205, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(320, 41);
            label3.TabIndex = 5;
            label3.Text = "Podaj dane osobowe:";
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(46, 263);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(288, 40);
            textBox2.TabIndex = 9;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(46, 181);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 40);
            textBox1.TabIndex = 8;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 233);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 29);
            label1.TabIndex = 7;
            label1.Text = "Hasło";
            label1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 150);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 29);
            label4.TabIndex = 6;
            label4.Text = "Login";
            label4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(390, 263);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 40);
            textBox3.TabIndex = 13;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(390, 181);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 40);
            textBox4.TabIndex = 12;
            textBox4.Visible = false;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(390, 233);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 11;
            label5.Text = "Nazwisko";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(390, 150);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 29);
            label6.TabIndex = 10;
            label6.Text = "Imie";
            label6.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(222, 348);
            textBox5.Margin = new Padding(2, 2, 2, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(271, 40);
            textBox5.TabIndex = 15;
            textBox5.Visible = false;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(222, 318);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 29);
            label7.TabIndex = 14;
            label7.Text = "Pesel";
            label7.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(222, 408);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(270, 62);
            button1.TabIndex = 16;
            button1.Text = "Zapisz dane";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Hydraulik", "Kierowca", "Sprzataczka" });
            comboBox2.Location = new Point(426, 34);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(173, 41);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(147, 154);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(198, 24);
            label8.TabIndex = 18;
            label8.Text = "Login must be unique!";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(248, 8);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(198, 24);
            label9.TabIndex = 19;
            label9.Text = "Login must be unique!";
            label9.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 502);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form4";
            Text = "Form4";
            FormClosing += Form4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button button1;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
    }
}