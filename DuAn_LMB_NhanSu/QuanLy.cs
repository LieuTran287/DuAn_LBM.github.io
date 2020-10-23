using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn_LMB_NhanSu
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btChiNhanh_Click(object sender, EventArgs e)
        {
            
            US_Control.CT_ChiNhanh cn = new US_Control.CT_ChiNhanh();
            pnLoad.Controls.Clear();
            pnLoad.Controls.Add(cn);
        }

        private void QuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
