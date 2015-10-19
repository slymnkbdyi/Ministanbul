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
    public partial class FormMuzeler : Form
    {
        public FormMuzeler()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "KÜLTÜR VE TURİZM BAKANLIĞI’NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Add("TOPKAPI SARAYI MÜZESİ ");
                comboBox2.Items.Add("AYASOFYA MÜZESİ");
                comboBox2.Items.Add("AYA İRİNİ KİLİSESİ MÜZESİ");
                comboBox2.Items.Add("KARİYE MÜZESİ");
                comboBox2.Items.Add("BÜYÜK SARAY MOZAİKLERİ MÜZESİ");
                





            }
            if (comboBox1.Text == "MİLLİ SARAYLAR DAİRE BAŞKANLIĞI’NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Add("AYNALIKAVAK KASRI  ");
                comboBox2.Items.Add("BEYKOZ KASRI ");
                comboBox2.Items.Add("BEYLERBEYİ SARAYI ");
                comboBox2.Items.Add("DOLMABAHÇE SARAYI ");
               
               





            }
            if (comboBox1.Text == "GENELKURMAY BAŞKANLIĞI’NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Add("DENİZ MÜZESİ");
                comboBox2.Items.Add("HAVACILIK MÜZESİ ");
                comboBox2.Items.Add("ASKERİ MÜZE VE KÜLTÜR SİTESİ KOMUTANLIĞI ");
               





            }
            if (comboBox1.Text == "VAKIFLAR GENEL MÜDÜRLÜĞÜ'NE BAĞLI MÜZELER ")
            {
                comboBox2.Items.Add("HALI MÜZESİ ");
                comboBox2.Items.Add("TÜRK VAKIF HAT SANATLARI MÜZESİ ");
                comboBox2.Items.Add("KİLİM VE DÜZ YAYGILAR MÜZESİ");
                







            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text =="TOPKAPI SARAYI MÜZESİ")
            {


                richTextBox1.Text = "TOPKAPI SARAYI MÜZESİ Sultanahmet Meydanı, Eminönü0212 512 0480Ziyaret gün ve saatleri: Salı günü hariç 09.00 - 19.00(Yaz saati uygulaması boyunca)Ücret: 20 TL, Harem: 15 TL";
            }
            if (comboBox2.Text == "AYASOFYA MÜZESİ ")
            {


                richTextBox1.Text = "Sultanahmet Meydanı, Eminönü 0212 5221750Ziyaret gün ve saatleri: Pazartesi kapalı, diğer günler 09.00 - 19.00Ücret: 20 TL";

            }
            if (comboBox2.Text == "AYA İRİNİ KİLİSESİ MÜZESİ ")
            {


                richTextBox1.Text = "Topkapı Sarayı Avlusu, Sultanahmet, Eminönü 0212 5284500Ziyaret gün ve saatleri: Ayasofya Müzesinden alınacak izinle gezilebilir.Ücret:";
            }
            if (comboBox2.Text == "KARİYE MÜZESİ ")
            {


                richTextBox1.Text = "Kariye Mah. Kariye Sok. No:26 Edirnekapı, Fatih 0212 6319241Ziyaret gün ve saatleri: Ücret: 15 TL";
            }
            if (comboBox2.Text == "BÜYÜK SARAY MOZAİKLERİ MÜZESİ ")
            {


                richTextBox1.Text = "Arasta Çarşısı, Sultanahmet, Eminönü 0212 5284500Ziyaret gün ve saatleri: Çarşamba hariç, diğer günler 09.00 - 17.00Ücret: 8 TL";
            }
            if (comboBox2.Text == "AYNALIKAVAK KASRI  ")
            {


                richTextBox1.Text = "Aynalı Kavak Caddesi, Hasköy, Eyüp 0212 2273441Ziyaret gün ve saatleri: Pazartesi ve Perşembe günleri hariç diğer günler 08.30 - 17.00 Ücret:";
            }
            if (comboBox2.Text == "BEYKOZ KASRI")
            {


                richTextBox1.Text = "Hünkar İskele Caddesi, Beykoz 0216 4241942Ziyaret gün ve saatleri: Pazartesi ve Perşembe günleri hariç diğer günler 08.30 - 17.00 Ücret:";
            }
            if (comboBox2.Text == "BEYLERBEYİ SARAYI ")
            {


                richTextBox1.Text = "Abdullahağa Caddesi, Beylerbeyi, Üsküdar 0216 3219320Ziyaret gün ve saatleri: Pazartesi ve Perşembe günleri hariç diğer günler 08.30 - 17.00 Ücret:";
            }
            if (comboBox2.Text == "BÜYÜK SARAY MOZAİKLERİ MÜZESİ ")
            {


                richTextBox1.Text = "Arasta Çarşısı, Sultanahmet, Eminönü 0212 5284500Ziyaret gün ve saatleri: Çarşamba hariç, diğer günler 09.00 - 17.00Ücret: 8 TL";
            }
            if (comboBox2.Text == "DOLMABAHÇE SARAYI  ")
            {


                richTextBox1.Text = "0212 2369000 Dolmabahçe, BeşiktaşZiyaret gün ve saatleri: Pazartesi ve Perşembe günleri hariç diğer günler 08.30 - 16.30 Ücret:";
            }
            if (comboBox2.Text == "BÜYÜK SARAY MOZAİKLERİ MÜZESİ ")
            {


                richTextBox1.Text = "Arasta Çarşısı, Sultanahmet, Eminönü 0212 5284500Ziyaret gün ve saatleri: Çarşamba hariç, diğer günler 09.00 - 17.00Ücret: 8 TL";
            }
            if (comboBox2.Text == "DENİZ MÜZESİ ")
            {


                richTextBox1.Text = "Cezayir Cad. No:1, Beşiktaş 0212 3274345Ziyaret gün ve saatleri: Pazartesi ve Salı günleri kapalı olup, hafta içi: 09.00 - 17.00, hafta sonu: 10.00 - 18.00 Ücret: 4 TL, Öğrenci: 1 TL ";
            }
            if (comboBox2.Text == "BHAVACILIK MÜZESİ ")
            {


                richTextBox1.Text = "0212 6632490 Hava Harp Okulu Komutanlığı, Yeşilköy: 3 TL, Öğrenci 1 TL";
            }
            if (comboBox2.Text == "ASKERİ MÜZE VE KÜLTÜR SİTESİ KOMUTANLIĞI  ")
            {


                richTextBox1.Text = "Askeri Müze ve Kültür Sitesi Komutanlığı, Harbiye, Şişli 0212 2332720Ziyaret gün ve saatleri: Pazartesi ve Salı günleri dışında her gün 09:00 - 17:00 Ücret: ";
            }
            if (comboBox2.Text == "HALI MÜZESİ ")
            {


                richTextBox1.Text = "Soğukçeşme sokak Sultanahmet 0212 512 69  saatleri: 09:00 - 17:00Pazartesi kapalıdır.";
            }
            if (comboBox2.Text == "TÜRK VAKIF HAT SANATLARI MÜZESİ")
            {


                richTextBox1.Text = "Beyazıt Camii Karşısı, Beyazıt 0212 5275851 Restorasyon nedeniyle kapalıdır.";
            }
            if (comboBox2.Text == "KİLİM VE DÜZ YAYGILAR MÜZESİ")
            {


                richTextBox1.Text = "Sultanahmet Camii Avlusu, Sultanahmet 0212 51813 30Restorasyon nedeniyle kapalıdır.";
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
