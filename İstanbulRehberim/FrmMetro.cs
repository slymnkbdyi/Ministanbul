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
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Metro İstanbul Durakları " + "    ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0,1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "M1 Yenikapı - Atatürk Havalimanı / Kirazlı Metro Hattı")
            {

                textBox1.Text = "    M1A istasyonları: Yenikapı, Aksaray,Emniyet/Fatih, Ulubatlı/Topkapı, Bayrampaşa-Maltepe, Sağmalcılar, Kartaltepe/Kocatepe, Otogar, Esenler, Terazidere, Davutpaşa/Yıldız Teknik Üniversitesi, Merter, Zeytinburnu, Bakırköy-İncirli, Bahçelievler, Ataköy/Şirinevler, Yenibosna, DTM/İstanbul Fuar Merkezi, HavalimanıM1B uzatması istasyonları: Esenler, Menderes, Üçyüzlü, Bağcılar Meydan, Kirazlı";
            }
            if (comboBox1.Text == "M2 Yenikapı- Hacıosman Metro Hattı  ")
            {

                textBox1.Text = "    Yenikapı,  Vezneciler, Haliç, Şişhane, Taksim, Osmanbey, Şişli/Mecidiyeköy, Gayrettepe, Levent,  4.Levent, Sanayi, İTÜ Ayazağa, Atatürk Oto Sanayi, Darüşşafaka, Hacıosman Seyrantepe";
            }
            if (comboBox1.Text == "M3 Başakşehir Metro Hattı")
            {

                textBox1.Text = "      Metrokent, Başak Konutları, Siteler, Turgut Özal, İkitelli Sanayi, Olimpiyat, Ziya Gökalp Mh,  İstoç, Mahmutbey, Yeni Mahalle, Kirazlı";
            }
            if (comboBox1.Text == "M4 Kadıköy-Kartal Metro Hattı")
            {

                textBox1.Text = "   Kadıköy, Ayrılık Çeşmesi, Acıbadem, Ünalan, Göztepe, Yenisahra, Kozyatağı, Bostancı, Küçükyalı, Maltepe, Huzurevi, Gülsuyu, Esenkent, Hastane/Adliye, Soğanlık, Kartal";
            }
            if (comboBox1.Text == "M6 Levent – Hisarüstü/Boğaziçi Üniversitesi ")
            {

                textBox1.Text = "    Levent, Nispetiye, Etiler, Hisarüstü / Boğaziçi Üniversitesi";
            }
            if (comboBox1.Text == "M2 Yenikapı- Hacıosman Metro Hattı  ")
            {

                textBox1.Text = "     Yenikapı,  Vezneciler, Haliç, Şişhane, Taksim, Osmanbey, Şişli/Mecidiyeköy, Gayrettepe, Levent,  4.Levent, Sanayi, İTÜ Ayazağa, Atatürk Oto Sanayi, Darüşşafaka, Hacıosman Seyrantepe";
            }
            if (comboBox1.Text == "T1 Kabataş-Bağcılar Tramvay Hattı ")
            {

                textBox1.Text = "    Kabataş, Fındıklı, Tophane, Karaköy, Eminönü, Sirkeci, Gülhane, Sultanahmet, Çemberlitaş, Beyazıt, Laleli, Aksaray, Yusufpaşa, Haseki,Fındıkzade, Çapa-Şehremini, Pazartekke, Topkapı, Cevizlibağ-A.Ö.Y, Merkez Efendi, Akşemsettin, Mithatpaşa, Zeytinburnu, Mehmet Akif, Merter Tekstil Sitesi, Güngören, Akıncılar, Soğanlı, Yavuz Selim, Güneştepe, Bağcılar";
            }
            if (comboBox1.Text == "M2 Yenikapı- Hacıosman Metro Hattı  ")
            {

                textBox1.Text = "      Yenikapı,  Vezneciler, Haliç, Şişhane, Taksim, Osmanbey, Şişli/Mecidiyeköy, Gayrettepe, Levent,  4.Levent, Sanayi, İTÜ Ayazağa, Atatürk Oto Sanayi, Darüşşafaka, Hacıosman Seyrantepe";
            }
            if (comboBox1.Text == "T3 Kadıköy Moda Nostaljik Tramvay")
            {

                textBox1.Text = "     İDO- İskele Camii- Çarşı- Altıyol- Bahariye- Kilise- Moda İlkokulu-Moda Caddesi- Mühürdar- Damga Sokak";
            }
            if (comboBox1.Text == "T4 Topkapı  Habibler  Tramvay Hattı")
            {

                textBox1.Text = "          (Mescid-i Selam, Cebeci, Sultançifliği, Yeni Mahalle, Hacı Şükrü, 50.Yıl/Baştabya, Cumhuriyet Mah, Metris, Karadeniz, Taşköprü, Ali Fuat Başgil, Bosna/Çukurçeşme, Sağmalcılar, Uluyol/Bereç, Rami, Topçular, Demirkapı, Şehitlik, Edirnekapı, Vatan, Fetihkapı, Topkapı)";
            }
            if (comboBox1.Text == "F1 Taksim - Kabataş Füniküler Hattı  ")
            {

                textBox1.Text = "      Kabataş - Taksim";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa FrmAnasayfa = new FrmAnasayfa();
            FrmAnasayfa.Show();
            this.Hide();
        }
    }
}
