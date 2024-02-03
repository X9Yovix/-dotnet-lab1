namespace Exercice3
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            labelRes.Text = "Nombre est " + (int.Parse(TbN.Text) % 2 == 0 ? "pair" : "impair");
        }
    }
}
