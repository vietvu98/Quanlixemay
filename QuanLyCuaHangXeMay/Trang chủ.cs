using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public static Form1 Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new Form1();
                }
                return obj;
            }
        }

        public Panel panelTruyen
        {
            get
            {
                return panel2;
            }
            set { panel2 = value; }
        }
        static Form1 obj;
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        
        private void toolStripLinhKien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormNhapSanPham sp = new FormNhapSanPham();
            sp.TopLevel = false;
            panel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();
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

            if(nv.MACV == "CV01")
            {
                bt_ThongTinNguoiDung.Visible = true;
                toolStripKhachHang.Visible = true;
                toolStripSanPham.Visible = true;
                toolStripPhuTung.Visible = true;
                toolStripDoiTac.Visible = true;
                btnHoaDon.Visible = true;
                btnThongKe.Visible = true;

            }
            else if (nv.MACV == "CV02")
            {
                bt_ThongTinNguoiDung.Visible = false;
                toolStripKhachHang.Visible = true;
                toolStripSanPham.Visible = true;
                toolStripPhuTung.Visible = true;
                toolStripDoiTac.Visible = true;
                btnHoaDon.Visible = true;
                btnThongKe.Visible = false;

            }
            else if (nv.MACV == "CV03")
            {
                bt_ThongTinNguoiDung.Visible = false;
                toolStripKhachHang.Visible = true;
                toolStripSanPham.Visible = true;
                toolStripPhuTung.Visible = false;
                toolStripDoiTac.Visible = true;
                btnHoaDon.Visible = true;
                btnThongKe.Visible = true;

            }
            obj = this;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //FormHoaDon hd = new FormHoaDon();
            //hd.TopLevel = false;
            //panel2.Controls.Add(hd);
            //hd.Dock = DockStyle.Fill;
            //hd.Show();
        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormHoaDon hd = new FormHoaDon();
            hd.TopLevel = false;
            panel2.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            hd.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormThongKe hd = new FormThongKe();
            hd.TopLevel = false;
            panel2.Controls.Add(hd);
            hd.Dock = DockStyle.Fill;
            hd.Show();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Visible = false;
            Transition1.MaxAnimationTime = 2500;
            Transition1.TimeStep = 0.1f;
            Transition1.HideSync(panel2);
            panel2.Controls.Clear();
            ControlDangNhap1 hd = new ControlDangNhap1();



            Transition1.AnimationType = Guna.UI.Animation.AnimationType.VertSlide;
            Transition1.TimeStep = 0.01f;
            panel2.Controls.Add(hd);
            Transition1.ShowSync(panel2);
            
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {

            Process.Start("http://www.facebook.com/");
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            FormBackUp b = new FormBackUp();
            b.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
