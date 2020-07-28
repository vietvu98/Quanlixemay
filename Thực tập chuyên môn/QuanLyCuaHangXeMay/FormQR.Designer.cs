namespace QuanLyCuaHangXeMay
{
    partial class FormQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQR));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtURL = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnKetNoi = new Guna.UI.WinForms.GunaButton();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.White;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.LineColor = System.Drawing.Color.SaddleBrown;
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.Size = new System.Drawing.Size(277, 47);
            this.txtURL.TabIndex = 0;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AnimationHoverSpeed = 0.07F;
            this.btnKetNoi.AnimationSpeed = 0.03F;
            this.btnKetNoi.BackColor = System.Drawing.Color.SlateGray;
            this.btnKetNoi.BaseColor = System.Drawing.Color.Silver;
            this.btnKetNoi.BorderColor = System.Drawing.Color.Black;
            this.btnKetNoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnKetNoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.ForeColor = System.Drawing.Color.Black;
            this.btnKetNoi.Image = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.Image")));
            this.btnKetNoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKetNoi.Location = new System.Drawing.Point(318, 12);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnKetNoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKetNoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKetNoi.OnHoverImage = null;
            this.btnKetNoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnKetNoi.Size = new System.Drawing.Size(193, 47);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kết nối ứng dụng";
            this.btnKetNoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(12, 81);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(552, 297);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 2;
            this.picQR.TabStop = false;
            this.picQR.Click += new System.EventHandler(this.picQR_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(531, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 3;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // FormQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 394);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQR";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtURL;
        private Guna.UI.WinForms.GunaButton btnKetNoi;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}