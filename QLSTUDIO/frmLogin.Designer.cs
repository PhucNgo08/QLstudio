namespace QLSTUDIO
{
    partial class frmLogin
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lbltdn = new System.Windows.Forms.Label();
            this.lblmk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(448, 339);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(245, 273);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(156, 20);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(245, 313);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(156, 20);
            this.txtMK.TabIndex = 2;
            // 
            // lbltdn
            // 
            this.lbltdn.AutoSize = true;
            this.lbltdn.Location = new System.Drawing.Point(149, 273);
            this.lbltdn.Name = "lbltdn";
            this.lbltdn.Size = new System.Drawing.Size(81, 13);
            this.lbltdn.TabIndex = 3;
            this.lbltdn.Text = "Tên đăng nhập";
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Location = new System.Drawing.Point(149, 316);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(53, 13);
            this.lblmk.TabIndex = 4;
            this.lblmk.Text = "Mật Khẩu";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSTUDIO.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lbltdn);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btn_Login);
            this.MaximumSize = new System.Drawing.Size(662, 443);
            this.MinimumSize = new System.Drawing.Size(662, 443);
            this.Name = "frmLogin";
            this.RightToLeftLayout = true;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lbltdn;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.Button btn_Login;
    }
}

