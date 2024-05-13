using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Ayran:Pastane
    {
        public int ayran_fiyat;
        public int sayac;
        public int toplam;

        public Ayran()
        {
            this.ayran_fiyat = 20;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += ayran_fiyat;
        }
    }
}
