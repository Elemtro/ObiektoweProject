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
using Microsoft.VisualBasic;
using Npgsql;

namespace ObiektoweProject
{
    public partial class Form3 : Form
    {
        // Here we have some essential private string.
        // db_name - here we store name of our database
        // table_name - here we store our table name which we want work with. 
        // login and password we take from user
        private string db_name = "ObiektoweProject";
        private string table_name = "";

        private string login = "";
        private string password = "";

        // The constructor first takes a string and then decides
        // which class system and table form to work with.
        public Form3(string table_name)
        {
            InitializeComponent();
            if (table_name == "staly")
                this.table_name = "pr_staly";
            else if (table_name == "etatowy")
                this.table_name = "pr_etatowy";
            else
                this.table_name = "uczen";
        }

        // This method opens connection to PostgreSQL using NPGSQL NuGet package.
        // Right after that programm checks login and password (if can find any)
        // and decides let user in (if login and password are correct) or not.
        private async void button1_Click(object sender, EventArgs e)
        {
            var connectionString = $"Host=localhost;Username=postgres;Password=2004;Database={db_name}";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            await using var cmd = new NpgsqlCommand($"SELECT login, password FROM {table_name} WHERE login = \'{login}\' AND password = \'{password}\'", conn);
            await using var reader = await cmd.ExecuteReaderAsync();

            string login_unq = "";
            string passwd_unq = "";
            while (reader.Read())
            {
                login_unq = reader.GetString(0);
                passwd_unq = reader.GetString(1);
            }

            if (login_unq != login || passwd_unq != password)
                label4.Visible = true;
            else if (login.Length == 0 || password.Length == 0)
                label4.Visible = true;
            else
            {
                Form6 form6 = new Form6(table_name, login, password);
                form6.Show();
                this.Visible = false;
            }

        }

        // This method clears all the programm's processes after exiting
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // We take our private string "login" from user input
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            login = textBox1.Text;
        }

        // We take our private string "password" from user input
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            password = textBox2.Text;
        }

        // This method creates new form in which user can create new account
        private void button2_Click(object sender, EventArgs e)
        {
            if (table_name == "uczen")
            {
                Form5 form = new Form5(table_name);
                form.Show();
                this.Visible = false;
            }
            else
            {
                Form4 form = new Form4(table_name);
                form.Show();
                this.Visible = false;
            }
        }
    }
}
