using System.Windows.Forms;

namespace Insurance
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void страховые_выплатыBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.страховые_выплатыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormReports_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);
            // TODO: This line of code loads data into the 'database1DataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);
            // TODO: This line of code loads data into the 'database1DataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);
            // TODO: This line of code loads data into the 'database1DataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);
            // TODO: This line of code loads data into the 'database1DataSet.Страховые_выплаты' table. You can move, or remove it, as needed.
            this.страховые_выплатыTableAdapter.Fill(this.database1DataSet.Страховые_выплаты);

        }

        private void buttonAddDogovor_Click(object sender, System.EventArgs e)
        {
            FormAddWithdrawMoney fAddDog = new FormAddWithdrawMoney();
            fAddDog.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            this.страховые_выплатыTableAdapter.Fill(this.database1DataSet.Страховые_выплаты);
        }
    }
}