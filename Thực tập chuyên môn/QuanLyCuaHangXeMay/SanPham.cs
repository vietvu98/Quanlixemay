using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
            if (a.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = new Bitmap(a.FileName);
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //private void btnXemHinh_Click(object sender, EventArgs e)
        //{
        //    if (pnlHinhAnh.Left == 989)
        //    {
        //        dgvTTSanPham.Visible = false;
        //        panel1.Left = 989;
        //        dgvTTSanPham.Left = 989;

        //        pnlHinhAnh.Visible = false;
        //        pnlHinhAnh.Left = 0;
        //        pnlHinhAnh.Visible = true;
        //        pnlHinhAnh.Refresh();
        //    }
        //}

        //private void btnQuayLai_Click(object sender, EventArgs e)
        //{
        //    if (dgvTTSanPham.Left == 989 && panel1.Left == 989)
        //    {
        //        pnlHinhAnh.Visible = false;
        //        pnlHinhAnh.Left = 989;

        //        dgvTTSanPham.Visible = false;
        //        panel1.Left = 0;
        //        dgvTTSanPham.Left = 0;
        //        dgvTTSanPham.Visible = true;
        //        dgvTTSanPham.Refresh();
        //    }
        //}

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOAISP_SPDataSet.LOAISP' table. You can move, or remove it, as needed.
            this.lOAISPTableAdapter.Fill(this.lOAISP_SPDataSet.LOAISP);
            //màu dòng chẵn
            dgvTTSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvTTSanPham.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //Mau o khi click
            dgvTTSanPham.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //color chữ khi click
            dgvTTSanPham.DefaultCellStyle.SelectionForeColor = Color.Red;
            //back groud
            dgvTTSanPham.BackgroundColor = Color.White;
            dgvTTSanPham.EnableHeadersVisualStyles = false;
            dgvTTSanPham.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Mau title
            dgvTTSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
            //mau chu title
            dgvTTSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgvTTSanPham.Columns["GIABAN"].DefaultCellStyle.Format = "VND";
            dgvTTSanPham.AutoGenerateColumns = false;
            dgvTTSanPham.DataSource = dt.SELECTALL_VND();
            cbxLoai.DisplayMember = "TENLOAI";
            cbxLoai.ValueMember = "MALOAI";
            cbxLoai.DataSource = dt.LOAISPs.ToList();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
            if (a.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = new Bitmap(a.FileName);
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dgvTTSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTTSanPham.CurrentRow.Index;
            txtMaSP.Text = dgvTTSanPham.Rows[i].Cells[0].Value.ToString();
            var sph = dt.SANPHAMs.Where(s => s.MASP == txtMaSP.Text).FirstOrDefault();
        //    var loaisp = dt.LOAISPs.Where(s=>s.MALOAI == sph.L)
            txtTenSP.Text = sph.TENSP;
            cbxLoai.SelectedValue = dgvTTSanPham.Rows[i].Cells[2].Value;
            txtDungTich.Text = sph.DUNGTICHXL;
            txtKichThuoc.Text = sph.KICHTHUOC;
            txtKhoiLuong.Text = sph.KHOILUONG.ToString();
            txtCongSuat.Text = sph.CONGSUATTD;
            txtHangXe.Text = sph.HANGXE;
            txtSoLuong.Text = sph.SOLUONG.ToString();
            txtGia.Text = sph.GIABAN.ToString();
            SANPHAM sp = dt.SANPHAMs.Where(s => s.MASP == txtMaSP.Text).FirstOrDefault();
            if (sp == null || sp.HINHANH == null)
            {
                ptbAnh.Image = null;
            }
            else
            {
                MemoryStream stream = new MemoryStream(sp.HINHANH.ToArray());
                Image image = Image.FromStream(stream);
                if (image == null)
                {
                    return;
                }
                else
                {
                    ptbAnh.Image = image;
                }
            }
            
        }
        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cbxLoai.SelectedItem = null;
            txtDungTich.Text = "";
            txtKichThuoc.Text = "";
            txtKhoiLuong.Text = "";
            txtCongSuat.Text = "";
            txtHangXe.Text = "";
            txtSoLuong.Text = "0";
            txtGia.Text = "";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            ptbAnh.Image = null;
            btnLuu.Enabled = true;
            btnChonAnh.Enabled = true;
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = true;
            cbxLoai.Enabled = true;
            txtDungTich.Enabled = true;
            txtKichThuoc.Enabled = true;
            txtKhoiLuong.Enabled = true;
            txtCongSuat.Enabled = true;
            txtHangXe.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGia.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
           
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnChonAnh.Enabled = true;
            a = 2;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var r = dt.SELECTALL_VND().Where(s => s.MASP == txtMaSP.Text.Trim()).FirstOrDefault();
            if (a == 1 && r == null)
            {
                if(ptbAnh.Image == null)
                {
                    dt.SP_INSERT(txtMaSP.Text, txtTenSP.Text, cbxLoai.SelectedValue.ToString(), txtDungTich.Text, txtKichThuoc.Text, Convert.ToInt32(txtKhoiLuong.Text)
                       , txtCongSuat.Text, txtHangXe.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGia.Text), null);

                }
                else if(ptbAnh.Image != null)
                {
                    MemoryStream stream = new MemoryStream();
                    ptbAnh.Image.Save(stream, ImageFormat.Jpeg);
                    dt.SP_INSERT(txtMaSP.Text, txtTenSP.Text, cbxLoai.SelectedValue.ToString(), txtDungTich.Text, txtKichThuoc.Text, Convert.ToInt32(txtKhoiLuong.Text)
                        , txtCongSuat.Text, txtHangXe.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGia.Text), stream.ToArray());
                }
                dgvTTSanPham.AutoGenerateColumns = false;
                dgvTTSanPham.DataSource = dt.SELECTALL_VND();
                a = 0;

            }
            else if (a == 1 && r != null)
            {
                DialogResult dtr = MessageBox.Show("Da co du lieu roi!", "Thong Bao", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    txtMaSP.Text = "";
                    txtTenSP.Text = "";
                    cbxLoai.SelectedItem = null;
                    txtDungTich.Text = "";
                    txtKichThuoc.Text = "";
                    txtKhoiLuong.Text = "";
                    txtCongSuat.Text = "";
                    txtHangXe.Text = "";
                    txtSoLuong.Text = "";
                    txtGia.Text = "";
                }

            }
            else if (a == 2 && r != null)
            {
                if(ptbAnh.Image == null)
                {
                    dt.SP_UPDATE(txtMaSP.Text, txtTenSP.Text, cbxLoai.SelectedValue.ToString(), txtDungTich.Text, txtKichThuoc.Text, Convert.ToInt32(txtKhoiLuong.Text)
                   , txtCongSuat.Text, txtHangXe.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt64(txtGia.Text), null);
                }
                else if (ptbAnh.Image != null)
                {
                    MemoryStream stream = new MemoryStream();
                    ptbAnh.Image.Save(stream, ImageFormat.Jpeg);
                    dt.SP_UPDATE(txtMaSP.Text, txtTenSP.Text, cbxLoai.SelectedValue.ToString(), txtDungTich.Text, txtKichThuoc.Text, Convert.ToInt32(txtKhoiLuong.Text)
                       , txtCongSuat.Text, txtHangXe.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt64(txtGia.Text), stream.ToArray());
                }
                
                dgvTTSanPham.AutoGenerateColumns = false;
                dgvTTSanPham.DataSource = dt.SELECTALL_VND();
                a = 0;
                SanPham_Load(sender, e);
            }
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cbxLoai.SelectedItem = null;
            txtDungTich.Text = "";
            txtKichThuoc.Text = "";
            txtKhoiLuong.Text = "";
            txtCongSuat.Text = "";
            txtHangXe.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

           

        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    DialogResult dtr = MessageBox.Show("Ban co muon xoa khong!", "Thong bao", MessageBoxButtons.YesNo);
        //    if (dtr == DialogResult.Yes)
        //    {
        //        if (txtMaSP.Text == "")
        //        {
        //            MessageBox.Show("Ban chua chon thong tin de xoa!");
        //        }
        //        else
        //        {
        //            dt.SP_DELETE(txtMaSP.Text);
        //            dgvTTSanPham.AutoGenerateColumns = false;
        //            dgvTTSanPham.DataSource = dt.SELECTALL_VND();
        //        }
        //        btnThem.Enabled = true;
        //        btnSua.Enabled = true;
                
        //        btnLuu.Enabled = false;
        //        btnHuy.Enabled = false;
        //    }
        //}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvTTSanPham.AutoGenerateColumns = false;
            dgvTTSanPham.DataSource = dt.SP_SEARCH(txtSearch.Text);
        }

        private void btnXeSo_Click(object sender, EventArgs e)
        {
            dgvTTSanPham.DataSource = dt.LOAIXE("L01");
        }

        private void btnXeTayGa_Click(object sender, EventArgs e)
        {
            dgvTTSanPham.DataSource = dt.LOAIXE("L02");
        }

        private void btnXeMoTo_Click(object sender, EventArgs e)
        {
            dgvTTSanPham.DataSource = dt.LOAIXE("L03");
        }

        //private void gunaCircleButton1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog a = new OpenFileDialog();
        //    a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
        //    if (a.ShowDialog() == DialogResult.OK)
        //    {
        //        pbAnh1.Image = new Bitmap(a.FileName);
        //        pbAnh1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    if(pbAnh1 != null)
        //    {
        //        gunaCircleButton1.Visible = false;
        //    }
        //    else
        //    {
        //        gunaCircleButton1.Visible = true;
        //    }
        //}

        //private void gunaCircleButton3_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog a = new OpenFileDialog();
        //    a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
        //    if (a.ShowDialog() == DialogResult.OK)
        //    {
        //        pbAnh3.Image = new Bitmap(a.FileName);
        //        pbAnh3.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    if (pbAnh3 != null)
        //    {
        //        gunaCircleButton3.Visible = false;
        //    }
        //    else
        //    {
        //        gunaCircleButton3.Visible = true;
        //    }
        //}

        //private void gunaCircleButton2_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog a = new OpenFileDialog();
        //    a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
        //    if (a.ShowDialog() == DialogResult.OK)
        //    {
        //        pbAnh2.Image = new Bitmap(a.FileName);
        //        pbAnh2.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    if (pbAnh2 != null)
        //    {
        //        gunaCircleButton2.Visible = false;
        //    }
        //    else
        //    {
        //        gunaCircleButton2.Visible = true;
        //    }
        //}

        //private void gunaCircleButton4_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog a = new OpenFileDialog();
        //    a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
        //    if (a.ShowDialog() == DialogResult.OK)
        //    {
        //        pbAnh4.Image = new Bitmap(a.FileName);
        //        pbAnh4.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    if (pbAnh4 != null)
        //    {
        //        gunaCircleButton4.Visible = false;
        //    }
        //    else
        //    {
        //        gunaCircleButton4.Visible = true;
        //    }
        //}

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            //MemoryStream x = new MemoryStream();
            //pbAnh1.Image.Save(x, ImageFormat.Jpeg);
            //MemoryStream y = new MemoryStream();
            //pbAnh2.Image.Save(y, ImageFormat.Jpeg);
            //MemoryStream z = new MemoryStream();
            //pbAnh3.Image.Save(z, ImageFormat.Jpeg);
            //MemoryStream t = new MemoryStream();
            //pbAnh4.Image.Save(t, ImageFormat.Jpeg);

            //dt.INSERT_HINHANH(txtMaSP.Text, x.ToArray(), y.ToArray(), z.ToArray(), t.ToArray());

        }

        private void lb_TenSP_Click(object sender, EventArgs e)
        {

        }

        private void dgvTTSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "" || txtSearch.Text.Trim() != null)
            {
                dgvTTSanPham.AutoGenerateColumns = false;
                dgvTTSanPham.DataSource = dt.SP_SEARCH(txtSearch.Text);
            }
            else if (txtSearch.Text.Trim() == "" || txtSearch.Text.Trim() == null)
            {


                dgvTTSanPham.AutoGenerateColumns = false;
                dgvTTSanPham.DataSource = dt.SELECTALL_VND();
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Lỗi rồi", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Lỗi rồi", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtKhoiLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKhoiLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Lỗi rồi", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
