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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text;
            string password = txtMK.Text;

            // Kết nối đến cơ sở dữ liệu bằng Entity Framework
            using (var context = new QLSTUDIOEntities())
            {
                var admin = context.Admin
                                   .FirstOrDefault(a => a.username == username && a.password == password);

                if (admin != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    // Mở form quản lý chính (QLStudio Form)
                    this.Hide();
                    // Mở form QLSTUDIO
                    Form frmQLSTUDIO = new frmQLSTUDIO();
                    frmQLSTUDIO.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
           this.Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
   
