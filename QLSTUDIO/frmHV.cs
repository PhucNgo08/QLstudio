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

namespace QLSTUDIO
{
    public partial class frmHV : Form
    {
        public frmHV()
        {
            InitializeComponent();
        }

   
        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn quay lại?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Form frmQLSTUDIO = Application.OpenForms["QLSTUDIO"];

                if (frmQLSTUDIO != null)
                {
                    frmQLSTUDIO.Show();  // Hiển thị lại form TQL
                }
                else
                {
                    // Nếu form chính không tồn tại, khởi tạo lại
                    frmQLSTUDIO = new frmQLSTUDIO();
                    frmQLSTUDIO.Show();
                }

                this.Close();  // Đóng form đăng ký
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtphone.Text) ||
        string.IsNullOrWhiteSpace(txtemail.Text) ||
        cboGT.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (var context = new QLSTUDIOEntities())
            {
                var newMember = new Member
                {
                    name = txtName.Text.Trim(),
                    phone = txtphone.Text.Trim(),
                    email = txtemail.Text.Trim(),
                    gender = cboGT.SelectedItem.ToString(),
                    dob = dtpDate.Value
                };

                context.Member.Add(newMember);
                context.SaveChanges();

                MessageBox.Show("Thêm học viên thành công!");
                LoadMembers(); // Làm mới danh sách học viên
            }
        }
        private void LoadMembers()
        {
            using (var context = new QLSTUDIOEntities())
            {
                var members = context.Member
                    .Select(m => new
                    {
                        m.member_id,
                        m.name,
                        m.phone,
                        m.email,
                        m.gender,
                        m.dob
                    })
                    .ToList();

                dgvMember.DataSource = members; // Giả sử dgvMembers là tên của DataGridView
            }
        }

        private void frmHV_Load(object sender, EventArgs e)
        {
            cboGT.Items.Add("Nam");
            cboGT.Items.Add("Nữ");
            cboGT.SelectedIndex = 0; // Chọn mặc định
        }
    }
}
