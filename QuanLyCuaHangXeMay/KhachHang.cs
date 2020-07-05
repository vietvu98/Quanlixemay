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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            //màu dòng chẵn
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //Mau o khi click
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //color chữ khi click
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.Red;
            //back groud
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Mau title
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
            //mau chu title
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dt.KH_SELECT();
        }
        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            a = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var r = dt.KH_SELECT().Where(s => s.MAKH == txtMaKH.Text.Trim()).FirstOrDefault();
            if (a == 1 && r == null)
            {
                dt.KH_INSERT(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, Convert.ToDouble(txtDienThoai.Text), txtEmail.Text);
                dgvKhachHang.AutoGenerateColumns = false;
                dgvKhachHang.DataSource = dt.KH_SELECT();
                a = 0;
            }
            else if (a == 1 && r != null)
            {
                DialogResult dtr = MessageBox.Show("Da co du lieu roi!", "Thong Bao", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtDiaChi.Text = "";
                    txtDienThoai.Text = "";
                    txtEmail.Text = "";
                }
            }
            else if (a == 2 && r != null)
            {
    
                dt.KH_UPDATE(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, Convert.ToDouble(txtDienThoai.Text), txtEmail.Text);
                dgvKhachHang.AutoGenerateColumns = false;
                dgvKhachHang.DataSource = dt.KH_SELECT();
                a = 0;
            }
            txtMaKH.Text = "";
            txtTenKH.Text = "";
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
            if (dtr == DialogResult.Yes)
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Ban chua chon thong tin de xoa!");
                }
                else
                {
                    dt.KH_DELETE(txtMaKH.Text);
                    dgvKhachHang.AutoGenerateColumns = false;
                    dgvKhachHang.DataSource = dt.KH_SELECT();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = dt.KH_SEARCH(txtSearch.Text);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
