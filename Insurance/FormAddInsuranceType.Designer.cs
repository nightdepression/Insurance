namespace Insurance
{
    partial class FormAddInsuranceType
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
            System.Windows.Forms.Label объект_страхованияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddInsuranceType));
            this.database1DataSet = new Insurance.Database1DataSet();
            this.объекты_страхованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.объекты_страхованияTableAdapter = new Insurance.Database1DataSetTableAdapters.Объекты_страхованияTableAdapter();
            this.tableAdapterManager = new Insurance.Database1DataSetTableAdapters.TableAdapterManager();
            this.объекты_страхованияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.объекты_страхованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.объект_страхованияTextBox = new System.Windows.Forms.TextBox();
            объект_страхованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объекты_страхованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объекты_страхованияBindingNavigator)).BeginInit();
            this.объекты_страхованияBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // объект_страхованияLabel
            // 
            объект_страхованияLabel.AutoSize = true;
            объект_страхованияLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            объект_страхованияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            объект_страхованияLabel.Location = new System.Drawing.Point(21, 102);
            объект_страхованияLabel.Name = "объект_страхованияLabel";
            объект_страхованияLabel.Size = new System.Drawing.Size(169, 20);
            объект_страхованияLabel.TabIndex = 1;
            объект_страхованияLabel.Text = "Объект страхования:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // объекты_страхованияBindingSource
            // 
            this.объекты_страхованияBindingSource.DataMember = "Объекты страхования";
            this.объекты_страхованияBindingSource.DataSource = this.database1DataSet;
            // 
            // объекты_страхованияTableAdapter
            // 
            this.объекты_страхованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Insurance.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговораTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Объекты_страхованияTableAdapter = this.объекты_страхованияTableAdapter;
            this.tableAdapterManager.Страховые_выплатыTableAdapter = null;
            // 
            // объекты_страхованияBindingNavigator
            // 
            this.объекты_страхованияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.объекты_страхованияBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.объекты_страхованияBindingNavigator.BindingSource = this.объекты_страхованияBindingSource;
            this.объекты_страхованияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.объекты_страхованияBindingNavigator.CountItemFormat = "из {0}";
            this.объекты_страхованияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.объекты_страхованияBindingNavigator.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.объекты_страхованияBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.объекты_страхованияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.объекты_страхованияBindingNavigatorSaveItem});
            this.объекты_страхованияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.объекты_страхованияBindingNavigator.MoveFirstItem = null;
            this.объекты_страхованияBindingNavigator.MoveLastItem = null;
            this.объекты_страхованияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.объекты_страхованияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.объекты_страхованияBindingNavigator.Name = "объекты_страхованияBindingNavigator";
            this.объекты_страхованияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.объекты_страхованияBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.объекты_страхованияBindingNavigator.Size = new System.Drawing.Size(526, 25);
            this.объекты_страхованияBindingNavigator.TabIndex = 0;
            this.объекты_страхованияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // объекты_страхованияBindingNavigatorSaveItem
            // 
            this.объекты_страхованияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.объекты_страхованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("объекты_страхованияBindingNavigatorSaveItem.Image")));
            this.объекты_страхованияBindingNavigatorSaveItem.Name = "объекты_страхованияBindingNavigatorSaveItem";
            this.объекты_страхованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.объекты_страхованияBindingNavigatorSaveItem.Text = "Save Data";
            this.объекты_страхованияBindingNavigatorSaveItem.Click += new System.EventHandler(this.объекты_страхованияBindingNavigatorSaveItem_Click);
            // 
            // объект_страхованияTextBox
            // 
            this.объект_страхованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объекты_страхованияBindingSource, "Объект страхования", true));
            this.объект_страхованияTextBox.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.объект_страхованияTextBox.Location = new System.Drawing.Point(221, 101);
            this.объект_страхованияTextBox.Name = "объект_страхованияTextBox";
            this.объект_страхованияTextBox.Size = new System.Drawing.Size(293, 26);
            this.объект_страхованияTextBox.TabIndex = 2;
            this.объект_страхованияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.объект_страхованияTextBox_KeyPress);
            // 
            // FormAddInsuranceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(526, 231);
            this.Controls.Add(объект_страхованияLabel);
            this.Controls.Add(this.объект_страхованияTextBox);
            this.Controls.Add(this.объекты_страхованияBindingNavigator);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddInsuranceType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAddInsuranceType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объекты_страхованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объекты_страхованияBindingNavigator)).EndInit();
            this.объекты_страхованияBindingNavigator.ResumeLayout(false);
            this.объекты_страхованияBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource объекты_страхованияBindingSource;
        private Database1DataSetTableAdapters.Объекты_страхованияTableAdapter объекты_страхованияTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator объекты_страхованияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton объекты_страхованияBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox объект_страхованияTextBox;
    }
}