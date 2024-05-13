using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Acma:Pastane
    {
        public int acma_fiyat;
        public int sayac;
        public int toplam;

        public Acma()
        {
            this.acma_fiyat = 12;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += acma_fiyat;
        }


    }
}
