using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public class TTNV
        {
            static public String MaNV="";
        }
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        

        public string MaHoa(string txt)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            txt = sb.ToString();
            return txt;
        }
        private void lblQuen_Click(object sender, EventArgs e)
        {
            if (panelQuenMK.Left == 808)
            {
                panelDangNhap.Visible = false;
                panelDangNhap.Left = 808;

                panelQuenMK.Visible = false;
                panelQuenMK.Left = 417;
                panelQuenMK.Visible = true;
                panelQuenMK.Refresh();
            }
        }

        private void txtQuayLai_Click(object sender, EventArgs e)
        {
            if (panelDangNhap.Left == 808)
            {
                panelQuenMK.Visible = false;
                panelQuenMK.Left = 808;

                panelDangNhap.Visible = false;
                panelDangNhap.Left = 417;
                panelDangNhap.Visible = true;
                panelDangNhap.Refresh();
            }
            DangNhap_Load(sender, e);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            //txtTaiKhoan.Text = null;
            //txtTKQuen.Text = null;
            //txtGmailQuen.Text = null;
        }

        private void txtHoTro_Click(object sender, EventArgs e)
        {
            DialogResult dtr = MessageBox.Show("Bạn Có Chắc Muốn Đổi Mật Khẩu Không", "Thông báo", MessageBoxButtons.OKCancel);
            if (dtr == DialogResult.OK)
            {
                var rda = dt.NHANVIENs.Where(s => s.USERLOGIN == txtTKQuen.Text.Trim()).Where(s => s.EMAIL == txtGmailQuen.Text.Trim()).FirstOrDefault();
                if (rda == null)
                {
                    MessageBox.Show("Không có tài khoản này!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string bodyemail = "Xin Chào " + rda.TENNHANVIEN + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + rda.PASSWORD.Remove(6, 26)
                                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu";
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("tvfahasa@gmail.com");
                        mail.To.Add(rda.EMAIL);
                        mail.Subject = "Motocyecle VN- Đưa những chiếc xe về ngôi nhà của bạn";
                        mail.Body = bodyemail;
                        SmtpClient smptClient = new SmtpClient();
                        smptClient.Host = "smtp.gmail.com";
                        System.Net.NetworkCredential credential = new NetworkCredential();
                        credential.UserName = "tvfahasa@gmail.com";
                        credential.Password = "Hehehe123";
                        smptClient.Credentials = credential;
                        smptClient.Port = 587;
                        smptClient.EnableSsl = true;
                        smptClient.Send(mail);
                        MessageBox.Show("Đã gửi mã xác minh về Email Mời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                        if (panelDoiMK.Left == 1201)
                        {
                            panelQuenMK.Visible = false;
                            panelQuenMK.Left = 1201;

                            panelDoiMK.Visible = false;
                            panelDoiMK.Left = 417;
                            panelDoiMK.Visible = true;
                            panelDoiMK.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (dtr == DialogResult.Cancel)
            {
                if (panelDangNhap.Left == 808)
                {
                    panelQuenMK.Visible = false;
                    panelQuenMK.Left = 808;

                    panelDangNhap.Visible = false;
                    panelDangNhap.Left = 417;
                    panelDangNhap.Visible = true;
                    panelDangNhap.Refresh();
                }
                DangNhap_Load(sender, e);
            }

        }

        private void txtDoiMK_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = dt.NHANVIENs.Where(s => s.USERLOGIN == txtTKDoi.Text.Trim()).Where(s => s.PASSWORD.Remove(6, 26) == txtMaXM.Text.Trim()).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Bạn Đã Nhập Sai Mã Xác Minh Vui Lòng Check Mail Hoặc Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                dt.quenmk(txtTKDoi.Text.Trim(), MaHoa(txtMKmoi.Text.Trim()));
                MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK);
                panelDoiMK.Visible = false;
                panelDangNhap.Visible = true;

                if (panelDangNhap.Left == 808)
                {
                    panelDoiMK.Visible = false;
                    panelDoiMK.Left = 808;

                    panelDangNhap.Visible = false;
                    panelDangNhap.Left = 417;
                    panelDangNhap.Visible = true;
                    panelDangNhap.Refresh();
                }
                DangNhap_Load(sender, e);

            }
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = dt.NHANVIENs.Where(s => s.USERLOGIN == txtTaiKhoan.Text.Trim()).Where(s => s.PASSWORD == MaHoa(txtMatKhau.Text.Trim())).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Bạn Chưa Có Tài Khoản.\nBạn Cần Đăng Ký!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {

                MessageBox.Show("Chào Mừng Bạn Đến Với\nNVV Shop", "Thông Báo", MessageBoxButtons.OK);

                TTNV.MaNV =nv.MANHANVIEN ;
                
                Form1 f1 = new Form1();
                this.Hide(); 

                f1.Show();
            }
            
            
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMatKhau_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
