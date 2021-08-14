using System.Windows.Forms;

namespace Insurance
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormClients_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);

        }

        private void buttonAddDogovor_Click(object sender, System.EventArgs e)
        {
            FormAddClient fAddDog = new FormAddClient();
            fAddDog.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()) && !string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                клиентыBindingSource.Filter = "[ФИО Клиента] LIKE '%" + textBox1.Text + "%'";
            else клиентыBindingSource.Filter = "";
        }
    }
}