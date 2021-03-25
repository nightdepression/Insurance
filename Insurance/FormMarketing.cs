using System.Windows.Forms;

namespace Insurance
{
    public partial class FormMarketing : Form
    {
        public FormMarketing()
        {
            InitializeComponent();
        }

        private void объекты_страхованияBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.объекты_страхованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormMarketing_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Объекты_страхования' table. You can move, or remove it, as needed.
            this.объекты_страхованияTableAdapter.Fill(this.database1DataSet.Объекты_страхования);

        }

        private void buttonAddDogovor_Click(object sender, System.EventArgs e)
        {
            FormAddInsuranceType fAddDog = new FormAddInsuranceType();
            fAddDog.ShowDialog();
        }
    }
}