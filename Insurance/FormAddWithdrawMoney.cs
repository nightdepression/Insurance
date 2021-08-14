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
            if (string.IsNullOrEmpty(___ДоговораTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(___ДоговораTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(iD_клиентаTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(iD_клиентаTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(iD_объектаTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(iD_объектаTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(страховая_премияTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(страховая_премияTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(сумма_выплатыTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(сумма_выплатыTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(описаниеTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(описаниеTextBox.Text.Trim()))
            { MessageBox.Show("Одно из ключевых полей было не заполнено", "Внимание"); return; }

            this.Validate();
            this.страховые_выплатыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormAddWithdrawMoney_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Страховые_выплаты' table. You can move, or remove it, as needed.
            this.страховые_выплатыTableAdapter.Fill(this.database1DataSet.Страховые_выплаты);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
