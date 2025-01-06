using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSTUDIO
{
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu lên DataGridView
        }

        // Hàm tải dữ liệu giảng viên
        private void LoadData()
        {
            using (var context = new QLSTUDIOEntities())
            {
                var teachers = context.Teacher
                    .Select(t => new
                    {
                        t.teacher_id,
                        t.teacher_name,
                        t.phone,
                        t.email,
                        DanceType = t.DanceType.dance_type_name
                    }).ToList();

                dgvGV.DataSource = teachers; // Gán dữ liệu cho DataGridView
            }
        }

        // Hàm kiểm tra đầu vào hợp lệ
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtphone.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                cboDanceType.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (var context = new QLSTUDIOEntities())
            {
                var newTeacher = new Teacher
                {
                    teacher_name = txtName.Text.Trim(),
                    phone = txtphone.Text.Trim(),
                    email = txtemail.Text.Trim(),
                    dance_type_id = ((DanceType)cboDanceType.SelectedItem).dance_type_id
                };

                context.Teacher.Add(newTeacher);
                context.SaveChanges();

                MessageBox.Show("Thêm giảng viên thành công!");
                LoadData(); // Làm mới dữ liệu
            
            }
        }

        private void btnfix_Click(object sender, EventArgs e)
        {
            if (dgvGV.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên để sửa!");
                return;
            }

            if (!ValidateInput()) return;

            int teacherId = (int)dgvGV.CurrentRow.Cells["teacher_id"].Value;

            using (var context = new QLSTUDIOEntities())
            {
                var teacher = context.Teacher.FirstOrDefault(t => t.teacher_id == teacherId);
                if (teacher != null)
                {
                    teacher.teacher_name = txtName.Text.Trim();
                    teacher.phone = txtphone.Text.Trim();
                    teacher.email = txtemail.Text.Trim();
                    teacher.dance_type_id = ((DanceType)cboDanceType.SelectedItem).dance_type_id;

                    context.SaveChanges();

                    MessageBox.Show("Cập nhật giảng viên thành công!");
                    LoadData(); // Làm mới dữ liệu
                }
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            if (dgvGV.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên để xóa!");
                return;
            }

            int teacherId = (int)dgvGV.CurrentRow.Cells["teacher_id"].Value;
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (var context = new QLSTUDIOEntities())
            {
                var teacher = context.Teacher.FirstOrDefault(t => t.teacher_id == teacherId);
                if (teacher != null)
                {
                    // Kiểm tra xem giảng viên có đang được tham chiếu trong các bảng khác
                    if (context.DanceRoom.Any(d => d.teacher_id == teacherId))
                    {
                        MessageBox.Show("Không thể xóa giảng viên vì có phòng khiêu vũ liên kết!");
                        return;
                    }

                    context.Teacher.Remove(teacher);
                    context.SaveChanges();

                    MessageBox.Show("Xóa giảng viên thành công!");
                    LoadData(); // Làm mới dữ liệu
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtfind.Text.Trim();

            using (var context = new QLSTUDIOEntities())
            {
                var result = context.Teacher
                    .Where(t => t.teacher_name.Contains(keyword) || t.phone.Contains(keyword))
                    .Select(t => new
                    {
                        t.teacher_id,
                        t.teacher_name,
                        t.phone,
                        t.email,
                        DanceType = t.DanceType.dance_type_name
                    }).ToList();

                dgvGV.DataSource = result;

                if (!result.Any())
                {
                    MessageBox.Show("Không tìm thấy giảng viên nào phù hợp!");
                }
            }
        }
             // Hàm xóa dữ liệu nhập trong các TextBox và ComboBox
        private void ClearInput()
        {
            txtName.Clear();
            txtphone.Clear();
            txtemail.Clear();
            cboDanceType.SelectedIndex = -1;
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGV.CurrentRow != null)
            {
                txtName.Text = dgvGV.CurrentRow.Cells["teacher_name"].Value.ToString();
                txtphone.Text = dgvGV.CurrentRow.Cells["phone"].Value.ToString();
                txtemail.Text = dgvGV.CurrentRow.Cells["email"].Value.ToString();
                cboDanceType.Text = dgvGV.CurrentRow.Cells["DanceType"].Value.ToString();
            }
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

        private void cboDanceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDanceType.SelectedItem = cboDanceType.Items
        .Cast<DanceType>()
        .FirstOrDefault(d => d.dance_type_name == dgvGV.CurrentRow.Cells["DanceType"].Value.ToString());

        }
    }
}
