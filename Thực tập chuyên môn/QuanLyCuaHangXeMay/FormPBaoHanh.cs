using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class FormPBaoHanh : Form
    {
        public FormPBaoHanh()
        {
            InitializeComponent();
        }

        private void FormPBaoHanh_Load(object sender, EventArgs e)
        {
            string ma = FormHoaDon.thongtinHD.ma;
            // TODO: This line of code loads data into the 'DataSetPhieuHoaDon.selectCTHD' table. You can move, or remove it, as needed.
            this.selectCTHDTableAdapter.Fill(this.DataSetPhieuHoaDon.selectCTHD, ma);
            // TODO: This line of code loads data into the 'DataSetPhieuHoaDon.ctKhachHang' table. You can move, or remove it, as needed.
            this.ctKhachHangTableAdapter.Fill(this.DataSetPhieuHoaDon.ctKhachHang, ma);
            // TODO: This line of code loads data into the 'DataSetPhieuHoaDon.selectHoaDon' table. You can move, or remove it, as needed.
            this.selectHoaDonTableAdapter.Fill(this.DataSetPhieuHoaDon.selectHoaDon, ma);

            this.reportViewer1.RefreshReport();
          
        }
    }
}
