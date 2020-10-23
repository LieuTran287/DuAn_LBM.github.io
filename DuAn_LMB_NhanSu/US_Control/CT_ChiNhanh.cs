using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuAn_LMB_NhanSu.US_Control
{
    public partial class CT_ChiNhanh : UserControl
    {
        DataTable dt_chinhanh = new DataTable();
        Dataprovider data = new Dataprovider();
        SqlDataReader dr;

        private DataGridViewRow drv_chinhanh = new DataGridViewRow();
        public DataGridViewRow DRV_CHINHANH
        {
            get { return drv_chinhanh; }
            set { drv_chinhanh = value; }
        }
        public CT_ChiNhanh()
        {
            InitializeComponent();
        }

        private void load()
        {
            string sql_chinhanh = "SELECT * FROM CHINHANH";
            //dt = Dataprovider.HienThiChiNhanh("0");
            dt_chinhanh = Dataprovider.getDatatTable(sql_chinhanh);
            Luoi_ChiNhanh.DataSource = dt_chinhanh;
        }
        private void CT_ChiNhanh_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btThemPhongBan_Click(object sender, EventArgs e)
        {

            US_Control.CT_PhongBan pb = new CT_PhongBan();
            this.Hide();
            pb.getChinhanh += delegate { return drv_chinhanh; };
            this.Parent.Controls.Add(pb);
            
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaChiNhanh.Text))
            {
                if (!string.IsNullOrEmpty(txtTenChiNhanh.Text))
                {
                    dr = data.ThemChiNhanh(txtMaChiNhanh.Text, txtTenChiNhanh.Text, cboCapCN.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtNhomMe.Text);
                    label10.Text = "Thêm vào thành công!";
                    load();
                }
                else
                {
                    label9.Text = "Lỗi!";
                }
            }
            else
            {
                label8.Text = "Lỗi!";
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void Luoi_ChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            drv_chinhanh = Luoi_ChiNhanh.Rows[e.RowIndex];
        }
    }
}
