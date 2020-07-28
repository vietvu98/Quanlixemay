using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraCharts;
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
    public partial class FormThongKe : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            int a = 0;
            foreach (var r in dt.KHACHHANGs)
            {

                a = a + 1;
            }
            lbTongKH.Text = a.ToString();
            decimal b = 0;
            foreach (var doanht in dt.thongKeDoanhThu())
            {
                b = b + Convert.ToDecimal(doanht.tien);
            }
            lbDoanhTHu.Text = b.ToString("N0");
            ChartControl.DataSource = dt.thongKeDoanhThu().ToList();
            ChartControl.SeriesDataMember = "thang";
            ChartControl.SeriesTemplate.ArgumentDataMember = "thang";
            ChartControl.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "tien" });
            ChartControl.SeriesTemplate.View = new StackedBarSeriesView();
            //ChartControl.SeriesNameTemplate.BeginText = "Tháng ";
        }

        private void bt_XuatFile_Click(object sender, EventArgs e)
        {
            data_ThongTin.DataSource = dt.data_xuatExcel();
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Bảng Thống Kê Hóa Đơn " ;
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã HD";
            worksheet.Cells[3, 3] = "Tên khách hàng";
            worksheet.Cells[3, 4] = "Tên nhân viên";
            worksheet.Cells[3, 5] = "Ngày lập hóa đơn";
            worksheet.Cells[3, 6] = "Giảm giá (%)";
            worksheet.Cells[3, 7] = "Tổng tiền (VNĐ)";
           

            for (int i = 0; i < data_ThongTin.RowCount -1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = data_ThongTin.Rows[i].Cells[j].Value;
                }
            }
            int dem = data_ThongTin.RowCount -1;
            


            // Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Đinh dạng cột
            worksheet.Range["A1"].ColumnWidth = 7;
            worksheet.Range["B1"].ColumnWidth = 45;
            worksheet.Range["C1"].ColumnWidth = 49;
            worksheet.Range["D1"].ColumnWidth = 33;
            worksheet.Range["E1"].ColumnWidth = 31;
            worksheet.Range["F1"].ColumnWidth = 52;
            worksheet.Range["G1"].ColumnWidth = 23;
            

            // Định dạng font chữ
            //     worksheet.Range["A1", "J100"].Font.Name = "";
            worksheet.Range["A1", "A100"].Font.Size = 24;
            worksheet.Range["A3", "G100"].Font.Size = 16;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
            worksheet.Range["A3", "G3"].Font.Bold = true;

            // kẻ bảng
            worksheet.Range["A3", "G" + (dem + 3)].Borders.LineStyle = 1;


            //Định dạng dòng text
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A3", "G3"].HorizontalAlignment = 3;
            worksheet.Range["A4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["B4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["C4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["D4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["E4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["F4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["G4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["H4", "G" + (dem + 4)].HorizontalAlignment = 3;

        }
    }
}
