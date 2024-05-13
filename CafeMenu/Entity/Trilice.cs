using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public class Trilice : Pastane
    {
        public int trilice_fiyat;
        public int sayac;
        public int toplam;

        public Trilice()
        {
            this.trilice_fiyat = 40;
            this.sayac = 0;
            this.toplam = 0;
        }

        public override int fiyat()
        {
            sayac++;
            return toplam += trilice_fiyat;
        }
    }
}
