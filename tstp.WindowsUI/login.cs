using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otomasyon
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public string user_name = "";
        public string user_password = "";
        public string user_type = "";
        public int user_id;


        public static string ad;
        public static string soyad;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=otom;User Id=standart;password=1;");
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_pass_Enter(object sender, EventArgs e)
        {
            tb_pass.ForeColor = Color.Black;
            tb_pass.Clear();
            tb_pass.PasswordChar = '*';
        }

        
        private void tb_name_Enter(object sender, EventArgs e)
        {
            tb_name.ForeColor = Color.Black;
            tb_name.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            check c = new check();
            c.Show();
            
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin s = new signin();
            s.tür = "user";
            s.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();                               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From kullanici Where Kullanici_adi='" + tb_name.Text.ToString() + "' and kullanici_sifre='" + tb_pass.Text.ToString() + "'", conn);
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                

                if (dataGridView1.Rows.Count > 1)
                {

                    if (dataGridView1.Rows[0].Cells[5].Value.ToString() == "admin")
                    {
                        connection.yetki = "admin";
                    }
                    else
                    {
                        connection.yetki = "user";
                    }
                    user_id = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                    user_name = tb_name.Text.ToString();
                    user_password = tb_pass.ToString();
                    user_type = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Update kullanici set kullanici_giris_sayisi='"+(int.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString())+1)+"',kullanici_giris_tarihi='"+DateTime.Now.Date+"',kullanici_giris_saati='"+DateTime.Now.Hour+":"+DateTime.Now.Minute+"' where kulanici_no='"+user_id+"'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ad = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    soyad = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    MessageBox.Show("Hoşgeldiniz "+dataGridView1.Rows[0].Cells[1].Value.ToString()+" "+ dataGridView1.Rows[0].Cells[2].Value.ToString()+" Anasayfaya Yönlendiriliyorsunuz");
                    anasayfa ana = new anasayfa();
                    ana.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!!!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            
        }

        
    }
}
