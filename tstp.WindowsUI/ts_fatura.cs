using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class ts_fatura : Form
    {
        public ts_fatura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

        private void ts_fatura_Load(object sender, EventArgs e)
        {
            label8.Text = label8.Text + " " + DateTime.Now.Date;
            lbl_ad.Text = lbl_ad.Text + fatura.fatura_bilgileri.musteri_adi;
            lbl_soyad.Text = lbl_soyad.Text + fatura.fatura_bilgileri.musteri_soyadi;
            lbl_tel.Text = lbl_tel.Text + fatura.fatura_bilgileri.musteri_telefon;
            lbl_cins.Text = fatura.fatura_bilgileri.musteri_cihaz;
            lbl_miktar.Text = fatura.fatura_bilgileri.musteri_cihaz_çözüm;
            lbl_personel.Text = fatura.fatura_bilgileri.personel_adi + " " + fatura.fatura_bilgileri.personel_soyadi;

        }
    }
}
