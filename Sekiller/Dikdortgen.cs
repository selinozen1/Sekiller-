using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Dikdortgen : Sekiller
    {
        private int genislik;
        private  int yukseklik;


        public Dikdortgen()
        {

        }

       public Dikdortgen(int yukseklik, int genislik, char sembol = '*', bool doluMu = false) :base(sembol, doluMu)
        {
           
            this.yukseklik = yukseklik;
            this.genislik = genislik;
            
        }

        public int getGenislik()
        {
            return genislik;
        }
        public int setGenislik(int genislik)
        {
            return genislik;
        }

        public int getYukseklik()
        {
            return yukseklik;
        }

        public int setYukseklik(int yukseklik)
        {
            return yukseklik;
        }

        public double AlanHesapla()
        {
            return genislik * yukseklik;
        }

        public double CevreHesapla()
        {
            return 2 * (genislik + yukseklik);
        }

        public void Ciz()
        {
            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    if(i == 0 || i == yukseklik - 1 || j == 0 || j == genislik - 1 || doluMu)
                    {
                        Console.Write(sembol);
                    }
                    //else if (!doluMu)
                    //{
                    //    Console.WriteLine(' ');
                    //} 
                    else
                    {
                        Console.Write(' ');
                    }
                   
                }
                Console.WriteLine();
            }
        }

        public string OzellikYazdir()
        {
            string ozellikler = "";
            Console.WriteLine();
            Console.Write(getOlusturmaTarihi() + " tarihinde oluşturulan Dikdörtgen sınıfı : ");
            Console.WriteLine("\nAlan : " + AlanHesapla());
            Console.WriteLine("Cevre : " + CevreHesapla());
            Console.WriteLine("Sembol : " + sembol);
            Console.WriteLine("DoluMu : " + doluMu);
           

            return ozellikler;

           
        }
       
    }
}

