using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace otomasyon
{
    public partial class signin : Form
    {
        public string tür = "";
        int no;
        public signin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=otom;User Id=standart;password=1;");
        SqlCommand cmd = new SqlCommand();
        

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz İpptal Edilmiştir !");
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable t = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter("Select kullanici_adi from kullanici where kullanici_adi='" + tb_username.Text.ToString() + "'", conn);
                a.Fill(t);
                if (t.Rows.Count == 0)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "Insert Into kullanici (kulanici_no,adi,soyadi,kullanici_adi,kullanici_sifre,kullanici_türü,kullanici_giris_sayisi) values (" + (no + 1) + ",'" + tb_name.Text.ToString() + "','" + tb_surname.Text.ToString() + "','" + tb_username.Text.ToString() + "','" + tb_password.Text.ToString() + "','" + tür.ToString() + "'," + 0 + ")";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Başarılı Bir Şekilde Kullanıcı Oluşturdunuz");
                        conn.Close();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Daha Önce Alınmış Lütfen Başka Bir Kullanıcı Adı Seçin");
                }
            }
            catch(Exception eeee)
            {
                MessageBox.Show(eeee.ToString());
            }

        }

        private void signin_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select MAX(kulanici_no) as kullanici_id From kullanici",conn);
            adptr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            no = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
            btn_submit.Enabled = false;
            
            


        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && tb_password.Text != "" && tb_surname.Text != "" && tb_username.Text != "")
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && tb_password.Text != "" && tb_surname.Text != "" && tb_username.Text != "")
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && tb_password.Text != "" && tb_surname.Text != "" && tb_username.Text != "")
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }

        private void tb_surname_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && tb_password.Text != "" && tb_surname.Text != "" && tb_username.Text != "")
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }
    }
}
