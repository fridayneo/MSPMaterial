using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;

namespace MSPMaterial.View.DialogForm
{
    public partial class frmPhoto : Form
    {
        private Capture cap = null;

        string stringPhotoPath = @"D:\MSPImages\";
        
        private string folder;
        public string Folder
        {
            set { this.folder = value; }
            get { return this.folder; }
        }

        private string id;
        public string ID
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public frmPhoto()
        {
            InitializeComponent();
        }

        public frmPhoto(string id, string folder)
        {
            this.id = id;
            this.folder = folder;
            InitializeComponent();
        }

        private void frmPhoto_Load(object sender, EventArgs e)
        {
            cap = new Capture(0); // 連結到攝影機0，如果你有兩台攝影機，第二台就是1
            Application.Idle += new EventHandler(Application_Idle); // 在Idle的event下，把畫面設定到pictureBox上(當然你也可以用timer事件)

        }
        void Application_Idle(object sender, EventArgs e)
        {
            Mat frame = cap.QueryFrame(); // 去query該畫面
            picPhoto.Image = frame.Bitmap; // 把畫面轉換成bitmap型態，在餵給pictureBox元件
        }

        /// <summary>
        /// 開啟攝影機
        /// </summary>
        private void openWebCam()
        {
            //如果webcam沒啟動
            if (cap == null)
            {
                try
                {
                    //打開預設的webcam
                    cap = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
        }

      
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openWebCam();

            // Query 攝影機的畫面
            Mat photoFrame = cap.QueryFrame();

            DirectoryInfo di = Directory.CreateDirectory(stringPhotoPath+folder);

            string imageName = stringPhotoPath + folder + "\\" + id + ".jpg";
            if (System.IO.File.Exists(imageName)) {

                DialogResult dialogResult = MessageBox.Show("是否取代現有照片？", "檔案已存在！！", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(imageName);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            //儲存影像
            photoFrame.Bitmap.Save(imageName);
            this.DialogResult = DialogResult.OK;
        }

        private void frmPhoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            cap.Dispose();
            Application.Idle -= new EventHandler(Application_Idle);
        }
    }
}
