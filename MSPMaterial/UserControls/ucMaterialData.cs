using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSPMaterial.Controller;
using MSPMaterial.Model;
using MSPMaterial.View.DialogForm;

namespace MSPMaterial.UserControls
{
    public partial class ucMaterialData : UserControl
    {
        string strOutput = "1";
        string strInput = "2";
        string strWIP = "3";
        string strScrapped = "4";

        string strIDType = "0";
        string strToday = System.DateTime.Today.ToString("yyyyMMdd");
        CommFunction cf = new CommFunction();
        string type = "";


        private bool success;
        public bool Success
        {
            get { return this.success; }
            set { this.success = value; }
        }

        private static Data db;
        public Data DB
        {
            set { db = value; }
            get { return db; }
        }

        public ucMaterialData()
        {
            InitializeComponent();
        }

        public void start(string type)
        {
            lblCompany.Visible = txtCompany.Visible = false;
            this.type = type;
            switch (type)
            {
                case "Input":
                    lblAmount.Text = "進料數量：";
                    lblComment.Text = "進料備註：";
                    lblType.Text = "進料類型：";
                    lblPicType.Text = "進料圖片：";
                    strIDType = strInput;
                    break;
                case "Output":
                    lblAmount.Text = "領料數量：";
                    lblComment.Text = "領料備註：";
                    lblType.Text = "領料類型：";
                    lblPicType.Text = "領料圖片：";
                    strIDType = strOutput;
                    break;
                case "WIP":
                    lblAmount.Text = "加工數量：";
                    lblComment.Text = "加工備註：";
                    lblType.Text = "加工類型：";
                    lblPicType.Text = "加工圖片：";
                    strIDType = strWIP;
                    lblCompany.Visible = txtCompany.Visible = true;
                    break;
                case "Scrapped":
                    lblAmount.Text = "報廢數量：";
                    lblComment.Text = "報廢備註：";
                    lblType.Text = "報廢類型：";
                    lblPicType.Text = "報廢圖片：";
                    strIDType = strScrapped;
                    break;
                default:
                    break;
            }
            initSet(type);
        }


        public void initSet(string type)
        {
            lblID.Text = strIDType + strToday + db.getListCount(type);
            txtAmount.Text = "0";
            var result = db.getMaterials("", "");
            setMaterialsDataBinding(result);

            var typeResult = db.getType(type);
            cbxType.DataSource = typeResult;
            cbxType.DisplayMember = "type";
            cbxType.ValueMember = "type";
            cbxType.SelectedIndex = 0;
        }

        private void setMaterialsDataBinding(IEnumerable<materials> result)
        {
            txtStand.DataBindings.Clear();
            txtLevel.DataBindings.Clear();
            txtSection.DataBindings.Clear();
            txtCell.DataBindings.Clear();
            txtCurrentAmount.DataBindings.Clear();

            txtStand.DataBindings.Add(new Binding("Text", result, "Stand"));
            txtLevel.DataBindings.Add(new Binding("Text", result, "Level"));
            txtSection.DataBindings.Add(new Binding("Text", result, "Section"));
            txtCell.DataBindings.Add(new Binding("Text", result, "Cell"));
            txtCurrentAmount.DataBindings.Add(new Binding("Text", result, "CurrentAmount"));

            cbxMaterialName.DataSource = result;
            cbxMaterialName.DisplayMember = "Name";
            cbxMaterialName.ValueMember = "Name";

            cbxMaterialID.DataSource = result;
            cbxMaterialID.DisplayMember = "ID";
            cbxMaterialID.ValueMember = "ID";
        }

