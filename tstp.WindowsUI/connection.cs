using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace otomasyon
{
    public class connection
    {
        public static string yetki;
        public static SqlConnection conn;
        public static string hata;
        public static void baglanti_kur()
        {
            try
            {
                if(yetki=="admin")
                {
                    conn = new SqlConnection("Data Source=.;Initial Catalog=otom;User Id=yonetici;password=12;");
                }
                if(yetki=="user")
                {
                    conn = new SqlConnection("Data Source=.;Initial Catalog=otom;User Id=standart;password=1;");
                }
                conn.Open();
            }
            catch(Exception ex)
            {
                hata = ex.ToString();
                
            }
        }

        public static void balanti_kapat()
        {
            conn.Close();
        }
    }
}
