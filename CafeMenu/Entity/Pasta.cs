using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Pasta:Pastane
    {
        public int pasta_fiyat;
        public int sayac;
        public int toplam;

        public Pasta()
        {
            this.pasta_fiyat = 120;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += pasta_fiyat;
        }
    }
}
