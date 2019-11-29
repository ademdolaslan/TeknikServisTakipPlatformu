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
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=otom;User Id=standart;password=1;");
        signin s = new signin();
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select * From kullanici Where Kullanici_adi='" + tb_name.Text.ToString() + "' and kullanici_sifre='" + tb_pass.Text.ToString() + "' and kullanici_türü='admin'", conn);
            adptr.Fill(tbl);
            if(tbl.Rows.Count!=0)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Giriş Başarılı Yönlendiriliyorsunuz ";
                s.tür = "admin";
                s.Show();
                Close();
                
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Giriş Başarısız Tekrar deneyiniz ";
            }
            conn.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_name.ForeColor = Color.Black;
        }

        private void tb_pass_Enter(object sender, EventArgs e)
        {
            tb_pass.Clear();
            tb_pass.ForeColor = Color.Black;
            tb_pass.PasswordChar = '*';
        }

        private void check_Load(object sender, EventArgs e)
        {

        }
    }
}
