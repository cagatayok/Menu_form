using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Kahve:Pastane
    {
        public int kahve_fiyat;
        public int sayac;
        public int toplam;

        public Kahve()
        {
            this.kahve_fiyat = 30;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += kahve_fiyat;
        }
    }
}
