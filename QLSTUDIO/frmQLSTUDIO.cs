using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLSTUDIO
{
    public partial class frmQLSTUDIO : Form

    {
        public frmQLSTUDIO()
        {
            InitializeComponent();
        }

        private void btnLoaiNhay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDanceType frmDanceType = new frmDanceType();
            frmDanceType.ShowDialog();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHV frmHV = new frmHV();
            frmHV.ShowDialog();
        }
    }
}
