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
    public partial class depo : Form
    {
        public depo()
        {
            InitializeComponent();
        }

        private void depo_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
        }
        public string param;

        private void depo_Load(object sender, EventArgs e)
        {
            int rc = 0;
            int rr = 0;
            try
            {
                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                connection.balanti_kapat();


                if(dataGridView1.RowCount>0)
                {
                    for(int i=0;i<dataGridView1.RowCount-1;i++)
                    {
                        rc += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                }
                rr = dataGridView1.RowCount;

                label2.Text = "Şu anda deponuzda toplam " + rc.ToString() + " adet , " + rr.ToString() + " farklı ürün bulunmaktadır.";

            }
            catch(Exception ex)
            {

            }
            



        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            param = comboBox1.Text.ToString();
        }

        private void btn_filtrele_Click(object sender, EventArgs e)
        {
            try
            {
                if (param == "Ürün Adına Göre")
                {
                    connection.baglanti_kur();
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca where parca_ismi Like '%" + tb_filter.Text.ToString() + "%'", connection.conn);
                    adptr.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    connection.balanti_kapat();
                }
                if (param == "Ürün Markasına Göre")
                {
                    connection.baglanti_kur();
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca where parca_marka Like '%" + tb_filter.Text.ToString() + "%'", connection.conn);
                    adptr.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    connection.balanti_kapat();
                }
                if (param == "Ürün Modeline Göre")
                {
                    connection.baglanti_kur();
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca where parca_model Like '%" + tb_filter.Text.ToString() + "%'", connection.conn);
                    adptr.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    connection.balanti_kapat();
                }
                if (param == "Ürün Türüne Göre")
                {
                    connection.baglanti_kur();
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca where parca_tur Like '%" + tb_filter.Text.ToString() + "%'", connection.conn);
                    adptr.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    connection.balanti_kapat();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca", connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                connection.balanti_kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                connection.baglanti_kur();
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From view_yedek_parca where parca_no="+int.Parse(tb_parca_no.Text.ToString()), connection.conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                connection.balanti_kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
