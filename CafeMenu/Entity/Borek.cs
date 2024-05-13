using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Borek:Pastane
    {
        public int borek_fiyat;
        public int sayac;
        public int toplam;

        public Borek()
        {
            this.borek_fiyat = 15;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam+=borek_fiyat;
        }

    }
}
