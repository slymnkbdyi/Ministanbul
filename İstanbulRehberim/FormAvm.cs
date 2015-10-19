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
    public partial class FormAvm : Form
    {
        public FormAvm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Olivium")
            {



                richTextBox1.Visible = true;
                richTextBox1.Text = "2000 yılında Zeytinburnu’nda açılan Olivium, İstanbul’daki ilk outlet alışveriş merkezidir. Outlet olması nedeniyle ünlü markaların kaliteli ürünlerini uygun fiyatlara bulabileceğiniz mekan, zamanla Zeytinburnu’nda gidilebilecek en iyi mekanlardan biri haline gelmiştir. Olivium’a ulaşım için Bağcılar-Kabataş tramvay hattı ve Zeytinburnu otobüsleri kullanılabilir.";
                richTextBox2.Visible = false;
                richTextBox3.Visible = false;
                richTextBox4.Visible = false;
                richTextBox5.Visible = false;
               

            }
            if (comboBox1.Text == "Palladium")
            {
                richTextBox1.Visible = false;
                richTextBox2.Visible = true;
                richTextBox3.Visible = false;
                richTextBox4.Visible = false;
                richTextBox5.Visible = false;

                richTextBox2.Text = "2008 yılında Ataşehir’de kurulan Palladium, Sonsuz Yaşam Küresi sloganı ile hemen hemen her alanda hizmet vermektedir. İlçenin gelişiminde oldukça büyük bir katkısı olan avm, içerisinde son derece kaliteli yemek yerleri ve mağazaları barındırıyor. Ücretsiz müşteri servisleri ile Üsküdar, Çekmeköy gibi merkezlerden gidilebildiği gibi, Kadıköy-Batı Ataşehir otobüsü 8A’yı kullanarak da ulaşım sağlayabilirsiniz..";
            }
            if (comboBox1.Text == "Capacity")
            {



                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
                richTextBox3.Visible = true;
                richTextBox4.Visible = false;
                richTextBox5.Visible = false;
                richTextBox3.Text = "2007 yılında hizmete açılan Capacity alışveriş merkezinin, Carousel’in popülerliğini kaybetmesinden sonra Bakırköy’e yeni bir hava kazandırdığı kesin. Orta kısımdaki interaktif havuzu ile dikkat çeken avm, içerisinde ünlü yemek yerlerini de bulunduruyor. Bakırköy’ün merkezi denilecek bir noktada bulunduğundan ulaşımın nispeten kolay olduğu alışveriş merkezine Bakırköy’e giden her otobüs ile ulaşılabilir.";
            }
            if (comboBox1.Text == "Forum İstanbul")
            {



                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
                richTextBox3.Visible = false;
                richTextBox4.Visible = true;
                richTextBox5.Visible = false;
                richTextBox4.Text = "2009 yılında Bayrampaşa ilçesinde kurulan Forum İstanbul, büyüklüğü ile dikkat çeken alışveriş merkezlerinden biridir. İçerisinde köpekbalıklarının da yer aldığı Turkuazoo adlı dev bir akvaryum ve kış aylarında buz pateni yapabileceğiniz bir alan bulunan avm, ziyaretçilerine eğlenceli saatler vaadediyor. Yorum İstanbul adı altında çok sayıda daire bulunduran alan, hem alışveriş hem de yaşam merkezi olma özelliğine sahip. Forum İstanbul’a Atatürk  Havalimanı-Aksaray metrosu ile çok kolay ulaşılabileceği gibi, Cevatpaşa otobüsleri ile de gidebilirsiniz..";
            }
            if (comboBox1.Text == "Marmara Forum")
            {



                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
                richTextBox3.Visible = false;
                richTextBox4.Visible = false;
                richTextBox5.Visible = true;
                richTextBox5.Text = "2011 yılında Bakırköy’de hizmete giren Marmara Forum, büyüklüğü ile ünlü alışveriş merkezlerinden biri. Bünyesinde birçok kaliteli mağaza ve restorantı barındıran avm, My Forum özelliği ile de dikkatleri üzerine çekiyor. Bu hizmetin özelliği, istediğiniz etkinlikler için size bir alan tahsis edilmesi ve bu alanı dilediğiniz şekilde kullanabilmeniz. Tabi ki, üye olmanız halinde bu hizmetten faydalanabiliyorsunuz. Bakırköy’de yer alan avm’ye ulaşım için metrobüs veya metronun Zeytinburnu durağını kullanabilirsiniz..";
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa FrmAnasayfa = new FrmAnasayfa();
            FrmAnasayfa.Show();
            this.Hide();
        }

        private void FormAvm_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "2000 yılında Zeytinburnu’nda açılan Olivium, İstanbul’daki ilk outlet alışveriş merkezidir. Outlet olması nedeniyle ünlü markaların kaliteli ürünlerini uygun fiyatlara bulabileceğiniz mekan, zamanla Zeytinburnu’nda gidilebilecek en iyi mekanlardan biri haline gelmiştir. Olivium’a ulaşım için Bağcılar-Kabataş tramvay hattı ve Zeytinburnu otobüsleri kullanılabilir.";
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            richTextBox5.Visible = false;
        }
    }
}
