namespace Exercice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(TbN1.Text);
            float n2 = float.Parse(TbN2.Text);
            TbRes.Text = (n1+n2).ToString();
        }
    }
}
