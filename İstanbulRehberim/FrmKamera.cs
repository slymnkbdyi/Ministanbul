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
    public partial class FrmKamera : Form
    {
        public FrmKamera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/kadikoy/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/istiklal-caddesi-1/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/eminonu/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/galata/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/eyup-sultan-sesli/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/kapali-carsi/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("http://www.ibbtube.com/kameralar/kiz-kulesi/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnasayfa FrmAnasayfa = new FrmAnasayfa();
            FrmAnasayfa.Show();
            this.Hide();
        }

        private void FrmKamera_Load(object sender, EventArgs e)
        {

        }
    }
}
