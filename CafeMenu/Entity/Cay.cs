using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Cay:Pastane
    {
        public int cay_fiyat;
        public int sayac;
        public int toplam;

        public Cay()
        {
            this.cay_fiyat = 20;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += cay_fiyat;
        }
    }
}
