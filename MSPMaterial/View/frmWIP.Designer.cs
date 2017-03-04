namespace MSPMaterial.View
{
    partial class frmWIP
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
            System.Windows.Forms.Label material_IDLabel;
            System.Windows.Forms.Label material_NameLabel;
            System.Windows.Forms.Label user_NameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label isFinishedLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWIP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWIP = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.wiplistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnWIPSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxItem = new System.Windows.Forms.ToolStripComboBox();
            this.txtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picWIP = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.ckbIsFInish = new System.Windows.Forms.CheckBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.txtMaterialID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Material_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wipListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            material_IDLabel = new System.Windows.Forms.Label();
            material_NameLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            isFinishedLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiplistBindingNavigator)).BeginInit();
            this.wiplistBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWIP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wipListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 18);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(65, 12);
            iDLabel.TabIndex = 31;
            iDLabel.Text = "加工編號：";
            // 
            // material_IDLabel
            // 
            material_IDLabel.AutoSize = true;
            material_IDLabel.Location = new System.Drawing.Point(12, 49);
            material_IDLabel.Name = "material_IDLabel";
            material_IDLabel.Size = new System.Drawing.Size(65, 12);
            material_IDLabel.TabIndex = 32;
            material_IDLabel.Text = "物料編號：";
            // 
            // material_NameLabel
            // 
            material_NameLabel.AutoSize = true;
            material_NameLabel.Location = new System.Drawing.Point(13, 76);
            material_NameLabel.Name = "material_NameLabel";
            material_NameLabel.Size = new System.Drawing.Size(65, 12);
            material_NameLabel.TabIndex = 33;
            material_NameLabel.Text = "物料名稱：";
            // 
            // user_NameLabel
            // 
            user_NameLabel.AutoSize = true;
            user_NameLabel.Location = new System.Drawing.Point(123, 129);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(53, 12);
            user_NameLabel.TabIndex = 34;
            user_NameLabel.Text = "登記者：";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(123, 103);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(41, 12);
            typeLabel.TabIndex = 36;
            typeLabel.Text = "類型：";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(12, 129);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(65, 12);
            reasonLabel.TabIndex = 37;
            reasonLabel.Text = "加工原因：";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(216, 103);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(41, 12);
            timeLabel.TabIndex = 38;
            timeLabel.Text = "時間：";
            // 
            // isFinishedLabel
            // 
            isFinishedLabel.AutoSize = true;
            isFinishedLabel.Location = new System.Drawing.Point(288, 129);
            isFinishedLabel.Name = "isFinishedLabel";
            isFinishedLabel.Size = new System.Drawing.Size(65, 12);
            isFinishedLabel.TabIndex = 39;
            isFinishedLabel.Text = "是否結案：";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(13, 103);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(65, 12);
            amountLabel.TabIndex = 39;
            amountLabel.Text = "加工數量：";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(192, 18);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(65, 12);
            companyNameLabel.TabIndex = 39;
            companyNameLabel.Text = "加工公司：";
            // 
            // dgvWIP
            // 
            this.dgvWIP.AllowUserToAddRows = false;
            this.dgvWIP.AllowUserToDeleteRows = false;
            this.dgvWIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWIP.AutoGenerateColumns = false;
            this.dgvWIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWIP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWIP.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Material_ID,
            this.Material_Name,
            this.dataGridViewTextBoxColumn2,
            this.Reason,
            this.dataGridViewTextBoxColumn5,
            this.IsFinished,
            this.User_Name,
            this.dataGridViewTextBoxColumn4});
            this.dgvWIP.DataSource = this.wipListBindingSource;
            this.dgvWIP.Location = new System.Drawing.Point(0, 334);
            this.dgvWIP.Name = "dgvWIP";
            this.dgvWIP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWIP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWIP.RowTemplate.Height = 24;
            this.dgvWIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWIP.Size = new System.Drawing.Size(777, 278);
            this.dgvWIP.TabIndex = 35;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // wiplistBindingNavigator
            // 
            this.wiplistBindingNavigator.AddNewItem = null;
            this.wiplistBindingNavigator.BackColor = System.Drawing.Color.LightGreen;
            this.wiplistBindingNavigator.BindingSource = this.wipListBindingSource;
            this.wiplistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wiplistBindingNavigator.DeleteItem = null;
            this.wiplistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnEdit,
            this.btnWIPSave,
            this.toolStripSeparator,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cbxItem,
            this.txtSearchValue,
            this.btnSearch});
            this.wiplistBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wiplistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wiplistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wiplistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wiplistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wiplistBindingNavigator.Name = "wiplistBindingNavigator";
            this.wiplistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wiplistBindingNavigator.Size = new System.Drawing.Size(777, 25);
            this.wiplistBindingNavigator.TabIndex = 34;
            this.wiplistBindingNavigator.Text = "outputNavigator";
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
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::MSPMaterial.Properties.Resources.add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "領料";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::MSPMaterial.Properties.Resources.modify;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "編輯";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnWIPSave
            // 
            this.btnWIPSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWIPSave.Enabled = false;
            this.btnWIPSave.Image = global::MSPMaterial.Properties.Resources.save;
            this.btnWIPSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWIPSave.Name = "btnWIPSave";
            this.btnWIPSave.Size = new System.Drawing.Size(23, 22);
            this.btnWIPSave.Text = "存檔";
            this.btnWIPSave.Click += new System.EventHandler(this.btnWIPSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
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
            "加工編號",
            "物料編號",
            "物料名稱",
            "加工原因",
            "加工類型",
            "登記者"});
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.picWIP);
            this.groupBox2.Location = new System.Drawing.Point(399, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 272);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "進料圖片";
            // 
            // picWIP
            // 
            this.picWIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWIP.Location = new System.Drawing.Point(3, 18);
            this.picWIP.Name = "picWIP";
            this.picWIP.Size = new System.Drawing.Size(341, 251);
            this.picWIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWIP.TabIndex = 26;
            this.picWIP.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(companyNameLabel);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(amountLabel);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(isFinishedLabel);
            this.panel1.Controls.Add(this.ckbIsFInish);
            this.panel1.Controls.Add(timeLabel);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(reasonLabel);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(typeLabel);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(user_NameLabel);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(material_NameLabel);
            this.panel1.Controls.Add(this.txtMaterialName);
            this.panel1.Controls.Add(material_IDLabel);
            this.panel1.Controls.Add(this.txtMaterialID);
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 300);
            this.panel1.TabIndex = 36;
            // 
            // txtCompany
            // 
            this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "CompanyName", true));
            this.txtCompany.Location = new System.Drawing.Point(260, 14);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(115, 22);
            this.txtCompany.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "Amount", true));
            this.txtAmount.Location = new System.Drawing.Point(78, 98);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(45, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // ckbIsFInish
            // 
            this.ckbIsFInish.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.wipListBindingSource, "IsFinished", true));
            this.ckbIsFInish.Enabled = false;
            this.ckbIsFInish.Location = new System.Drawing.Point(353, 123);
            this.ckbIsFInish.Name = "ckbIsFInish";
            this.ckbIsFInish.Size = new System.Drawing.Size(37, 24);
            this.ckbIsFInish.TabIndex = 9;
            this.ckbIsFInish.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "Time", true));
            this.txtTime.Location = new System.Drawing.Point(260, 98);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(115, 22);
            this.txtTime.TabIndex = 7;
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "Reason", true));
            this.txtComment.Location = new System.Drawing.Point(15, 148);
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(360, 127);
            this.txtComment.TabIndex = 10;
            this.txtComment.Text = "";
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "Type", true));
            this.txtType.Location = new System.Drawing.Point(164, 98);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(50, 22);
            this.txtType.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "User_Name", true));
            this.txtUserName.Location = new System.Drawing.Point(182, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 8;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "Material_Name", true));
            this.txtMaterialName.Location = new System.Drawing.Point(79, 70);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.ReadOnly = true;
            this.txtMaterialName.Size = new System.Drawing.Size(296, 22);
            this.txtMaterialName.TabIndex = 4;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "Material_ID", true));
            this.txtMaterialID.Location = new System.Drawing.Point(79, 42);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.ReadOnly = true;
            this.txtMaterialID.Size = new System.Drawing.Size(296, 22);
            this.txtMaterialID.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wipListBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(79, 13);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(111, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // Material_ID
            // 
            this.Material_ID.DataPropertyName = "Material_ID";
            this.Material_ID.HeaderText = "物料編號";
            this.Material_ID.MinimumWidth = 80;
            this.Material_ID.Name = "Material_ID";
            this.Material_ID.ReadOnly = true;
            this.Material_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Material_Name
            // 
            this.Material_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Material_Name.DataPropertyName = "Material_Name";
            this.Material_Name.HeaderText = "物料名稱";
            this.Material_Name.MinimumWidth = 100;
            this.Material_Name.Name = "Material_Name";
            this.Material_Name.ReadOnly = true;
            this.Material_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "加工原因";
            this.Reason.MinimumWidth = 100;
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsFinished
            // 
            this.IsFinished.DataPropertyName = "IsFinished";
            this.IsFinished.HeaderText = "是否結案";
            this.IsFinished.MinimumWidth = 50;
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.DataPropertyName = "User_Name";
            this.User_Name.HeaderText = "登記人";
            this.User_Name.MinimumWidth = 80;
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            this.User_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "加工編號";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "類型";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "數量";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd  HH:mm:ss";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "加工時間";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wipListBindingSource
            // 
            this.wipListBindingSource.DataSource = typeof(MSPMaterial.Model.wiplist);
            // 
            // frmWIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 618);
            this.Controls.Add(this.dgvWIP);
            this.Controls.Add(this.wiplistBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWIP";
            this.Text = "frmWIP";
            this.Load += new System.EventHandler(this.frmWIP_Load);
            this.Leave += new System.EventHandler(this.frmWIP_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiplistBindingNavigator)).EndInit();
            this.wiplistBindingNavigator.ResumeLayout(false);
            this.wiplistBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWIP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wipListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource wipListBindingSource;
        private System.Windows.Forms.DataGridView dgvWIP;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator wiplistBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.PictureBox picWIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.TextBox txtMaterialID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxItem;
        private System.Windows.Forms.ToolStripTextBox txtSearchValue;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.CheckBox ckbIsFInish;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnWIPSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}