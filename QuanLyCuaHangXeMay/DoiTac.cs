using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class DoiTac : Form
    {
        
        public DoiTac()
        {
            InitializeComponent();
        }
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        private void btnXemCT_Click(object sender, EventArgs e)
        {

            if (panelChiTietDatHang.Left == 987)
            {
                panelThongTinDT.Visible = false;
                panelThongTinDT.Left = 987;

                panelChiTietDatHang.Visible = false;
                panelChiTietDatHang.Left = 317;
                panelChiTietDatHang.Visible = true;
                panelChiTietDatHang.Refresh();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (panelThongTinDT.Left == 987)
            {
                panelChiTietDatHang.Visible = false;
                panelChiTietDatHang.Left = 987;

                panelThongTinDT.Visible = false;
                panelThongTinDT.Left = 317;
                panelThongTinDT.Visible = true;
                panelThongTinDT.Refresh();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
            if (a.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = new Bitmap(a.FileName);
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void DoiTac_Load(object sender, EventArgs e)
        {
            //màu dòng chẵn
            dgvDoiTac.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvDoiTac.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //Mau o khi click
            dgvDoiTac.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //color chữ khi click
            dgvDoiTac.DefaultCellStyle.SelectionForeColor = Color.Red;
            //back groud
             dgvDoiTac.BackgroundColor = Color.White;
            dgvDoiTac.EnableHeadersVisualStyles = false;
            dgvDoiTac.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Mau title
            dgvDoiTac.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
            //mau chu title
            dgvDoiTac.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;




            ////màu dòng chẵn
            //dgvDoiTac.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //dgvDoiTac.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ////Mau o khi click
            //dgvDoiTac.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ////color chữ khi click
            //dgvDoiTac.DefaultCellStyle.SelectionForeColor = Color.Red;
            ////back groud
            //dgvDoiTac.BackgroundColor = Color.FromArgb(51, 51, 76);



            //dgvDoiTac.EnableHeadersVisualStyles = false;
            ////      dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ////Mau title
            //dgvDoiTac.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
            ////mau chu title
            //dgvDoiTac.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ////font size data gridview
            //dgvDoiTac.DefaultCellStyle.Font = new Font("Tahoma", 12);
            ////// font title datagridview
            //dgvDoiTac.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15);
            ////borderstyle header
            //dgvDoiTac.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dgvDoiTac.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ////dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            ////text header center
            //dgvDoiTac.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ////color border
            //dgvDoiTac.GridColor = Color.Aqua;
            ////forecoloe datagridview
            dgvDoiTac.RowTemplate.Height = 40;
            dgvDoiTac.AutoGenerateColumns = false;
            dgvDoiTac.DataSource = dt.NHACUNGCAPs;     
            
        }
        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            ptbAnh.Image = null;
            btnLuu.Enabled = true;
            btnChonAnh.Enabled = true;
            txtMaDT.Enabled = true;
            txtMaDT.Focus();
            a=1;
        }

        private void dgvDoiTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDoiTac.Columns[e.ColumnIndex].Name == "xem")
            {
                label6.Text = dgvDoiTac.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (panelChiTietDatHang.Left == 987)
                {
                    panelThongTinDT.Visible = false;
                    panelThongTinDT.Left = 987;

                    panelChiTietDatHang.Visible = false;
                    panelChiTietDatHang.Left = 317;
                    panelChiTietDatHang.Visible = true;
                    panelChiTietDatHang.Refresh();
                }
            }
        }

        private void dgvDoiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDoiTac.CurrentRow.Index;
            txtMaDT.Text = dgvDoiTac.Rows[i].Cells[0].Value.ToString();
            txtTenDT.Text = dgvDoiTac.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDoiTac.Rows[i].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvDoiTac.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvDoiTac.Rows[i].Cells[4].Value.ToString();
            NHACUNGCAP ncc = dt.NHACUNGCAPs.Where(s => s.MANHACUNGCAP == txtMaDT.Text).FirstOrDefault();
            if(ncc == null || ncc.HINHANH == null)
            {
                ptbAnh.Image = null;
            }
            else
            {
                MemoryStream stream = new MemoryStream(ncc.HINHANH.ToArray());
                Image image = Image.FromStream(stream);
                if(image == null)
                {
                    return;
                }
                else
                {
                    ptbAnh.Image = image;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaDT.Enabled = false;
            txtTenDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnChonAnh.Enabled = true;
            a = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var r = dt.NCC_SELECT().Where(s => s.MANHACUNGCAP == txtMaDT.Text.Trim()).FirstOrDefault();
            if(a == 1 && r == null)
            {
                MemoryStream stream = new MemoryStream();
                ptbAnh.Image.Save(stream, ImageFormat.Jpeg);
                dt.NCC_INSERT(txtMaDT.Text, txtTenDT.Text, txtDiaChi.Text, Convert.ToDouble(txtDienThoai.Text), txtEmail.Text, stream.ToArray());
                dgvDoiTac.AutoGenerateColumns = false;
                dgvDoiTac.DataSource = dt.NCC_SELECT();
                a = 0;
            }
            else if(a==1 && r != null)
            {
                DialogResult dtr = MessageBox.Show("Da co du lieu roi!", "Thong Bao", MessageBoxButtons.OK);
                if(dtr == DialogResult.OK)
                {
                    txtMaDT.Text = "";
                    txtTenDT.Text = "";
                    txtDiaChi.Text = "";
                    txtDienThoai.Text = "";
                    txtEmail.Text = "";
                }
            }
            else if(a==2 && r!=null)
            {
                MemoryStream stream = new MemoryStream();
                ptbAnh.Image.Save(stream, ImageFormat.Jpeg);
                dt.NCC_UPDATE(txtMaDT.Text, txtTenDT.Text, txtDiaChi.Text, Convert.ToDouble(txtDienThoai.Text), txtEmail.Text, stream.ToArray());
                dgvDoiTac.AutoGenerateColumns = false;
                dgvDoiTac.DataSource = dt.NCC_SELECT();
                a = 0;
            }
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dtr = MessageBox.Show("Ban co muon xoa khong!", "Thong bao", MessageBoxButtons.YesNo);
            if( dtr == DialogResult.Yes)
            {
                if(txtMaDT.Text == "")
                {
                    MessageBox.Show("Ban chua chon thong tin de xoa!");
                }
                else
                {
                    dt.NCC_DELETE(txtMaDT.Text);
                    dgvDoiTac.AutoGenerateColumns = false;
                    dgvDoiTac.DataSource = dt.NCC_SELECT();
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void panelChiTietDatHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDoiTac.AutoGenerateColumns = false;
            dgvDoiTac.DataSource = dt.NCC_SEARCH(txtSearch.Text);
        }
    }
}
