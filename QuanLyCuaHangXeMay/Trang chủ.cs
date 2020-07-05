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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        private void toolStripLinhKien_Click(object sender, EventArgs e)
        {

        }

  

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }
        string user, pass;
        public string nhanuser
        {
            get { return user; }
            set { user = value; }
        }

        public string nhanpass
        {
            get { return pass; }
            set { pass = value; }
        }
        
        private void bt_ThongTinNguoiDung_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripKhachHang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            KhachHang kh = new KhachHang();
            kh.TopLevel = false;
            panel2.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
            kh.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dx = new DangNhap();
            this.Hide();
            dx.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripDoiTac_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DoiTac dt = new DoiTac();
            dt.TopLevel = false;
            panel2.Controls.Add(dt);
            dt.Dock = DockStyle.Fill;
            dt.Show();
            
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            KhuyenMai km = new KhuyenMai();
            km.TopLevel = false;
            panel2.Controls.Add(km);
            km.Dock = DockStyle.Fill;
            km.Show();
        }

        public void toolStripSanPham_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            SanPham sp = new SanPham();
            sp.TopLevel = false;
            panel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void toolStripBaoHanh_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_TIME.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void label_TIME_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            NHANVIEN nv = dt.NHANVIENs.Where(s => s.MANHANVIEN == DangNhap.TTNV.MaNV.ToString()).FirstOrDefault();
            label1.Text = "Xin Chào, " + nv.TENNHANVIEN;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
