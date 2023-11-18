using Npgsql;
using ObiektoweProject.Classes_Pracownik;
using ObiektoweProject.Classes_Pracownik_etatowy;
using ObiektoweProject.Classes_Uczen;
using ObiektoweProject.Interfaces_Pracownik;
using ObiektoweProject.Interfaces_Uczen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObiektoweProject
{
    public partial class Form6 : Form
    {
        private const string db_name = "ObiektoweProject";
        private string table_name = "";
        private string login = "";
        private string password = "";
        public Form6(string table_name, string log, string passwd)
        {
            this.table_name = table_name;
            login = log;
            password = passwd;
            InitializeComponent();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void Form6_Load(object sender, EventArgs e)
        {
            if (table_name == "uczen")
            {
                label6.Visible = true;

                const string connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                await using var cmd = new NpgsqlCommand($"SELECT * FROM {table_name} WHERE login = \'{login}\'", conn);
                await using var reader = cmd.ExecuteReader();

                IUczen uczen = new Uczen_podstaw();
                while (reader.Read())
                {
                    uczen.Login = reader.GetString(0);
                    uczen.Imie = reader.GetString(2);
                    uczen.Nazwisko = reader.GetString(3);
                    uczen.Pesel = reader.GetInt64(4);
                    uczen.Srednia = reader.GetDouble(5);
                    uczen.Stanowisko = reader.GetString(6);
                }

                label8.Text = uczen.Login;
                label8.Visible = true;

                label9.Text = uczen.Nazwisko;
                label9.Visible = true;

                label10.Text = uczen.Login;
                label10.Visible = true;

                label11.Text = uczen.Pesel.ToString();
                label11.Visible = true;

                label12.Text = uczen.Srednia.ToString();
                label12.Visible = true;

                switch (uczen.Stanowisko)
                {
                    case "Uczen_podstaw":
                        label13.Text = "Uczeń podstawówki";
                        label13.Visible = true;
                        break;
                    case "Uczen_sredn":
                        label13.Text = "Uczeń średni";
                        label13.Visible = true;
                        break;
                }
            }
            else if (table_name == "pr_staly")
            {
                label14.Visible = true;
                IPr_Staly pracownik = new Lekarz();

                const string connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                await using var cmd = new NpgsqlCommand($"SELECT * FROM {table_name} WHERE login = \'{login}\'", conn);
                await using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pracownik.Login = reader.GetString(0);
                    pracownik.Imie = reader.GetString(2);
                    pracownik.Nazwisko = reader.GetString(3);
                    pracownik.Pesel = reader.GetInt64(4);
                    pracownik.Pensja_miesiac = reader.GetInt16(5);
                    pracownik.Stanowisko = reader.GetString(6);
                }

                label8.Text = pracownik.Imie;
                label8.Visible = true;

                label9.Text = pracownik.Nazwisko;
                label9.Visible = true;

                label10.Text = pracownik.Login;
                label10.Visible = true;

                label11.Text = pracownik.Pesel.ToString();
                label11.Visible = true;

                label12.Text = pracownik.Pensja_miesiac.ToString();
                label12.Visible = true;

                switch (pracownik.Stanowisko)
                {
                    case "Kierownik":
                        label13.Text = "Kierownik";
                        label13.Visible = true;
                        break;
                    case "Ksiegowy":
                        label13.Text = "Księgowy";
                        label13.Visible = true;
                        break;
                    case "Lekarz":
                        label13.Text = "Lekarz";
                        label13.Visible = true;
                        break;
                    case "Nauczyciel":
                        label13.Text = "Nauczyciel";
                        label13.Visible = true;
                        break;
                }
            }
            else if (table_name == "pr_etatowy")
            {
                label15.Visible = true;
                IPr_Etatowy pracownik = new Hydraulik();

                const string connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                await using var cmd = new NpgsqlCommand($"SELECT * FROM {table_name} WHERE login = \'{login}\'", conn);
                await using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pracownik.Login = reader.GetString(0);
                    pracownik.Imie = reader.GetString(2);
                    pracownik.Nazwisko = reader.GetString(3);
                    pracownik.Pesel = reader.GetInt64(4);
                    pracownik.Pensja_godzina = reader.GetString(5);
                    pracownik.Stanowisko = reader.GetString(6);
                }

                label8.Text = pracownik.Imie;
                label8.Visible = true;

                label9.Text = pracownik.Nazwisko;
                label9.Visible = true;

                label10.Text = pracownik.Login;
                label10.Visible = true;

                label11.Text = pracownik.Pesel.ToString();
                label11.Visible = true;

                label12.Text = pracownik.Pensja_godzina.ToString();
                label12.Visible = true;

                switch (pracownik.Stanowisko)
                {
                    case "Hydraulik":
                        label13.Text = "Hydraulik";
                        label13.Visible = true;
                        break;
                    case "Kierowca":
                        label13.Text = "Kierowca";
                        label13.Visible = true;
                        break;
                    case "Sprzataczka":
                        label13.Text = "Sprzataczka";
                        label13.Visible = true;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
            this.Visible = false;
        }
    }
}