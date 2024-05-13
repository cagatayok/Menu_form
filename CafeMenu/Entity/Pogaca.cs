using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Pogaca:Pastane
    {
        public int pogaca_fiyat;
        public int sayac;
        public int toplam;
        

        public Pogaca()
        {
            this.pogaca_fiyat = 10;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += pogaca_fiyat;
        }
    }
}
