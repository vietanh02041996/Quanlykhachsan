using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San.GIAO_DIEN
{
    public partial class frmMain : Form
    {
        public static string _taikhoan = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form frmKH = new frmQuanLyKhachHang();
            frmKH.ShowDialog();
        }

		
		private void btnVatDung_Click(object sender, EventArgs e)
        {
            Form frmTB = new frmThietBi();
            frmTB.ShowDialog();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            Form DV = new frmDV();
            this.Hide();
            DV.ShowDialog();
            this.Show();
        }

		
		private void btnSuDungDV_Click(object sender, EventArgs e)
        {
            Form frmSD = new frmSuDungDV();
            this.Hide();
            frmSD.ShowDialog();
            this.Show();
        }

        

		

		private void restart_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form frmDN = new frmLogin();
            DialogResult tl;
            tl = frmDN.ShowDialog();
            if (tl != DialogResult.OK)
            {
                Application.Exit();
            }
        }

		private void btnPhong_Click(object sender, EventArgs e)
		{
			Form frmPhong = new frmPhong();
			frmPhong.ShowDialog();
		}

		private void btnThuePhong_Click(object sender, EventArgs e)
		{
			Form frmThue = new frmThuePhong();
			frmThue.ShowDialog();
		}

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form frmThanhToan = new frmThanhToan();
            frmThanhToan.ShowDialog();
        }
    }
}
