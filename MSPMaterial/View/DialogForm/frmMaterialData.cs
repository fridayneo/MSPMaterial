using MSPMaterial.Controller;
using MSPMaterial.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPMaterial.View.DialogForm
{
    public partial class frmMaterialData : Form
    {
        Data db;
        CommFunction cf = new CommFunction();

        public frmMaterialData()
        {
            InitializeComponent();
        }

        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        private void frmMaterialData_Load(object sender, EventArgs e)
        {
            db = new Data();
            ucMaterialDatas.DB = db;
            ucMaterialDatas.start(type);
            ucMaterialDatas.btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if (ucMaterialDatas.Success)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
