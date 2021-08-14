namespace Insurance
{
    partial class FormAddClient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label номер_клиентаLabel;
            System.Windows.Forms.Label фИО_клиентаLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label примечаниеLabel;
            System.Windows.Forms.Label телефонLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddClient));
            this.database1DataSet = new Insurance.Database1DataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Insurance.Database1DataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new Insurance.Database1DataSetTableAdapters.TableAdapterManager();
            this.клиентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.клиентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.фИО_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.примечаниеTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.MaskedTextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.клиентыДоговораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter = new Insurance.Database1DataSetTableAdapters.ДоговораTableAdapter();
            номер_клиентаLabel = new System.Windows.Forms.Label();
            фИО_клиентаLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            примечаниеLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).BeginInit();
            this.клиентыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыДоговораBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_клиентаLabel
            // 
            номер_клиентаLabel.AutoSize = true;
            номер_клиентаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            номер_клиентаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            номер_клиентаLabel.Location = new System.Drawing.Point(38, 69);
            номер_клиентаLabel.Name = "номер_клиентаLabel";
            номер_клиентаLabel.Size = new System.Drawing.Size(107, 17);
            номер_клиентаLabel.TabIndex = 1;
            номер_клиентаLabel.Text = "Номер клиента:";
            // 
            // фИО_клиентаLabel
            // 
            фИО_клиентаLabel.AutoSize = true;
            фИО_клиентаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            фИО_клиентаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            фИО_клиентаLabel.Location = new System.Drawing.Point(38, 110);
            фИО_клиентаLabel.Name = "фИО_клиентаLabel";
            фИО_клиентаLabel.Size = new System.Drawing.Size(94, 17);
            фИО_клиентаLabel.TabIndex = 3;
            фИО_клиентаLabel.Text = "ФИО клиента:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            дата_рожденияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            дата_рожденияLabel.Location = new System.Drawing.Point(38, 150);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(106, 17);
            дата_рожденияLabel.TabIndex = 7;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            адресLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            адресLabel.Location = new System.Drawing.Point(38, 225);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(51, 17);
            адресLabel.TabIndex = 13;
            адресLabel.Text = "Адрес:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            паспортные_данныеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            паспортные_данныеLabel.Location = new System.Drawing.Point(38, 264);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(141, 17);
            паспортные_данныеLabel.TabIndex = 15;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // примечаниеLabel
            // 
            примечаниеLabel.AutoSize = true;
            примечаниеLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            примечаниеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            примечаниеLabel.Location = new System.Drawing.Point(38, 306);
            примечаниеLabel.Name = "примечаниеLabel";
            примечаниеLabel.Size = new System.Drawing.Size(91, 17);
            примечаниеLabel.TabIndex = 17;
            примечаниеLabel.Text = "Примечание:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            телефонLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            телефонLabel.Location = new System.Drawing.Point(38, 186);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(68, 17);
            телефонLabel.TabIndex = 56;
            телефонLabel.Text = "Телефон:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.database1DataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Insurance.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговораTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.Объекты_страхованияTableAdapter = null;
            this.tableAdapterManager.Страховые_выплатыTableAdapter = null;
            // 
            // клиентыBindingNavigator
            // 
            this.клиентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиентыBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.клиентыBindingNavigator.BindingSource = this.клиентыBindingSource;
            this.клиентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиентыBindingNavigator.CountItemFormat = "из {0}";
            this.клиентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиентыBindingNavigator.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.клиентыBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.клиентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.клиентыBindingNavigatorSaveItem});
            this.клиентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентыBindingNavigator.MoveFirstItem = null;
            this.клиентыBindingNavigator.MoveLastItem = null;
            this.клиентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиентыBindingNavigator.Name = "клиентыBindingNavigator";
            this.клиентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиентыBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.клиентыBindingNavigator.Size = new System.Drawing.Size(533, 25);
            this.клиентыBindingNavigator.TabIndex = 0;
            this.клиентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // клиентыBindingNavigatorSaveItem
            // 
            this.клиентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентыBindingNavigatorSaveItem.Image")));
            this.клиентыBindingNavigatorSaveItem.Name = "клиентыBindingNavigatorSaveItem";
            this.клиентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клиентыBindingNavigatorSaveItem.Text = "Save Data";
            this.клиентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентыBindingNavigatorSaveItem_Click);
            // 
            // номер_клиентаTextBox
            // 
            this.номер_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Номер клиента", true));
            this.номер_клиентаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.номер_клиентаTextBox.Location = new System.Drawing.Point(249, 69);
            this.номер_клиентаTextBox.Name = "номер_клиентаTextBox";
            this.номер_клиентаTextBox.Size = new System.Drawing.Size(248, 20);
            this.номер_клиентаTextBox.TabIndex = 2;
            this.номер_клиентаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // фИО_клиентаTextBox
            // 
            this.фИО_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "ФИО клиента", true));
            this.фИО_клиентаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.фИО_клиентаTextBox.Location = new System.Drawing.Point(249, 110);
            this.фИО_клиентаTextBox.Name = "фИО_клиентаTextBox";
            this.фИО_клиентаTextBox.Size = new System.Drawing.Size(248, 20);
            this.фИО_клиентаTextBox.TabIndex = 4;
            this.фИО_клиентаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.фИО_клиентаTextBox_KeyPress);
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(249, 147);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 8;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.адресTextBox.Location = new System.Drawing.Point(249, 225);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(248, 20);
            this.адресTextBox.TabIndex = 14;
            // 
            // примечаниеTextBox
            // 
            this.примечаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Примечание", true));
            this.примечаниеTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.примечаниеTextBox.Location = new System.Drawing.Point(249, 306);
            this.примечаниеTextBox.Name = "примечаниеTextBox";
            this.примечаниеTextBox.Size = new System.Drawing.Size(248, 20);
            this.примечаниеTextBox.TabIndex = 18;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(249, 264);
            this.паспортные_данныеTextBox.Mask = "Серия: 0000 Номер: 000000 Выдан: LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLLLLLLLLLLLLLL";
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(248, 20);
            this.паспортные_данныеTextBox.TabIndex = 54;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(249, 186);
            this.телефонTextBox.MaxLength = 11;
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(248, 20);
            this.телефонTextBox.TabIndex = 57;
            this.телефонTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.телефонTextBox_KeyPress);
            // 
            // клиентыДоговораBindingSource
            // 
            this.клиентыДоговораBindingSource.DataMember = "КлиентыДоговора";
            this.клиентыДоговораBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // договораTableAdapter
            // 
            this.договораTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(533, 449);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(примечаниеLabel);
            this.Controls.Add(this.примечаниеTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(фИО_клиентаLabel);
            this.Controls.Add(this.фИО_клиентаTextBox);
            this.Controls.Add(номер_клиентаLabel);
            this.Controls.Add(this.номер_клиентаTextBox);
            this.Controls.Add(this.клиентыBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).EndInit();
            this.клиентыBindingNavigator.ResumeLayout(false);
            this.клиентыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыДоговораBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Database1DataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton клиентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_клиентаTextBox;
        private System.Windows.Forms.TextBox фИО_клиентаTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox примечаниеTextBox;
        private System.Windows.Forms.MaskedTextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.BindingSource клиентыДоговораBindingSource;
        private Database1DataSetTableAdapters.ДоговораTableAdapter договораTableAdapter;
    }
}