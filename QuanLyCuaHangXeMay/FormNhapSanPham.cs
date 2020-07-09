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
            var ma = from u in dt.PNHAPs
                     select u;
            var str = ma.OrderByDescending(s => s.MAPN).FirstOrDefault();
            int a = Convert.ToInt32(str.MAPN.ToString().Substring(2)) + 1;
            lbMaHD.Text = "PN" + a;
            //lbMaHD.Text = a;

            //int i = 0;
            //List<int> demso = new List<int>();
            //foreach (var r in dt.PNHAPs)
            //{
            //    demso.Add(Convert.ToInt32(r.MAPN.Remove(0, 2)));
            //    i++;
            //}
            //var a = dt.PNHAPs.FirstOrDefault();
            //if (a == null)
            //{
            //    lbMaHD.Text = "PN01";
            //}
            //else
            //{
            //    int max = demso[0];
            //    for (int j = 1; j < i; j++)
            //    {
            //        if (max < demso[j])
            //        {
            //            max = demso[j];
            //        }
            //    }
            //    if (max < 9)
            //    {
            //        max = max + 1;
            //        lbMaHD.Text = "PN0" + max;
            //    }
            //    else if (max > 9)
            //    {
            //        max = max + 1;
            //        lbMaHD.Text = "PN" + max;
            //    }
            //}
            hehe = 1;
            haha = 1;
            cbxXe.DisplayMember = "TENSP";
            cbxXe.ValueMember = "MASP";
            cbxXe.DataSource = dt.SANPHAMs.ToList();

            cbxPT.DisplayMember = "TENPT";
            cbxPT.ValueMember = "MAPT";
            cbxPT.DataSource = dt.PHUTUNGs.ToList();

            cbxNCC.DisplayMember = "TENNHACUNGCAP";
            cbxNCC.ValueMember = "MANHACUNGCAP";
            cbxNCC.DataSource = dt.NHACUNGCAPs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var HDN = dt.selectPN(lbMaHD.Text).FirstOrDefault();
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
                    dt.INSERT_PNHAP(lbMaHD.Text, Convert.ToString(cbxNCC.SelectedValue), "NV01", Convert.ToDateTime(DateTime.Now), 0);
                    //insert CTPNXE + update slt
                    dt.INSERT_CTPNHAPXE(lbMaHD.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text), Convert.ToDouble(txtDGXe.Text));
                    double tongtien = 0;
                    foreach (var a in dt.selectCTPNxe(lbMaHD.Text) )
                    {
                        tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble( a.SLNHAP);
                    }    
                    dt.UPDATE_TIENNHAPXE(lbMaHD.Text, tongtien);
                    MessageBox.Show("Thêm thành công", "Thêm");
                }
                else if (HDN != null)
                {
                    var CTPNX = dt.selectCTPN(lbMaHD.Text, cbxXe.SelectedValue.ToString()).FirstOrDefault();
                    if (CTPNX == null)
                    {
                        dt.INSERT_CTPNHAPXE(lbMaHD.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text) + CTPNX.SLNHAP, Convert.ToDouble(txtDGXe.Text));
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNxe(lbMaHD.Text))
                        {
                            tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble(a.SLNHAP);
                        }
                        dt.UPDATE_TIENNHAPXE(lbMaHD.Text, tongtien);
                    }
                    else if (CTPNX != null)
                    {
                        dt.updateSTCTPNX(lbMaHD.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text) + CTPNX.SLNHAP);
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNxe(lbMaHD.Text) )
                        {
                            tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble( a.SLNHAP);
                        }    
                        dt.UPDATE_TIENNHAPXE(lbMaHD.Text, tongtien);
                    }
                }
                dgvXe.DataSource = dt.selectCTPNxe(lbMaHD.Text);
                txtDGXe.Enabled = false; 
                txtSLXe.ResetText();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //var pn = dt.PNHAPs.Where(s => s.MAPN == lbMaHD.Text).FirstOrDefault();
            //var ctxe = dt.SANPHAMs.Where(s=>s.MASP == cbxXe.SelectedValue.ToString()).FirstOrDefault();
            //var ctpt = dt.PHUTUNGs.Where(s => s.MAPT == cbxPT.SelectedValue.ToString()).FirstOrDefault();

            //if (Convert.ToInt64(txtDGXe.Text) == 0)
            //{
            //    MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi");
            //}
            //else if (Convert.ToInt32(txtSLXe.Text) == 0)
            //{
            //    MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi");
            //}
            //////////////////////////////////////////////////////////////
            //if (Convert.ToInt64(txtDGPT.Text) == 0)
            //{
            //    MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi");
            //}
            //else if (Convert.ToInt32(txtSLPT.Text) == 0)
            //{
            //    MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi");
            //}
            //if(pn == null)
            //{
            //    dt.INSERT_PNHAP(lbMaHD.Text, cbxNCC.SelectedValue.ToString(), DangNhap.TTNV.MaNV,
            //                 Convert.ToDateTime(DateTime.Now), 0);
            //    dt.INSERT_CTPNHAPXE(lbMaHD.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text),
            //                   Convert.ToInt64(txtDGXe.Text));
            //    dt.INSERT_CTPNHAPPT(lbMaHD.Text, cbxXe.SelectedValue.ToString(), Convert.ToInt32(txtSLXe.Text),
            //                   Convert.ToInt64(txtDGXe.Text));
                //if(dgvXe.Rows.Count == 1 && dgvPT.Rows.Count ==1)
                //{
                //    MessageBox.Show 
                //}
            
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
                var CTPNX = dt.selectCTPN(lbMaHD.Text, cbxXe.SelectedValue.ToString()).FirstOrDefault();
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

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            var HDN = dt.selectPN(lbMaHD.Text).FirstOrDefault();
            if (txtDGPT.Text.Trim() == "" || txtSLPT.Text.Trim() == "" || txtDGPT.Text == null || txtSLPT.Text == null)
            {
                MessageBox.Show("Chưa nhập đủ", "Thông Báo");
            }
            else if (Convert.ToInt32(txtSLPT.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi");
            }
            else if (Convert.ToInt64(txtDGPT.Text) == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi");
            }
            else
            {
                if (HDN == null)
                {
                    dt.INSERT_PNHAP(lbMaHD.Text, Convert.ToString(cbxNCC.SelectedValue), "NV01", Convert.ToDateTime(DateTime.Now), 0);
                    //insert CTPN + update slt
                    dt.INSERT_CTPNHAPPT(lbMaHD.Text, cbxPT.SelectedValue.ToString(), Convert.ToInt32(txtSLPT.Text), Convert.ToDouble(txtDGPT.Text));
                    double tongtien = 0;
                    foreach (var a in dt.selectCTPNPT(lbMaHD.Text))
                    {
                        tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble(a.SLNHAP);
                    }
                    dt.UPDATE_TIENNHAPPT(lbMaHD.Text, tongtien);
                    MessageBox.Show("Thêm thành công", "Thêm");
                }
                else if (HDN != null)
                {
                    var CTPNPT = dt.selectCTPTung(lbMaHD.Text, cbxPT.SelectedValue.ToString()).FirstOrDefault();
                    if (CTPNPT == null)
                    {
                        dt.INSERT_CTPNHAPPT(lbMaHD.Text, cbxPT.SelectedValue.ToString(), Convert.ToInt32(txtSLPT.Text) + CTPNPT.SLNHAP, Convert.ToDouble(txtDGPT.Text));
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNPT(lbMaHD.Text))
                        {
                            tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble(a.SLNHAP);
                        }
                        dt.UPDATE_TIENNHAPPT(lbMaHD.Text, tongtien);
                    }
                    else if (CTPNPT != null)
                    {
                        dt.updateSLCTPPT(lbMaHD.Text, cbxPT.SelectedValue.ToString(), Convert.ToInt32(txtSLPT.Text) + CTPNPT.SLNHAP);
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNPT(lbMaHD.Text))
                        {
                            tongtien = tongtien + Convert.ToDouble(a.DONGIANHAP) * Convert.ToDouble(a.SLNHAP);
                        }
                        dt.UPDATE_TIENNHAPPT(lbMaHD.Text, tongtien);
                    }
                }
                dgvPT.DataSource = dt.selectCTPNPT(lbMaHD.Text);

                txtDGPT.Enabled = false;
                txtSLPT.ResetText();
            }
        }

        private void cbxPT_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var pt = dt.PHUTUNGs.FirstOrDefault();
                if (haha == 1)
                {
                    cbxPT.DisplayMember = "TENPT";
                    cbxPT.ValueMember = "MAPT";
                    cbxPT.DataSource = dt.PHUTUNGs.ToList();
                    cbxPT.SelectedValue = pt.MAPT;
                    haha++;
                }
                var CTPNX = dt.selectCTPN(lbMaHD.Text, cbxPT.SelectedValue.ToString()).FirstOrDefault();
                if (CTPNX == null)
                {
                    if (haha == 2)
                    {
                        txtDGPT.ResetText();
                    }

                    txtDGPT.Enabled = true;
                }
                else if (CTPNX != null)
                {
                    txtDGPT.Text = CTPNX.DONGIANHAP.ToString();
                    txtDGPT.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvPT_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvPT.Rows.Count - 1; i++)
            {
                dgvPT.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
