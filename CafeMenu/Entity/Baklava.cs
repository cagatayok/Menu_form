using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Baklava:Pastane
    {
        public int baklava_fiyat;
        public int sayac;
        public int toplam;

        public Baklava()
        {
            this.baklava_fiyat = 100;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += baklava_fiyat;
        }

    }
}
