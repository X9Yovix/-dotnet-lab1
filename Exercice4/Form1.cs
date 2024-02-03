namespace Exercice4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(TbN.Text == "")
            {
                MessageBox.Show("donner un nombre");
            }
            else
            {
                long res = fact(int.Parse(TbN.Text));
                //dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(int.Parse(TbN.Text), res);
            }
            
        }

        private long fact(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * fact(n - 1);
        }

        private void TbN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
