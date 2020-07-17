using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class FormBackUp : Form
    {
        public FormBackUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(QuanLyCuaHangXeMay.Properties.Settings.Default.QUANLICUAHANG_XEMAYConnectionString);
        int bk = 0;

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
                btn_BackUp.Enabled = true;
            }
        }
        private void backup()
        {
            string database = con.Database.ToString();
            if (txtPath.Text == string.Empty)
            {
                MessageBox.Show("please enter backup file location");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtPath.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (SqlCommand command = new SqlCommand(cmd, con))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("database backup done successefully");
                    btn_BackUp.Enabled = false;
                    if (bk == 2)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            bk++;
            string database = con.Database.ToString();

            try
            {
                if (txtPath.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtPath.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("database backup done successefully");
                        btn_BackUp.Enabled = false;
                        if (bk == 2)
                        {
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                DialogResult b = MessageBox.Show("Bạn có chắc chắn backup dữ liệu không ?", "Back up", MessageBoxButtons.YesNo);
                if (b == DialogResult.Yes)
                {
                    backup();
                    this.Close();
                }
            }
        }
    }
}
