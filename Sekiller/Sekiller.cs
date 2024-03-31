using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Sekiller
    {
        protected char sembol;
        protected bool doluMu;
        protected string olusturulmaTarihi;

        public bool getDoluMu()
        {
            return doluMu;
        }

        public bool setDoluMu(bool doluMu)
        {
            return doluMu;
        }

        public char setSembol(char sembol)
        {
            return sembol;
        }

        public string getOlusturmaTarihi()
        {
            return olusturulmaTarihi;
        }

        public Sekiller(char sembol = '*', bool doluMu = false)
        {
            this.sembol = sembol;
            this.doluMu = doluMu;
            olusturulmaTarihi = DateTime.Now.ToString();
        }

        public Sekiller(char sembol)
        {
            this.sembol = sembol;
            olusturulmaTarihi = DateTime.Now.ToString();
            sembol = '*';
        }

       
    }
}
