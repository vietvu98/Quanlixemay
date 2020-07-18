namespace QuanLyCuaHangXeMay
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHangXe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCongSuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonAnh = new DevExpress.XtraEditors.SimpleButton();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.txtKhoiLuong = new System.Windows.Forms.TextBox();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.txtDungTich = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmsp = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dgvTTSanPham = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAISP_SPDataSet = new QuanLyCuaHangXeMay.LOAISP_SPDataSet();
            this.DUNGTICHXL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KICHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHOILUONGSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONGSUATTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAVSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXeMoTo = new DevExpress.XtraEditors.SimpleButton();
            this.btnXeTayGa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXeSo = new DevExpress.XtraEditors.SimpleButton();
            this.lOAISPTableAdapter = new QuanLyCuaHangXeMay.LOAISP_SPDataSetTableAdapters.LOAISPTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISP_SPDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnHuy,
            this.btnTimKiem,
            this.txtSearch,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(973, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(55, 22);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(55, 22);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(23, 22);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.AutoSize = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxLoai);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtHangXe);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCongSuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnChonAnh);
            this.panel1.Controls.Add(this.ptbAnh);
            this.panel1.Controls.Add(this.txtKhoiLuong);
            this.panel1.Controls.Add(this.txtKichThuoc);
            this.panel1.Controls.Add(this.txtDungTich);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbmsp);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 251);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxLoai
            // 
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(441, 58);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(154, 21);
            this.cbxLoai.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Loại";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(791, 207);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(154, 20);
            this.txtGia.TabIndex = 19;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(666, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giá bán";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(791, 159);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(154, 20);
            this.txtSoLuong.TabIndex = 17;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(666, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng";
            // 
            // txtHangXe
            // 
            this.txtHangXe.Location = new System.Drawing.Point(441, 208);
            this.txtHangXe.Name = "txtHangXe";
            this.txtHangXe.Size = new System.Drawing.Size(154, 20);
            this.txtHangXe.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hãng xe";
            // 
            // txtCongSuat
            // 
            this.txtCongSuat.Location = new System.Drawing.Point(791, 113);
            this.txtCongSuat.Name = "txtCongSuat";
            this.txtCongSuat.Size = new System.Drawing.Size(154, 20);
            this.txtCongSuat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Công suất tối đa";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Appearance.Options.UseFont = true;
            this.btnChonAnh.Location = new System.Drawing.Point(79, 207);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(146, 33);
            this.btnChonAnh.TabIndex = 11;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // ptbAnh
            // 
            this.ptbAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbAnh.Location = new System.Drawing.Point(23, 3);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(264, 198);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 10;
            this.ptbAnh.TabStop = false;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.Location = new System.Drawing.Point(791, 64);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Size = new System.Drawing.Size(154, 20);
            this.txtKhoiLuong.TabIndex = 9;
            this.txtKhoiLuong.TextChanged += new System.EventHandler(this.txtKhoiLuong_TextChanged);
            this.txtKhoiLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoiLuong_KeyPress);
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(791, 10);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(154, 20);
            this.txtKichThuoc.TabIndex = 8;
            // 
            // txtDungTich
            // 
            this.txtDungTich.Location = new System.Drawing.Point(441, 157);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Size = new System.Drawing.Size(154, 20);
            this.txtDungTich.TabIndex = 7;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(441, 109);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(154, 20);
            this.txtTenSP.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khối lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dài x Rộng x Cao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dung tích xy-lanh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // lbmsp
            // 
            this.lbmsp.AutoSize = true;
            this.lbmsp.Location = new System.Drawing.Point(319, 20);
            this.lbmsp.Name = "lbmsp";
            this.lbmsp.Size = new System.Drawing.Size(71, 13);
            this.lbmsp.TabIndex = 1;
            this.lbmsp.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(441, 13);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(154, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // dgvTTSanPham
            // 
            this.dgvTTSanPham.AllowUserToAddRows = false;
            this.dgvTTSanPham.AllowUserToDeleteRows = false;
            this.dgvTTSanPham.AllowUserToResizeRows = false;
            this.dgvTTSanPham.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTTSanPham.ColumnHeadersHeight = 45;
            this.dgvTTSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.MALOAI,
            this.DUNGTICHXL,
            this.KICHTHUOC,
            this.KHOILUONGSP,
            this.CONGSUATTD,
            this.HANGXE,
            this.SOLUONG,
            this.GIAVSP});
            this.dgvTTSanPham.Location = new System.Drawing.Point(0, 346);
            this.dgvTTSanPham.Name = "dgvTTSanPham";
            this.dgvTTSanPham.ReadOnly = true;
            this.dgvTTSanPham.RowHeadersVisible = false;
            this.dgvTTSanPham.RowHeadersWidth = 50;
            this.dgvTTSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTSanPham.Size = new System.Drawing.Size(968, 264);
            this.dgvTTSanPham.TabIndex = 15;
            this.dgvTTSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTSanPham_CellClick);
            this.dgvTTSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTSanPham_CellContentClick);
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.FillWeight = 80F;
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Width = 85;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.DataSource = this.lOAISPBindingSource;
            this.MALOAI.DisplayMember = "TENLOAI";
            this.MALOAI.HeaderText = "Tên Loại";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MALOAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MALOAI.ValueMember = "MALOAI";
            this.MALOAI.Width = 80;
            // 
            // lOAISPBindingSource
            // 
            this.lOAISPBindingSource.DataMember = "LOAISP";
            this.lOAISPBindingSource.DataSource = this.lOAISP_SPDataSet;
            // 
            // lOAISP_SPDataSet
            // 
            this.lOAISP_SPDataSet.DataSetName = "LOAISP_SPDataSet";
            this.lOAISP_SPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DUNGTICHXL
            // 
            this.DUNGTICHXL.DataPropertyName = "DUNGTICHXL";
            this.DUNGTICHXL.HeaderText = "Dung Tích xy-lanh";
            this.DUNGTICHXL.Name = "DUNGTICHXL";
            this.DUNGTICHXL.ReadOnly = true;
            // 
            // KICHTHUOC
            // 
            this.KICHTHUOC.DataPropertyName = "KICHTHUOC";
            this.KICHTHUOC.HeaderText = "Dài x Rộng x Cao";
            this.KICHTHUOC.Name = "KICHTHUOC";
            this.KICHTHUOC.ReadOnly = true;
            // 
            // KHOILUONGSP
            // 
            this.KHOILUONGSP.DataPropertyName = "KHOILUONGSP";
            this.KHOILUONGSP.HeaderText = "Khối lượng(Kg)";
            this.KHOILUONGSP.Name = "KHOILUONGSP";
            this.KHOILUONGSP.ReadOnly = true;
            this.KHOILUONGSP.Width = 80;
            // 
            // CONGSUATTD
            // 
            this.CONGSUATTD.DataPropertyName = "CONGSUATTD";
            this.CONGSUATTD.HeaderText = "Công suất tối đa";
            this.CONGSUATTD.Name = "CONGSUATTD";
            this.CONGSUATTD.ReadOnly = true;
            this.CONGSUATTD.Width = 102;
            // 
            // HANGXE
            // 
            this.HANGXE.DataPropertyName = "HANGXE";
            this.HANGXE.HeaderText = "Hãng Xe";
            this.HANGXE.Name = "HANGXE";
            this.HANGXE.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // GIAVSP
            // 
            this.GIAVSP.DataPropertyName = "GIASP";
            this.GIAVSP.HeaderText = "Giá bán(VND)";
            this.GIAVSP.Name = "GIAVSP";
            this.GIAVSP.ReadOnly = true;
            this.GIAVSP.ToolTipText = "VND";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXeMoTo);
            this.panel2.Controls.Add(this.btnXeTayGa);
            this.panel2.Controls.Add(this.btnXeSo);
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 51);
            this.panel2.TabIndex = 19;
            // 
            // btnXeMoTo
            // 
            this.btnXeMoTo.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXeMoTo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXeMoTo.Appearance.Options.UseFont = true;
            this.btnXeMoTo.Appearance.Options.UseForeColor = true;
            this.btnXeMoTo.Location = new System.Drawing.Point(822, 6);
            this.btnXeMoTo.Name = "btnXeMoTo";
            this.btnXeMoTo.Size = new System.Drawing.Size(124, 39);
            this.btnXeMoTo.TabIndex = 2;
            this.btnXeMoTo.Text = "Xe Moto";
            this.btnXeMoTo.Click += new System.EventHandler(this.btnXeMoTo_Click);
            // 
            // btnXeTayGa
            // 
            this.btnXeTayGa.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXeTayGa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXeTayGa.Appearance.Options.UseFont = true;
            this.btnXeTayGa.Appearance.Options.UseForeColor = true;
            this.btnXeTayGa.Location = new System.Drawing.Point(453, 3);
            this.btnXeTayGa.Name = "btnXeTayGa";
            this.btnXeTayGa.Size = new System.Drawing.Size(124, 39);
            this.btnXeTayGa.TabIndex = 1;
            this.btnXeTayGa.Text = "Xe Tay Ga";
            this.btnXeTayGa.Click += new System.EventHandler(this.btnXeTayGa_Click);
            // 
            // btnXeSo
            // 
            this.btnXeSo.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXeSo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXeSo.Appearance.Options.UseFont = true;
            this.btnXeSo.Appearance.Options.UseForeColor = true;
            this.btnXeSo.Location = new System.Drawing.Point(80, 6);
            this.btnXeSo.Name = "btnXeSo";
            this.btnXeSo.Size = new System.Drawing.Size(124, 39);
            this.btnXeSo.TabIndex = 0;
            this.btnXeSo.Text = "Xe Số";
            this.btnXeSo.Click += new System.EventHandler(this.btnXeSo_Click);
            // 
            // lOAISPTableAdapter
            // 
            this.lOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(973, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTTSanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISP_SPDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnChonAnh;
        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.TextBox txtKhoiLuong;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.TextBox txtDungTich;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmsp;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DataGridView dgvTTSanPham;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnXeMoTo;
        private DevExpress.XtraEditors.SimpleButton btnXeTayGa;
        private DevExpress.XtraEditors.SimpleButton btnXeSo;
        private System.Windows.Forms.TextBox txtCongSuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHangXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxLoai;
        private LOAISP_SPDataSet lOAISP_SPDataSet;
        private System.Windows.Forms.BindingSource lOAISPBindingSource;
        private LOAISP_SPDataSetTableAdapters.LOAISPTableAdapter lOAISPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewComboBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUNGTICHXL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KICHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOILUONGSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONGSUATTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAVSP;
        private System.Windows.Forms.ToolStripButton btnThem;
    }
}