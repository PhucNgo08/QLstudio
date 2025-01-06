namespace QLSTUDIO
{
    partial class frmDanceType
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
            this.dgvDanceType = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameDance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanceType)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanceType
            // 
            this.dgvDanceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgvDanceType.Location = new System.Drawing.Point(12, 12);
            this.dgvDanceType.Name = "dgvDanceType";
            this.dgvDanceType.Size = new System.Drawing.Size(389, 339);
            this.dgvDanceType.TabIndex = 0;
            this.dgvDanceType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanceType_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Nhay";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tên Loại nhảy";
            this.Column1.Name = "Column1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDele);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnFix);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(545, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 221);
            this.panel1.TabIndex = 1;
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(118, 127);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(75, 23);
            this.btnDele.TabIndex = 3;
            this.btnDele.Text = "Xóa";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(23, 127);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(74, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm ";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(118, 34);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameDance
            // 
            this.txtNameDance.Location = new System.Drawing.Point(499, 38);
            this.txtNameDance.Name = "txtNameDance";
            this.txtNameDance.Size = new System.Drawing.Size(100, 20);
            this.txtNameDance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ten loai nhay";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(423, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "quay lai";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDanceType
            // 
            this.ClientSize = new System.Drawing.Size(776, 413);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameDance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDanceType);
            this.Name = "frmDanceType";
            this.Text = "Dance type";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.dgvDanceType, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtNameDance, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanceType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanceType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameDance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnBack;
    }
}
