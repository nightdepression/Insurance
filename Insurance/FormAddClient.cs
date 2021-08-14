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
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }

        private void FormAddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Договора' table. You can move, or remove it, as needed.
            this.договораTableAdapter.Fill(this.database1DataSet.Договора);
            // TODO: This line of code loads data into the 'database1DataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.database1DataSet.Клиенты);

        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(номер_клиентаTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(номер_клиентаTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(фИО_клиентаTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(фИО_клиентаTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(телефонTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(телефонTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(адресTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(адресTextBox.Text.Trim()))
            { MessageBox.Show("Одно из ключевых полей было не заполнено", "Внимание"); return; }

            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void фИО_клиентаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
