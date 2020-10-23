using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_LMB_NhanSu.US_Control
{
    public partial class CT_PhongBan : UserControl
    {
        public delegate DataGridViewRow drvChiNhanh();
        public drvChiNhanh getChinhanh;
        DataTable dt = new DataTable();
        string mapb = null, tenpb = null, sonv = null;

        //Hàm load dữ liệu
        public void load()
        {
            DataGridViewRow drv_chinhanh = getChinhanh();
            lbMaChiNhanh.Text = drv_chinhanh.Cells[0].Value.ToString();
            string query = "select Ma_PhongBan,Ten_PhongBan,SoLuongNV from PHONGBAN where Ma_ChiNhanh = '" + lbMaChiNhanh.Text + "'";
            dt = Dataprovider.getDatatTable(query);
            Luoi_PhongBan.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhongBan.Text))
            {
                if (!string.IsNullOrEmpty(txtTenPhongBan.Text))
                {
                    string insert = "insert into PHONGBAN(Ma_PhongBan,Ten_PhongBan,SoLuongNV,Ma_ChiNhanh) values ('" + txtMaPhongBan.Text + "',N'" + txtTenPhongBan.Text + "','" + txtSoLNhanVien.Text + "','" + lbMaChiNhanh.Text + "')";
                    dt = Dataprovider.getDatatTable(insert);
                    load();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhongBan.Text))
            {
                if (!string.IsNullOrEmpty(txtTenPhongBan.Text))
                {
                    string update = "update PHONGBAN set Ten_PhongBan = N'" + txtTenPhongBan.Text + "',SoLuongNV = '" + txtSoLNhanVien.Text + "',Ma_ChiNhanh = '" + lbMaChiNhanh.Text + "' where Ma_PhongBan = '" + txtMaPhongBan.Text + "'";
                    dt = Dataprovider.getDatatTable(update);
                    int ktra = Dataprovider.Update(dt);
                    load();
                }
            }
        }

        private void Luoi_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mapb = Luoi_PhongBan.CurrentRow.Cells[0].Value.ToString();
            tenpb = Luoi_PhongBan.CurrentRow.Cells[1].Value.ToString();
            sonv = Luoi_PhongBan.CurrentRow.Cells[2].Value.ToString();
            txtMaPhongBan.Text = mapb;
            txtSoLNhanVien.Text = sonv;
            txtTenPhongBan.Text = tenpb;
        }

        public CT_PhongBan()
        {
            InitializeComponent();
        }

        private void CT_PhongBan_Load(object sender, EventArgs e)
        {
            load();
        }

    }
}
