using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuAn_LMB_NhanSu
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            //{
            //    if (!string.IsNullOrEmpty(txtMatKhau.Text))
            //    {
            //        dt.Clear();
            //        dt = Dataprovider.dangnhap(txtTaiKhoan.Text, txtMatKhau.Text);
            //        if (dt.Rows[0]["err"].ToString() == "0")
            //        {
            //            QuanLy ql = new QuanLy();
            //            this.Hide();
            //            ql.Show();
            //        }
            //        else
            //        {
            //            label6.Text = " Lỗi!! Sai tài khoản hoặc mật khẩu";
            //            txtTaiKhoan.Clear();
            //            txtMatKhau.Clear();
            //            txtTaiKhoan.Focus();
            //        }
            //    }
            //    else
            //    {
            //        label6.Text = " Lỗi!! nhập mật khẩu";
            //        txtMatKhau.Focus();
            //    }
            //}
            //else
            //{
            //    label6.Text = " Lỗi!! Nhập tài khoản của bạn";
            //    txtTaiKhoan.Focus();
            //}

            //lay thong tin tu nguoi dung nhap vao contronl

            //tao cau truy van du lieu
            string sql_taikhoan = "SELECT * FROM TAIKHOAN";
            DataTable dt_taikhoan = Dataprovider.getDatatTable(sql_taikhoan);
            foreach(DataRow dr_taikhoan in dt_taikhoan.Rows)
            {
                if (dr_taikhoan["Ten_TaiKhoan"].ToString().Equals(txtTaiKhoan.Text.Trim()) && 
                    dr_taikhoan["MatKhau"].ToString().Equals(txtMatKhau.Text.Trim()))
                {
                    QuanLy ql = new QuanLy();
                    this.Hide();
                    ql.Show();
                }
                else
                {
                    label6.Text = " Lỗi!! Sai tài khoản hoặc mật khẩu";
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }


        }
    }
}
