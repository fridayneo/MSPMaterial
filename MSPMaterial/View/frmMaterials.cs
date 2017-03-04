using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSPMaterial.Model;
using System.Data.Entity;
using MSPMaterial.Controller;
using MSPMaterial.View.DialogForm;

namespace MSPMaterial.View
{
    public partial class frmMaterials : Form
    {
        CommFunction cf = new CommFunction();
        Data db;
        

        public frmMaterials()
        {
            InitializeComponent();
            setTypeView();
        }

        private void setTypeView()
        {
            if (Account.CurrentUser.Type != "Admin")
            {
                txtID.ReadOnly = txtName.ReadOnly =
                txtCurrentAmount.ReadOnly =
                txtSafetyAmount.ReadOnly =
                txtWIPAmount.ReadOnly =
                txtCell.ReadOnly =
                txtStand.ReadOnly = txtLevel.ReadOnly =
                txtSection.ReadOnly = dgvMaterials.ReadOnly = true;

                btnAdd.Enabled = btnTakePhoto.Enabled =
                btnDelete.Enabled = btnReset.Enabled =
                btnSave.Enabled = false;
            }
        }

        private void frmMaterials_Load(object sender, EventArgs e)
        {
            db = new Data();
            var result = db.getMaterials("", "");
            materialsBindingSource.DataSource = result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtReset();
        }

        private void txtReset()
        {
           txtName.Text =
                txtCurrentAmount.Text =
                txtSafetyAmount.Text =
                txtWIPAmount.Text =
                txtSection.Text = txtCell.Text = txtStand.Text = txtLevel.Text = "";
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.materialsBindingSource.EndEdit();
            db.saveChange();
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            frmPhoto form = new frmPhoto(txtID.Text, "Materials");
            DialogResult dr = form.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
               // setImage(txtID.Text);
               picPhoto.Image = cf.getImage("Materials", txtID.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getResult();
        }

        private void getResult()
        {
            if (cbxItem.SelectedItem == null && txtSearchValue.Text == "")
            {
                cf.showErrorMessage("搜尋錯誤", "尚未設定搜尋條件");
            }
            else if (txtSearchValue.Text != "" && (cbxItem.SelectedItem == null || cbxItem.SelectedItem.ToString() == ""))
            {
                cf.showErrorMessage("搜尋錯誤", "請選擇搜尋條件");
            }
            else if (cbxItem.SelectedItem != null && cbxItem.SelectedItem.ToString() != "" && txtSearchValue.Text == "")
            {
                cf.showErrorMessage("搜尋錯誤", "請輸入搜尋內容");
            }
            else
            {
                if (cbxItem.SelectedItem != null)
                {
                    var result = db.getMaterials(cbxItem.SelectedItem.ToString(), txtSearchValue.Text);
                    materialsBindingSource.DataSource = result;
                }
            }
        }

        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxItem.SelectedIndex == 0)
            {
                txtSearchValue.Text = "";
            }
        }

        private void frmMaterials_Leave(object sender, EventArgs e)
        {
            db.closeConnection();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string id = ((System.Windows.Forms.TextBox)sender).Text;
            picPhoto.Image = cf.getImage("Materials",id);
        }
    }
}
