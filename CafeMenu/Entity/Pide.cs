using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Pide:Pastane
    {
        public int pide_fiyat;
        public int sayac;
        public int toplam;

        public Pide()
        {
            this.pide_fiyat = 20;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += pide_fiyat;
        }

    }
}
