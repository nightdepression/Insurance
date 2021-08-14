using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance
{
    public partial class FormAddDogovor : Form
    {
        // public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb;";

        // private OleDbConnection myConnection;

        public FormAddDogovor()
        {
            InitializeComponent();

            /*myConnection = new OleDbConnection(connectString);

            myConnection.Open();*/
        }

        private void FormAddDogovor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Договора' table. You can move, or remove it, as needed.
            this.договораTableAdapter.Fill(this.database1DataSet.Договора);

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*int numberDogovora = Convert.ToInt32(textBox1.Text);

            string query = "INSERT INTO Договор (№ Договора, Дата заключения, ФИО Клиента, Паспортные данные, ID Клиента, ID Объекта страхования, " +
                "Страховая премия, Страховая выплата, Срок действия) VALUES ('" + numberDogovora + "', 'NULL', 'NULL', 'NULL', 'NULL', 'NULL', 'NULL', 'NULL', 'NULL')";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();*/
        }

        private void FormAddDogovor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // myConnection.Close();
        }

        private void договораBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(фИО_КлиентаTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(фИО_КлиентаTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(iD_Объекта_страхованияTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(iD_Объекта_страхованияTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(страховая_премияTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(страховая_премияTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(страховая_выплатаTextBox.Text.Trim()) || string.IsNullOrWhiteSpace(страховая_выплатаTextBox.Text.Trim()))
            { MessageBox.Show("Одно из ключевых полей было не заполнено", "Внимание"); return; }

            this.Validate();
            this.договораBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void фИО_КлиентаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void iD_КлиентаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void iD_Объекта_страхованияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
