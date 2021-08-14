namespace Insurance
{
    partial class FormAddWithdrawMoney
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
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label ___ДоговораLabel;
            System.Windows.Forms.Label дата_заключенияLabel;
            System.Windows.Forms.Label срок_действия_доLabel;
            System.Windows.Forms.Label iD_клиентаLabel;
            System.Windows.Forms.Label iD_объектаLabel;
            System.Windows.Forms.Label страховая_премияLabel;
            System.Windows.Forms.Label сумма_выплатыLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddWithdrawMoney));
            this.database1DataSet = new Insurance.Database1DataSet();
            this.страховые_выплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.страховые_выплатыTableAdapter = new Insurance.Database1DataSetTableAdapters.Страховые_выплатыTableAdapter();
            this.tableAdapterManager = new Insurance.Database1DataSetTableAdapters.TableAdapterManager();
            this.страховые_выплатыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.страховые_выплатыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.___ДоговораTextBox = new System.Windows.Forms.TextBox();
            this.дата_заключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.срок_действия_доDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.iD_объектаTextBox = new System.Windows.Forms.TextBox();
            this.страховая_премияTextBox = new System.Windows.Forms.TextBox();
            this.сумма_выплатыTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            датаLabel = new System.Windows.Forms.Label();
            ___ДоговораLabel = new System.Windows.Forms.Label();
            дата_заключенияLabel = new System.Windows.Forms.Label();
            срок_действия_доLabel = new System.Windows.Forms.Label();
            iD_клиентаLabel = new System.Windows.Forms.Label();
            iD_объектаLabel = new System.Windows.Forms.Label();
            страховая_премияLabel = new System.Windows.Forms.Label();
            сумма_выплатыLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховые_выплатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховые_выплатыBindingNavigator)).BeginInit();
            this.страховые_выплатыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            датаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            датаLabel.Location = new System.Drawing.Point(21, 62);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(39, 17);
            датаLabel.TabIndex = 1;
            датаLabel.Text = "Дата:";
            // 
            // ___ДоговораLabel
            // 
            ___ДоговораLabel.AutoSize = true;
            ___ДоговораLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            ___ДоговораLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            ___ДоговораLabel.Location = new System.Drawing.Point(21, 100);
            ___ДоговораLabel.Name = "___ДоговораLabel";
            ___ДоговораLabel.Size = new System.Drawing.Size(89, 17);
            ___ДоговораLabel.TabIndex = 3;
            ___ДоговораLabel.Text = "№ Договора:";
            // 
            // дата_заключенияLabel
            // 
            дата_заключенияLabel.AutoSize = true;
            дата_заключенияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            дата_заключенияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            дата_заключенияLabel.Location = new System.Drawing.Point(21, 144);
            дата_заключенияLabel.Name = "дата_заключенияLabel";
            дата_заключенияLabel.Size = new System.Drawing.Size(119, 17);
            дата_заключенияLabel.TabIndex = 5;
            дата_заключенияLabel.Text = "Дата заключения:";
            // 
            // срок_действия_доLabel
            // 
            срок_действия_доLabel.AutoSize = true;
            срок_действия_доLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            срок_действия_доLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            срок_действия_доLabel.Location = new System.Drawing.Point(21, 184);
            срок_действия_доLabel.Name = "срок_действия_доLabel";
            срок_действия_доLabel.Size = new System.Drawing.Size(123, 17);
            срок_действия_доLabel.TabIndex = 7;
            срок_действия_доLabel.Text = "Срок действия до:";
            // 
            // iD_клиентаLabel
            // 
            iD_клиентаLabel.AutoSize = true;
            iD_клиентаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            iD_клиентаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            iD_клиентаLabel.Location = new System.Drawing.Point(21, 226);
            iD_клиентаLabel.Name = "iD_клиентаLabel";
            iD_клиентаLabel.Size = new System.Drawing.Size(77, 17);
            iD_клиентаLabel.TabIndex = 9;
            iD_клиентаLabel.Text = "ID клиента:";
            // 
            // iD_объектаLabel
            // 
            iD_объектаLabel.AutoSize = true;
            iD_объектаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            iD_объектаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            iD_объектаLabel.Location = new System.Drawing.Point(21, 265);
            iD_объектаLabel.Name = "iD_объектаLabel";
            iD_объектаLabel.Size = new System.Drawing.Size(77, 17);
            iD_объектаLabel.TabIndex = 11;
            iD_объектаLabel.Text = "ID объекта:";
            // 
            // страховая_премияLabel
            // 
            страховая_премияLabel.AutoSize = true;
            страховая_премияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            страховая_премияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            страховая_премияLabel.Location = new System.Drawing.Point(21, 299);
            страховая_премияLabel.Name = "страховая_премияLabel";
            страховая_премияLabel.Size = new System.Drawing.Size(127, 17);
            страховая_премияLabel.TabIndex = 13;
            страховая_премияLabel.Text = "Страховая премия:";
            // 
            // сумма_выплатыLabel
            // 
            сумма_выплатыLabel.AutoSize = true;
            сумма_выплатыLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            сумма_выплатыLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            сумма_выплатыLabel.Location = new System.Drawing.Point(21, 334);
            сумма_выплатыLabel.Name = "сумма_выплатыLabel";
            сумма_выплатыLabel.Size = new System.Drawing.Size(110, 17);
            сумма_выплатыLabel.TabIndex = 15;
            сумма_выплатыLabel.Text = "Сумма выплаты:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            описаниеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            описаниеLabel.Location = new System.Drawing.Point(21, 371);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 17);
            описаниеLabel.TabIndex = 17;
            описаниеLabel.Text = "Описание:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // страховые_выплатыBindingSource
            // 
            this.страховые_выплатыBindingSource.DataMember = "Страховые выплаты";
            this.страховые_выплатыBindingSource.DataSource = this.database1DataSet;
            // 
            // страховые_выплатыTableAdapter
            // 
            this.страховые_выплатыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Insurance.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговораTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Объекты_страхованияTableAdapter = null;
            this.tableAdapterManager.Страховые_выплатыTableAdapter = this.страховые_выплатыTableAdapter;
            // 
            // страховые_выплатыBindingNavigator
            // 
            this.страховые_выплатыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.страховые_выплатыBindingNavigator.BindingSource = this.страховые_выплатыBindingSource;
            this.страховые_выплатыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.страховые_выплатыBindingNavigator.CountItemFormat = "из {0}";
            this.страховые_выплатыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.страховые_выплатыBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.страховые_выплатыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.страховые_выплатыBindingNavigatorSaveItem});
            this.страховые_выплатыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.страховые_выплатыBindingNavigator.MoveFirstItem = null;
            this.страховые_выплатыBindingNavigator.MoveLastItem = null;
            this.страховые_выплатыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.страховые_выплатыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.страховые_выплатыBindingNavigator.Name = "страховые_выплатыBindingNavigator";
            this.страховые_выплатыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.страховые_выплатыBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.страховые_выплатыBindingNavigator.Size = new System.Drawing.Size(533, 25);
            this.страховые_выплатыBindingNavigator.TabIndex = 0;
            this.страховые_выплатыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
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
            // страховые_выплатыBindingNavigatorSaveItem
            // 
            this.страховые_выплатыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.страховые_выплатыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("страховые_выплатыBindingNavigatorSaveItem.Image")));
            this.страховые_выплатыBindingNavigatorSaveItem.Name = "страховые_выплатыBindingNavigatorSaveItem";
            this.страховые_выплатыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.страховые_выплатыBindingNavigatorSaveItem.Text = "Save Data";
            this.страховые_выплатыBindingNavigatorSaveItem.Click += new System.EventHandler(this.страховые_выплатыBindingNavigatorSaveItem_Click);
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.страховые_выплатыBindingSource, "Дата", true));
            this.датаDateTimePicker.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.датаDateTimePicker.Location = new System.Drawing.Point(241, 62);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 2;
            // 
            // ___ДоговораTextBox
            // 
            this.___ДоговораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.страховые_выплатыBindingSource, "№ Договора", true));
            this.___ДоговораTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.___ДоговораTextBox.Location = new System.Drawing.Point(241, 100);
            this.___ДоговораTextBox.Name = "___ДоговораTextBox";
            this.___ДоговораTextBox.Size = new System.Drawing.Size(200, 20);
            this.___ДоговораTextBox.TabIndex = 4;
            // 
            // дата_заключенияDateTimePicker
            // 
            this.дата_заключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.страховые_выплатыBindingSource, "Дата заключения", true));
            this.дата_заключенияDateTimePicker.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.дата_заключенияDateTimePicker.Location = new System.Drawing.Point(241, 140);
            this.дата_заключенияDateTimePicker.Name = "дата_заключенияDateTimePicker";
            this.дата_заключенияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заключенияDateTimePicker.TabIndex = 6;
            // 
            // срок_действия_доDateTimePicker
            // 
            this.срок_действия_доDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.страховые_выплатыBindingSource, "Срок действия до", true));
            this.срок_действия_доDateTimePicker.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.срок_действия_доDateTimePicker.Location = new System.Drawing.Point(241, 181);
            this.срок_действия_доDateTimePicker.Name = "срок_действия_доDateTimePicker";
            this.срок_действия_доDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.срок_действия_доDateTimePicker.TabIndex = 8;
            // 
            // iD_клиентаTextBox
            // 
            this.iD_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.страховые_выплатыBindingSource, "ID клиента", true));
            this.iD_клиентаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.iD_клиентаTextBox.Location = new System.Drawing.Point(241, 223);
            this.iD_клиентаTextBox.Name = "iD_клиентаTextBox";
            this.iD_клиентаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_клиентаTextBox.TabIndex = 10;
            // 
            // iD_объектаTextBox
            // 
            this.iD_объектаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.страховые_выплатыBindingSource, "ID объекта", true));
            this.iD_объектаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.iD_объектаTextBox.Location = new System.Drawing.Point(241, 262);
            this.iD_объектаTextBox.Name = "iD_объектаTextBox";
            this.iD_объектаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_объектаTextBox.TabIndex = 12;
            // 
            // страховая_премияTextBox
            // 
            this.страховая_премияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.страховые_выплатыBindingSource, "Страховая премия", true));
            this.страховая_премияTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.страховая_премияTextBox.Location = new System.Drawing.Point(241, 296);
            this.страховая_премияTextBox.Name = "страховая_премияTextBox";
            this.страховая_премияTextBox.Size = new System.Drawing.Size(200, 20);
            this.страховая_премияTextBox.TabIndex = 14;
            // 
            // сумма_выплатыTextBox
            // 
            this.сумма_выплатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.страховые_выплатыBindingSource, "Сумма выплаты", true));
            this.сумма_выплатыTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.сумма_выплатыTextBox.Location = new System.Drawing.Point(241, 331);
            this.сумма_выплатыTextBox.Name = "сумма_выплатыTextBox";
            this.сумма_выплатыTextBox.Size = new System.Drawing.Size(200, 20);
            this.сумма_выплатыTextBox.TabIndex = 16;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.страховые_выплатыBindingSource, "Описание", true));
            this.описаниеTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.описаниеTextBox.Location = new System.Drawing.Point(241, 368);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 20);
            this.описаниеTextBox.TabIndex = 18;
            // 
            // FormAddWithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(533, 436);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(сумма_выплатыLabel);
            this.Controls.Add(this.сумма_выплатыTextBox);
            this.Controls.Add(страховая_премияLabel);
            this.Controls.Add(this.страховая_премияTextBox);
            this.Controls.Add(iD_объектаLabel);
            this.Controls.Add(this.iD_объектаTextBox);
            this.Controls.Add(iD_клиентаLabel);
            this.Controls.Add(this.iD_клиентаTextBox);
            this.Controls.Add(срок_действия_доLabel);
            this.Controls.Add(this.срок_действия_доDateTimePicker);
            this.Controls.Add(дата_заключенияLabel);
            this.Controls.Add(this.дата_заключенияDateTimePicker);
            this.Controls.Add(___ДоговораLabel);
            this.Controls.Add(this.___ДоговораTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.страховые_выплатыBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddWithdrawMoney";
            this.Load += new System.EventHandler(this.FormAddWithdrawMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховые_выплатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховые_выплатыBindingNavigator)).EndInit();
            this.страховые_выплатыBindingNavigator.ResumeLayout(false);
            this.страховые_выплатыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource страховые_выплатыBindingSource;
        private Database1DataSetTableAdapters.Страховые_выплатыTableAdapter страховые_выплатыTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator страховые_выплатыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton страховые_выплатыBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox ___ДоговораTextBox;
        private System.Windows.Forms.DateTimePicker дата_заключенияDateTimePicker;
        private System.Windows.Forms.DateTimePicker срок_действия_доDateTimePicker;
        private System.Windows.Forms.TextBox iD_клиентаTextBox;
        private System.Windows.Forms.TextBox iD_объектаTextBox;
        private System.Windows.Forms.TextBox страховая_премияTextBox;
        private System.Windows.Forms.TextBox сумма_выплатыTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
    }
}