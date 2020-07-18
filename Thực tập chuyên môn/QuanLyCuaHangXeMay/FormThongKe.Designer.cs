namespace QuanLyCuaHangXeMay
{
    partial class FormThongKe
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
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView4 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView4 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle4 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            this.ChartControl = new DevExpress.XtraCharts.ChartControl();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDoanhTHu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.lbTongKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_XuatFile = new Guna.UI.WinForms.GunaButton();
            this.data_ThongTin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView4)).BeginInit();
            this.gunaGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartControl
            // 
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            this.ChartControl.Diagram = xyDiagram4;
            this.ChartControl.Legend.Name = "Default Legend";
            this.ChartControl.Location = new System.Drawing.Point(17, 214);
            this.ChartControl.Name = "ChartControl";
            series4.Name = "Series 1";
            sideBySideBarSeriesView4.ColorEach = true;
            series4.View = sideBySideBarSeriesView4;
            this.ChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.ChartControl.SeriesTemplate.SeriesColorizer = null;
            this.ChartControl.SeriesTemplate.View = splineSeriesView4;
            this.ChartControl.Size = new System.Drawing.Size(934, 386);
            this.ChartControl.TabIndex = 48;
            chartTitle4.Text = "Doanh thu theo tháng";
            this.ChartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle4});
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.label2);
            this.gunaGradientPanel2.Controls.Add(this.lbDoanhTHu);
            this.gunaGradientPanel2.Controls.Add(this.label4);
            this.gunaGradientPanel2.Controls.Add(this.pictureBox3);
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.MediumSpringGreen;
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.Aquamarine;
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(387, 12);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(302, 166);
            this.gunaGradientPanel2.TabIndex = 50;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "VND";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDoanhTHu
            // 
            this.lbDoanhTHu.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhTHu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhTHu.Location = new System.Drawing.Point(3, 104);
            this.lbDoanhTHu.Name = "lbDoanhTHu";
            this.lbDoanhTHu.Size = new System.Drawing.Size(168, 42);
            this.lbDoanhTHu.TabIndex = 5;
            this.lbDoanhTHu.Text = "0";
            this.lbDoanhTHu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng doanh thu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.lbTongKH);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.pictureBox2);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.DarkKhaki;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.GreenYellow;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(273, 166);
            this.gunaGradientPanel1.TabIndex = 49;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // lbTongKH
            // 
            this.lbTongKH.BackColor = System.Drawing.Color.Transparent;
            this.lbTongKH.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongKH.Location = new System.Drawing.Point(3, 104);
            this.lbTongKH.Name = "lbTongKH";
            this.lbTongKH.Size = new System.Drawing.Size(267, 42);
            this.lbTongKH.TabIndex = 2;
            this.lbTongKH.Text = "0";
            this.lbTongKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số lượng khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bt_XuatFile
            // 
            this.bt_XuatFile.AnimationHoverSpeed = 0.07F;
            this.bt_XuatFile.AnimationSpeed = 0.03F;
            this.bt_XuatFile.BackColor = System.Drawing.Color.Transparent;
            this.bt_XuatFile.BaseColor = System.Drawing.Color.Transparent;
            this.bt_XuatFile.BorderColor = System.Drawing.Color.Black;
            this.bt_XuatFile.FocusedColor = System.Drawing.Color.Empty;
            this.bt_XuatFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XuatFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_XuatFile.Image = ((System.Drawing.Image)(resources.GetObject("bt_XuatFile.Image")));
            this.bt_XuatFile.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_XuatFile.Location = new System.Drawing.Point(739, 116);
            this.bt_XuatFile.Name = "bt_XuatFile";
            this.bt_XuatFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bt_XuatFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_XuatFile.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_XuatFile.OnHoverImage = null;
            this.bt_XuatFile.OnPressedColor = System.Drawing.Color.Black;
            this.bt_XuatFile.Radius = 7;
            this.bt_XuatFile.Size = new System.Drawing.Size(209, 55);
            this.bt_XuatFile.TabIndex = 51;
            this.bt_XuatFile.Text = "Xuất Excel";
            this.bt_XuatFile.Click += new System.EventHandler(this.bt_XuatFile_Click);
            // 
            // data_ThongTin
            // 
            this.data_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThongTin.Location = new System.Drawing.Point(707, 12);
            this.data_ThongTin.Name = "data_ThongTin";
            this.data_ThongTin.Size = new System.Drawing.Size(241, 98);
            this.data_ThongTin.TabIndex = 52;
            this.data_ThongTin.Visible = false;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(973, 610);
            this.Controls.Add(this.data_ThongTin);
            this.Controls.Add(this.bt_XuatFile);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.ChartControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartControl)).EndInit();
            this.gunaGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ChartControl;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDoanhTHu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label lbTongKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton bt_XuatFile;
        private System.Windows.Forms.DataGridView data_ThongTin;
    }
}