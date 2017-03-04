using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MSPMaterial.Controller
{
    class CommFunction
    {
        string pathMSPImage = @"D:\MSPImages\";

        public void setDigitOnly(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // 8 = Backspace
            // https://msdn.microsoft.com/en-us/library/system.windows.forms.keys(v=vs.71).aspx
            
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        public void showErrorMessage(string title , string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public Bitmap getImage(string folder, string id)
        {
            Bitmap image;
            string imagePath = pathMSPImage + "\\" + folder + "\\" + id + ".jpg";
           
            if (System.IO.File.Exists(imagePath))
            {
                using (var bmpTemp = new Bitmap(imagePath))
                {
                    image = new Bitmap(bmpTemp);
                }
                // image = (Bitmap)Image.FromFile(imagePath, true);
            }
            else
            {
                image = MSPMaterial.Properties.Resources.no_image;
            }
            image.Tag = imagePath;
            return image;
        }

        public void deleteImage(string imagePath)
        {
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
        }
    }
}
