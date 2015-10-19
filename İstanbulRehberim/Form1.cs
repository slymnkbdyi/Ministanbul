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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();     /*Burada Saatimizi Gösteiryoruz */
            label2.Text = DateTime.Now.ToLongDateString();    /*Burada Tarihimiz Gösteriyoruz*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camibilgi = new FrmCamiler();
            camibilgi.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmHarita haritaformu = new FrmHarita();
            haritaformu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmKamera KameraFormu = new FrmKamera();
            KameraFormu.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMetro FrmMetro = new FrmMetro();
            FrmMetro.Show();
            this.Hide();

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMetrobus FrmMetrobus = new FrmMetrobus();
            FrmMetrobus.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmNeAlinir FrmNeAlinir = new FrmNeAlinir();
            FrmNeAlinir.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmNeYenir FrmNeYenir = new FrmNeYenir();
            FrmNeYenir.Show();
            this.Hide();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kopruler frmKopruler = new Kopruler();
            frmKopruler.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAvm FormAvm = new FormAvm();
            FormAvm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMuzeler FormMuzeler = new FormMuzeler();
            FormMuzeler.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
