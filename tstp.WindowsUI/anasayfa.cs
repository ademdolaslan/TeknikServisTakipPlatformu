using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            label1.Text = login.ad +" "+ login.soyad + " Olarak Giriş Yaptınız";
            try
            {
                connection.baglanti_kur();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_teknik_servis_Click(object sender, EventArgs e)
        {
            teknik_servis tk = new teknik_servis();
            Hide();
            tk.Show();

        }

        private void btn_ürün_satış_Click(object sender, EventArgs e)
        {
            ürün_satis üs = new ürün_satis();
            üs.Show();
            Hide();
        }

        private void btn_ürün_alım_Click(object sender, EventArgs e)
        {
            ürün_alim üa = new ürün_alim();
            üa.Show();
            Hide();
        }

        private void btn_depo_Click(object sender, EventArgs e)
        {
            depo d = new depo();
            d.Show();
            Hide();
        }
    }
}
