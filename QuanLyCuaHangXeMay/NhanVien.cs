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
    public partial class NhanVien : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUCVUDataSet.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.cHUCVUDataSet.CHUCVU);
          

            //màu dòng chẵn
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //Mau o khi click
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //color chữ khi click
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.Red;
            //back groud
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Mau title
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 226);
            //mau chu title
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dt.NHANVIENs;
            cbbChucvu.DisplayMember = "TENCHUCVU";
            cbbChucvu.ValueMember = "MACV";
            cbbChucvu.DataSource = dt.CHUCVUs.ToList();
            lblTK.Visible = false;
            lblMK.Visible = false;
            txtTaiKhoan.Visible = false;
            txtMatKhau.Visible = false;
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            NHANVIEN nv = dt.NHANVIENs.Where(s => s.MANHANVIEN == txtMaNV.Text.ToString()).FirstOrDefault();
            txtTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(nv.NGAYSINH);

            txtQueQuan.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            cbbChucvu.SelectedValue = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            if (dgvNhanVien.Rows[i].Cells[6].Value.ToString() == "Nam")
            {
                rdtNam.Checked = true;
            }
            else
            {
                rdtNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
