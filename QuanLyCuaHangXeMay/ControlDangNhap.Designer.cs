﻿namespace QuanLyCuaHangXeMay
{
    partial class ControlDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDangNhap));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Yellow;
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(-81, -148);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 300;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1113, 668);
            this.gunaElipsePanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 74);
            this.label1.TabIndex = 10;
            this.label1.Text = "MotorCycle Store\r\nMang Những Chiếc Xe Về Ngôi Nhà Của Bạn\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox2.Image")));
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(781, 458);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(150, 150);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 7;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // ControlDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 610);
            this.Controls.Add(this.gunaTransfarantPictureBox2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlDangNhap";
            this.Text = "ControlDangNhap";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
    }
}