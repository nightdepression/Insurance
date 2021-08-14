namespace Insurance
{
    sealed partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuMain = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.reportsButton = new FontAwesome.Sharp.IconButton();
            this.customersButton = new FontAwesome.Sharp.IconButton();
            this.insuranceButton = new FontAwesome.Sharp.IconButton();
            this.marketingButton = new FontAwesome.Sharp.IconButton();
            this.dashboardButton = new FontAwesome.Sharp.IconButton();
            this.menuLogo = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.panelTittle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textHome = new System.Windows.Forms.Label();
            this.iconMainForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuMain.SuspendLayout();
            this.menuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.panelTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMainForm)).BeginInit();
            this.panelMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.menuMain.Controls.Add(this.settingsButton);
            this.menuMain.Controls.Add(this.reportsButton);
            this.menuMain.Controls.Add(this.customersButton);
            this.menuMain.Controls.Add(this.insuranceButton);
            this.menuMain.Controls.Add(this.marketingButton);
            this.menuMain.Controls.Add(this.dashboardButton);
            this.menuMain.Controls.Add(this.menuLogo);
            this.menuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(246, 739);
            this.menuMain.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.settingsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 34;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 433);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.settingsButton.Size = new System.Drawing.Size(246, 52);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Администрирование";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click_1);
            // 
            // reportsButton
            // 
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.reportsButton.IconChar = FontAwesome.Sharp.IconChar.FontAwesomeFlag;
            this.reportsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.reportsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportsButton.IconSize = 34;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 381);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.reportsButton.Size = new System.Drawing.Size(246, 52);
            this.reportsButton.TabIndex = 6;
            this.reportsButton.Text = "Выплаты";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.customersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.customersButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.customersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.customersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customersButton.IconSize = 34;
            this.customersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.Location = new System.Drawing.Point(0, 329);
            this.customersButton.Name = "customersButton";
            this.customersButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.customersButton.Size = new System.Drawing.Size(246, 52);
            this.customersButton.TabIndex = 5;
            this.customersButton.Text = "Клиенты";
            this.customersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // insuranceButton
            // 
            this.insuranceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.insuranceButton.FlatAppearance.BorderSize = 0;
            this.insuranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insuranceButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.insuranceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.insuranceButton.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.insuranceButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.insuranceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.insuranceButton.IconSize = 34;
            this.insuranceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insuranceButton.Location = new System.Drawing.Point(0, 277);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.insuranceButton.Size = new System.Drawing.Size(246, 52);
            this.insuranceButton.TabIndex = 4;
            this.insuranceButton.Text = "Страхование";
            this.insuranceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insuranceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // marketingButton
            // 
            this.marketingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketingButton.FlatAppearance.BorderSize = 0;
            this.marketingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marketingButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.marketingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.marketingButton.IconChar = FontAwesome.Sharp.IconChar.CarCrash;
            this.marketingButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.marketingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.marketingButton.IconSize = 34;
            this.marketingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marketingButton.Location = new System.Drawing.Point(0, 225);
            this.marketingButton.Name = "marketingButton";
            this.marketingButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.marketingButton.Size = new System.Drawing.Size(246, 52);
            this.marketingButton.TabIndex = 2;
            this.marketingButton.Text = "Виды страхования";
            this.marketingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marketingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.marketingButton.UseVisualStyleBackColor = true;
            this.marketingButton.Click += new System.EventHandler(this.marketingButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.dashboardButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardButton.IconSize = 34;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 173);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.dashboardButton.Size = new System.Drawing.Size(246, 52);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Главная";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // menuLogo
            // 
            this.menuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.menuLogo.Controls.Add(this.homeButton);
            this.menuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuLogo.Location = new System.Drawing.Point(0, 0);
            this.menuLogo.Name = "menuLogo";
            this.menuLogo.Size = new System.Drawing.Size(246, 173);
            this.menuLogo.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(246, 173);
            this.homeButton.TabIndex = 0;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // panelTittle
            // 
            this.panelTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.panelTittle.Controls.Add(this.button1);
            this.panelTittle.Controls.Add(this.buttonMaximize);
            this.panelTittle.Controls.Add(this.buttonClose);
            this.panelTittle.Controls.Add(this.textHome);
            this.panelTittle.Controls.Add(this.iconMainForm);
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(246, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(1040, 65);
            this.panelTittle.TabIndex = 1;
            this.panelTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(969, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.BackgroundImage")));
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(990, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(23, 35);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1011, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 35);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textHome
            // 
            this.textHome.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textHome.Location = new System.Drawing.Point(61, 25);
            this.textHome.Name = "textHome";
            this.textHome.Size = new System.Drawing.Size(256, 22);
            this.textHome.TabIndex = 1;
            this.textHome.Text = "Главная";
            // 
            // iconMainForm
            // 
            this.iconMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
            this.iconMainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconMainForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconMainForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconMainForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMainForm.IconSize = 49;
            this.iconMainForm.Location = new System.Drawing.Point(6, 12);
            this.iconMainForm.Name = "iconMainForm";
            this.iconMainForm.Size = new System.Drawing.Size(49, 53);
            this.iconMainForm.TabIndex = 0;
            this.iconMainForm.TabStop = false;
            // 
            // panelMainForm
            // 
            this.panelMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panelMainForm.Controls.Add(this.pictureBox1);
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm.Location = new System.Drawing.Point(246, 65);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(1040, 674);
            this.panelMainForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1286, 739);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.panelTittle);
            this.Controls.Add(this.menuMain);
            this.MinimumSize = new System.Drawing.Size(996, 618);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insurance Company";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.panelTittle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMainForm)).EndInit();
            this.panelMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button buttonMaximize;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Panel panelMainForm;

        private System.Windows.Forms.Panel panelTittle;

        private System.Windows.Forms.Label textHome;

        private FontAwesome.Sharp.IconPictureBox iconMainForm;

        private System.Windows.Forms.PictureBox homeButton;

        private FontAwesome.Sharp.IconButton marketingButton;

        private FontAwesome.Sharp.IconButton reportsButton;
        private FontAwesome.Sharp.IconButton settingsButton;

        private FontAwesome.Sharp.IconButton customersButton;

        private FontAwesome.Sharp.IconButton insuranceButton;

        private FontAwesome.Sharp.IconButton dashboardButton;

        private System.Windows.Forms.Panel menuLogo;
        private System.Windows.Forms.Panel menuMain;

        #endregion
    }
}