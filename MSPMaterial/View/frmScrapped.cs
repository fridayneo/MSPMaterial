﻿using MSPMaterial.Controller;
using MSPMaterial.Model;
using MSPMaterial.View.DialogForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPMaterial.View
{
    public partial class frmScrapped : Form
    {
        Data db;
        CommFunction cf = new CommFunction();
        string type = "Scrapped";

        public frmScrapped()
        {
            InitializeComponent();
        }

        private void frmScrapped_Load(object sender, EventArgs e)
        {
            db = new Data();
           
            dgvUpdate();
        }

        private void dgvUpdate()
        {
            var scrappedResult = db.getScrappedlist("","");
            scrappedListBindingSource.DataSource = scrappedResult;
        }


        private void frmScrapped_Leave(object sender, EventArgs e)
        {
            db.closeConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMaterialData form = new frmMaterialData();
            form.Type = type;

            DialogResult dr = form.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                dgvUpdate();
            }
            else
            {
                if (form.ucMaterialDatas.picCameraPhoto.Tag != null)
                {
                    if (form.ucMaterialDatas.picCameraPhoto.Tag.ToString() != String.Empty)
                    {
                        cf.deleteImage(form.ucMaterialDatas.picCameraPhoto.Tag.ToString());
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    var result = db.getScrappedlist(cbxItem.SelectedItem.ToString(), txtSearchValue.Text);
                    if (result.Count() == 0) // 為了避免 indexoutofrange error
                    {
                        cf.showErrorMessage("無符合資料", "無符合資料，請重新輸入搜尋內容");
                    }
                    else
                    {
                        scrappedListBindingSource.DataSource = result;
                    }
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string id = ((System.Windows.Forms.TextBox)sender).Text;
            picScrapped.Image = cf.getImage(type, id);

        }

        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxItem.SelectedIndex == 0)
            {
                txtSearchValue.Text = "";
            }
        }
    }
}