        private void btnKeyWord_Click(object sender, EventArgs e)
        {
            var result = db.getMaterials("物料名稱", txtKeyword.Text);
            setMaterialsDataBinding(result);
            cbxMaterialID.SelectedIndex = 0;
            cbxMaterialName.SelectedIndex = 0;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            cf.setDigitOnly(e);
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                int intInputAmount = int.Parse(txtAmount.Text);

                if ((type == "Output" || type =="WIP" ) && (intInputAmount > int.Parse(txtCurrentAmount.Text)))
                {
                    cf.showErrorMessage("數量錯誤", "輸入量不得大於現有數量");
                }
            }
            catch
            {
                cf.showErrorMessage("輸入錯誤", "此欄位只能輸入數字");
                txtAmount.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxType.Text == "")
            {
                cf.showErrorMessage("資料尚未完整", "類型尚未選擇");
                cbxType.Focus();
            }
            else if (type == "WIP" && txtCompany.Text == string.Empty)
            {
                cf.showErrorMessage("資料輸入錯誤", "請輸入加工工廠");
                txtCompany.Focus();
            }
            else
            {
                try
                {
                    int currentAmount = int.Parse(txtCurrentAmount.Text);
                    int amount = int.Parse(txtAmount.Text);

                    if(amount == 0)
                    {
                        cf.showErrorMessage("資料輸入錯誤", "數量不得為 0");
                        return;
                    }

                    int materialNewAmount = currentAmount;

                    string imgURL = "";
                    if(picCameraPhoto.Image != null)
                    {
                        imgURL = "MSPImages\\" + type + "\\" + lblID.Text + ".jpg";
                    }
                    switch (type)
                    {
                        case "Input":
                            materialNewAmount = currentAmount + amount;
                            inputlist list = new inputlist();
                            list.ID = lblID.Text;
                            list.Material_ID = cbxMaterialID.Text;
                            list.Material_Name = cbxMaterialName.Text;
                            list.Amount = int.Parse(txtAmount.Text);
                            list.User_Name = Account.CurrentUser.User;
                            list.Type = cbxType.Text;
                            list.Time = DateTime.Now;
                            list.Image = imgURL;
                            list.Comment = txtComment.Text;
                            db.AddInput(list, cbxMaterialID.Text, materialNewAmount);
                            break;
                        case "Output":
                            materialNewAmount = currentAmount - amount;
                            outputlist olist = new outputlist();
                            olist.ID = lblID.Text;
                            olist.Material_ID = cbxMaterialID.Text;
                            olist.Material_Name = cbxMaterialName.Text;
                            olist.Amount = int.Parse(txtAmount.Text);
                            olist.User_Name = Account.CurrentUser.User;
                            olist.Type = cbxType.Text;
                            olist.Time = DateTime.Now;
                            olist.Image = imgURL;
                            olist.Comment = txtComment.Text;
                            db.AddOutput(olist, cbxMaterialID.Text, materialNewAmount);
                            break;
                        case "Scrapped":
                            materialNewAmount = currentAmount - amount;
                            scrapped slist = new scrapped();
                            slist.ID =lblID.Text;
                            slist.Material_ID = cbxMaterialID.Text;
                            slist.Material_Name = cbxMaterialName.Text;
                            slist.Amount = int.Parse(txtAmount.Text);
                            slist.User_Name = Account.CurrentUser.User;
                            slist.Type = cbxType.Text;
                            slist.Time = DateTime.Now;
                            slist.Image = imgURL;
                            slist.Reason = txtComment.Text;
                            db.AddScrapped(slist, cbxMaterialID.Text, materialNewAmount);
                            break;
                        case "WIP":
                            int wipAmount = amount;
                            wiplist wlist = new wiplist();
                            wlist.ID = lblID.Text;
                            wlist.Material_ID = cbxMaterialID.Text;
                            wlist.Material_Name = cbxMaterialName.Text;
                            wlist.Amount = int.Parse(txtAmount.Text);
                            wlist.User_Name = Account.CurrentUser.User;
                            wlist.Type = cbxType.Text;
                            wlist.Time = DateTime.Now;
                            wlist.Image = imgURL;
                            wlist.Reason = txtComment.Text;
                            wlist.CompanyName = txtCompany.Text;
                            db.AddWIP(wlist, cbxMaterialID.Text, wipAmount);
                            break;
                        default:
                            materialNewAmount = currentAmount;
                            break;
                    }
                    MessageBox.Show("存檔成功");
                    success = true;
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                    {
                        cf.showErrorMessage("存檔錯誤", ex.InnerException.InnerException.Message);
                    }else if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() > 0)
                    {
                        cf.showErrorMessage("存檔錯誤", "資料庫欄位缺少\n" + ex.Message);
                    }
                    else
                    {
                        cf.showErrorMessage("存檔錯誤", ex.Message);
                    }
                    success = false;
                }
            }
        }

        private void cbxMaterialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            picPhoto.Image = cf.getImage("Materials", cbxMaterialID.Text);
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            frmPhoto form = new frmPhoto(lblID.Text, type);
            DialogResult dr = form.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                picCameraPhoto.Image = cf.getImage(type, lblID.Text);
                picCameraPhoto.Tag = picCameraPhoto.Image.Tag;
            }
        }
    }
}
