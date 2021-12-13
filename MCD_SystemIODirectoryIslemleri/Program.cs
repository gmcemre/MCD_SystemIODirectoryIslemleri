using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIODirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c:\\NetworkAkademi"); // C'de Yeni Klasör Oluşturma
            //KlasorVarlikKontrolu("c:\\NetworkAkademi"); //C'de bu klasör var mı yok mu?
            //KlasorSilmeIslemleri("c:\\NetworkAkademi");
            //KlasorTasimaIslemleri("c:\\NetworkAkademi", "c:\\TasimaIslemi\\NetworkAkademi");

            Odev1();
            Console.ReadLine();
        }



        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI = Directory.CreateDirectory(path);
        }

        static void KlasorVarlikKontrolu(string path)
        {

            bool kontrol = Directory.Exists(path);

        }

        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path, true); //true parametresini vermezsek dosyanın içi dolu ise hata verir.Ama true dersek içindekilerle beraber dosyayı siler.
        }

        static void KlasorTasimaIslemleri(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

        static void Odev1()
        {
            /*
             * C sürücüsü içerisinde NetworkAkademi adında bir klasör oluşturun,Oluşturmadan önce varlık kontrolü yapın eğer klasör var ise silin silerken yine kullanıcıdan silmek istiyor musunuz diye E/H ile kontrol sağlayın.
             * Daha sonra oluşturun.Eğer klasör yok ise oluşturun.Fakat adımların bilgisini ekrana yazdırın.
             */
            string dosyaYol = "c:\\NetworkAkademi";
            bool kontrol = Directory.Exists(dosyaYol);
            if (kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör zaten sistemde mevcut.Klasörü silip tekrar yenisini eklemek istiyor musunuz? [E/H]");
                string EH = Console.ReadLine().ToUpper();
                if (EH == "E")
                {
                    Directory.Delete(dosyaYol);
                    Console.WriteLine("Klasör Silindi.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor.");
                    Directory.CreateDirectory(dosyaYol);
                    Console.WriteLine("Klasör oluşturuldu.");
                }
                else
                {
                    Console.WriteLine("İşlem Bitti.");
                }

            }
            else
            {
                DirectoryInfo DI = Directory.CreateDirectory(dosyaYol);
                Console.WriteLine("Klasör Oluşturuldu.");
            }
        }
    }
}
