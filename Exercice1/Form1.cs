namespace Exercice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "Bonjour " + TbFirstName.Text + " " + TbLastName.Text;
            labelRes.Text = res;
        }

        private void labelRes_Click(object sender, EventArgs e)
        {

        }
    }
}
