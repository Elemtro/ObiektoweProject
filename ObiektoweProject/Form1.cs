namespace ObiektoweProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This method opens new form and makes our previous form invincible
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
        //This method opens new form and makes our previous form invincible
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("uczen");
            form3.Show();
            this.Visible = false;
        }
        //This method clears all the programm's processes after exiting
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}