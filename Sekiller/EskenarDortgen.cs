using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class EskenarDortgen : Sekiller
    {
        private int yukseklik;
        private int genislik;

        public EskenarDortgen()
        {

        }

        public EskenarDortgen(int yukseklik, int genislik, char sembol = '&', bool doluMu = true) :base(sembol, doluMu)
        {
            this.yukseklik = yukseklik;
            this.genislik = genislik;
        }

        public void YukseklikDegistir(int yukseklik)
        {
            this.yukseklik = yukseklik;
        }

        public int YukseklikAl()
        {
            return yukseklik;
        }

        public void GenislikDegistir(int genislik)
        {
            this.genislik = genislik;
        }
        public int GenislikAl()
        {
            return genislik;
        }
       
        public void Ciz()
        {
            if (genislik != yukseklik || genislik % 2 == 0 || yukseklik % 2 == 0)
            {
                Console.WriteLine("Çizim yapılamıyor");
            }
            else
            {
                for(int i = 1; i <= yukseklik; i += 2)
                {
                    for(int j = yukseklik; j > i; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(sembol);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                    for (int l = 1; l < yukseklik; l += 2)
                    {
                        for (int m = 1; m <= l + 1; m++)
                        {
                            Console.Write(' ');
                        }
                            for (int n = yukseklik-1; n > l; n--)
                            {
                                Console.Write(sembol);
                                Console.Write(" ");
                            }
                    Console.WriteLine();
                }
            }
        }
        

        public double AlanHesapla()
        {
            return 0.5 * genislik * yukseklik;
        }

        public string OzellikYazdir()
        {
            string ozellik = "";
            Console.Write(getOlusturmaTarihi() + " tarihinde oluşturulan Eskenar Dortgen sınıfı : ");
            Console.WriteLine("\nAlan : " + AlanHesapla());
            Console.WriteLine("Sembol : " + sembol);
            Console.WriteLine("DoluMu : " + doluMu);

            return ozellik;
        }


    }
}
