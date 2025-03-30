using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs.GUI
{
    public partial class ThongTinTaiKhoan : UserControl
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }


        private void ToggleEditMode(bool isEditing)
        {
            pnSua.Visible = !isEditing;
            pnHuyLuu.Visible = isEditing;

            txtHoTen.ReadOnly = txtSDT.ReadOnly = txtEmail.ReadOnly = !isEditing;
            txtHoTen.BorderStyle = txtSDT.BorderStyle = txtEmail.BorderStyle = isEditing ? BorderStyle.FixedSingle : BorderStyle.None;

            Color backColor = isEditing ? Color.White : Color.FromArgb(245, 245, 245);
            txtHoTen.BackColor = txtSDT.BackColor = txtEmail.BackColor = backColor;

            dtpNgaySinh.Enabled = isEditing;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ToggleEditMode(false);
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            //
        }

        private void lblSLNhacNho_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnXemMuon_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
