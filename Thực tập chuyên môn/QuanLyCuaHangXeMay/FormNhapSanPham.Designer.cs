namespace QuanLyCuaHangXeMay
{
    partial class FormNhapSanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaPN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDGXe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemXe = new Guna.UI.WinForms.GunaButton();
            this.cbxXe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLXe = new System.Windows.Forms.TextBox();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Phiếu nhập";
            // 
            // lbMaPN
            // 
            this.lbMaPN.AutoSize = true;
            this.lbMaPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPN.Location = new System.Drawing.Point(559, 18);
            this.lbMaPN.Name = "lbMaPN";
            this.lbMaPN.Size = new System.Drawing.Size(2, 27);
            this.lbMaPN.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nhà cung cấp";
            // 
            // cbxNCC
            // 
            this.cbxNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(742, 25);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(151, 28);
            this.cbxNCC.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Xe ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Số lượng";
            // 
            // txtDGXe
            // 
            this.txtDGXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGXe.Location = new System.Drawing.Point(742, 72);
            this.txtDGXe.Name = "txtDGXe";
            this.txtDGXe.Size = new System.Drawing.Size(149, 26);
            this.txtDGXe.TabIndex = 36;
            this.txtDGXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGXe_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Đơn giá";
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToAddRows = false;
            this.dgvXe.AllowUserToDeleteRows = false;
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.ColumnHeadersHeight = 40;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SLNHAP,
            this.DONGIANHAP,
            this.THANHTIEN,
            this.Xoa});
            this.dgvXe.Location = new System.Drawing.Point(18, 237);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.ReadOnly = true;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.Size = new System.Drawing.Size(920, 217);
            this.dgvXe.TabIndex = 38;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            this.dgvXe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvXe_RowsAdded);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(799, 505);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(26, 27);
            this.lbTongTien.TabIndex = 40;
            this.lbTongTien.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tổng tiền";
            // 
            // btnThemXe
            // 
            this.btnThemXe.AnimationHoverSpeed = 0.07F;
            this.btnThemXe.AnimationSpeed = 0.03F;
            this.btnThemXe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemXe.BorderColor = System.Drawing.Color.Black;
            this.btnThemXe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.ForeColor = System.Drawing.Color.White;
            this.btnThemXe.Image = null;
            this.btnThemXe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemXe.Location = new System.Drawing.Point(389, 101);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemXe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemXe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemXe.OnHoverImage = null;
            this.btnThemXe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemXe.Size = new System.Drawing.Size(99, 42);
            this.btnThemXe.TabIndex = 41;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemXe.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxXe
            // 
            this.cbxXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxXe.FormattingEnabled = true;
            this.cbxXe.Location = new System.Drawing.Point(139, 25);
            this.cbxXe.Name = "cbxXe";
            this.cbxXe.Size = new System.Drawing.Size(149, 28);
            this.cbxXe.TabIndex = 37;
            this.cbxXe.SelectedValueChanged += new System.EventHandler(this.cbxXe_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLXe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDGXe);
            this.groupBox1.Controls.Add(this.cbxXe);
            this.groupBox1.Controls.Add(this.cbxNCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThemXe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 163);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập xe";
            // 
            // txtSLXe
            // 
            this.txtSLXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLXe.Location = new System.Drawing.Point(139, 69);
            this.txtSLXe.Name = "txtSLXe";
            this.txtSLXe.Size = new System.Drawing.Size(149, 26);
            this.txtSLXe.TabIndex = 42;
            this.txtSLXe.TextAlignChanged += new System.EventHandler(this.txtSLXe_TextAlignChanged);
            this.txtSLXe.TextChanged += new System.EventHandler(this.txtSLXe_TextChanged);
            this.txtSLXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLXe_KeyPress);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã xe";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Xe";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SLNHAP
            // 
            this.SLNHAP.DataPropertyName = "SLNHAP";
            this.SLNHAP.HeaderText = "Số lượng";
            this.SLNHAP.Name = "SLNHAP";
            this.SLNHAP.ReadOnly = true;
            // 
            // DONGIANHAP
            // 
            this.DONGIANHAP.DataPropertyName = "DONGIANHAP";
            this.DONGIANHAP.HeaderText = "Đơn giá";
            this.DONGIANHAP.Name = "DONGIANHAP";
            this.DONGIANHAP.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            // 
            // FormNhapSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(973, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.lbMaPN);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapSanPham";
            this.Text = "0 ";
            this.Load += new System.EventHandler(this.FormNhapSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxXe;
        private System.Windows.Forms.TextBox txtDGXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton btnThemXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSLXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}