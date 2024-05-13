using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMenu
{
    public partial class Form2 : Form
    {
        int sayac2= 0;
        int toplam = 0;
        int pogaca_fiyat = 10;
        int simit_fiyat = 10;
        int fiyat;
        int fiyat2;

        Pogaca pogaca=new Pogaca();
        Simit simit=new Simit();
        Pide pide=new Pide();
        Acma acma=new Acma();
        Borek borek=new Borek();
        Baklava baklava=new Baklava();
        Pasta pasta=new Pasta();
        Trilice trilice=new Trilice();
        Cay cay=new Cay();
        Kahve kahve=new Kahve();
        Ayran ayran=new Ayran();
        MeyveSuyu meyvesuyu=new MeyveSuyu();


        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pogaca_Click(object sender, EventArgs e)
        {
            pogaca.fiyat();
            rtb_txt.AppendText("Poğaca Adet= " + pogaca.sayac+Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam+simit.toplam+pide.toplam+acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString()+" TL";
        }

        private void btn_simit_Click(object sender, EventArgs e)
        {
            simit.fiyat();
            rtb_txt.AppendText("Simit Adet= " + simit.sayac.ToString()+Environment.NewLine);
            txt_tutar.Text=(pogaca.toplam+simit.toplam+pide.toplam+acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString()+" TL";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pide_Click(object sender, EventArgs e)
        {
            pide.fiyat();
            rtb_txt.AppendText("Pide Adet= " + pide.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam+pide.toplam+acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";

        }

        private void btn_acma_Click(object sender, EventArgs e)
        {
            acma.fiyat();
            rtb_txt.AppendText("Acma Adet= " + acma.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam+acma.toplam + borek.toplam + baklava.toplam+pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";

        }

        private void btn_borek_Click(object sender, EventArgs e)
        {
            borek.fiyat();
            rtb_txt.AppendText("Borek Adet= " + borek.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam+borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";

        }

        private void btn_baklava_Click(object sender, EventArgs e)
        {
            baklava.fiyat();
            rtb_txt.AppendText("Baklva Adet= " + baklava.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam+baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";
        }

        private void btn_pasta_Click(object sender, EventArgs e)
        {
            pasta.fiyat();
            rtb_txt.AppendText("Pasta Adet= " + pasta.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam + baklava.toplam+pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";
        }

        private void btn_trilece_Click(object sender, EventArgs e)
        {
            trilice.fiyat();
            rtb_txt.AppendText("Trilice Adet= " + trilice.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam + baklava.toplam + pasta.toplam+trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cay.fiyat();
            rtb_txt.AppendText("Çay Adet= " + cay.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam+cay.toplam + kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";

        }

        private void btn_kahve_Click(object sender, EventArgs e)
        {
            kahve.fiyat();
            rtb_txt.AppendText("Kahve Adet= " + kahve.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam+kahve.toplam + ayran.toplam + meyvesuyu.toplam).ToString() + " TL";

        }

        private void btn_ayran_Click(object sender, EventArgs e)
        {
            ayran.fiyat();
            rtb_txt.AppendText("Ayran Adet= " +ayran.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam+ayran.toplam + meyvesuyu.toplam).ToString() + " TL";
        }

        private void btn_meyveSuyu_Click(object sender, EventArgs e)
        {
            meyvesuyu.fiyat();
            rtb_txt.AppendText("Meyve Suyu Adet= " + meyvesuyu.sayac.ToString() + Environment.NewLine);
            txt_tutar.Text = (pogaca.toplam + simit.toplam + pide.toplam + acma.toplam + borek.toplam + baklava.toplam + pasta.toplam + trilice.toplam + cay.toplam + kahve.toplam + ayran.toplam+ meyvesuyu.toplam).ToString() + " TL";
        }

        private void txt_tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            rtb_txt.Clear();
            txt_tutar.Clear();
        }
    }
}
