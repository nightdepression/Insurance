using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Insurance
{
    public sealed partial class Form1 : Form
    {
        // Переменные
        private IconButton _currentButton;
        private readonly Panel _leftBorderButton;
        private readonly Panel _rightBorderButton;
        private Form _currentForm;

        List<Color> _colors = new List<Color>();

        public Form1()
        {
            InitializeComponent();

            _leftBorderButton = new Panel {Size = new Size(10, 52)};
            _rightBorderButton = new Panel { Size = new Size(10, 52) };

            menuMain.Controls.Add(_leftBorderButton);
            menuMain.Controls.Add(_rightBorderButton);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
            _colors.Add((Color.FromArgb(33, 150, 243)));
            _colors.Add((Color.FromArgb(3, 169, 244)));
            _colors.Add((Color.FromArgb(0, 150, 136)));
            _colors.Add((Color.FromArgb(103, 58, 183)));
            _colors.Add((Color.FromArgb(156, 39, 176)));
            _colors.Add((Color.FromArgb(255, 87, 34)));
            _colors.Add((Color.FromArgb(255, 193, 7)));
            _colors.Add((Color.FromArgb(205, 220, 57)));

            OpenSecondForm(new FormDashboard());

            /* AllocConsole(); */
        }
        
        /* [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole(); */
        
        private struct RandomButtonColors
        {
            public static readonly Color Color1 = Color.FromArgb(172, 126, 241);
            public static readonly Color Color2 = Color.FromArgb(249, 118, 176);
            public static readonly Color Color3 = Color.FromArgb(253, 138, 114);
            public static readonly Color Color4 = Color.FromArgb(95, 77, 221);
            public static readonly Color Color5 = Color.FromArgb(249, 88, 155);
            public static readonly Color Color6 = Color.FromArgb(24, 161, 251);
            public static readonly Color Color7 = Color.FromArgb(255, 175, 204);
        }

        private void HighlightButton(object senderButton, Color color)
        {
            if (senderButton == null) return;

            // Отключаем остальные кнопки
            DisableHighlightButton();

            _currentButton = (IconButton)senderButton;
            _currentButton.BackColor = Color.FromArgb(37, 36, 81);
            _currentButton.ForeColor = color;
            _currentButton.TextAlign = ContentAlignment.MiddleCenter;
            _currentButton.IconColor = color;
            _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            _currentButton.ImageAlign = ContentAlignment.MiddleRight;

            _leftBorderButton.BackColor = color;
            _leftBorderButton.Location = new Point(0, _currentButton.Location.Y);
            _leftBorderButton.Visible = true;
            _leftBorderButton.BringToFront();

            _rightBorderButton.BackColor = color;
            _rightBorderButton.Location = new Point(235, _currentButton.Location.Y);
            _rightBorderButton.Visible = true;
            _rightBorderButton.BringToFront();

            iconMainForm.IconChar = _currentButton.IconChar;
            iconMainForm.IconColor = color;
            textHome.ForeColor = color;
        }

        private void DisableHighlightButton()
        {
            if (_currentButton == null) return;
            
            _currentButton.BackColor = Color.FromArgb(34, 34, 59);
            _currentButton.ForeColor = Color.FromArgb(242, 233, 228);
            _currentButton.TextAlign = ContentAlignment.MiddleLeft;
            _currentButton.IconColor = Color.FromArgb(242, 233, 228);
            _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void OpenSecondForm(Form childForm)
        {
            _currentForm?.Close();

            _currentForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            panelMainForm.Controls.Add(childForm);
            panelMainForm.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();

            textHome.Text = childForm.Text;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, RandomButtonColors.Color1);
            OpenSecondForm(new FormDashboard());
        }

        private void marketingButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, RandomButtonColors.Color2);
            OpenSecondForm(new FormMarketing());
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, RandomButtonColors.Color4);
            OpenSecondForm(new FormInsurance());
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, RandomButtonColors.Color5);
            OpenSecondForm(new FormClients());
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, RandomButtonColors.Color6);
            OpenSecondForm(new FormReports());
        }

        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            HighlightButton(sender, RandomButtonColors.Color7);
            OpenSecondForm(new FormAdmin());
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            _currentForm?.Close();
            FormReset();
        }

        private void FormReset()
        {
            DisableHighlightButton();
            _leftBorderButton.Visible = false;
            _rightBorderButton.Visible = false;

            textHome.Text = @"Главная";
            iconMainForm.IconChar = IconChar.Home;
            iconMainForm.IconColor = Color.FromArgb(172, 126, 241);
            textHome.ForeColor = Color.FromArgb(172, 126, 241);

            OpenSecondForm(new FormDashboard());
        }

        // Перетаскивание формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void FormMain_Resize(object sender, EventArgs e)
        {
            FormBorderStyle = WindowState == FormWindowState.Maximized ? FormBorderStyle.None : FormBorderStyle.Sizable;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}