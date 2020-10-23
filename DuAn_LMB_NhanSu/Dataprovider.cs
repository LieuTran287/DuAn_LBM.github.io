using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_LMB_NhanSu
{
    class Dataprovider
    {
        public static SqlConnection conn = null;
        public static DataTable dt = new DataTable();
        public static SqlConnection ketnoidulieu()
        {
            try
            {
                
                string[] kq;
                FileStream fs = new FileStream(@"ketnoi.ini", FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                String c = rd.ReadToEnd();
                string[] stringSeparators = new string[] { "\r\n" };
                kq = c.Split(stringSeparators, StringSplitOptions.None);
                string chuoiketnoi = "Data Source=" + kq[0].Trim() + ";Initial Catalog=" + kq[1].Trim() + ";Integrated Security=True";
                conn = new SqlConnection(chuoiketnoi);
                rd.Close();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #region
        ///Thực thi câu truy vấn
        ///
        public static DataTable dangnhap(string tk, string mk)
        {
            conn = ketnoidulieu();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            SqlCommand cm = new SqlCommand("DangNhap", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@taikhoan", tk);
            cm.Parameters.AddWithValue("@matkhau", mk);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}
