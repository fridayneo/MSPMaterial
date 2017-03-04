using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSPMaterial.Controller;

namespace MSPMaterial.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lblUser.Text = "登入者: " + Account.CurrentUser.User;
            if(Account.CurrentUser.Type != "Admin")
            {
                menuSystem.Visible = false;
            }
        }

        private void setChildForm(Form form)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            // Set the Parent Form of the Child window.
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;

            // Display the new form.
            form.Show();
           
        }

        private void 物料現況ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterials form = new frmMaterials();
            setChildForm(form);
        }

        private void 領取物料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOutput form = new frmOutput();
            setChildForm(form);
        }

        private void 物料進ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInput form = new frmInput();
            setChildForm(form);
        }

        private void 物料報廢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScrapped form = new frmScrapped();
            setChildForm(form);
        }

        private void 物料二次加工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWIP form = new frmWIP();
            setChildForm(form);
        }

        private void 登出系統ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定登出嗎？", "MSP 物料系統", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (!Application.AllowQuit) return;

                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        // 解決切換頁面時閃爍問題
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
