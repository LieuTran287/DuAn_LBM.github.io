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
        public static DataTable dt;
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
        ///Đăng nhập
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

        ///Hiện chi nhánh
        ///
        public static DataTable HienThiChiNhanh(string machinhanh)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cm = new SqlCommand("HienChiNhanh", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@machinhanh", machinhanh);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        #endregion
        public static DataTable getDatatTable(string sql)
        {
            //dt.Clear();
            dt = new DataTable();
            conn = ketnoidulieu();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }

        public SqlDataReader ThemChiNhanh(string machinhanh, string tenchinhanh, string cap, string diachi, string sdt, string nhomme)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlDataReader dr = null;
            SqlCommand cm = new SqlCommand("ThemChiNhanh", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@machinhanh", machinhanh);
            cm.Parameters.AddWithValue("@tenchinhanh", tenchinhanh);
            cm.Parameters.AddWithValue("@cap", cap);
            cm.Parameters.AddWithValue("@diachi", diachi);
            cm.Parameters.AddWithValue("@sdt", sdt);
            cm.Parameters.AddWithValue("@nhomme", nhomme);
            dr = cm.ExecuteReader();
            return dr;
        }
    }
}
