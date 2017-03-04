namespace MSPMaterial.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.物料現況ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.領取物料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料進ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料二次加工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料報廢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用者設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.類型設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.物料現況ToolStripMenuItem,
            this.領取物料ToolStripMenuItem,
            this.物料進ToolStripMenuItem,
            this.物料二次加工ToolStripMenuItem,
            this.物料報廢ToolStripMenuItem,
            this.menuSystem,
            this.登出系統ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 物料現況ToolStripMenuItem
            // 
            this.物料現況ToolStripMenuItem.Name = "物料現況ToolStripMenuItem";
            this.物料現況ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.物料現況ToolStripMenuItem.Text = "物料現況";
            this.物料現況ToolStripMenuItem.Click += new System.EventHandler(this.物料現況ToolStripMenuItem_Click);
            // 
            // 領取物料ToolStripMenuItem
            // 
            this.領取物料ToolStripMenuItem.Name = "領取物料ToolStripMenuItem";
            this.領取物料ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.領取物料ToolStripMenuItem.Text = "領料表";
            this.領取物料ToolStripMenuItem.Click += new System.EventHandler(this.領取物料ToolStripMenuItem_Click);
            // 
            // 物料進ToolStripMenuItem
            // 
            this.物料進ToolStripMenuItem.Name = "物料進ToolStripMenuItem";
            this.物料進ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.物料進ToolStripMenuItem.Text = "進料表";
            this.物料進ToolStripMenuItem.Click += new System.EventHandler(this.物料進ToolStripMenuItem_Click);
            // 
            // 物料二次加工ToolStripMenuItem
            // 
            this.物料二次加工ToolStripMenuItem.Name = "物料二次加工ToolStripMenuItem";
            this.物料二次加工ToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.物料二次加工ToolStripMenuItem.Text = "二次加工表";
            this.物料二次加工ToolStripMenuItem.Click += new System.EventHandler(this.物料二次加工ToolStripMenuItem_Click);
            // 
            // 物料報廢ToolStripMenuItem
            // 
            this.物料報廢ToolStripMenuItem.Name = "物料報廢ToolStripMenuItem";
            this.物料報廢ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.物料報廢ToolStripMenuItem.Text = "報廢表";
            this.物料報廢ToolStripMenuItem.Click += new System.EventHandler(this.物料報廢ToolStripMenuItem_Click);
            // 
            // 登出系統ToolStripMenuItem
            // 
            this.登出系統ToolStripMenuItem.Name = "登出系統ToolStripMenuItem";
            this.登出系統ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.登出系統ToolStripMenuItem.Text = "登出系統";
            this.登出系統ToolStripMenuItem.Click += new System.EventHandler(this.登出系統ToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUser.Location = new System.Drawing.Point(626, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "label1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用者設定ToolStripMenuItem,
            this.類型設定ToolStripMenuItem});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(68, 20);
            this.menuSystem.Text = "系統設定";
            // 
            // 使用者設定ToolStripMenuItem
            // 
            this.使用者設定ToolStripMenuItem.Name = "使用者設定ToolStripMenuItem";
            this.使用者設定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.使用者設定ToolStripMenuItem.Text = "使用者設定";
            // 
            // 類型設定ToolStripMenuItem
            // 
            this.類型設定ToolStripMenuItem.Name = "類型設定ToolStripMenuItem";
            this.類型設定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.類型設定ToolStripMenuItem.Text = "類型設定";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 508);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(757, 546);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSP 物料系統";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 物料現況ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 領取物料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料進ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料報廢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料二次加工ToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem 登出系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem 使用者設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 類型設定ToolStripMenuItem;
    }
}