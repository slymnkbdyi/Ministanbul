using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace İstanbulRehberim
{
    public partial class FrmCamiler : Form
    {
       
        public FrmCamiler()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source = ACERR; Initial Catalog = stanbulRehberim; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
            
        {

            textBox1.Text = "Sultan Ahmet Camii, 1609-1616 yılları arasında Osmanlı Padişahı I. Ahmed tarafından İstanbul'daki tarihî yarımadada, Mimar Sedefkâr Mehmet Ağa'ya yaptırılmıştır.[1] Cami mavi, yeşil ve beyaz renkli İznik çinileriyle bezendiği için ve yarım kubbeleri ve büyük kubbesinin içi de yine mavi ağırlıklı kalem işleri ile süslendiği için Avrupalılarca Mavi camii (Blue Mosque) olarak adlandırılır. Ayasofya'nın 1934 yılında camiden müzeye dönüştürülmesiyle, İstanbul'un ana camii konumuna ulaşmıştır.";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\sultanahmet.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Sultan+Ahmet+Camii/@41.0057273,28.974052,17z/data=!3m1!4b1!4m2!3m1!1s0x14cab9bd6570f4e1:0xe52df7368a157ca4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anaform = new FrmAnasayfa();
            anaform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yeni Cami ya da Valide Sultan Camii, İstanbul'da 1597 yılında Sultan III. Murat'ın eşi Safiye Sultan'ın emriyle temeli atılan ve 1665'te zamanın padişahı IV. Mehmet'in annesi Turhan Hatice Sultan'ın büyük çabaları ve bağışlarıyla tamamlanıp ibadete açılan camidir.";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\yenicami.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Yeni+Cami/@41.0170606,28.9697109,17z/data=!3m1!4b1!4m2!3m1!1s0x14cab9eba0aba48d:0x653381c9eafc239c");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ayasofya (Yunanca: Aγία Σοφία, tam adı: Ναός τῆς Ἁγίας τοῦ Θεοῦ Σοφίας, Latince: Sancta Sophia ya da Sancta Sapientia[2]), İstanbul'da tarihî bir müze. Bizans İmparatoru I. Jüstinyen tarafından, MS 532 - 537 yılları arasında İstanbul'un tarihi yarımadasındaki eski şehir merkezine inşa ettirilmiş bazilika planlı bir patrik katedrali olup, 1453 yılında İstanbul'un Osmanlı tarafından alınmasından sonra, Fatih Sultan Mehmet tarafından camiye dönüştürülmüştür. 1935 yılından beri ise müze olarak hizmet vermektedir.[3][4] Ayasofya, mimari bakımdan, bazilika planı ile merkezî planı birleştiren, kubbeli bazilika tipinde bir yapı olup kubbe geçişi ve taşıyıcı sistem özellikleriyle mimarlık tarihinde önemli bir dönüm noktası olarak ele alınır..";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\ayasofya.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Ayasofya+M%C3%BCzesi/@41.008587,28.9779863,17z/data=!3m1!4b1!4m2!3m1!1s0x14cab9be92011c27:0x236e6f6f37444fae");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Büyük Mecidiye Camii ya da halk arasında bilinen adı ile Ortaköy Camii, İstanbul Boğaziçi’nde Beşiktaş ilçesinin, Ortaköy semtinde sahilde bulunan Neo Barok tarzında bir camiidir..";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\ortakoy.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/B%C3%BCy%C3%BCk+Mecidiye+Cami/@41.0472073,29.0247689,17z/data=!3m1!4b1!4m2!3m1!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Fatih Camii ve Külliyesi, İstanbul'un Fatih ilçesinde Fatih Sultan Mehmed tarafından yaptırılmış olan cami ve külliyedir. Külliye 16 adet medrese, darüşşifa (hastane), tabhane (konukevi) imarethane (aşevi), kütüphane ve hamam bulunmaktadır. Şehrin yedi tepesinden birinde inşa edilmiştir. Cami 1766 depreminde yıkıldıktan sonra onarılarak 1771'de bugünkü halini almıştır. 1999 Gölcük Depreminde zemininde kaymalar tespit edilen camide 2008 yılında Vakıflar Genel Müdürlüğü tarafından zemin güçlendirme ve restorasyon çalışmalarına başlandı ve 2012 yılında ibadete açılmıştır.";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\fatih.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Fatih+Cami/@41.019594,28.9482923,17z/data=!3m1!4b1!4m2!3m1!1s0x14caba2036e39977:0xb3b9fb8e95f27599");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Süleymaniye Camii, I. Süleyman adına 1551-1557 yılları arasında İstanbul'da Mimar Sinan tarafından inşa edilen camidir.[2]";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\sulman.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/S%C3%BCleymaniye+Cami/@41.0167256,28.960943,17z/data=!3m1!4b1!4m2!3m1!1s0x14cab98d3ac01031:0x8accf5042157cfed");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bayezid Camii (Beyazıt Camii ve Beyazıd Camii olarak da bilinir) İstanbul'un Bayezid semtinde Sultan II. Bayezid tarafından yaptırılmış ünlü bir cami..";



            pictureBox1.ImageLocation = @"C:\Users\acer\Documents\Visual Studio 2015\Projects\İstanbulRehberim\İstanbulRehberim\bin\Debug\CAMİLER\beyazit.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Beyaz%C4%B1t+Camii/@41.010226,28.9630139,17z/data=!3m1!4b1!4m2!3m1!1s0x14cab991d73292a1:0xc5894f505ceb16fa");
        }
    }
}
