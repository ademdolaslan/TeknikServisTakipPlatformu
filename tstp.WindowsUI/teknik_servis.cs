using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class teknik_servis : Form
    {
        public teknik_servis()
        {
            InitializeComponent();
        }
        public int sil_arıza_no;
        public int musterino;
        public int personelno;
        public int arızano;
        public string metin;
        string[] parcalar;
        private void teknik_servis_Load(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select teknik_servis.ariza_no,musteri.musteri_adi,musteri.musteri_soyadi,musteri.musteri_telefon,teknik_servis.ariza_cihaz,teknik_servis.ariza_tanim,teknik_servis.ariza_cozum,personel.personel_adi,personel.personel_soyadi From musteri,teknik_servis,personel Where teknik_servis.musteri_no=musteri.musteri_no and teknik_servis.personel_no=personel.personel_no", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;



                SqlCommand kmt = new SqlCommand();
                kmt.Connection=connection.conn;
                kmt.CommandText = "Select MAX(musteri.musteri_no) as musteri_no,MAX(teknik_servis.ariza_no) as ariza_no From musteri,teknik_servis";
                kmt.ExecuteNonQuery(); 
                SqlDataReader dr = kmt.ExecuteReader();
                if(dr.Read())
                {
                    musterino = int.Parse(dr["musteri_no"].ToString());
                    arızano = int.Parse(dr["ariza_no"].ToString());                   
                }
                connection.balanti_kapat();
                connection.baglanti_kur();
                SqlCommand c = new SqlCommand();
                c.CommandText = "Select * from personel";
                c.Connection = connection.conn;
                c.CommandType = CommandType.Text;
                SqlDataReader d = c.ExecuteReader();
                while(d.Read())
                {
                    combo_personel.Items.Add(d["personel_adi"] + " " + d["personel_soyadi"]);
                }
                connection.balanti_kapat();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void teknik_servis_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
           
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            
            try
            {
                connection.baglanti_kur();

                SqlCommand a = new SqlCommand();
                a.Connection = connection.conn;
                a.CommandText = "Select * From Personel Where personel_adi='" + parcalar[0] + "' and personel_soyadi='" + parcalar[1] + "'";
                a.ExecuteNonQuery();
                SqlDataReader d = a.ExecuteReader();
                if (d.Read())
                {
                    personelno = int.Parse(d["personel_no"].ToString());
                }
                connection.balanti_kapat();
                connection.baglanti_kur();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection.conn;
                cmd.CommandText = "Insert Into musteri(musteri_no,musteri_adi,musteri_soyadi,musteri_telefon,musteri_talep) Values("+(musterino + 1)+",'"+tb_m_adi.Text.ToString()+"','"+tb_m_soyadi.Text.ToString()+"','"+tb_m_telefon.Text.ToString()+"','"+tb_talep.Text.ToString()+"')";
                cmd.ExecuteNonQuery();

                connection.balanti_kapat();
                connection.baglanti_kur();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = connection.conn;
                cmd1.CommandText = "Insert Into teknik_servis(ariza_no,musteri_no,personel_no,ariza_tanim,ariza_cozum,ariza_cihaz) values("+(arızano+1)+","+(musterino+1)+","+(personelno)+",'"+tb_arıza_tanım.Text.ToString()+"','"+tb_arıza_çözüm.Text.ToString()+"','"+tb_cihaz.Text.ToString()+"')";
                cmd1.ExecuteNonQuery();

                connection.balanti_kapat();
                connection.baglanti_kur();

                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select teknik_servis.ariza_no,musteri.musteri_adi,musteri.musteri_soyadi,musteri.musteri_telefon,teknik_servis.ariza_cihaz,teknik_servis.ariza_tanim,teknik_servis.ariza_cozum,personel.personel_adi,personel.personel_soyadi From musteri,teknik_servis,personel Where teknik_servis.musteri_no=musteri.musteri_no and teknik_servis.personel_no=personel.personel_no", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;

                connection.balanti_kapat();
                connection.baglanti_kur();


                connection.balanti_kapat();
                musterino++;
                arızano++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void combo_personel_TextChanged(object sender, EventArgs e)
        {
            metin=combo_personel.Text;
            parcalar = metin.Split(' ');
            

        }

       

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dsl = new DialogResult();
            dsl = MessageBox.Show("Çıkışı Onaylıyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (dsl == DialogResult.Yes)
            {
                try
                {
                    fatura.fatura_bilgileri.musteri_adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    fatura.fatura_bilgileri.musteri_soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    fatura.fatura_bilgileri.musteri_telefon = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    fatura.fatura_bilgileri.musteri_cihaz = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    fatura.fatura_bilgileri.musteri_cihaz_çözüm = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    fatura.fatura_bilgileri.personel_adi = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    fatura.fatura_bilgileri.personel_soyadi = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                    connection.baglanti_kur();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = connection.conn;
                    cmd1.CommandText = "delete from teknik_servis where ariza_no=" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd1.ExecuteNonQuery();

                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select teknik_servis.ariza_no,musteri.musteri_adi,musteri.musteri_soyadi,musteri.musteri_telefon,teknik_servis.ariza_cihaz,teknik_servis.ariza_tanim,teknik_servis.ariza_cozum,personel.personel_adi,personel.personel_soyadi From musteri,teknik_servis,personel Where teknik_servis.musteri_no=musteri.musteri_no and teknik_servis.personel_no=personel.personel_no", connection.conn);
                    adptr.Fill(tbl);
                    dataGridView1.DataSource = tbl;

                    MessageBox.Show("Fatura Sayfasına Yönlendiriliyorsunuz");

                    ts_fatura f = new ts_fatura();
                    f.Show();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
