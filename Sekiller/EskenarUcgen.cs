using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class EskenarUcgen : Sekiller
    {
        private int kenar;


        public EskenarUcgen()
        {

        }
        public EskenarUcgen(int kenar, char sembol = '%', bool doluMu = true) :base(sembol, doluMu)
        {
            this.kenar = kenar;
            
        }

        public int getKenar()
        {
            return kenar;
        }

        public int setKenar(int kenar)
        {
            return kenar;
        }
         
        public double AlanHesapla()
        {
            return (Math.Pow(kenar, 2)) * (Math.Sqrt(3) / 4);
        }

        public double CevreHesapla()
        {
            return (kenar + kenar + kenar);
        }

        public void Ciz()
        {
            if(kenar % 2 == 0)
            {
                Console.WriteLine("Çizim yapılamıyor.");
            }
            else
            {
                for(int i = 0; i < kenar; i += 2)
                {
                    for(int j = i; j < kenar; j++)
                    {
                        Console.Write(' ');
                    }
                    for(int k = 0; k <= i; k++)
                    {
                        Console.Write(sembol);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            
        }

        public string OzellikYazdir()
        {
            string ozellik = "";
            Console.Write(getOlusturmaTarihi() + " tarihinde oluşturulan Eskenar Ucgen sınıfı : ");
            Console.WriteLine("\nAlan  :" + AlanHesapla());
            Console.WriteLine("Cevre : " + CevreHesapla());
            Console.WriteLine("Sembol : " + sembol);
            Console.WriteLine("DoluMu : " + doluMu);

            return ozellik;
        }
    }
}
