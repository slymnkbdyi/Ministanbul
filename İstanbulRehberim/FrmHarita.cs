using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstanbulRehberim
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Image img = pictureBox2.Image;
            int zoomwidth = pictureBox2.Width;
            int zoomheight = pictureBox2.Height;
            if(img.Width <=(e.X+zoomwidth))
            {
                zoomwidth = img.Width - e.X;
            }
            if(img.Height<=(e.Y+zoomheight))
            {


                zoomheight = img.Height - e.Y;
            }
            Rectangle reg = new Rectangle(e.X,e.Y,zoomwidth,zoomheight);
            pictureBox1.Image = cropImage(img, reg);
        }
        private Image cropImage(Image img,Rectangle cropArea)
        {

            Bitmap btmpImage = new Bitmap(img);
            Bitmap btmpCrop = btmpImage.Clone(cropArea, btmpImage.PixelFormat);
            return (Image)(btmpCrop);


        }
    }
}
