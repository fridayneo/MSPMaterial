using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSPMaterial.View;

namespace MSPMaterial
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //open only one program
            bool createdNew;
            System.Threading.Mutex instance = new System.Threading.Mutex(true, "MSP", out createdNew);
            GC.Collect();
            if (!createdNew)
            {
                MessageBox.Show(" MSP 物料系統已在運作中！", "系統提示!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                instance.WaitOne();

                string dataDir = AppDomain.CurrentDomain.BaseDirectory;
                if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
                {
                    dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                    AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());

                instance.ReleaseMutex(); //好像沒有這段也可以耶。
            }
            
        }
    }
}
