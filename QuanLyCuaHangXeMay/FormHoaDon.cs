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
    public partial class FormHoaDon : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        public  class thongtinHD
        {
            public static string ma;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            
            
            int i = 0;
            List<int> demso = new List<int>();
            foreach (var r in dt.HOADONs)
            {
                demso.Add(Convert.ToInt32(r.MAHD.Remove(0, 2)));
                i++;
            }
            var a = dt.HOADONs.FirstOrDefault();
            if (a == null)
            {
                lbMaHD.Text = "HD01";
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
                    lbMaHD.Text = "HD0" + max;
                }
                else if (max > 9)
                {
                    max = max + 1;
                    lbMaHD.Text = "HD" + max;
                }
            }
            
            cbbTenSP.DisplayMember = "TENSP";
            cbbTenSP.ValueMember = "MASP";
            cbbTenSP.DataSource = dt.SANPHAMs.ToList();
           
            
            cbbMaKH.DisplayMember = "TENKH";
            cbbMaKH.ValueMember = "MAKH";
            cbbMaKH.DataSource = dt.KHACHHANGs.ToList();

            dgvHD.AutoGenerateColumns = false;


        }

        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SANPHAM sp = dt.SANPHAMs.Where(s => s.MASP == cbbTenSP.SelectedValue.ToString()).FirstOrDefault();
            lbDongia.Text = sp.GIABAN.ToString();
        }

        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            KHACHHANG kh = dt.KHACHHANGs.Where(s => s.MAKH == cbbMaKH.SelectedValue.ToString()).FirstOrDefault();
            lbMaKH.Text = kh.MAKH.ToString();
            lbDiaChi.Text = kh.DIACHI.ToString();
            lbSDT.Text = kh.DIENTHOAI.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var HDX = dt.selectHoaDon(lbMaHD.Text).FirstOrDefault();
            if(txtSL.Text.Trim() == "" || txtSL.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo");
            }
            else if(Convert.ToInt32(txtSL.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }
            else
            {
                if (HDX == null)
                {
                    dt.Insert_HoaDon(lbMaHD.Text, Convert.ToString(cbbMaKH.SelectedValue), "NV01",
                        Convert.ToDateTime(DateTime.Now), Convert.ToInt32(numericChietKhau.Value), 0, Convert.ToBoolean("true"));
                    dt.INSERT_CTHD(lbMaHD.Text, cbbTenSP.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text),
                                        (Convert.ToDouble(txtSL.Text) * Convert.ToDouble(lbDongia.Text)));
                    double thanhtien = 0;
                    foreach (var a in dt.selectCTHD(lbMaHD.Text))
                    {
                        thanhtien = thanhtien + Convert.ToDouble(a.GIABAN) * Convert.ToDouble(a.SL);
                    }
                    dt.UPDATE_ThanhTien(lbMaHD.Text, thanhtien);
                    MessageBox.Show("Thêm thành công", "Thêm");
                    numericChietKhau.Enabled = false;
                }
                else if (HDX != null)
                {
                    var CTX = dt.selectAll_CTHD(lbMaHD.Text, cbbTenSP.SelectedValue.ToString()).FirstOrDefault();
                    if(CTX == null)
                    {
                        dt.INSERT_CTHD(lbMaHD.Text, cbbTenSP.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text),
                                        (Convert.ToDouble(txtSL.Text) * Convert.ToDouble(lbDongia.Text)));
                        double thanhtien = 0;
                        foreach (var a in dt.selectCTHD(lbMaHD.Text))
                        {
                            thanhtien = thanhtien + Convert.ToDouble(a.GIABAN) * Convert.ToDouble(a.SL);
                        }
                        dt.UPDATE_ThanhTien(lbMaHD.Text, thanhtien);
                        MessageBox.Show("Thêm thành công", "Thêm");
                    }
                    else if(CTX != null)
                    {
                        dt.updateSL_CTHD(lbMaHD.Text, cbbTenSP.SelectedValue.ToString(), Convert.ToInt32(txtSL.Text) + CTX.SL,
                           CTX.THANHTIEN + (Convert.ToDouble(txtSL.Text) * Convert.ToDouble(lbDongia.Text)));
                        double thanhtien = 0;
                        foreach (var a in dt.selectCTHD(lbMaHD.Text))
                        {
                            thanhtien = thanhtien + Convert.ToDouble(a.GIABAN) * Convert.ToDouble(a.SL);
                        }
                        dt.UPDATE_ThanhTien(lbMaHD.Text, thanhtien);
                        MessageBox.Show("Thêm thành công", "Thêm");
                    }
                }


            }
            dgvHD.DataSource = dt.selectCTHD(lbMaHD.Text);
            txtSL.ResetText();
            double TongTienHD = 0;
            double TongTienDiscount = 0;
            foreach (var a in dt.selectCTHD(lbMaHD.Text))
            {
                TongTienHD = TongTienHD + Convert.ToDouble(a.GIABAN) * Convert.ToDouble(a.SL);
                
            }
            TongTienDiscount = TongTienHD - ((Convert.ToDouble(numericChietKhau.Value) * TongTienHD) * 0.01);
            dt.UPDATE_TONGTIEN(lbMaHD.Text,TongTienDiscount);
            lbTongTien.Text = TongTienDiscount.ToString("N0");

           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            thongtinHD.ma = lbMaHD.Text;          
            FromPhieuHoaDon hd = new FromPhieuHoaDon();
            hd.Show();
        }
    }
}
