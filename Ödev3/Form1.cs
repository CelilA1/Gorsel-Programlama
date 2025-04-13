using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Ödev3;
using System;
using System.Reflection;
using System.Security.Policy;

namespace Ödev3
{
    public partial class Form1 : Form
    {
        private Image LoadImageFromResources(string imageName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"Ödev3.BurçResim.{imageName}";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                return Image.FromStream(stream);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        string Ad, Soyad, Burc, BurcYorumu, VKI_Yorum, DogumTarihi, AyStr, BurcResimIsmi;
        int Boy, Kilo, Gun, Ay, Yil;
        double VKI, Boycm;

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            Ad = textBox_Ad.Text;
            Soyad = textBox_Soyad.Text;
            DogumTarihi = textBox_DogumTarihi.Text;
            Gun = int.Parse(DogumTarihi.Substring(0, 2));
            Ay = int.Parse(DogumTarihi.Substring(3, 2));
            Yil = int.Parse(DogumTarihi.Substring(6, 4));
            Kilo = int.Parse(textBox_Kilo.Text);
            Boy = int.Parse(textBox_Boy.Text);
            Boycm = Boy / 100;
            VKI = Kilo / (Boycm * Boycm);

            switch (Ay)
            {
                case 01:
                    BurcResimIsmi = "Oğlak.png";
                    BurcYorumu = "Oğlak, yılın başlangıcında kararlı ve disiplinli bir şekilde ilerleyerek başarıya odaklanabilir.";
                    Burc = "Oğlak";
                    AyStr = "Ocak";
                    break;

                case 02:
                    BurcResimIsmi = "Kova.png";
                    BurcYorumu = "Kova, yenilikçi düşüncelerle öne çıkabilir, özgürlüğüne düşkünlük artacak.";
                    Burc = "Kova";
                    AyStr = "Şubat";
                    break;

                case 03:
                    BurcResimIsmi = "Balık.png";
                    BurcYorumu = "Balık, duygusal olarak yoğun bir dönem geçirebilir, sezgileri güçlü olacak.";
                    Burc = "Balık";
                    AyStr = "Mart";
                    break;

                case 04:
                    BurcResimIsmi = "Koç.png";
                    BurcYorumu = "Koç, cesur ve atılgan bir şekilde yeni başlangıçlar yapabilir, liderlik özellikleri ön planda.";
                    Burc = "Koç";
                    AyStr = "Nisan";
                    break;

                case 05:
                    BurcResimIsmi = "Boğa.png";
                    BurcYorumu = "Boğa, sabırlı ve kararlı bir şekilde finansal ve kişisel hedeflerine ulaşmak isteyecek.";
                    Burc = "Boğa";
                    AyStr = "Mayıs";
                    break;

                case 06:
                    BurcResimIsmi = "İkizler.png";
                    BurcYorumu = "İkizler, iletişim gücünü kullanarak çevresindekilerle ilişkilerini güçlendirebilir.";
                    Burc = "İkizler";
                    AyStr = "Haziran";
                    break;

                case 07:
                    BurcResimIsmi = "Yengeç.png";
                    BurcYorumu = "Yengeç, aile ve ev hayatına önem verecek, duygusal bağlar daha derinleşecek.";
                    Burc = "Yengeç";
                    AyStr = "Temmuz";
                    break;

                case 08:
                    BurcResimIsmi = "Aslan.png";
                    BurcYorumu = "Aslan, kendine güvenerek sahneye çıkacak, yaratıcı projelerde başarı elde edebilir.";
                    Burc = "Aslan";
                    AyStr = "Ağustos";
                    break;

                case 09:
                    BurcResimIsmi = "Başak.png";
                    BurcYorumu = "Başak, detaylara olan düşkünlüğüyle işlerindeki verimliliği arttırabilir, düzen arayacak.";
                    Burc = "Başak";
                    AyStr = "Eylül";
                    break;

                case 10:
                    BurcResimIsmi = "Terazi.png";
                    BurcYorumu = "Terazi, uyum ve denge arayışında olacak, ilişkilerde diplomatik bir yaklaşım sergileyecek.";
                    Burc = "Terazi";
                    AyStr = "Ekim";
                    break;

                case 11:
                    BurcResimIsmi = "Akrep.png";
                    BurcYorumu = "Akrep, gizemli ve güçlü bir şekilde hedeflerine yönelerek derinleşmek isteyecek.";
                    Burc = "Akrep";
                    AyStr = "Kasım";
                    break;

                case 12:
                    BurcResimIsmi = "Yay.png";
                    BurcYorumu = "Yay, keşif ve macera isteğiyle yeni yerler görmek ve farklı deneyimler yaşamak isteyebilir.";
                    Burc = "Yay";
                    AyStr = "Aralık";
                    break;
            }

            if (VKI < 18.5)
            {
                VKI_Yorum = "Zayıf: Vücut kitle indeksiniz düşük, beslenme düzeninizi gözden geçirin.";
            }
            else if (VKI >= 18.5 && VKI <= 22.9)
            {
                VKI_Yorum = "Normal Kilolu: Sağlıklı bir kiloya sahipsiniz, dengeli beslenmeye devam edin.";
            }
            else if (VKI > 22.9 && VKI <= 24.9)
            {
                VKI_Yorum = "Normal Kilolu (Üst Sınır): Biraz daha dikkatli olmalısınız, sağlıklı alışkanlıklar edinin.";
            }
            else if (VKI > 24.9 && VKI <= 26.9)
            {
                VKI_Yorum = "Fazla Kilolu (Başlangıç): Fazla kilolarınız sağlık riskleri oluşturabilir, dikkatli olmalısınız.";
            }
            else if (VKI > 26.9 && VKI <= 29.9)
            {
                VKI_Yorum = "Fazla Kilolu (İleri Seviye): Kilo kaybı üzerinde çalışmak faydalı olabilir.";
            }
            else if (VKI > 29.9 && VKI <= 34.9)
            {
                VKI_Yorum = "Obez (Seviye 1): Ciddi sağlık riskleri taşıyorsunuz, bir uzmanla çalışmanız gerekebilir.";
            }
            else if (VKI > 34.9 && VKI <= 39.9)
            {
                VKI_Yorum = "Obez (Seviye 2): Sağlık sorunları riski yüksek, kilo vermek için profesyonel yardım almanız önerilir.";
            }
            else if (VKI > 39.9)
            {
                VKI_Yorum = "Morbid Obez (Seviye 3): Hayatınızı tehdit edebilir, acilen bir uzman desteği almanız gerekmektedir.";
            }

            using (var context = new AppDbContext())
            {
                var kullanici = new Kullanici
                {
                    Ad = Ad,
                    Soyad = Soyad,
                    DogumTarihi = DogumTarihi,
                    Boy = Boy,
                    Kilo = Kilo,
                    Burc = Burc,
                    BurcYorumu = BurcYorumu,
                    VKI = VKI,
                    VKI_Yorum = VKI_Yorum
                };
                context.Kullanici.Add(kullanici);
                context.SaveChanges();
            }

            pictureBox_BurcResim.Image = LoadImageFromResources(BurcResimIsmi);

        }

        private void button_Goster_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                var kullanicilar = context.Kullanici.ToList();

                dataGridView1.DataSource = kullanicilar;
            }

            dataGridView1.AutoResizeColumns();

        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Ad.Text = "";
            textBox_Boy.Text = "";
            textBox_DogumTarihi.Text = "";
            textBox_Kilo.Text = "";
            textBox_Soyad.Text = "";
            pictureBox_BurcResim.Image = null;
            
        }
    }
}

public class Kullanici
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string DogumTarihi { get; set; }
    public int Boy { get; set; }
    public int Kilo { get; set; }
    public string Burc { get; set; }
    public string BurcYorumu { get; set; }
    public double VKI { get; set; }
    public string VKI_Yorum { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Kullanici> Kullanici { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\Burc.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}