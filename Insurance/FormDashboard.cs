using System;
using System.Windows.Forms;

namespace Insurance
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
            labelTimer.Text = DateTime.Now.ToString("HH:mm:ss") + "\n" + DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("HH:mm:ss") + "\n" + DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}