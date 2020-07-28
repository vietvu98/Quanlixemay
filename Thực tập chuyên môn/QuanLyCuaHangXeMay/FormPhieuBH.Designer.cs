namespace QuanLyCuaHangXeMay
{
    partial class FormPhieuBH
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
            this.selectCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPhieuHoaDon = new QuanLyCuaHangXeMay.DataSetPhieuHoaDon();
            this.ctKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.selectCTHDTableAdapter = new QuanLyCuaHangXeMay.DataSetPhieuHoaDonTableAdapters.selectCTHDTableAdapter();
            this.ctKhachHangTableAdapter = new QuanLyCuaHangXeMay.DataSetPhieuHoaDonTableAdapters.ctKhachHangTableAdapter();
            this.selectHoaDonTableAdapter = new QuanLyCuaHangXeMay.DataSetPhieuHoaDonTableAdapters.selectHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.selectCTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPhieuHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCTHDBindingSource
            // 
            this.selectCTHDBindingSource.DataMember = "selectCTHD";
            this.selectCTHDBindingSource.DataSource = this.dataSetPhieuHoaDon;
            // 
            // dataSetPhieuHoaDon
            // 
            this.dataSetPhieuHoaDon.DataSetName = "DataSetPhieuHoaDon";
            this.dataSetPhieuHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctKhachHangBindingSource
            // 
            this.ctKhachHangBindingSource.DataMember = "ctKhachHang";
            this.ctKhachHangBindingSource.DataSource = this.dataSetPhieuHoaDon;
            // 
            // selectHoaDonBindingSource
            // 
            this.selectHoaDonBindingSource.DataMember = "selectHoaDon";
            this.selectHoaDonBindingSource.DataSource = this.dataSetPhieuHoaDon;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectCTHDBindingSource;
            reportDataSource2.Name = "DataSet3";
            reportDataSource2.Value = this.ctKhachHangBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.selectHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangXeMay.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1039, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(994, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // selectCTHDTableAdapter
            // 
            this.selectCTHDTableAdapter.ClearBeforeFill = true;
            // 
            // ctKhachHangTableAdapter
            // 
            this.ctKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // selectHoaDonTableAdapter
            // 
            this.selectHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 650);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieuBH";
            this.Load += new System.EventHandler(this.FormPhieuBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPhieuHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.BindingSource selectCTHDBindingSource;
        private DataSetPhieuHoaDon dataSetPhieuHoaDon;
        private System.Windows.Forms.BindingSource ctKhachHangBindingSource;
        private System.Windows.Forms.BindingSource selectHoaDonBindingSource;
        private DataSetPhieuHoaDonTableAdapters.selectCTHDTableAdapter selectCTHDTableAdapter;
        private DataSetPhieuHoaDonTableAdapters.ctKhachHangTableAdapter ctKhachHangTableAdapter;
        private DataSetPhieuHoaDonTableAdapters.selectHoaDonTableAdapter selectHoaDonTableAdapter;
    }
}