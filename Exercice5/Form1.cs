namespace Exercice5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TbRes.Enabled = false;
            TbRes.BackColor = Color.White;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if(!RadioAddition.Checked && !RadioSoustraction.Checked && !RadioMulti.Checked && !RadioDivision.Checked)
            {
                MessageBox.Show("choisir une option");
                return;
            }

            if (RadioAddition.Checked)
            {
                TbRes.Text = (float.Parse(TbN1.Text) + float.Parse(TbN2.Text)).ToString();
                return;
            }
            if (RadioSoustraction.Checked)
            {
                TbRes.Text = (float.Parse(TbN1.Text) - float.Parse(TbN2.Text)).ToString();
                return;
            }
            if (RadioMulti.Checked)
            {
                TbRes.Text = (float.Parse(TbN1.Text) * float.Parse(TbN2.Text)).ToString();
                return;
            }
            if (RadioDivision.Checked)
            {
                TbRes.Text = (float.Parse(TbN1.Text) / float.Parse(TbN2.Text)).ToString();
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
