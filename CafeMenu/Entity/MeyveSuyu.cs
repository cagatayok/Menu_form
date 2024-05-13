using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class MeyveSuyu:Pastane
    {
        public int meyveSuyu_fiyat;
        public int sayac;
        public int toplam;

        public MeyveSuyu()
        {
            this.meyveSuyu_fiyat = 25;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += meyveSuyu_fiyat;
        }
    }
}
