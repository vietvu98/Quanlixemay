namespace QuanLyCuaHangXeMay
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TIME = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.status_NguoiDung = new System.Windows.Forms.StatusStrip();
            this.User_NguoiDung = new System.Windows.Forms.ToolStripDropDownButton();
            this.bt_ThongTinNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label_NguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripKhachHang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSanPham = new System.Windows.Forms.ToolStripButton();
            this.toolStripPhuTung = new System.Windows.Forms.ToolStripButton();
            this.toolStripBaoHanh = new System.Windows.Forms.ToolStripButton();
            this.toolStripDoiTac = new System.Windows.Forms.ToolStripButton();
            this.btnHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnKhuyenMai = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.status_NguoiDung.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_TIME);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.status_NguoiDung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(761, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 18;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_TIME
            // 
            this.label_TIME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TIME.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TIME.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_TIME.Location = new System.Drawing.Point(402, 9);
            this.label_TIME.Name = "label_TIME";
            this.label_TIME.Size = new System.Drawing.Size(229, 38);
            this.label_TIME.TabIndex = 17;
            this.label_TIME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TIME.Click += new System.EventHandler(this.label_TIME_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.GhostWhite;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(76, 77);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // status_NguoiDung
            // 
            this.status_NguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_NguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.status_NguoiDung.Dock = System.Windows.Forms.DockStyle.None;
            this.status_NguoiDung.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.status_NguoiDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.User_NguoiDung,
            this.label_NguoiDung});
            this.status_NguoiDung.Location = new System.Drawing.Point(1002, 9);
            this.status_NguoiDung.Name = "status_NguoiDung";
            this.status_NguoiDung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status_NguoiDung.Size = new System.Drawing.Size(62, 38);
            this.status_NguoiDung.TabIndex = 15;
            this.status_NguoiDung.Text = "statusStrip1";
            // 
            // User_NguoiDung
            // 
            this.User_NguoiDung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.User_NguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_ThongTinNguoiDung,
            this.toolStripMenuItem1,
            this.bt_DangXuat});
            this.User_NguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("User_NguoiDung.Image")));
            this.User_NguoiDung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.User_NguoiDung.Name = "User_NguoiDung";
            this.User_NguoiDung.Size = new System.Drawing.Size(45, 36);
            this.User_NguoiDung.Text = "toolStripDropDownButton1";
            // 
            // bt_ThongTinNguoiDung
            // 
            this.bt_ThongTinNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongTinNguoiDung.Name = "bt_ThongTinNguoiDung";
            this.bt_ThongTinNguoiDung.Size = new System.Drawing.Size(226, 24);
            this.bt_ThongTinNguoiDung.Text = "Thông tin người dùng";
            this.bt_ThongTinNguoiDung.Click += new System.EventHandler(this.bt_ThongTinNguoiDung_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 24);
            this.toolStripMenuItem1.Text = "Đổi mật khẩu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(226, 24);
            this.bt_DangXuat.Text = "Đăng Xuất";
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
            // 
            // label_NguoiDung
            // 
            this.label_NguoiDung.Name = "label_NguoiDung";
            this.label_NguoiDung.Size = new System.Drawing.Size(0, 33);
            this.label_NguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripKhachHang,
            this.toolStripSanPham,
            this.toolStripPhuTung,
            this.toolStripBaoHanh,
            this.toolStripDoiTac,
            this.btnHoaDon,
            this.btnKhuyenMai,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 77);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(115, 608);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripKhachHang
            // 
            this.toolStripKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("toolStripKhachHang.Image")));
            this.toolStripKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripKhachHang.Name = "toolStripKhachHang";
            this.toolStripKhachHang.Size = new System.Drawing.Size(112, 23);
            this.toolStripKhachHang.Text = "Khách Hàng";
            this.toolStripKhachHang.Click += new System.EventHandler(this.toolStripKhachHang_Click);
            // 
            // toolStripSanPham
            // 
            this.toolStripSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSanPham.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSanPham.Image")));
            this.toolStripSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSanPham.Name = "toolStripSanPham";
            this.toolStripSanPham.Size = new System.Drawing.Size(112, 23);
            this.toolStripSanPham.Text = "Sản Phẩm";
            this.toolStripSanPham.Click += new System.EventHandler(this.toolStripSanPham_Click);
            // 
            // toolStripPhuTung
            // 
            this.toolStripPhuTung.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPhuTung.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPhuTung.Image")));
            this.toolStripPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripPhuTung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPhuTung.Name = "toolStripPhuTung";
            this.toolStripPhuTung.Size = new System.Drawing.Size(112, 23);
            this.toolStripPhuTung.Text = "Phụ Tùng";
            this.toolStripPhuTung.Click += new System.EventHandler(this.toolStripLinhKien_Click);
            // 
            // toolStripBaoHanh
            // 
            this.toolStripBaoHanh.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBaoHanh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBaoHanh.Image")));
            this.toolStripBaoHanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBaoHanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBaoHanh.Name = "toolStripBaoHanh";
            this.toolStripBaoHanh.Size = new System.Drawing.Size(112, 23);
            this.toolStripBaoHanh.Text = "Bảo Hành";
            this.toolStripBaoHanh.Click += new System.EventHandler(this.toolStripBaoHanh_Click);
            // 
            // toolStripDoiTac
            // 
            this.toolStripDoiTac.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDoiTac.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDoiTac.Image")));
            this.toolStripDoiTac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDoiTac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDoiTac.Name = "toolStripDoiTac";
            this.toolStripDoiTac.Size = new System.Drawing.Size(112, 23);
            this.toolStripDoiTac.Text = "Đối Tác ";
            this.toolStripDoiTac.Click += new System.EventHandler(this.toolStripDoiTac_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(112, 23);
            this.btnHoaDon.Text = "Hóa Đơn";
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuyenMai.Image = ((System.Drawing.Image)(resources.GetObject("btnKhuyenMai.Image")));
            this.btnKhuyenMai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuyenMai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(112, 23);
            this.btnKhuyenMai.Text = "Khuyến Mãi";
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(115, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 608);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(112, 20);
            this.toolStripButton1.Text = "Thống kê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1083, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.status_NguoiDung.ResumeLayout(false);
            this.status_NguoiDung.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripDoiTac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripPhuTung;
        private System.Windows.Forms.ToolStripButton toolStripKhachHang;
        private System.Windows.Forms.StatusStrip status_NguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel label_NguoiDung;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolStripButton btnHoaDon;
        private System.Windows.Forms.ToolStripButton btnKhuyenMai;
        private System.Windows.Forms.ToolStripButton toolStripSanPham;
        private System.Windows.Forms.Label label_TIME;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripBaoHanh;
        private System.Windows.Forms.ToolStripDropDownButton User_NguoiDung;
        private System.Windows.Forms.ToolStripMenuItem bt_ThongTinNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bt_DangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

