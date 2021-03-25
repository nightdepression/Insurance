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
    public partial class FormAddInsuranceType : Form
    {
        public FormAddInsuranceType()
        {
            InitializeComponent();
        }

        private void объекты_страхованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.объекты_страхованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormAddInsuranceType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Объекты_страхования' table. You can move, or remove it, as needed.
            this.объекты_страхованияTableAdapter.Fill(this.database1DataSet.Объекты_страхования);

        }

        private void объект_страхованияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
