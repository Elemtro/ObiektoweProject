﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObiektoweProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // This method opens new form and makes our previous form invincible
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("staly"); 
            form.Show();
            this.Visible = false;
        }
        // This method clears all the programm's processes after exiting
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        } 
        // This method opens new form and makes our previous form invincible
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("etatowy");
            form.Show();
            this.Visible = false;
        }
    }
}
