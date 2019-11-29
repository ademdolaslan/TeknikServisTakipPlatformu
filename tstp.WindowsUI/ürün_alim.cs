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
    public partial class ürün_alim : Form
    {
        public ürün_alim()
        {
            InitializeComponent();
        }
        public int firma_no;
        public int alım_no;
        public int personel_no;
        public int parca_no;
        public string metin;
        public string[] parcalar;
        private void ürün_alim_Load(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From yedek_parca", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                connection.balanti_kapat();


                connection.baglanti_kur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select MAX(firmalar.firma_no) as firma_no,MAX(alim.alim_no) as alim_no,MAX(yedek_parca.parca_no) as parca_no from yedek_parca,firmalar,alim";
                cmd.Connection = connection.conn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    parca_no = int.Parse(dr["parca_no"].ToString());
                    firma_no = int.Parse(dr["firma_no"].ToString());
                    alım_no = int.Parse(dr["alim_no"].ToString());
                }
                connection.balanti_kapat();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ürün_alim_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
        }
        private void tb_firma_ad_Leave(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                SqlCommand c = new SqlCommand();
                c.CommandText = "Select * from firmalar where firmalar.firma_adi LIKE '" + tb_firma_ad.Text.ToString() + "%'";
                c.Connection = connection.conn;
                SqlDataReader d = c.ExecuteReader();

                if (d.Read())
                {
                    firma_no = int.Parse(d["firma_no"].ToString());
                    tb_firma_ad.Text = d["firma_adi"].ToString();
                    tb_firma_telefon.Text = d["firma_telefon"].ToString();
                    tb_firma_adres.Text = d["firma_adres"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                



                connection.baglanti_kur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from yedek_parca where parca_ismi='"+tb_ürün_ad.Text.ToString()+"' and parca_marka='"+tb_ürün_marka.Text.ToString()+"' and parca_model='"+tb_ürün_model.Text.ToString()+"'";
                cmd.Connection = connection.conn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    parca_no = int.Parse(dr["parca_no"].ToString());
                    int parca_stok = int.Parse(dr["parca_stok"].ToString());
                    connection.balanti_kapat();
                    connection.baglanti_kur();
                    SqlCommand cc = new SqlCommand();
                    cc.Connection = connection.conn;
                    cc.CommandText = "Update yedek_parca SET parca_stok=" + (parca_stok + int.Parse(tb_ürün_stok.Text)) + " where parca_no=" + parca_no;
                    cc.ExecuteNonQuery();
                    connection.balanti_kapat();
                    





                    try
                    {
                        connection.baglanti_kur();
                        SqlCommand c = new SqlCommand();
                        c.CommandText = "Select * from firmalar where firmalar.firma_adi LIKE '" + tb_firma_ad.Text.ToString() + "%'";
                        c.Connection = connection.conn;
                        SqlDataReader d = c.ExecuteReader();

                        if (d.Read())
                        {
                            firma_no = int.Parse(d["firma_no"].ToString());
                            tb_firma_ad.Text = d["firma_adi"].ToString();
                            tb_firma_telefon.Text = d["firma_telefon"].ToString();
                            tb_firma_adres.Text = d["firma_adres"].ToString();
                        }
                        else
                        {
                            connection.baglanti_kur();

                            SqlCommand cccc = new SqlCommand();
                            cccc.Connection = connection.conn;
                            cccc.CommandText = "Insert Into firmalar(firma_no,firma_adi,firma_telefon,firma_adres) Values(" + (firma_no + 1) + ",'" + tb_firma_ad.Text.ToString() + "','" + int.Parse(tb_firma_telefon.Text.ToString()) + "','" + tb_firma_adres.Text.ToString() + "')";
                            cccc.ExecuteNonQuery();
                            connection.balanti_kapat();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }





                    connection.baglanti_kur();
                    SqlCommand c1 = new SqlCommand();
                    c1.Connection = connection.conn;
                    c1.CommandText = "Insert Into alim(alim_no,firma_no,personel_no,alim_tarih,alim_tanim,parca_no) Values(" + (alım_no + 1) + ",'" + (firma_no) + "','" + personel_no + "','" + DateTime.Now.Date.ToString() + "','" + "Yeni Parça Girişi" + "','" + parca_no + "')";
                    c1.ExecuteNonQuery();
                    connection.balanti_kapat();
                    firma_no+=1;
                    alım_no+=1;
                    



                }

                else
                {
                    connection.balanti_kapat();
                    connection.baglanti_kur();
                    SqlCommand cc = new SqlCommand();
                    cc.Connection = connection.conn;
                    cc.CommandText = "Insert Into yedek_parca(parca_no,parca_ismi,parca_marka,parca_model,parca_stok,parca_fiyat,parca_tür) Values(" + (parca_no + 1) + ",'" + tb_ürün_ad.Text.ToString() + "','" + tb_ürün_marka.Text.ToString() + "','" + tb_ürün_model.Text.ToString() + "','" + int.Parse(tb_ürün_stok.Text) + "','"+int.Parse(tb_ürün_fiyat.Text)+"','"+combo_tür.Text.ToString()+"')";
                    cc.ExecuteNonQuery();
                    connection.balanti_kapat();
                    parca_no+=1;

                    connection.baglanti_kur();                   
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "Select * from firmalar where firmalar.firma_adi LIKE '" + tb_firma_ad.Text.ToString() + "%'";
                    c.Connection = connection.conn;
                    SqlDataReader d = c.ExecuteReader();
                    if (d.Read())
                    {
                        
                    }
                    else
                    {
                        SqlCommand cccc = new SqlCommand();
                        cccc.Connection = connection.conn;
                        cccc.CommandText = "Insert Into firmalar(firma_no,firma_adi,firma_telefon,firma_adres) Values(" + (firma_no + 1) + ",'" + tb_firma_ad.Text.ToString() + "','" + int.Parse(tb_firma_telefon.Text.ToString()) + "','" + tb_firma_adres.Text.ToString() + "')";
                        cccc.ExecuteNonQuery();
                        firma_no+=1;
                        

                    }

                    connection.balanti_kapat();

                    connection.baglanti_kur();
                    SqlCommand c1 = new SqlCommand();
                    c1.Connection = connection.conn;
                    c1.CommandText = "Insert Into alim(alım_no,firma_no,personel_no,alim_tarih,alim_tanim,parca_no) Values(" + (alım_no + 1) + ",'" + (firma_no) + "','" + personel_no + "','" +DateTime.Now.Date.ToString()+ "','"+"Yeni Parça Girişi"+"','"+ parca_no +"')";
                    c1.ExecuteNonQuery();
                    alım_no+=1;
                    connection.balanti_kapat();






                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                connection.balanti_kapat();
                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From yedek_parca", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                connection.balanti_kapat();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void combo_personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                metin = combo_personel.Text;
                parcalar = metin.Split(' ');

                connection.baglanti_kur();
                SqlCommand c = new SqlCommand();
                c.CommandText = "Select personel.personel_no from personel where personel_adi='"+parcalar[0]+"' and personel_soyadi='"+parcalar[1]+"'";
                c.Connection = connection.conn;
                c.CommandType = CommandType.Text;
                SqlDataReader d = c.ExecuteReader();
                if (d.Read())
                {
                    personel_no = int.Parse(d["personel_no"].ToString());
                }
                connection.balanti_kapat();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
