namespace Example_15_SQL_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbNameCell = new System.Windows.Forms.TextBox();
            this.lbNameCell = new System.Windows.Forms.Label();
            this.lbDataType = new System.Windows.Forms.Label();
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.btAddRows = new System.Windows.Forms.Button();
            this.lbTableFormat = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbTableName = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.tbDelete = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbNameDataBase = new System.Windows.Forms.TextBox();
            this.lbNameDb = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btUpdate = new System.Windows.Forms.Button();
            this.lbLogins = new System.Windows.Forms.Label();
            this.cbDtLogins = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.dataSet = new Example_15_SQL_.DataSet();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new Example_15_SQL_.DataSetTableAdapters.LoginsTableAdapter();
            this.tableAdapterManager = new Example_15_SQL_.DataSetTableAdapters.TableAdapterManager();
            this.loginsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.loginsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvLoginsUpdate = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInsert = new System.Windows.Forms.TabPage();
            this.dgvLoginsInsert = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNewnvcLogins = new System.Windows.Forms.TextBox();
            this.tbNewnvcPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tbDelete.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingNavigator)).BeginInit();
            this.loginsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginsUpdate)).BeginInit();
            this.tbInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginsInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbDelete);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbInsert);
            this.tabControl1.Location = new System.Drawing.Point(2, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Maroon;
            this.tabPage1.Controls.Add(this.tbNameCell);
            this.tabPage1.Controls.Add(this.lbNameCell);
            this.tabPage1.Controls.Add(this.lbDataType);
            this.tabPage1.Controls.Add(this.cbDataType);
            this.tabPage1.Controls.Add(this.btAddRows);
            this.tabPage1.Controls.Add(this.lbTableFormat);
            this.tabPage1.Controls.Add(this.grid);
            this.tabPage1.Controls.Add(this.btCreate);
            this.tabPage1.Controls.Add(this.lbTableName);
            this.tabPage1.Controls.Add(this.tbTableName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CREATE";
            // 
            // tbNameCell
            // 
            this.tbNameCell.Location = new System.Drawing.Point(125, 239);
            this.tbNameCell.Name = "tbNameCell";
            this.tbNameCell.Size = new System.Drawing.Size(161, 20);
            this.tbNameCell.TabIndex = 9;
            // 
            // lbNameCell
            // 
            this.lbNameCell.AutoSize = true;
            this.lbNameCell.BackColor = System.Drawing.Color.Fuchsia;
            this.lbNameCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameCell.Location = new System.Drawing.Point(6, 237);
            this.lbNameCell.Name = "lbNameCell";
            this.lbNameCell.Size = new System.Drawing.Size(81, 20);
            this.lbNameCell.TabIndex = 8;
            this.lbNameCell.Text = "Name Cell";
            // 
            // lbDataType
            // 
            this.lbDataType.AutoSize = true;
            this.lbDataType.BackColor = System.Drawing.Color.Fuchsia;
            this.lbDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDataType.Location = new System.Drawing.Point(6, 198);
            this.lbDataType.Name = "lbDataType";
            this.lbDataType.Size = new System.Drawing.Size(78, 20);
            this.lbDataType.TabIndex = 7;
            this.lbDataType.Text = "Data type";
            // 
            // cbDataType
            // 
            this.cbDataType.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDataType.FormattingEnabled = true;
            this.cbDataType.Items.AddRange(new object[] {
            "CHAR",
            "VARCHAR",
            "TEXT",
            "NCHAR",
            "NVARCHAR",
            "NTEXT",
            "INT",
            "FLOAT",
            "DATE",
            "DATETIME",
            "TIME"});
            this.cbDataType.Location = new System.Drawing.Point(125, 198);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(161, 29);
            this.cbDataType.TabIndex = 6;
            this.cbDataType.Text = "INT";
            // 
            // btAddRows
            // 
            this.btAddRows.BackColor = System.Drawing.Color.White;
            this.btAddRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddRows.Location = new System.Drawing.Point(61, 308);
            this.btAddRows.Name = "btAddRows";
            this.btAddRows.Size = new System.Drawing.Size(161, 23);
            this.btAddRows.TabIndex = 5;
            this.btAddRows.Text = "Add int the table";
            this.btAddRows.UseVisualStyleBackColor = false;
            this.btAddRows.Click += new System.EventHandler(this.btAddRows_Click);
            // 
            // lbTableFormat
            // 
            this.lbTableFormat.AutoSize = true;
            this.lbTableFormat.BackColor = System.Drawing.Color.Cyan;
            this.lbTableFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableFormat.Location = new System.Drawing.Point(360, 103);
            this.lbTableFormat.Name = "lbTableFormat";
            this.lbTableFormat.Size = new System.Drawing.Size(132, 25);
            this.lbTableFormat.TabIndex = 4;
            this.lbTableFormat.Text = "Table format";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grid.Location = new System.Drawing.Point(292, 131);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(243, 228);
            this.grid.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name Cell";
            this.Column2.Name = "Column2";
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.Yellow;
            this.btCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreate.Location = new System.Drawing.Point(10, 52);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(116, 50);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create Table";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.BackColor = System.Drawing.Color.Lime;
            this.lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableName.Location = new System.Drawing.Point(6, 12);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(124, 24);
            this.lbTableName.TabIndex = 1;
            this.lbTableName.Text = "Name Table";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(146, 16);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(247, 20);
            this.tbTableName.TabIndex = 0;
            // 
            // tbDelete
            // 
            this.tbDelete.BackColor = System.Drawing.Color.Black;
            this.tbDelete.Controls.Add(this.btDelete);
            this.tbDelete.Controls.Add(this.tbNameDataBase);
            this.tbDelete.Controls.Add(this.lbNameDb);
            this.tbDelete.ForeColor = System.Drawing.Color.Black;
            this.tbDelete.Location = new System.Drawing.Point(4, 22);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbDelete.Size = new System.Drawing.Size(533, 359);
            this.tbDelete.TabIndex = 1;
            this.tbDelete.Text = "DELETE";
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDelete.Location = new System.Drawing.Point(176, 170);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(146, 62);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbNameDataBase
            // 
            this.tbNameDataBase.Location = new System.Drawing.Point(258, 46);
            this.tbNameDataBase.Multiline = true;
            this.tbNameDataBase.Name = "tbNameDataBase";
            this.tbNameDataBase.Size = new System.Drawing.Size(194, 29);
            this.tbNameDataBase.TabIndex = 1;
            // 
            // lbNameDb
            // 
            this.lbNameDb.AutoSize = true;
            this.lbNameDb.BackColor = System.Drawing.Color.White;
            this.lbNameDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameDb.Location = new System.Drawing.Point(18, 46);
            this.lbNameDb.Name = "lbNameDb";
            this.lbNameDb.Size = new System.Drawing.Size(194, 29);
            this.lbNameDb.TabIndex = 0;
            this.lbNameDb.Text = "Name Data Base";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Yellow;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvLoginsUpdate);
            this.tabPage2.Controls.Add(this.tbNewValue);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbDtLogins);
            this.tabPage2.Controls.Add(this.btUpdate);
            this.tabPage2.Controls.Add(this.lbLogins);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 359);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "UPDATE";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Lime;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btUpdate.Location = new System.Drawing.Point(322, 282);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(198, 74);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lbLogins
            // 
            this.lbLogins.AutoSize = true;
            this.lbLogins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbLogins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogins.Location = new System.Drawing.Point(216, 24);
            this.lbLogins.Name = "lbLogins";
            this.lbLogins.Size = new System.Drawing.Size(66, 24);
            this.lbLogins.TabIndex = 1;
            this.lbLogins.Text = "Logins";
            // 
            // cbDtLogins
            // 
            this.cbDtLogins.FormattingEnabled = true;
            this.cbDtLogins.Items.AddRange(new object[] {
            "intId",
            "nvcLogins",
            "nvcPassword"});
            this.cbDtLogins.Location = new System.Drawing.Point(121, 282);
            this.cbDtLogins.Name = "cbDtLogins";
            this.cbDtLogins.Size = new System.Drawing.Size(161, 21);
            this.cbDtLogins.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "New value";
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(121, 316);
            this.tbNewValue.Multiline = true;
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(161, 24);
            this.tbNewValue.TabIndex = 5;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.dataSet;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginsTableAdapter = this.loginsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Example_15_SQL_.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginsBindingNavigator
            // 
            this.loginsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginsBindingNavigator.BindingSource = this.loginsBindingSource;
            this.loginsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loginsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loginsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.loginsBindingNavigatorSaveItem});
            this.loginsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loginsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loginsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loginsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loginsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loginsBindingNavigator.Name = "loginsBindingNavigator";
            this.loginsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loginsBindingNavigator.Size = new System.Drawing.Size(538, 25);
            this.loginsBindingNavigator.TabIndex = 1;
            this.loginsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // loginsBindingNavigatorSaveItem
            // 
            this.loginsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginsBindingNavigatorSaveItem.Image")));
            this.loginsBindingNavigatorSaveItem.Name = "loginsBindingNavigatorSaveItem";
            this.loginsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.loginsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.loginsBindingNavigatorSaveItem.Click += new System.EventHandler(this.loginsBindingNavigatorSaveItem_Click_1);
            // 
            // dgvLoginsUpdate
            // 
            this.dgvLoginsUpdate.AutoGenerateColumns = false;
            this.dgvLoginsUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginsUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvLoginsUpdate.DataSource = this.loginsBindingSource;
            this.dgvLoginsUpdate.Location = new System.Drawing.Point(121, 56);
            this.dgvLoginsUpdate.Name = "dgvLoginsUpdate";
            this.dgvLoginsUpdate.Size = new System.Drawing.Size(300, 220);
            this.dgvLoginsUpdate.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "intId";
            this.dataGridViewTextBoxColumn1.HeaderText = "intId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nvcLogins";
            this.dataGridViewTextBoxColumn2.HeaderText = "nvcLogins";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nvcPassword";
            this.dataGridViewTextBoxColumn3.HeaderText = "nvcPassword";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Type";
            // 
            // tbInsert
            // 
            this.tbInsert.BackColor = System.Drawing.Color.OrangeRed;
            this.tbInsert.Controls.Add(this.label5);
            this.tbInsert.Controls.Add(this.btInsert);
            this.tbInsert.Controls.Add(this.label4);
            this.tbInsert.Controls.Add(this.label3);
            this.tbInsert.Controls.Add(this.tbNewnvcPassword);
            this.tbInsert.Controls.Add(this.tbNewnvcLogins);
            this.tbInsert.Controls.Add(this.dgvLoginsInsert);
            this.tbInsert.Location = new System.Drawing.Point(4, 22);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsert.Size = new System.Drawing.Size(533, 359);
            this.tbInsert.TabIndex = 3;
            this.tbInsert.Text = "INSERT";
            // 
            // dgvLoginsInsert
            // 
            this.dgvLoginsInsert.AutoGenerateColumns = false;
            this.dgvLoginsInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginsInsert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvLoginsInsert.DataSource = this.loginsBindingSource;
            this.dgvLoginsInsert.Location = new System.Drawing.Point(6, 45);
            this.dgvLoginsInsert.Name = "dgvLoginsInsert";
            this.dgvLoginsInsert.Size = new System.Drawing.Size(343, 178);
            this.dgvLoginsInsert.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "intId";
            this.dataGridViewTextBoxColumn4.HeaderText = "intId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nvcLogins";
            this.dataGridViewTextBoxColumn5.HeaderText = "nvcLogins";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nvcPassword";
            this.dataGridViewTextBoxColumn6.HeaderText = "nvcPassword";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tbNewnvcLogins
            // 
            this.tbNewnvcLogins.Location = new System.Drawing.Point(210, 245);
            this.tbNewnvcLogins.Multiline = true;
            this.tbNewnvcLogins.Name = "tbNewnvcLogins";
            this.tbNewnvcLogins.Size = new System.Drawing.Size(164, 31);
            this.tbNewnvcLogins.TabIndex = 1;
            // 
            // tbNewnvcPassword
            // 
            this.tbNewnvcPassword.Location = new System.Drawing.Point(210, 282);
            this.tbNewnvcPassword.Multiline = true;
            this.tbNewnvcPassword.Name = "tbNewnvcPassword";
            this.tbNewnvcPassword.Size = new System.Drawing.Size(164, 31);
            this.tbNewnvcPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "nvcLogins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "nvcPassword";
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btInsert.Location = new System.Drawing.Point(386, 84);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(113, 51);
            this.btInsert.TabIndex = 5;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(188, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Logins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 411);
            this.Controls.Add(this.loginsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tbDelete.ResumeLayout(false);
            this.tbDelete.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingNavigator)).EndInit();
            this.loginsBindingNavigator.ResumeLayout(false);
            this.loginsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginsUpdate)).EndInit();
            this.tbInsert.ResumeLayout(false);
            this.tbInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginsInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbDelete;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.ComboBox cbDataType;
        private System.Windows.Forms.Button btAddRows;
        private System.Windows.Forms.Label lbTableFormat;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox tbNameCell;
        private System.Windows.Forms.Label lbNameCell;
        private System.Windows.Forms.Label lbDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbNameDataBase;
        private System.Windows.Forms.Label lbNameDb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbLogins;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDtLogins;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private DataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton loginsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvLoginsUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbInsert;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewnvcPassword;
        private System.Windows.Forms.TextBox tbNewnvcLogins;
        private System.Windows.Forms.DataGridView dgvLoginsInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label5;
    }
}

