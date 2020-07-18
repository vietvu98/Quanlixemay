namespace QuanLyCuaHangXeMay
{
    partial class FormPhieuBaoHanh
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetPhieuHoaDon = new QuanLyCuaHangXeMay.DataSetPhieuHoaDon();
            this.selectCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectCTHDTableAdapter = new QuanLyCuaHangXeMay.DataSetPhieuHoaDonTableAdapters.selectCTHDTableAdapter();
            this.selectHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectHoaDonTableAdapter = new QuanLyCuaHangXeMay.DataSetPhieuHoaDonTableAdapters.selectHoaDonTableAdapter();
            this.KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHACHHANGTableAdapter = new QuanLyCuaHangXeMay.DataSetPhieuHoaDonTableAdapters.KHACHHANGTableAdapter();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPhieuHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectCTHDBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.selectHoaDonBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangXeMay.ReportPhieuBaoHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1046, 679);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetPhieuHoaDon
            // 
            this.DataSetPhieuHoaDon.DataSetName = "DataSetPhieuHoaDon";
            this.DataSetPhieuHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectCTHDBindingSource
            // 
            this.selectCTHDBindingSource.DataMember = "selectCTHD";
            this.selectCTHDBindingSource.DataSource = this.DataSetPhieuHoaDon;
            // 
            // selectCTHDTableAdapter
            // 
            this.selectCTHDTableAdapter.ClearBeforeFill = true;
            // 
            // selectHoaDonBindingSource
            // 
            this.selectHoaDonBindingSource.DataMember = "selectHoaDon";
            this.selectHoaDonBindingSource.DataSource = this.DataSetPhieuHoaDon;
            // 
            // selectHoaDonTableAdapter
            // 
            this.selectHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // KHACHHANGBindingSource
            // 
            this.KHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.KHACHHANGBindingSource.DataSource = this.DataSetPhieuHoaDon;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1002, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(44, 24);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // FormPhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 679);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuBaoHanh";
            this.Text = "FormPhieuBaoHanh";
            this.Load += new System.EventHandler(this.FormPhieuBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPhieuHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectCTHDBindingSource;
        private DataSetPhieuHoaDon DataSetPhieuHoaDon;
        private System.Windows.Forms.BindingSource selectHoaDonBindingSource;
        private System.Windows.Forms.BindingSource KHACHHANGBindingSource;
        private DataSetPhieuHoaDonTableAdapters.selectCTHDTableAdapter selectCTHDTableAdapter;
        private DataSetPhieuHoaDonTableAdapters.selectHoaDonTableAdapter selectHoaDonTableAdapter;
        private DataSetPhieuHoaDonTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}