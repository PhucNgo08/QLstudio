using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace QLSTUDIO
{
    public partial class frmDanceType : QLSTUDIO.frmQLSTUDIO
    {
        public frmDanceType()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu lên DataGridView
        }

        private void LoadData()
        {
            using (var context = new QLSTUDIOEntities())
            {
                // Tắt lazy loading nếu cần
                context.Configuration.LazyLoadingEnabled = false;

                // Sử dụng eager loading nếu DanceType có liên kết khác
                var danceTypes = context.DanceType.ToList(); // Lấy danh sách loại nhảy
                dgvDanceType.DataSource = danceTypes; // Hiển thị lên DataGridView
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string danceTypeName = txtNameDance.Text;
            if (!string.IsNullOrEmpty(danceTypeName))
            {
                using (var context = new QLSTUDIOEntities())
                {
                    var newDanceType = new DanceType
                    {
                        dance_type_name = danceTypeName
                    };
                    context.DanceType.Add(newDanceType);
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    MessageBox.Show("Loại nhảy đã được thêm thành công!");

                    LoadData(); // Làm mới lại DataGridView
                }
            }
            else
            {
                MessageBox.Show("Tên loại nhảy không được để trống!");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvDanceType.CurrentCell?.RowIndex ?? -1; // Kiểm tra null
            if (selectedRowIndex >= 0)
            {
                int danceTypeId = (int)dgvDanceType.Rows[selectedRowIndex].Cells[0].Value;
                string danceTypeName = txtNameDance.Text;

                if (!string.IsNullOrEmpty(danceTypeName))
                {
                    using (var context = new QLSTUDIOEntities())
                    {
                        var danceType = context.DanceType.FirstOrDefault(dt => dt.dance_type_id == danceTypeId);
                        if (danceType != null)
                        {
                            danceType.dance_type_name = danceTypeName;
                            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                            MessageBox.Show("Loại nhảy đã được cập nhật!");

                            LoadData(); // Làm mới lại DataGridView
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tên loại nhảy không được để trống!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại nhảy để sửa.");
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ô nào được chọn hay không
            if (dgvDanceType.CurrentCell != null && dgvDanceType.CurrentCell.RowIndex >= 0)
            {
                int selectedRowIndex = dgvDanceType.CurrentCell.RowIndex;

                if (dgvDanceType.Rows[selectedRowIndex].Cells[0].Value != null &&
                    int.TryParse(dgvDanceType.Rows[selectedRowIndex].Cells[0].Value.ToString(), out int danceTypeId))
                {
                    using (var context = new QLSTUDIOEntities())
                    {
                        var danceType = context.DanceType.FirstOrDefault(dt => dt.dance_type_id == danceTypeId);
                        if (danceType != null)
                        {
                            context.DanceType.Remove(danceType);
                            context.SaveChanges();
                            MessageBox.Show("Loại nhảy đã được xóa!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại nhảy để xóa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một hàng dữ liệu hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }

        private void dgvDanceType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Loại bỏ truy vấn không cần thiết tại sự kiện này
            if (e.RowIndex >= 0) // Đảm bảo không phải hàng tiêu đề
            {
                var clickedCell = dgvDanceType.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Hiển thị giá trị của ô đã nhấp
                MessageBox.Show("Giá trị ô đã nhấp: " + clickedCell.Value.ToString());
            }
            dgvDanceType.AllowUserToAddRows = false;
            dgvDanceType.AutoGenerateColumns = true;
            if (e.RowIndex >= 0 && dgvDanceType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var clickedCell = dgvDanceType.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                MessageBox.Show("Giá trị ô đã nhấp: " + clickedCell.ToString());
            }


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtNameDance.Text.Trim(); // Lấy giá trị từ TextBox

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                using (var context = new QLSTUDIOEntities())
                {
                    // Tìm kiếm loại nhảy chứa từ khóa
                    var filteredDanceTypes = context.DanceType
                        .Where(dt => dt.dance_type_name.Contains(searchKeyword))
                        .ToList();

                    if (filteredDanceTypes.Any())
                    {
                        dgvDanceType.DataSource = filteredDanceTypes; // Hiển thị kết quả tìm kiếm
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại nhảy nào phù hợp!");
                        dgvDanceType.DataSource = null; // Xóa kết quả hiển thị cũ
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
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
    }
}
