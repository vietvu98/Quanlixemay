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
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TIME = new System.Windows.Forms.Label();
            this.status_NguoiDung = new System.Windows.Forms.StatusStrip();
            this.User_NguoiDung = new System.Windows.Forms.ToolStripDropDownButton();
            this.bt_ThongTinNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label_NguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripKhachHang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSanPham = new System.Windows.Forms.ToolStripButton();
            this.toolStripPhuTung = new System.Windows.Forms.ToolStripButton();
            this.toolStripDoiTac = new System.Windows.Forms.ToolStripButton();
            this.btnHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnThongKe = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Transition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnFacebook = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangNhap)).BeginInit();
            this.status_NguoiDung.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaCirclePictureBox2);
            this.panel1.Controls.Add(this.btnFacebook);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_TIME);
            this.panel1.Controls.Add(this.status_NguoiDung);
            this.Transition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BaseColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.btnDangNhap, Guna.UI.Animation.DecorationType.None);
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.Location = new System.Drawing.Point(0, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(81, 77);
            this.btnDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDangNhap.TabIndex = 19;
            this.btnDangNhap.TabStop = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.Transition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
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
            this.Transition1.SetDecoration(this.label_TIME, Guna.UI.Animation.DecorationType.None);
            this.label_TIME.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TIME.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_TIME.Location = new System.Drawing.Point(455, 9);
            this.label_TIME.Name = "label_TIME";
            this.label_TIME.Size = new System.Drawing.Size(229, 38);
            this.label_TIME.TabIndex = 17;
            this.label_TIME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TIME.Click += new System.EventHandler(this.label_TIME_Click);
            // 
            // status_NguoiDung
            // 
            this.status_NguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_NguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.status_NguoiDung, Guna.UI.Animation.DecorationType.None);
            this.status_NguoiDung.Dock = System.Windows.Forms.DockStyle.None;
            this.status_NguoiDung.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.status_NguoiDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.User_NguoiDung,
            this.label_NguoiDung});
            this.status_NguoiDung.Location = new System.Drawing.Point(1012, 9);
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
            this.Transition1.SetDecoration(this.toolStrip1, Guna.UI.Animation.DecorationType.None);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripKhachHang,
            this.toolStripSanPham,
            this.toolStripPhuTung,
            this.toolStripDoiTac,
            this.btnHoaDon,
            this.btnThongKe});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 77);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(119, 608);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripKhachHang
            // 
            this.toolStripKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripKhachHang.Name = "toolStripKhachHang";
            this.toolStripKhachHang.Size = new System.Drawing.Size(98, 23);
            this.toolStripKhachHang.Text = "Khách Hàng";
            this.toolStripKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripKhachHang.Click += new System.EventHandler(this.toolStripKhachHang_Click);
            // 
            // toolStripSanPham
            // 
            this.toolStripSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSanPham.Name = "toolStripSanPham";
            this.toolStripSanPham.Size = new System.Drawing.Size(116, 23);
            this.toolStripSanPham.Text = "Xử lí sản phẩm";
            this.toolStripSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSanPham.Click += new System.EventHandler(this.toolStripSanPham_Click);
            // 
            // toolStripPhuTung
            // 
            this.toolStripPhuTung.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripPhuTung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPhuTung.Name = "toolStripPhuTung";
            this.toolStripPhuTung.Size = new System.Drawing.Size(118, 23);
            this.toolStripPhuTung.Text = "Nhập sản phẩm";
            this.toolStripPhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripPhuTung.Click += new System.EventHandler(this.toolStripLinhKien_Click);
            // 
            // toolStripDoiTac
            // 
            this.toolStripDoiTac.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDoiTac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDoiTac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDoiTac.Name = "toolStripDoiTac";
            this.toolStripDoiTac.Size = new System.Drawing.Size(71, 23);
            this.toolStripDoiTac.Text = "Đối Tác ";
            this.toolStripDoiTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripDoiTac.Click += new System.EventHandler(this.toolStripDoiTac_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(79, 23);
            this.btnThongKe.Text = "Thông Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.Transition1.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(119, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 608);
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
            // Transition1
            // 
            this.Transition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.Transition1.DefaultAnimation = animation2;
            this.Transition1.MaxAnimationTime = 2000;
            this.Transition1.TimeStep = 0.005F;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(221, 129);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(575, 340);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 20;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.gunaCirclePictureBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(172, 9);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(50, 52);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 26;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            this.gunaCirclePictureBox2.Click += new System.EventHandler(this.gunaCirclePictureBox2_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.Transparent;
            this.btnFacebook.BaseColor = System.Drawing.Color.Transparent;
            this.Transition1.SetDecoration(this.btnFacebook, Guna.UI.Animation.DecorationType.None);
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.Location = new System.Drawing.Point(246, 9);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(50, 50);
            this.btnFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFacebook.TabIndex = 27;
            this.btnFacebook.TabStop = false;
            this.btnFacebook.UseTransfarantBackground = false;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
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
            this.Transition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangNhap)).EndInit();
            this.status_NguoiDung.ResumeLayout(false);
            this.status_NguoiDung.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacebook)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnHoaDon;
        private System.Windows.Forms.ToolStripButton toolStripSanPham;
        private System.Windows.Forms.Label label_TIME;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton User_NguoiDung;
        private System.Windows.Forms.ToolStripMenuItem bt_ThongTinNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem bt_DangXuat;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox btnDangNhap;
        private System.Windows.Forms.ToolStripButton btnThongKe;
        public Guna.UI.WinForms.GunaTransition Transition1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaCirclePictureBox btnFacebook;
    }
}

