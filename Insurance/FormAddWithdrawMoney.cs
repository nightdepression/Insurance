using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance
{
    public partial class FormAddWithdrawMoney : Form
    {
        public FormAddWithdrawMoney()
        {
            InitializeComponent();
        }

        private void страховые_выплатыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.страховые_выплатыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormAddWithdrawMoney_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Страховые_выплаты' table. You can move, or remove it, as needed.
            this.страховые_выплатыTableAdapter.Fill(this.database1DataSet.Страховые_выплаты);

        }
    }
}
