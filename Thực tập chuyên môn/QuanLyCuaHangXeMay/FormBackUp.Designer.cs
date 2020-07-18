namespace QuanLyCuaHangXeMay
{
    partial class FormBackUp
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
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btn_BackUp = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_Browser = new Guna.UI.WinForms.GunaGradientButton();
            this.txtPath = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.gunaControlBox1);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel4);
            this.gunaElipsePanel2.Controls.Add(this.btn_BackUp);
            this.gunaElipsePanel2.Controls.Add(this.btn_Browser);
            this.gunaElipsePanel2.Controls.Add(this.txtPath);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(12, 12);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(340, 263);
            this.gunaElipsePanel2.TabIndex = 36;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(293, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 28);
            this.gunaControlBox1.TabIndex = 38;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(89, 32);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(167, 37);
            this.gunaLabel4.TabIndex = 35;
            this.gunaLabel4.Text = "Backup Data";
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.AnimationHoverSpeed = 0.07F;
            this.btn_BackUp.AnimationSpeed = 0.03F;
            this.btn_BackUp.BaseColor1 = System.Drawing.Color.Gainsboro;
            this.btn_BackUp.BaseColor2 = System.Drawing.Color.Azure;
            this.btn_BackUp.BorderColor = System.Drawing.Color.Black;
            this.btn_BackUp.FocusedColor = System.Drawing.Color.Empty;
            this.btn_BackUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackUp.ForeColor = System.Drawing.Color.Black;
            this.btn_BackUp.Image = null;
            this.btn_BackUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_BackUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BackUp.Location = new System.Drawing.Point(173, 186);
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.btn_BackUp.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(255)))));
            this.btn_BackUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BackUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BackUp.OnHoverImage = null;
            this.btn_BackUp.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BackUp.Size = new System.Drawing.Size(154, 42);
            this.btn_BackUp.TabIndex = 36;
            this.btn_BackUp.Text = "BackUp";
            this.btn_BackUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // btn_Browser
            // 
            this.btn_Browser.AnimationHoverSpeed = 0.07F;
            this.btn_Browser.AnimationSpeed = 0.03F;
            this.btn_Browser.BaseColor1 = System.Drawing.Color.Gainsboro;
            this.btn_Browser.BaseColor2 = System.Drawing.Color.Azure;
            this.btn_Browser.BorderColor = System.Drawing.Color.Black;
            this.btn_Browser.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Browser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browser.ForeColor = System.Drawing.Color.Black;
            this.btn_Browser.Image = null;
            this.btn_Browser.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Browser.Location = new System.Drawing.Point(7, 186);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.btn_Browser.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(255)))));
            this.btn_Browser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Browser.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Browser.OnHoverImage = null;
            this.btn_Browser.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Browser.Size = new System.Drawing.Size(154, 42);
            this.btn_Browser.TabIndex = 37;
            this.btn_Browser.Text = "Browser";
            this.btn_Browser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.Transparent;
            this.txtPath.BaseColor = System.Drawing.Color.White;
            this.txtPath.BorderColor = System.Drawing.Color.Silver;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.Enabled = false;
            this.txtPath.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPath.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPath.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPath.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(7, 103);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.Size = new System.Drawing.Size(320, 42);
            this.txtPath.TabIndex = 34;
            // 
            // FormBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 290);
            this.Controls.Add(this.gunaElipsePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBackUp";
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGradientButton btn_BackUp;
        private Guna.UI.WinForms.GunaGradientButton btn_Browser;
        private Guna.UI.WinForms.GunaTextBox txtPath;
    }
}