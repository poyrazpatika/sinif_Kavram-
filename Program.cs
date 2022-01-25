using System;

namespace sinif_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] özellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi (Parametre Listesi)
            //      {
            //      // Metot Komutları
            //      }
            //  }

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.calisanBilgileri();

            Console.WriteLine("********");

            Calisan calisan2 = new Calisan();
            calisan1.Ad = "Deniz";
            calisan1.Soyad = "Arda";
            calisan1.No = 25646789;
            calisan1.Departman = "Satın Alma";
            calisan2.calisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }
        
        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }


}
