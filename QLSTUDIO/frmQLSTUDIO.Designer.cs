namespace QLSTUDIO
{
    partial class frmQLSTUDIO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.btnDKHP = new System.Windows.Forms.Button();
            this.btnLichHoc = new System.Windows.Forms.Button();
            this.btnHocVien = new System.Windows.Forms.Button();
            this.btnLoaiNhay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDiemDanh);
            this.panel1.Controls.Add(this.btnDKHP);
            this.panel1.Controls.Add(this.btnLichHoc);
            this.panel1.Controls.Add(this.btnHocVien);
            this.panel1.Controls.Add(this.btnLoaiNhay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 296);
            this.panel1.TabIndex = 0;
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(31, 56);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(116, 23);
            this.btnGV.TabIndex = 7;
            this.btnGV.Text = "Giáo Viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý ";
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Location = new System.Drawing.Point(31, 219);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(116, 23);
            this.btnDiemDanh.TabIndex = 5;
            this.btnDiemDanh.Text = "Điểm Danh";
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            // 
            // btnDKHP
            // 
            this.btnDKHP.Location = new System.Drawing.Point(31, 258);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Size = new System.Drawing.Size(116, 23);
            this.btnDKHP.TabIndex = 4;
            this.btnDKHP.Text = "Đăng Ký Học phần";
            this.btnDKHP.UseVisualStyleBackColor = true;
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.Location = new System.Drawing.Point(31, 177);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.Size = new System.Drawing.Size(116, 23);
            this.btnLichHoc.TabIndex = 3;
            this.btnLichHoc.Text = "Lịch Học";
            this.btnLichHoc.UseVisualStyleBackColor = true;
            // 
            // btnHocVien
            // 
            this.btnHocVien.Location = new System.Drawing.Point(31, 139);
            this.btnHocVien.Name = "btnHocVien";
            this.btnHocVien.Size = new System.Drawing.Size(116, 23);
            this.btnHocVien.TabIndex = 2;
            this.btnHocVien.Text = "Học Viên";
            this.btnHocVien.UseVisualStyleBackColor = true;
            // 
            // btnLoaiNhay
            // 
            this.btnLoaiNhay.Location = new System.Drawing.Point(31, 97);
            this.btnLoaiNhay.Name = "btnLoaiNhay";
            this.btnLoaiNhay.Size = new System.Drawing.Size(116, 23);
            this.btnLoaiNhay.TabIndex = 0;
            this.btnLoaiNhay.Text = "Loại nhảy";
            this.btnLoaiNhay.UseVisualStyleBackColor = true;
            this.btnLoaiNhay.Click += new System.EventHandler(this.btnLoaiNhay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Phòng Tập";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmQLSTUDIO
            // 
            this.ClientSize = new System.Drawing.Size(821, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "frmQLSTUDIO";
            this.Text = "QLSTUDIO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.Button btnDKHP;
        private System.Windows.Forms.Button btnLichHoc;
        private System.Windows.Forms.Button btnHocVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoaiNhay;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Label label1;
    }
}
