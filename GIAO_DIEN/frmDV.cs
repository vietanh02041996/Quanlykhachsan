using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Khach_San.TRUY_VAN;
using Quan_Ly_Khach_San.DATABASE;

namespace Quan_Ly_Khach_San.GIAO_DIEN
{
    public partial class frmDV : Form
    {
        private DichVuDAO DV_DAO = new DichVuDAO();

        private DichVu DV = new DichVu();

        private bool _them = false;

        public frmDV()
        {
            InitializeComponent();
        }

        private void frmDV_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = DV_DAO.GetAll();
        }
        private void dgvDanhSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGia.Text = dgvDanhSach.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            txtMa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
            txtTen.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtTen.ResetText();
            txtMa.ResetText();
            txtGia.ResetText();
            dgvDanhSach.Enabled = false;
            txtGia.Enabled = true;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtTen.Enabled = true;
            txtGia.Enabled = true;
            dgvDanhSach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DV.MaDV = txtMa.Text;
            if (DV_DAO.XoaTTDichVu(DV) == 1)
            {
                //MessageBox.Show("Xóa thành công");
                dgvDanhSach.DataSource = DV_DAO.GetAll();
            }

            else
            {
                MessageBox.Show("Xóa thất bại. Có đối tượng đang sử dụng dịch vụ");
            }

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtGia.Enabled = false;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            dgvDanhSach.Enabled = true;
            _them = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                DV.MaDV = txtMa.Text;
                DV.TenDV = txtTen.Text;
                DV.Gia = txtGia.Text;
                if (!string.IsNullOrEmpty(txtMa.Text) && !string.IsNullOrEmpty(txtTen.Text))
                {
                    DV_DAO.ThemThongTin(DV);
                    MessageBox.Show("Thêm thành công");
                    dgvDanhSach.DataSource = DV_DAO.GetAll();
                }
                else MessageBox.Show("Bạn phải nhập đầy đủ thông tin dịch vụ!");

                _them = false;
            }
            else
            {
                DV.MaDV = txtMa.Text;
                DV.TenDV = txtTen.Text;
                DV.Gia = txtGia.Text;
                if (!string.IsNullOrEmpty(txtTen.Text))
                {
                    DV_DAO.SuaThongTin(DV);
                    MessageBox.Show("Sửa thành công");
                    dgvDanhSach.DataSource = DV_DAO.GetAll();
                }
                else MessageBox.Show("Tên dịch vụ không được bỏ trống!");
            }

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;

            txtGia.Enabled = false;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            _them = false;

            dgvDanhSach.Enabled = true;
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {

            string dk = "";
            dk = "MaDV like N'%" + txtTimMa.Text + "%'";

            dgvDanhSach.DataSource = DV_DAO.GetAll(dk);
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {

            string dk = "";
            dk = "TenDV like N'%" + txtTimTen.Text + "%'";

            dgvDanhSach.DataSource = DV_DAO.GetAll(dk);
        }

        // textbox giá chỉ được phép nhập số
        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTimMa_Click(object sender, EventArgs e)
        {
            txtTimTen.Clear();

        }

        private void txtTimTen_Click(object sender, EventArgs e)
        {
            txtTimMa.Clear();
        }
    }
}
