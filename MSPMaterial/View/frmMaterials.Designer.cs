namespace MSPMaterial.View
{
    partial class frmMaterials
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label currentAmountLabel;
            System.Windows.Forms.Label wIPAmountLabel;
            System.Windows.Forms.Label safetyAmountLabel;
            System.Windows.Forms.Label standLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label cellLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterials));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnTakePhoto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxItem = new System.Windows.Forms.ToolStripComboBox();
            this.txtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.Stand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtStand = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.txtSafetyAmount = new System.Windows.Forms.TextBox();
            this.txtWIPAmount = new System.Windows.Forms.TextBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            currentAmountLabel = new System.Windows.Forms.Label();
            wIPAmountLabel = new System.Windows.Forms.Label();
            safetyAmountLabel = new System.Windows.Forms.Label();
            standLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            cellLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingNavigator)).BeginInit();
            this.materialsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(18, 39);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(65, 12);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "物料編號：";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 73);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 12);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "物料名稱：";
            // 
            // currentAmountLabel
            // 
            currentAmountLabel.AutoSize = true;
            currentAmountLabel.Location = new System.Drawing.Point(18, 101);
            currentAmountLabel.Name = "currentAmountLabel";
            currentAmountLabel.Size = new System.Drawing.Size(65, 12);
            currentAmountLabel.TabIndex = 6;
            currentAmountLabel.Text = "目前數量：";
            // 
            // wIPAmountLabel
            // 
            wIPAmountLabel.AutoSize = true;
            wIPAmountLabel.Location = new System.Drawing.Point(6, 179);
            wIPAmountLabel.Name = "wIPAmountLabel";
            wIPAmountLabel.Size = new System.Drawing.Size(77, 12);
            wIPAmountLabel.TabIndex = 18;
            wIPAmountLabel.Text = "在外加工量：";
            // 
            // safetyAmountLabel
            // 
            safetyAmountLabel.AutoSize = true;
            safetyAmountLabel.Location = new System.Drawing.Point(6, 140);
            safetyAmountLabel.Name = "safetyAmountLabel";
            safetyAmountLabel.Size = new System.Drawing.Size(77, 12);
            safetyAmountLabel.TabIndex = 16;
            safetyAmountLabel.Text = "安全庫存量：";
            // 
            // standLabel
            // 
            standLabel.AutoSize = true;
            standLabel.Location = new System.Drawing.Point(6, 26);
            standLabel.Name = "standLabel";
            standLabel.Size = new System.Drawing.Size(29, 12);
            standLabel.TabIndex = 0;
            standLabel.Text = "架：";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(65, 26);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(29, 12);
            levelLabel.TabIndex = 2;
            levelLabel.Text = "層：";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(124, 26);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(29, 12);
            sectionLabel.TabIndex = 4;
            sectionLabel.Text = "區：";
            // 
            // cellLabel
            // 
            cellLabel.AutoSize = true;
            cellLabel.Location = new System.Drawing.Point(182, 26);
            cellLabel.Name = "cellLabel";
            cellLabel.Size = new System.Drawing.Size(29, 12);
            cellLabel.TabIndex = 6;
            cellLabel.Text = "格：";
            // 
            // materialsBindingNavigator
            // 
            this.materialsBindingNavigator.AddNewItem = this.btnAdd;
            this.materialsBindingNavigator.BindingSource = this.materialsBindingSource;
            this.materialsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialsBindingNavigator.DeleteItem = this.btnDelete;
            this.materialsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnReset,
            this.btnTakePhoto,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cbxItem,
            this.txtSearchValue,
            this.btnSearch});
            this.materialsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialsBindingNavigator.Name = "materialsBindingNavigator";
            this.materialsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialsBindingNavigator.Size = new System.Drawing.Size(790, 25);
            this.materialsBindingNavigator.TabIndex = 0;
            this.materialsBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "新增";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "儲存資料";
            this.btnSave.Click += new System.EventHandler(this.materialsBindingNavigatorSaveItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReset.Image = global::MSPMaterial.Properties.Resources.reset;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(23, 22);
            this.btnReset.Text = "清除重填";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTakePhoto.Image = global::MSPMaterial.Properties.Resources.camera;
            this.btnTakePhoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(23, 22);
            this.btnTakePhoto.Text = "拍照";
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "查詢";
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.Items.AddRange(new object[] {
            "",
            "物料編號",
            "物料名稱",
            "位置-區",
            "位置-欄",
            "位置-列",
            "位置-層"});
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(80, 25);
            this.cbxItem.SelectedIndexChanged += new System.EventHandler(this.cbxItem_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(80, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::MSPMaterial.Properties.Resources.find;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.Text = "查詢";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterials.AutoGenerateColumns = false;
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.Stand,
            this.Level,
            this.Section,
            this.Cell});
            this.dgvMaterials.DataSource = this.materialsBindingSource;
            this.dgvMaterials.Location = new System.Drawing.Point(0, 286);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.RowTemplate.Height = 24;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(790, 260);
            this.dgvMaterials.TabIndex = 1;
            // 
            // Stand
            // 
            this.Stand.DataPropertyName = "Stand";
            this.Stand.HeaderText = "架";
            this.Stand.Name = "Stand";
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "層";
            this.Level.Name = "Level";
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "區";
            this.Section.Name = "Section";
            // 
            // Cell
            // 
            this.Cell.DataPropertyName = "Cell";
            this.Cell.HeaderText = "格";
            this.Cell.Name = "Cell";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 258);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.picPhoto);
            this.groupBox3.Location = new System.Drawing.Point(469, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 234);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "物料圖片";
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Location = new System.Drawing.Point(3, 18);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(303, 213);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.txtCurrentAmount);
            this.groupBox1.Controls.Add(currentAmountLabel);
            this.groupBox1.Controls.Add(wIPAmountLabel);
            this.groupBox1.Controls.Add(this.txtSafetyAmount);
            this.groupBox1.Controls.Add(this.txtWIPAmount);
            this.groupBox1.Controls.Add(safetyAmountLabel);
            this.groupBox1.Location = new System.Drawing.Point(-6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 231);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物料基本資料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(cellLabel);
            this.groupBox2.Controls.Add(this.txtCell);
            this.groupBox2.Controls.Add(sectionLabel);
            this.groupBox2.Controls.Add(this.txtSection);
            this.groupBox2.Controls.Add(levelLabel);
            this.groupBox2.Controls.Add(this.txtLevel);
            this.groupBox2.Controls.Add(standLabel);
            this.groupBox2.Controls.Add(this.txtStand);
            this.groupBox2.Location = new System.Drawing.Point(150, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "物料位置區";
            // 
            // txtCell
            // 
            this.txtCell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Cell", true));
            this.txtCell.Location = new System.Drawing.Point(213, 23);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(23, 22);
            this.txtCell.TabIndex = 7;
            // 
            // txtSection
            // 
            this.txtSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Section", true));
            this.txtSection.Location = new System.Drawing.Point(153, 23);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(23, 22);
            this.txtSection.TabIndex = 5;
            // 
            // txtLevel
            // 
            this.txtLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Level", true));
            this.txtLevel.Location = new System.Drawing.Point(94, 23);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(23, 22);
            this.txtLevel.TabIndex = 3;
            // 
            // txtStand
            // 
            this.txtStand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Stand", true));
            this.txtStand.Location = new System.Drawing.Point(36, 23);
            this.txtStand.Name = "txtStand";
            this.txtStand.Size = new System.Drawing.Size(23, 22);
            this.txtStand.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(98, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(98, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "CurrentAmount", true));
            this.txtCurrentAmount.Location = new System.Drawing.Point(98, 98);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.Size = new System.Drawing.Size(46, 22);
            this.txtCurrentAmount.TabIndex = 7;
            // 
            // txtSafetyAmount
            // 
            this.txtSafetyAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "SafetyAmount", true));
            this.txtSafetyAmount.Location = new System.Drawing.Point(98, 137);
            this.txtSafetyAmount.Name = "txtSafetyAmount";
            this.txtSafetyAmount.Size = new System.Drawing.Size(46, 22);
            this.txtSafetyAmount.TabIndex = 17;
            // 
            // txtWIPAmount
            // 
            this.txtWIPAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "WIPAmount", true));
            this.txtWIPAmount.Location = new System.Drawing.Point(98, 176);
            this.txtWIPAmount.Name = "txtWIPAmount";
            this.txtWIPAmount.Size = new System.Drawing.Size(46, 22);
            this.txtWIPAmount.TabIndex = 19;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataSource = typeof(MSPMaterial.Model.materials);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "物料編號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "物料名稱";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrentAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "目前庫存量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SafetyAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "安全庫存量";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "WIPAmount";
            this.dataGridViewTextBoxColumn5.HeaderText = "在外加工量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMaterials);
            this.Controls.Add(this.materialsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaterials";
            this.Text = "frmMaterials";
            this.Load += new System.EventHandler(this.frmMaterials_Load);
            this.Leave += new System.EventHandler(this.frmMaterials_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingNavigator)).EndInit();
            this.materialsBindingNavigator.ResumeLayout(false);
            this.materialsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materialsBindingSource;
        private System.Windows.Forms.BindingNavigator materialsBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.TextBox txtSafetyAmount;
        private System.Windows.Forms.TextBox txtWIPAmount;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripButton btnTakePhoto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxItem;
        private System.Windows.Forms.ToolStripTextBox txtSearchValue;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtStand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell;
        private System.Windows.Forms.PictureBox picPhoto;
    }
}