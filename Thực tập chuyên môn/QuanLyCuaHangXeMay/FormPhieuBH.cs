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
    public partial class FormPhieuBH : Form
    {
        public FormPhieuBH()
        {
            InitializeComponent();
        }

        private void FormPhieuBH_Load(object sender, EventArgs e)
        {
            string ma = FormHoaDon.thongtinHD.ma;
            // TODO: This line of code loads data into the 'dataSetPhieuHoaDon.selectCTHD' table. You can move, or remove it, as needed.
            this.selectCTHDTableAdapter.Fill(this.dataSetPhieuHoaDon.selectCTHD, ma);
            // TODO: This line of code loads data into the 'dataSetPhieuHoaDon.ctKhachHang' table. You can move, or remove it, as needed.
            this.ctKhachHangTableAdapter.Fill(this.dataSetPhieuHoaDon.ctKhachHang, ma);
            // TODO: This line of code loads data into the 'dataSetPhieuHoaDon.selectHoaDon' table. You can move, or remove it, as needed.
            this.selectHoaDonTableAdapter.Fill(this.dataSetPhieuHoaDon.selectHoaDon, ma);

            this.reportViewer1.RefreshReport();
        }
    }
}
