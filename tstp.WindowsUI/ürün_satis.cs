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
    public partial class ürün_satis : Form
    {
        public ürün_satis()
        {
            InitializeComponent();
        }
        public int musteri_no;
        public int satis_no;
        public int personel_no;
        public int parca_no;
        public string metin;
        public string[] parcalar;

        private void ürün_satis_Load(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                
                SqlCommand c = new SqlCommand();
                c.CommandText = "Select * from personel";
                c.Connection = connection.conn;
                c.CommandType = CommandType.Text;
                SqlDataReader d = c.ExecuteReader();
                while (d.Read())
                {
                    combo_personel.Items.Add(d["personel_adi"] + " " + d["personel_soyadi"]);
                }
                connection.balanti_kapat();

                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From yedek_parca", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                connection.balanti_kapat();

                connection.baglanti_kur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select MAX(musteri.musteri_no) as musteri_no from musteri";
                cmd.Connection = connection.conn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    musteri_no = int.Parse(dr["musteri_no"].ToString());
                }
                connection.balanti_kapat();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            
            DialogResult dsl = new DialogResult();
            dsl = MessageBox.Show("Satışı Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (dsl == DialogResult.Yes)
            {
                try
                {


                    fatura.satis_fatura.musteri_adi = tb_musteri_adi.Text;
                    fatura.satis_fatura.musteri_soyadi = tb_musteri_soyadi.Text;
                    fatura.satis_fatura.musteri_telefon = int.Parse(tb_musteri_telefon.Text);
                    fatura.satis_fatura.marka = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    fatura.satis_fatura.model = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    fatura.satis_fatura.fiyat = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    fatura.satis_fatura.adet = int.Parse(textBox1.Text);









                    parca_no = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                connection.baglanti_kur();
                SqlCommand cr3 = new SqlCommand();
                cr3.CommandText = "Select MAX(satis.satis_no) as satis_no from satis";
                cr3.Connection = connection.conn;
                SqlDataReader dd1 = cr3.ExecuteReader();
                if (dd1.Read())
                {
                    
                    satis_no = int.Parse(dd1["satis_no"].ToString());


                }
                connection.balanti_kapat();
                connection.baglanti_kur();

                    SqlCommand cmmd = new SqlCommand();                    
                    cmmd.CommandText = "Select * from musteri where musteri_adi='"+tb_musteri_adi.Text.ToString()+"' and musteri_soyadi='"+tb_musteri_soyadi.Text.ToString()+"' and musteri_telefon="+int.Parse(tb_musteri_telefon.Text);
                    cmmd.Connection = connection.conn;
                    SqlDataReader d = cmmd.ExecuteReader();
                    if(d.Read())
                    {
                        musteri_no = int.Parse(d["musteri_no"].ToString());
                        
                    }
                    else
                    {
                        connection.baglanti_kur();
                        SqlCommand cr = new SqlCommand();
                        cr.CommandText = "Select MAX(musteri.musteri_no) as musteri_no from musteri";
                        cr.Connection = connection.conn;
                        SqlDataReader dd = cr.ExecuteReader();
                        if(dd.Read())
                        {
                            musteri_no = int.Parse(dd["musteri_no"].ToString());
                            
                            

                        }
                        connection.balanti_kapat();


                        connection.baglanti_kur();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = connection.conn;
                        cmd2.CommandText = "Insert Into musteri(musteri_no,musteri_adi,musteri_soyadi,musteri_telefon,musteri_talep) values("+(musteri_no +1)+",'"+tb_musteri_adi.Text.ToString()+"','"+tb_musteri_soyadi.Text.ToString()+"',"+int.Parse(tb_musteri_telefon.Text)+",'Ürün Alımı')";
                        cmd2.ExecuteNonQuery();
                        connection.balanti_kapat();

                    }
                    connection.balanti_kapat();

                    connection.baglanti_kur();
                    SqlCommand crr = new SqlCommand();
                    crr.CommandText = "Select * from personel";
                    crr.Connection = connection.conn;
                    SqlDataReader ddd = crr.ExecuteReader();
                    if (ddd.Read())
                    {
                        personel_no = int.Parse(ddd["personel_no"].ToString());

                    }
                    connection.balanti_kapat();



                    connection.baglanti_kur();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = connection.conn;
                    cmd1.CommandText = "Insert Into satis(satis_no,musteri_no,personel_no,satis_tarih,satis_tanim,parca_no) values(" + (satis_no + 1) + "," + musteri_no + "," + personel_no + ",'" + DateTime.Now.Date.ToString()+ "','Ürün Satışı',"+personel_no+")";
                    cmd1.ExecuteNonQuery();
                    connection.balanti_kapat();

                    connection.baglanti_kur();
                    SqlCommand cmdd1 = new SqlCommand();
                    cmdd1.Connection = connection.conn;
                    cmdd1.CommandText = "Update yedek_parca Set parca_stok=" + (int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) - int.Parse(textBox1.Text.ToString()))+" where parca_no="+int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmdd1.ExecuteNonQuery();
                    connection.balanti_kapat();

                    connection.baglanti_kur();
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * From yedek_parca", connection.conn);
                    adptr.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    connection.balanti_kapat();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.Source);
                }
            }

            satis_fatura s = new satis_fatura();
            s.Show();


        }

        private void combo_personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                metin = combo_personel.Text;
                parcalar = metin.Split(' ');

                
                SqlCommand c = new SqlCommand();
                c.CommandText = "Select personel.personel_no from personel where personel_adi='" + parcalar[0] + "' and personel_soyadi='" + parcalar[1] + "'";
                c.Connection = connection.conn;
                c.CommandType = CommandType.Text;
                SqlDataReader d = c.ExecuteReader();
                if (d.Read())
                {
                    personel_no = int.Parse(d["personel_no"].ToString());
                }
                connection.balanti_kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ürün_satis_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
        }
    }
}
