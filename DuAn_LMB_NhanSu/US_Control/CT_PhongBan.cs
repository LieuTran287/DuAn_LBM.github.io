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
        public CT_PhongBan()
        {
            InitializeComponent();
        }

        private void CT_PhongBan_Load(object sender, EventArgs e)
        {
            DataGridViewRow drv_chinhanh = getChinhanh();
            lbmachinhanh.Text = drv_chinhanh.Cells[0].Value.ToString();
        }
    }
}
