namespace Exercice6
{
    public partial class Form1 : Form
    {
        string error = "invalid username or password";
        string password = "admin";
        string username = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(TbUsername.Text.Equals(this.username) && TbPassword.Text.Equals(this.password))
            {
                MessageBox.Show("correct");
            }
            else
            {
                labelError.Text = this.error;
                labelError.BackColor = Color.Red;
                labelError.ForeColor = Color.White;
            }
        }
    }
}
