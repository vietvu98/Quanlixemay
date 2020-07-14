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
    public partial class FormNhapSanPham : Form
    {
        public FormNhapSanPham()
        {
            InitializeComponent();
        }
        int hehe = 0;
        int haha = 0;
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        private void FormNhapSanPham_Load(object sender, EventArgs e)
        {
            //var ma = from u in dt.PNHAPs
            //         select u;
            //var str = ma.OrderByDescending(s => s.MAPN).FirstOrDefault();
            //int a = Convert.ToInt32(str.MAPN.ToString().Substring(2)) + 1;

            //lbMaPN.Text = "PN" + a;
            //lbMaHD.Text = a;

            int i = 0;
            List<int> demso = new List<int>();
            foreach (var r in dt.PNHAPs)
            {
                demso.Add(Convert.ToInt32(r.MAPN.Remove(0, 2)));
                i++;
            }
            var a = dt.PNHAPs.FirstOrDefault();
            if (a == null)
            {
                lbMaPN.Text = "PN01";
            }
            else
            {
                int max = demso[0];
                for (int j = 1; j < i; j++)
                {
                    if (max < demso[j])
                    {
                        max = demso[j];
                    }
                }
                if (max < 9)
                {
                    max = max + 1;
                    lbMaPN.Text = "PN0" + max;
                }
                else if (max > 9)
                {
                    max = max + 1;
                    lbMaPN.Text = "PN" + max;
                }
            }
            hehe = 1;
            haha = 1;
            cbxXe.DisplayMember = "TENSP";
            cbxXe.ValueMember = "MASP";
            cbxXe.DataSource = dt.SANPHAMs.ToList();

            cbxNCC.DisplayMember = "TENNHACUNGCAP";
            cbxNCC.ValueMember = "MANHACUNGCAP";
            cbxNCC.DataSource = dt.NHACUNGCAPs;

            dgvXe.AutoGenerateColumns = false;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var HDN = dt.selectPN(lbMaPN.Text).FirstOrDefault();
            if (txtDGXe.Text.Trim() == ""|| txtSLXe.Text.Trim() == "" || txtDGXe.Text == null || txtSLXe.Text == null)
            {
                MessageBox.Show("Chưa nhập đủ","Thông Báo");
            }
            else if (Convert.ToInt32(txtSLXe.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi");
            }
            else if (Convert.ToInt64(txtDGXe.Text) == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi");
            }
           
            else
            {
                if (HDN == null)
                {
                    dt.INSERT_PNHAP(lbMaPN.Text, Convert.ToString(cbxNCC.SelectedValue), DangNhap.TTNV.MaNV, Convert.ToDateTime(DateTime.Now), 0);
                    //insert CTPNXE + update slt
                    dt.INSERT_CTPNHAPXE(lbMaPN.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text), Convert.ToDouble(txtDGXe.Text),
                                        (Convert.ToDouble(txtDGXe.Text) * Convert.ToDouble(txtSLXe.Text)));
                    double tongtien = 0;
                    foreach (var a in dt.selectCTPNxe(lbMaPN.Text) )
                    {
                        tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble( a.SLNHAP);
                    }    
                    dt.UPDATE_TIENNHAPXE(lbMaPN.Text, tongtien);
                    MessageBox.Show("Thêm thành công", "Thêm");
                }
                else if (HDN != null)
                {
                    var CTPNX = dt.selectCTPN(lbMaPN.Text, cbxXe.SelectedValue.ToString()).FirstOrDefault();
                    if (CTPNX == null)
                    {
                        dt.INSERT_CTPNHAPXE(lbMaPN.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text) , Convert.ToDouble(txtDGXe.Text),
                            (Convert.ToDouble(txtDGXe.Text) * Convert.ToDouble(txtSLXe.Text)));
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNxe(lbMaPN.Text))
                        {
                            tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble(a.SLNHAP);
                        }
                        dt.UPDATE_TIENNHAPXE(lbMaPN.Text, tongtien);
                    }
                    else if (CTPNX != null)
                    {

                        dt.updateSLTCTPNX(lbMaPN.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text) + CTPNX.SLNHAP, 
                            CTPNX.THANHTIEN + (Convert.ToDouble(txtSLXe.Text) * Convert.ToDouble(txtDGXe.Text) ));
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNxe(lbMaPN.Text) )
                        {
                            tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble( a.SLNHAP);
                        }    
                        dt.UPDATE_TIENNHAPXE(lbMaPN.Text, tongtien);
                    }
                }
                
                dgvXe.DataSource = dt.selectCTPNxe(lbMaPN.Text);
                txtDGXe.Enabled = false; 
                txtSLXe.ResetText();
                double TongTienHD = 0;
                foreach (var a in dt.selectCTPNxe(lbMaPN.Text))
                {
                    TongTienHD = TongTienHD + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble(a.SLNHAP);
                }
                lbTongTien.Text = TongTienHD.ToString("N0");
            }
        }

        

        private void dgvXe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i=0; i < dgvXe.Rows.Count - 1; i++)
            {
                dgvXe.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void txtDGXe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbxXe_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                var sp = dt.SANPHAMs.FirstOrDefault();
                if (hehe == 1)
                {
                    cbxXe.DisplayMember = "TENSP";
                    cbxXe.ValueMember = "MASP";
                    cbxXe.DataSource = dt.SANPHAMs.ToList();
                    cbxXe.SelectedValue = sp.MASP;
                    hehe++;
                }
                var CTPNX = dt.selectCTPN(lbMaPN.Text, cbxXe.SelectedValue.ToString()).FirstOrDefault();
                if (CTPNX == null)
                {
                    if (hehe ==2)
                    {
                        txtDGXe.ResetText();
                    }    
                    
                    txtDGXe.Enabled = true;
                }
                else if (CTPNX != null)
                {
                    txtDGXe.Text = CTPNX.DONGIANHAP.ToString();
                    txtDGXe.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSLXe_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txtSLXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvXe.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult a = MessageBox.Show(" Ban co muon xoa khong?","Xoa", MessageBoxButtons.YesNo);
                if(a == DialogResult.Yes)
                {
                    var SP = dt.SANPHAMs.Where(s => s.MASP == cbxXe.SelectedValue.ToString()).FirstOrDefault();
                    var CTPN = dt.CTPNHAPs.Where(s => s.MAPN == lbMaPN.Text).Where(s => s.MASP == cbxXe.SelectedValue.ToString()).FirstOrDefault();
                    dt.delete_PhieuNhap(lbMaPN.Text, cbxXe.SelectedValue.ToString());
                    dt.updateSLT(cbxXe.SelectedValue.ToString(), SP.SOLUONG - CTPN.SLNHAP);
                    dgvXe.DataSource = dt.selectCTPNxe(lbMaPN.Text);
                }
            }
        }
    }
}
