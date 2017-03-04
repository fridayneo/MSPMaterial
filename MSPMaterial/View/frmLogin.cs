using MSPMaterial.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPMaterial.View
{
    public partial class frmLogin : Form
    {
        Data db = new Data();
        CommFunction cf = new CommFunction();
        Thread thread;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (txtAccount.Text == "")
            {
                MessageBox.Show("請輸入帳號", "登入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("請輸入密碼", "登入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SHA384 sha384 = new SHA384CryptoServiceProvider();//建立一個SHA384
                byte[] source = Encoding.Default.GetBytes(txtPassword.Text);//將字串轉為Byte[]
                byte[] crypto = sha384.ComputeHash(source);//進行SHA384加密
                string password = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串

                int id = int.Parse(txtAccount.Text);
                if (db.checkLogin(id, password))
                {
                    this.Close();
                    thread = new Thread(openMainForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤", "登入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openMainForm(object obj)
        {
            Application.Run(new frmMain());
        }

        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            cf.setDigitOnly(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 按下 enter 鍵觸發登入
        // 因為登入鍵是 picturebox，如果是普通 button，可以直接設定 AcceptButton
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                login();
                return true; // return true to intercept the key press
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
