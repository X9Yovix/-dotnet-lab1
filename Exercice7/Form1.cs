namespace Exercice7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetuComboBoxElements();
            SetupDataGridViewColumns();
        }
        private void SetuComboBoxElements()
        {
            CbGender.Items.Add("Select an option");
            CbGender.Items.Add("Male");
            CbGender.Items.Add("Female");
            CbGender.SelectedItem = CbGender.Items[0];
        }
        private void SetupDataGridViewColumns()
        {
            // Add columns to the DataGridView
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Gender", "Gender");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedGender = CbGender.SelectedItem as string;
            if (selectedGender == CbGender.Items[0])
            {
                MessageBox.Show("select an option");
                return;
            }
            if (TbId.Text == "" || TbFirstName.Text == "" || TbLastName.Text == "" || TbAddress.Text == "")
            {
                MessageBox.Show("tb is empty");
                return;
            }

            dataGridView1.Rows.Add(TbId.Text, TbFirstName.Text, TbLastName.Text, TbAddress.Text, selectedGender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TbId.Text = "";
            TbFirstName.Text = "";
            TbLastName.Text = "";
            TbAddress.Text = "";
            CbGender.SelectedItem = CbGender.Items[0];
        }

        private void CbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("select a row to remove");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
