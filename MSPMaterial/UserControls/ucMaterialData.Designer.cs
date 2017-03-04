namespace MSPMaterial.UserControls
{
    partial class ucMaterialData
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label cellLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label standLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label wIPAmountLabel;
            System.Windows.Forms.Label safetyAmountLabel;
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtStand = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cbxMaterialID = new System.Windows.Forms.ComboBox();
            this.cbxMaterialName = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnKeyWord = new System.Windows.Forms.PictureBox();
            this.wIPAmountTextBox = new System.Windows.Forms.TextBox();
            this.safetyAmountTextBox = new System.Windows.Forms.TextBox();
            this.picCameraPhoto = new System.Windows.Forms.PictureBox();
            this.lblPicType = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            cellLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            standLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            wIPAmountLabel = new System.Windows.Forms.Label();
            safetyAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKeyWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCameraPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(136, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 12);
            label3.TabIndex = 55;
            label3.Text = "目前數量：";
            // 
            // cellLabel
            // 
            cellLabel.AutoSize = true;
            cellLabel.Location = new System.Drawing.Point(400, 68);
            cellLabel.Name = "cellLabel";
            cellLabel.Size = new System.Drawing.Size(29, 12);
            cellLabel.TabIndex = 53;
            cellLabel.Text = "格：";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(313, 68);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(29, 12);
            sectionLabel.TabIndex = 51;
            sectionLabel.Text = "區：";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(220, 68);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(29, 12);
            levelLabel.TabIndex = 49;
            levelLabel.Text = "層：";
            // 
            // standLabel
            // 
            standLabel.AutoSize = true;
            standLabel.Location = new System.Drawing.Point(136, 68);
            standLabel.Name = "standLabel";
            standLabel.Size = new System.Drawing.Size(29, 12);
            standLabel.TabIndex = 47;
            standLabel.Text = "架：";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(136, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 12);
            nameLabel.TabIndex = 41;
            nameLabel.Text = "物料名稱：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(333, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 12);
            label1.TabIndex = 45;
            label1.Text = "名稱搜尋：";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(136, 12);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(65, 12);
            iDLabel.TabIndex = 39;
            iDLabel.Text = "物料編號：";
            // 
            // wIPAmountLabel
            // 
            wIPAmountLabel.AutoSize = true;
            wIPAmountLabel.Location = new System.Drawing.Point(367, 100);
            wIPAmountLabel.Name = "wIPAmountLabel";
            wIPAmountLabel.Size = new System.Drawing.Size(77, 12);
            wIPAmountLabel.TabIndex = 87;
            wIPAmountLabel.Text = "在外加工量：";
            // 
            // safetyAmountLabel
            // 
            safetyAmountLabel.AutoSize = true;
            safetyAmountLabel.Location = new System.Drawing.Point(251, 100);
            safetyAmountLabel.Name = "safetyAmountLabel";
            safetyAmountLabel.Size = new System.Drawing.Size(65, 12);
            safetyAmountLabel.TabIndex = 85;
            safetyAmountLabel.Text = "安全庫存：";
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.Location = new System.Drawing.Point(202, 94);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.ReadOnly = true;
            this.txtCurrentAmount.Size = new System.Drawing.Size(41, 22);
            this.txtCurrentAmount.TabIndex = 56;
            this.txtCurrentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(437, 64);
            this.txtCell.Name = "txtCell";
            this.txtCell.ReadOnly = true;
            this.txtCell.Size = new System.Drawing.Size(46, 22);
            this.txtCell.TabIndex = 54;
            this.txtCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(348, 64);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(46, 22);
            this.txtSection.TabIndex = 52;
            this.txtSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(252, 64);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(46, 22);
            this.txtLevel.TabIndex = 50;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStand
            // 
            this.txtStand.Location = new System.Drawing.Point(168, 64);
            this.txtStand.Name = "txtStand";
            this.txtStand.ReadOnly = true;
            this.txtStand.Size = new System.Drawing.Size(46, 22);
            this.txtStand.TabIndex = 48;
            this.txtStand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(402, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(57, 22);
            this.txtKeyword.TabIndex = 43;
            // 
            // cbxMaterialID
            // 
            this.cbxMaterialID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterialID.FormattingEnabled = true;
            this.cbxMaterialID.Location = new System.Drawing.Point(203, 8);
            this.cbxMaterialID.Name = "cbxMaterialID";
            this.cbxMaterialID.Size = new System.Drawing.Size(124, 20);
            this.cbxMaterialID.TabIndex = 40;
            this.cbxMaterialID.SelectedIndexChanged += new System.EventHandler(this.cbxMaterialID_SelectedIndexChanged);
            // 
            // cbxMaterialName
            // 
            this.cbxMaterialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterialName.FormattingEnabled = true;
            this.cbxMaterialName.Location = new System.Drawing.Point(203, 34);
            this.cbxMaterialName.Name = "cbxMaterialName";
            this.cbxMaterialName.Size = new System.Drawing.Size(280, 20);
            this.cbxMaterialName.TabIndex = 42;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(74, 126);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(218, 96);
            this.txtComment.TabIndex = 63;
            this.txtComment.Text = "";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(220, 226);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(57, 20);
            this.cbxType.TabIndex = 67;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(369, 225);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ShortcutsEnabled = false;
            this.txtAmount.Size = new System.Drawing.Size(42, 22);
            this.txtAmount.TabIndex = 66;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "儲存檔案";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(3, 129);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(65, 12);
            this.lblComment.TabIndex = 69;
            this.lblComment.Text = "備註備註：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(149, 229);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 70;
            this.lblType.Text = "類型類型：";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(297, 229);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 12);
            this.lblAmount.TabIndex = 71;
            this.lblAmount.Text = "數量數量：";
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(5, 5);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(129, 111);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 72;
            this.picPhoto.TabStop = false;
            // 
            // btnKeyWord
            // 
            this.btnKeyWord.Image = global::MSPMaterial.Properties.Resources.find;
            this.btnKeyWord.Location = new System.Drawing.Point(465, 8);
            this.btnKeyWord.Name = "btnKeyWord";
            this.btnKeyWord.Size = new System.Drawing.Size(18, 20);
            this.btnKeyWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKeyWord.TabIndex = 44;
            this.btnKeyWord.TabStop = false;
            this.btnKeyWord.Click += new System.EventHandler(this.btnKeyWord_Click);
            // 
            // wIPAmountTextBox
            // 
            this.wIPAmountTextBox.Location = new System.Drawing.Point(442, 94);
            this.wIPAmountTextBox.Name = "wIPAmountTextBox";
            this.wIPAmountTextBox.ReadOnly = true;
            this.wIPAmountTextBox.Size = new System.Drawing.Size(41, 22);
            this.wIPAmountTextBox.TabIndex = 88;
            this.wIPAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // safetyAmountTextBox
            // 
            this.safetyAmountTextBox.Location = new System.Drawing.Point(320, 94);
            this.safetyAmountTextBox.Name = "safetyAmountTextBox";
            this.safetyAmountTextBox.ReadOnly = true;
            this.safetyAmountTextBox.Size = new System.Drawing.Size(41, 22);
            this.safetyAmountTextBox.TabIndex = 86;
            this.safetyAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picCameraPhoto
            // 
            this.picCameraPhoto.Location = new System.Drawing.Point(369, 126);
            this.picCameraPhoto.Name = "picCameraPhoto";
            this.picCameraPhoto.Size = new System.Drawing.Size(114, 96);
            this.picCameraPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCameraPhoto.TabIndex = 89;
            this.picCameraPhoto.TabStop = false;
            // 
            // lblPicType
            // 
            this.lblPicType.AutoSize = true;
            this.lblPicType.Location = new System.Drawing.Point(298, 129);
            this.lblPicType.Name = "lblPicType";
            this.lblPicType.Size = new System.Drawing.Size(65, 12);
            this.lblPicType.TabIndex = 90;
            this.lblPicType.Text = "領料圖片：";
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnPhoto.Image = global::MSPMaterial.Properties.Resources.camera;
            this.btnPhoto.Location = new System.Drawing.Point(315, 162);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(27, 31);
            this.btnPhoto.TabIndex = 91;
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "此筆單號：";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(65, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 12);
            this.lblID.TabIndex = 93;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(5, 180);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(65, 12);
            this.lblCompany.TabIndex = 94;
            this.lblCompany.Text = "加工工廠：";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(7, 200);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(58, 22);
            this.txtCompany.TabIndex = 95;
            // 
            // ucMaterialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.lblPicType);
            this.Controls.Add(this.picCameraPhoto);
            this.Controls.Add(wIPAmountLabel);
            this.Controls.Add(this.wIPAmountTextBox);
            this.Controls.Add(safetyAmountLabel);
            this.Controls.Add(this.safetyAmountTextBox);
            this.Controls.Add(standLabel);
            this.Controls.Add(this.txtStand);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.lblType);
            this.Controls.Add(cellLabel);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(levelLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtCurrentAmount);
            this.Controls.Add(nameLabel);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnKeyWord);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cbxMaterialID);
            this.Controls.Add(this.cbxMaterialName);
            this.Controls.Add(iDLabel);
            this.Name = "ucMaterialData";
            this.Size = new System.Drawing.Size(492, 253);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKeyWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCameraPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtStand;
        private System.Windows.Forms.PictureBox btnKeyWord;
        private System.Windows.Forms.TextBox txtKeyword;
        public System.Windows.Forms.TextBox txtCurrentAmount;
        public System.Windows.Forms.ComboBox cbxMaterialID;
        public System.Windows.Forms.ComboBox cbxMaterialName;
        public System.Windows.Forms.RichTextBox txtComment;
        public System.Windows.Forms.ComboBox cbxType;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox wIPAmountTextBox;
        private System.Windows.Forms.TextBox safetyAmountTextBox;
        private System.Windows.Forms.Label lblPicType;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.PictureBox picCameraPhoto;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
    }
}
