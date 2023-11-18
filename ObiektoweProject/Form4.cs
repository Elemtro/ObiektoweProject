using Microsoft.VisualBasic.Logging;
using Npgsql;
using ObiektoweProject.Classes_Pracownik;
using ObiektoweProject.Classes_Pracownik_etatowy;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ObiektoweProject
{
    public partial class Form4 : Form
    {
        private const string db_name = "ObiektoweProject";
        private string table_name = "";

        IPr_Staly? pracownik_st = null;
        IPr_Etatowy? pracownik_et = null;

        int[] all_data = { 0, 0, 0, 0, 0 };
        bool unique = false;
        public Form4(string table_name)
        {
            InitializeComponent();
            this.table_name = table_name;
            if (table_name == "pr_staly")
            {
                comboBox2.Visible = false;
            }
            else if (table_name == "pr_etatowy")
            {
                comboBox1.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Kierownik":
                    pracownik_st = new Kierownik();
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
                    break;
                case "Ksiegowy":
                    pracownik_st = new Ksiegowy();
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
                    break;
                case "Lekarz":
                    pracownik_st = new Lekarz();
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
                    break;
                case "Nauczyciel":
                    pracownik_st = new Nauczyciel();
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
                    break;
            }
        }


        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

            if (table_name == "pr_staly")
                pracownik_st.Login = textBox1.Text;
            else if (table_name == "pr_etatowy")
                pracownik_et.Login = textBox1.Text;

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

            if (table_name == "pr_staly")
                pracownik_st.Imie = textBox4.Text;
            else if (table_name == "pr_etatowy")
                pracownik_et.Imie = textBox4.Text;
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

            if (table_name == "pr_staly")
                pracownik_st.Password = textBox2.Text;
            else if (table_name == "pr_etatowy")
                pracownik_et.Password = textBox2.Text;
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

            if (table_name == "pr_staly")
                pracownik_st.Nazwisko = textBox3.Text;
            else if (table_name == "pr_etatowy")
                pracownik_et.Nazwisko = textBox3.Text;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            textBox5.MaxLength = 11;
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
                if (table_name == "pr_staly")
                    pracownik_st.Pesel = long.Parse(textBox5.Text);
                else if (table_name == "pr_etatowy")
                    pracownik_et.Pesel = long.Parse(textBox5.Text);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Hydraulik":
                    pracownik_et = new Hydraulik();
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
                    break;
                case "Kierowca":
                    pracownik_et = new Kierowca();
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
                    break;
                case "Sprzataczka":
                    pracownik_et = new Sprzataczka();
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
                    break;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string command = "";

            if (table_name == "pr_staly")
            {
                command = $"INSERT INTO {table_name} (login, password, imie, nazwisko, pesel, pensja_miesiac, stanowisko)" +
                $"VALUES ($1, $2, $3, $4, $5, $6, $7)";
                await using var cmd = new NpgsqlCommand(command, conn)
                {
                    Parameters =
                    {
                        new () {Value = pracownik_st.Login},
                        new () {Value = pracownik_st.Password},
                        new () {Value = pracownik_st.Imie},
                        new () {Value = pracownik_st.Nazwisko},
                        new () {Value = pracownik_st.Pesel},
                        new () {Value = pracownik_st.Pensja_miesiac},
                        new () {Value = pracownik_st.GetType().Name},
                    }
                };
                await cmd.ExecuteNonQueryAsync();
                await using var cmd2 = new NpgsqlCommand($"COPY {table_name} TO 'C:\\Projects\\ObiektoweProject\\CSV files\\pracownik_staly.csv' WITH (FORMAT CSV, HEADER)", conn);
                await cmd2.ExecuteNonQueryAsync();
            }
            else
            {
                command = $"INSERT INTO {table_name} (login, password, imie, nazwisko, pesel, pensja_godzina, stanowisko)" +
                $"VALUES ($1, $2, $3, $4, $5, $6, $7)";
                await using var cmd = new NpgsqlCommand(command, conn)
                {
                    Parameters =
                    {
                        new () {Value = pracownik_et.Login},
                        new () {Value = pracownik_et.Password},
                        new () {Value = pracownik_et.Imie},
                        new () {Value = pracownik_et.Nazwisko},
                        new () {Value = pracownik_et.Pesel},
                        new () {Value = pracownik_et.Pensja_godzina},
                        new () {Value = pracownik_et.GetType().Name},
                    }
                };
                await cmd.ExecuteNonQueryAsync();
                await using var cmd2 = new NpgsqlCommand($"COPY {table_name} TO 'C:\\Projects\\ObiektoweProject\\CSV files\\pracownik_etatowy.csv' WITH (FORMAT CSV, HEADER)", conn);
                await cmd2.ExecuteNonQueryAsync();
            }
            conn.Close();
            Form7 newForm = new Form7();
            newForm.Visible = true;
            this.Visible = false;
        }
    }
}
