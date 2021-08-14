using System.Drawing;
using System.Windows.Forms;

namespace Insurance
{
    public partial class FormInsurance : Form
    {
        public FormInsurance()
        {
            InitializeComponent();
        }

        private void FormInsurance_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Договора' table. You can move, or remove it, as needed.
            this.договораTableAdapter.Fill(this.database1DataSet.Договора);
            договораDataGridView.EnableHeadersVisualStyles = false;

        }

        private void buttonAddDogovor_Click(object sender, System.EventArgs e)
        {
            FormAddDogovor fAddDog = new FormAddDogovor();
            fAddDog.ShowDialog();
        }

        private void договораBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.договораBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            this.договораTableAdapter.Fill(this.database1DataSet.Договора);
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()) && !string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                договораBindingSource.Filter = "[ФИО Клиента] LIKE '%" + textBox1.Text + "%'";
            else договораBindingSource.Filter = "";
        }
    }
}