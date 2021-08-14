namespace Insurance
{
    partial class FormAddDogovor
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
            System.Windows.Forms.Label ___ДоговораLabel;
            System.Windows.Forms.Label дата_заключенияLabel;
            System.Windows.Forms.Label фИО_КлиентаLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label iD_КлиентаLabel;
            System.Windows.Forms.Label iD_Объекта_страхованияLabel;
            System.Windows.Forms.Label страховая_премияLabel;
            System.Windows.Forms.Label страховая_выплатаLabel;
            System.Windows.Forms.Label срок_действияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDogovor));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.database1DataSet = new Insurance.Database1DataSet();
            this.договораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter = new Insurance.Database1DataSetTableAdapters.ДоговораTableAdapter();
            this.tableAdapterManager = new Insurance.Database1DataSetTableAdapters.TableAdapterManager();
            this.договораBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.договораBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.___ДоговораTextBox = new System.Windows.Forms.TextBox();
            this.дата_заключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фИО_КлиентаTextBox = new System.Windows.Forms.TextBox();
            this.iD_КлиентаTextBox = new System.Windows.Forms.TextBox();
            this.iD_Объекта_страхованияTextBox = new System.Windows.Forms.TextBox();
            this.страховая_премияTextBox = new System.Windows.Forms.TextBox();
            this.страховая_выплатаTextBox = new System.Windows.Forms.TextBox();
            this.срок_действияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.паспортные_данныеTextBox = new System.Windows.Forms.MaskedTextBox();
            ___ДоговораLabel = new System.Windows.Forms.Label();
            дата_заключенияLabel = new System.Windows.Forms.Label();
            фИО_КлиентаLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            iD_КлиентаLabel = new System.Windows.Forms.Label();
            iD_Объекта_страхованияLabel = new System.Windows.Forms.Label();
            страховая_премияLabel = new System.Windows.Forms.Label();
            страховая_выплатаLabel = new System.Windows.Forms.Label();
            срок_действияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingNavigator)).BeginInit();
            this.договораBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ___ДоговораLabel
            // 
            ___ДоговораLabel.AutoSize = true;
            ___ДоговораLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            ___ДоговораLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            ___ДоговораLabel.Location = new System.Drawing.Point(22, 41);
            ___ДоговораLabel.Name = "___ДоговораLabel";
            ___ДоговораLabel.Size = new System.Drawing.Size(89, 17);
            ___ДоговораLabel.TabIndex = 43;
            ___ДоговораLabel.Text = "№ Договора:";
            // 
            // дата_заключенияLabel
            // 
            дата_заключенияLabel.AutoSize = true;
            дата_заключенияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            дата_заключенияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            дата_заключенияLabel.Location = new System.Drawing.Point(22, 77);
            дата_заключенияLabel.Name = "дата_заключенияLabel";
            дата_заключенияLabel.Size = new System.Drawing.Size(119, 17);
            дата_заключенияLabel.TabIndex = 44;
            дата_заключенияLabel.Text = "Дата заключения:";
            // 
            // фИО_КлиентаLabel
            // 
            фИО_КлиентаLabel.AutoSize = true;
            фИО_КлиентаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            фИО_КлиентаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            фИО_КлиентаLabel.Location = new System.Drawing.Point(22, 115);
            фИО_КлиентаLabel.Name = "фИО_КлиентаLabel";
            фИО_КлиентаLabel.Size = new System.Drawing.Size(95, 17);
            фИО_КлиентаLabel.TabIndex = 45;
            фИО_КлиентаLabel.Text = "ФИО Клиента:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            паспортные_данныеLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            паспортные_данныеLabel.Location = new System.Drawing.Point(22, 157);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(141, 17);
            паспортные_данныеLabel.TabIndex = 46;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // iD_КлиентаLabel
            // 
            iD_КлиентаLabel.AutoSize = true;
            iD_КлиентаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            iD_КлиентаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            iD_КлиентаLabel.Location = new System.Drawing.Point(23, 201);
            iD_КлиентаLabel.Name = "iD_КлиентаLabel";
            iD_КлиентаLabel.Size = new System.Drawing.Size(78, 17);
            iD_КлиентаLabel.TabIndex = 47;
            iD_КлиентаLabel.Text = "ID Клиента:";
            // 
            // iD_Объекта_страхованияLabel
            // 
            iD_Объекта_страхованияLabel.AutoSize = true;
            iD_Объекта_страхованияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            iD_Объекта_страхованияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            iD_Объекта_страхованияLabel.Location = new System.Drawing.Point(21, 245);
            iD_Объекта_страхованияLabel.Name = "iD_Объекта_страхованияLabel";
            iD_Объекта_страхованияLabel.Size = new System.Drawing.Size(161, 17);
            iD_Объекта_страхованияLabel.TabIndex = 48;
            iD_Объекта_страхованияLabel.Text = "ID Объекта страхования:";
            // 
            // страховая_премияLabel
            // 
            страховая_премияLabel.AutoSize = true;
            страховая_премияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            страховая_премияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            страховая_премияLabel.Location = new System.Drawing.Point(22, 292);
            страховая_премияLabel.Name = "страховая_премияLabel";
            страховая_премияLabel.Size = new System.Drawing.Size(127, 17);
            страховая_премияLabel.TabIndex = 49;
            страховая_премияLabel.Text = "Страховая премия:";
            // 
            // страховая_выплатаLabel
            // 
            страховая_выплатаLabel.AutoSize = true;
            страховая_выплатаLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            страховая_выплатаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            страховая_выплатаLabel.Location = new System.Drawing.Point(22, 336);
            страховая_выплатаLabel.Name = "страховая_выплатаLabel";
            страховая_выплатаLabel.Size = new System.Drawing.Size(131, 17);
            страховая_выплатаLabel.TabIndex = 50;
            страховая_выплатаLabel.Text = "Страховая выплата:";
            // 
            // срок_действияLabel
            // 
            срок_действияLabel.AutoSize = true;
            срок_действияLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            срок_действияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            срок_действияLabel.Location = new System.Drawing.Point(22, 380);
            срок_действияLabel.Name = "срок_действияLabel";
            срок_действияLabel.Size = new System.Drawing.Size(104, 17);
            срок_действияLabel.TabIndex = 51;
            срок_действияLabel.Text = "Срок действия:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.button1.Location = new System.Drawing.Point(352, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 42;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.buttonDelete.Location = new System.Drawing.Point(201, 361);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 42);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(111)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.buttonSave.Location = new System.Drawing.Point(48, 361);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 42);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договораBindingSource
            // 
            this.договораBindingSource.DataMember = "Договора";
            this.договораBindingSource.DataSource = this.database1DataSet;
            // 
            // договораTableAdapter
            // 
            this.договораTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Insurance.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговораTableAdapter = this.договораTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Объекты_страхованияTableAdapter = null;
            this.tableAdapterManager.Страховые_выплатыTableAdapter = null;
            // 
            // договораBindingNavigator
            // 
            this.договораBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.договораBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.договораBindingNavigator.BindingSource = this.договораBindingSource;
            this.договораBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.договораBindingNavigator.CountItemFormat = "из {0}";
            this.договораBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.договораBindingNavigator.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.договораBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.договораBindingNavigator.ImageScalingSize = new System.Drawing.Size(13, 13);
            this.договораBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.toolStripSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.договораBindingNavigatorSaveItem});
            this.договораBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.договораBindingNavigator.MoveFirstItem = null;
            this.договораBindingNavigator.MoveLastItem = null;
            this.договораBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.договораBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.договораBindingNavigator.Name = "договораBindingNavigator";
            this.договораBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.договораBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.договораBindingNavigator.Size = new System.Drawing.Size(535, 25);
            this.договораBindingNavigator.TabIndex = 43;
            this.договораBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // договораBindingNavigatorSaveItem
            // 
            this.договораBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.договораBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("договораBindingNavigatorSaveItem.Image")));
            this.договораBindingNavigatorSaveItem.Name = "договораBindingNavigatorSaveItem";
            this.договораBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.договораBindingNavigatorSaveItem.Text = "Save Data";
            this.договораBindingNavigatorSaveItem.Click += new System.EventHandler(this.договораBindingNavigatorSaveItem_Click_3);
            // 
            // ___ДоговораTextBox
            // 
            this.___ДоговораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "№ Договора", true));
            this.___ДоговораTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.___ДоговораTextBox.Location = new System.Drawing.Point(205, 41);
            this.___ДоговораTextBox.Name = "___ДоговораTextBox";
            this.___ДоговораTextBox.Size = new System.Drawing.Size(297, 20);
            this.___ДоговораTextBox.TabIndex = 44;
            // 
            // дата_заключенияDateTimePicker
            // 
            this.дата_заключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договораBindingSource, "Дата заключения", true));
            this.дата_заключенияDateTimePicker.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.дата_заключенияDateTimePicker.Location = new System.Drawing.Point(205, 77);
            this.дата_заключенияDateTimePicker.Name = "дата_заключенияDateTimePicker";
            this.дата_заключенияDateTimePicker.Size = new System.Drawing.Size(297, 20);
            this.дата_заключенияDateTimePicker.TabIndex = 45;
            // 
            // фИО_КлиентаTextBox
            // 
            this.фИО_КлиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "ФИО Клиента", true));
            this.фИО_КлиентаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.фИО_КлиентаTextBox.Location = new System.Drawing.Point(205, 115);
            this.фИО_КлиентаTextBox.Name = "фИО_КлиентаTextBox";
            this.фИО_КлиентаTextBox.Size = new System.Drawing.Size(297, 20);
            this.фИО_КлиентаTextBox.TabIndex = 46;
            this.фИО_КлиентаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.фИО_КлиентаTextBox_KeyPress);
            // 
            // iD_КлиентаTextBox
            // 
            this.iD_КлиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "ID Клиента", true));
            this.iD_КлиентаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_КлиентаTextBox.Location = new System.Drawing.Point(205, 201);
            this.iD_КлиентаTextBox.Name = "iD_КлиентаTextBox";
            this.iD_КлиентаTextBox.Size = new System.Drawing.Size(297, 20);
            this.iD_КлиентаTextBox.TabIndex = 48;
            this.iD_КлиентаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iD_КлиентаTextBox_KeyPress);
            // 
            // iD_Объекта_страхованияTextBox
            // 
            this.iD_Объекта_страхованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "ID Объекта страхования", true));
            this.iD_Объекта_страхованияTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_Объекта_страхованияTextBox.Location = new System.Drawing.Point(205, 245);
            this.iD_Объекта_страхованияTextBox.Name = "iD_Объекта_страхованияTextBox";
            this.iD_Объекта_страхованияTextBox.Size = new System.Drawing.Size(297, 20);
            this.iD_Объекта_страхованияTextBox.TabIndex = 49;
            this.iD_Объекта_страхованияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iD_Объекта_страхованияTextBox_KeyPress);
            // 
            // страховая_премияTextBox
            // 
            this.страховая_премияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "Страховая премия", true));
            this.страховая_премияTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.страховая_премияTextBox.Location = new System.Drawing.Point(205, 292);
            this.страховая_премияTextBox.Name = "страховая_премияTextBox";
            this.страховая_премияTextBox.Size = new System.Drawing.Size(297, 20);
            this.страховая_премияTextBox.TabIndex = 50;
            this.страховая_премияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iD_КлиентаTextBox_KeyPress);
            // 
            // страховая_выплатаTextBox
            // 
            this.страховая_выплатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "Страховая выплата", true));
            this.страховая_выплатаTextBox.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.страховая_выплатаTextBox.Location = new System.Drawing.Point(205, 334);
            this.страховая_выплатаTextBox.Name = "страховая_выплатаTextBox";
            this.страховая_выплатаTextBox.Size = new System.Drawing.Size(297, 20);
            this.страховая_выплатаTextBox.TabIndex = 51;
            this.страховая_выплатаTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iD_КлиентаTextBox_KeyPress);
            // 
            // срок_действияDateTimePicker
            // 
            this.срок_действияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договораBindingSource, "Срок действия", true));
            this.срок_действияDateTimePicker.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.срок_действияDateTimePicker.Location = new System.Drawing.Point(205, 377);
            this.срок_действияDateTimePicker.Name = "срок_действияDateTimePicker";
            this.срок_действияDateTimePicker.Size = new System.Drawing.Size(297, 20);
            this.срок_действияDateTimePicker.TabIndex = 52;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(205, 157);
            this.паспортные_данныеTextBox.Mask = "Серия: 0000 Номер: 000000 Выдан: LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLLLLLLLLLLLLLL";
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(297, 20);
            this.паспортные_данныеTextBox.TabIndex = 53;
            // 
            // FormAddDogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(535, 446);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(срок_действияLabel);
            this.Controls.Add(this.срок_действияDateTimePicker);
            this.Controls.Add(страховая_выплатаLabel);
            this.Controls.Add(this.страховая_выплатаTextBox);
            this.Controls.Add(страховая_премияLabel);
            this.Controls.Add(this.страховая_премияTextBox);
            this.Controls.Add(iD_Объекта_страхованияLabel);
            this.Controls.Add(this.iD_Объекта_страхованияTextBox);
            this.Controls.Add(iD_КлиентаLabel);
            this.Controls.Add(this.iD_КлиентаTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(фИО_КлиентаLabel);
            this.Controls.Add(this.фИО_КлиентаTextBox);
            this.Controls.Add(дата_заключенияLabel);
            this.Controls.Add(this.дата_заключенияDateTimePicker);
            this.Controls.Add(___ДоговораLabel);
            this.Controls.Add(this.___ДоговораTextBox);
            this.Controls.Add(this.договораBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddDogovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddDogovor_FormClosing);
            this.Load += new System.EventHandler(this.FormAddDogovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingNavigator)).EndInit();
            this.договораBindingNavigator.ResumeLayout(false);
            this.договораBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource договораBindingSource;
        private Database1DataSetTableAdapters.ДоговораTableAdapter договораTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator договораBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton договораBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ___ДоговораTextBox;
        private System.Windows.Forms.DateTimePicker дата_заключенияDateTimePicker;
        private System.Windows.Forms.TextBox фИО_КлиентаTextBox;
        private System.Windows.Forms.TextBox iD_КлиентаTextBox;
        private System.Windows.Forms.TextBox iD_Объекта_страхованияTextBox;
        private System.Windows.Forms.TextBox страховая_премияTextBox;
        private System.Windows.Forms.TextBox страховая_выплатаTextBox;
        private System.Windows.Forms.DateTimePicker срок_действияDateTimePicker;
        private System.Windows.Forms.MaskedTextBox паспортные_данныеTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}