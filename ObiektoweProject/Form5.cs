using Npgsql;
using ObiektoweProject.Classes_Pracownik;
using ObiektoweProject.Classes_Uczen;
using ObiektoweProject.Interfaces_Pracownik;
using ObiektoweProject.Interfaces_Uczen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObiektoweProject
{
    public partial class Form5 : Form
    {
        private const string db_name = "ObiektoweProject";
        private string table_name = "";

        IUczen? uczen = null;

        int[] all_data = { 0, 0, 0, 0, 0, 0 };
        bool unique = false;
        public Form5(string tb_name)
        {
            table_name = tb_name;
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Uczen podstawowy":
                    uczen = new Uczen_podstaw();
                    label3.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    label6.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    textBox2.Visible = true;
                    label5.Visible = true;
                    textBox3.Visible = true;
                    label7.Visible = true;
                    textBox5.Visible = true;
                    label9.Visible = true;
                    textBox6.Visible = true;
                    break;
                case "Uczen sredni":
                    uczen = new Uczen_sredn();
                    label3.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    label6.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    textBox2.Visible = true;
                    label5.Visible = true;
                    textBox3.Visible = true;
                    label7.Visible = true;
                    textBox5.Visible = true;
                    label9.Visible = true;
                    textBox6.Visible = true;
                    break;
            }
        }
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            all_data[0] = textBox1.Text.Length;
            bool has = all_data.Contains(0);
            if (!has)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            uczen.Login = textBox1.Text;

            var connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            await using var cmd = new NpgsqlCommand($"SELECT login FROM {table_name} WHERE login = \'{textBox1.Text}\'", conn);

            await using var reader = await cmd.ExecuteReaderAsync();
            string login_unq = "";
            while (await reader.ReadAsync())
            {
                login_unq = reader.GetString(0);
            }

            if (textBox1.Text == login_unq)
            {
                label8.Visible = true;
                button1.Visible = false;
                unique = false;
            }
            else
            {
                label8.Visible = false;
                unique = true;
            }
            conn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            all_data[4] = textBox4.Text.Length;
            bool has = all_data.Contains(0);
            if (!has)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            if (!unique)
            {
                button1.Visible = false;
            }

            uczen.Imie = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            all_data[1] = textBox2.Text.Length;
            bool has = all_data.Contains(0);
            if (!has)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            if (!unique)
            {
                button1.Visible = false;
            }

            uczen.Password = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            all_data[2] = textBox3.Text.Length;
            bool has = all_data.Contains(0);
            if (!has)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            if (!unique)
            {
                button1.Visible = false;
            }

            uczen.Nazwisko = textBox3.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            all_data[3] = textBox5.Text.Length;
            bool has = all_data.Contains(0);
            if (!has)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            if (!unique)
            {
                button1.Visible = false;
            }

            if (textBox5.Text.Length != 0)
            {
                uczen.Pesel = long.Parse(textBox5.Text);
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            textBox5.MaxLength = 11;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!unique)
            {
                button1.Visible = false;
            }

            string text = textBox6.Text;
            if (text.Count(c => c == '.') > 1)
            {
                int lastIndex = text.LastIndexOf('.');
                text = text.Substring(0, lastIndex) + text.Substring(lastIndex + 1).Replace(".", "");
                textBox6.Text = text;
                textBox6.SelectionStart = text.Length;
            }
            string edit = textBox6.Text.Replace('.', ',');

            all_data[5] = edit.Length;
            bool has = all_data.Contains(0);
            if (!has)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

            if (textBox6.Text.Length != 0 && edit != ",")
            {
                uczen.Srednia = double.Parse(edit);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string command = $"INSERT INTO {table_name} (login, password, imie, nazwisko, pesel, srednia, stanowisko)" +
            $"VALUES ($1, $2, $3, $4, $5, $6, $7)";
            await using var cmd = new NpgsqlCommand(command, conn)
            {
                Parameters =
                    {
                        new () {Value = uczen.Login},
                        new () {Value = uczen.Password},
                        new () {Value = uczen.Imie},
                        new () {Value = uczen.Nazwisko},
                        new () {Value = uczen.Pesel},
                        new () {Value = uczen.Srednia},
                        new () {Value = uczen.GetType().Name},
                    }
            };
            await cmd.ExecuteNonQueryAsync();

            await using var cmd2 = new NpgsqlCommand($"COPY {table_name} TO 'C:\\Projects\\ObiektoweProject\\CSV files\\uczen.csv' WITH (FORMAT CSV, HEADER)", conn);
            await cmd2.ExecuteNonQueryAsync();
            conn.Close();

            Form7 form7 = new Form7();
            form7.Visible = true;
            this.Visible = false;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            textBox6.MaxLength = 7;
        }
    }
}
