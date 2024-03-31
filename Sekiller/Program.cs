using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hangi tür nesneyi olusturmak istersiniz : ");
                Console.WriteLine("1- Dikdörtgen");
                Console.WriteLine("2- Eşkenar Üçgen");
                Console.WriteLine("3- Eşkenar Dörtgen");
                Console.WriteLine("4- Çıkış");

                int nesne = Convert.ToInt32(Console.ReadLine());

                if(nesne == 4)
                {
                    break;
                }

               
                switch (nesne)
                {
                    case 1:
                        Console.WriteLine("Seçiminiz -> 1");
                        Dikdortgen();
                        break;
                    case 2:
                        Console.WriteLine("Seçiminiz -> 2");
                        EskenarUcgen();
                        break;
                    case 3:
                        Console.WriteLine("Seçiminiz -> 3");
                        EskenarDortgen();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim");
                        break;
                }
               

                Console.ReadKey();
            }
        }
                
        
            static void Dikdortgen()
            {
            Console.Write("Genislik giriniz : ");
            int setGenislik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yükseklik giriniz : ");
            int setYukseklik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(setGenislik + " birim genişiliğinde " + setYukseklik + " birim yüksekliğinde dikdörtgen oluşturuluyor.");
            Console.WriteLine("Nesne çizdiriliyor...");

            Console.WriteLine();

            Console.Write("İçi dolu mu ? (true/false): ");
            bool setDoluMu = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Çizim sembolünü giriniz: ");
            char setSembol = Convert.ToChar(Console.ReadLine());

            Dikdortgen d1 = new Dikdortgen(setGenislik, setYukseklik,setSembol,setDoluMu);
            d1.OzellikYazdir();
            d1.Ciz();

        }
        static void EskenarUcgen()
        {
            Console.Write("Kenar giriniz : ");
            int setKenar = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İçi dolu mu ? (true/false): ");
            //bool setDoluMu = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Çizim sembolünü giriniz: ");
            char setSembol = Convert.ToChar(Console.ReadLine());


            EskenarUcgen e1 = new EskenarUcgen(setKenar, setSembol);
            e1.OzellikYazdir();
            e1.Ciz();
            
        }


        static void EskenarDortgen()
        {
            Console.Write("Genislik giriniz : ");
            int setGenislik = int.Parse(Console.ReadLine());

            Console.Write("Yukseklik giriniz : ");
            int setYukseklik = int.Parse(Console.ReadLine());

            //Console.Write("İçi dolu mu ? (true/false): ");
            //bool setDoluMu = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Çizim sembolünü giriniz: ");
            char setSembol = Convert.ToChar(Console.ReadLine());

            EskenarDortgen es1 = new EskenarDortgen(setGenislik, setYukseklik, setSembol);
            es1.OzellikYazdir();
            es1.Ciz();
        }

    }
            }

       
            
               
            
            
            

            
           
            
            
           

            

            

        

