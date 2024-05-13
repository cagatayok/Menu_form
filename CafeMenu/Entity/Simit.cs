using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Simit:Pastane
    {
        public int simit_fiyat;
        public int sayac;
        public int toplam;
        public Simit() 
        {
            this.simit_fiyat = 10;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += simit_fiyat;
        }


    }
}
