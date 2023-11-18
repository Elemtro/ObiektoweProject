namespace ObiektoweProject
{
    partial class Form5
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
            label8 = new Label();
            button1 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            textBox6 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(186, 191);
            label8.Name = "label8";
            label8.Size = new Size(233, 29);
            label8.TabIndex = 34;
            label8.Text = "Login must be unique!";
            label8.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(280, 509);
            button1.Name = "button1";
            button1.Size = new Size(338, 78);
            button1.TabIndex = 32;
            button1.Text = "Zapisz dane";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(60, 430);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(347, 47);
            textBox5.TabIndex = 31;
            textBox5.Visible = false;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(60, 392);
            label7.Name = "label7";
            label7.Size = new Size(73, 35);
            label7.TabIndex = 30;
            label7.Text = "Pesel";
            label7.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(489, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 47);
            textBox3.TabIndex = 29;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(489, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(347, 47);
            textBox4.TabIndex = 28;
            textBox4.Visible = false;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(489, 290);
            label5.Name = "label5";
            label5.Size = new Size(121, 35);
            label5.TabIndex = 27;
            label5.Text = "Nazwisko";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(489, 187);
            label6.Name = "label6";
            label6.Size = new Size(64, 35);
            label6.TabIndex = 26;
            label6.Text = "Imie";
            label6.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(60, 328);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(347, 47);
            textBox2.TabIndex = 25;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(60, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 47);
            textBox1.TabIndex = 24;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 290);
            label1.Name = "label1";
            label1.Size = new Size(78, 35);
            label1.TabIndex = 23;
            label1.Text = "Hasło";
            label1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 187);
            label4.Name = "label4";
            label4.Size = new Size(76, 35);
            label4.TabIndex = 22;
            label4.Text = "Login";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(258, 119);
            label3.Name = "label3";
            label3.Size = new Size(379, 49);
            label3.TabIndex = 21;
            label3.Text = "Podaj dane osobowe:";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 45);
            label2.Name = "label2";
            label2.Size = new Size(303, 39);
            label2.TabIndex = 19;
            label2.Text = "Wybierz tryb studiów:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Uczen podstawowy", "Uczen sredni" });
            comboBox2.Location = new Point(455, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(305, 47);
            comboBox2.TabIndex = 35;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(489, 430);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(347, 47);
            textBox6.TabIndex = 37;
            textBox6.Visible = false;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(489, 392);
            label9.Name = "label9";
            label9.Size = new Size(176, 35);
            label9.TabIndex = 36;
            label9.Text = "Średnia ocena";
            label9.Visible = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 627);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
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
            Controls.Add(label2);
            Name = "Form5";
            Text = "Form5";
            FormClosing += Form5_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button1;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label9;
    }
}