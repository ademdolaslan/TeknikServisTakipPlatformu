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
    public partial class satis_fatura : Form
    {
        public satis_fatura()
        {
            InitializeComponent();
        }

        private void fatura_ekranı_Load(object sender, EventArgs e)
        {
            label8.Text = label8.Text + " " + DateTime.Now.Date;
            lbl_ad.Text =lbl_ad.Text + fatura.satis_fatura.musteri_adi;
            lbl_soyad.Text =lbl_soyad.Text+ fatura.satis_fatura.musteri_soyadi;
            lbl_tel.Text = lbl_tel.Text + fatura.satis_fatura.musteri_telefon.ToString();
            lbl_miktar.Text = fatura.satis_fatura.adet.ToString();
            lbl_cins.Text = fatura.satis_fatura.marka + " " + fatura.satis_fatura.model;
            lbl_tutar.Text = ((fatura.satis_fatura.adet * fatura.satis_fatura.fiyat) + ((fatura.satis_fatura.adet * fatura.satis_fatura.fiyat) * 0.18)).ToString();






        }

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
