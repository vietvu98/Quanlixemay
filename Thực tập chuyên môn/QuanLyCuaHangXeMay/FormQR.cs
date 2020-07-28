using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QuanLyCuaHangXeMay
{
    public partial class FormQR : Form
    {
        public FormQR()
        {
            InitializeComponent();
        }
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        MJPEGStream Stream;
        private void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            picQR.Image = bmp;
        }
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (btnKetNoi.Text == "Kết nối ứng dụng")
            {
                if (txtURL.Text.Trim() == "" || txtURL.Text.Trim() == null)
                {
                    MessageBox.Show("Bạn chưa kết nối ứng dụng");
                }
                else
                {
                    picQR.Visible = true;
                    Stream = new MJPEGStream(txtURL.Text);
                    Stream.NewFrame += stream_NewFrame;
                    Stream.Start();
                    timer1.Enabled = true;
                    timer1.Start();
                    btnKetNoi.Text = "Ngắt ứng dụng";
                }
            }
            else
            {
                picQR.Visible = false;
                btnKetNoi.Text = "Kết nối ứng dụng";
                timer1.Stop();
                Stream.Stop();
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                BarcodeReader Reader = new BarcodeReader();
                if (Reader.Decode((Bitmap)picQR.Image) != null)
                {
                    Result result = Reader.Decode((Bitmap)picQR.Image);
                    if (result != null)
                    {
                        string mahd = result.ToString();
                        btnKetNoi_Click(sender, e);
                        HOADON hd = dt.HOADONs.Where(s => s.MAHD == mahd).FirstOrDefault();
                        if(hd != null)
                        {
                            int d, m, y;
                            d = Convert.ToInt32(Convert.ToDateTime(hd.NGAYXUATHD).Day);
                            m = Convert.ToInt32(Convert.ToDateTime(hd.NGAYXUATHD).Month);
                            y = Convert.ToInt32(Convert.ToDateTime(hd.NGAYXUATHD).Year);
                            int ysau = y +2;
                            if(DateTime.Now <= Convert.ToDateTime(d + "-" + m + "-" + ysau))
                            {
                                MessageBox.Show("Phiếu bảo hành còn thời hạn sử dụng","Thông báo");
                            }
                            else if (DateTime.Now > Convert.ToDateTime(d + "-" + m + "-" + ysau))
                            {
                                MessageBox.Show("Phiếu bảo hành hết hạn");
                            }
                            
                        }
                        else if(hd == null)
                        {
                            MessageBox.Show("Không có hóa đơn này","Thông báo");
                        }
                        
                    }
                }
            }
            catch(Exception )
            {

            }
            }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Stream.Stop();
            }
        }

        private void picQR_Click(object sender, EventArgs e)
        {

        }
    }
}
