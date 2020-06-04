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

namespace Quan_Ly_Khach_San.GIAO_DIEN
{
    public partial class frmSuDungDV : Form
    {
        DataTable data;
        private SuDungDichVuDAO DAL_SuDung = new SuDungDichVuDAO();
        private SuDungDichVu SuDung = new SuDungDichVu();
        private int _dong;
        private bool _chon = false;
        private bool _them = false;
        private bool _xoa = false;
        private bool _koload = true;

        public frmSuDungDV()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_chon)
            {
                labNgay.Text = DateTime.Today.ToShortDateString();
                labGio.Text = DateTime.Now.ToLongTimeString();
            }
        }

        private void frmSuDungDV_Load(object sender, EventArgs e)
        {
            _koload = false;
            

            DataTable tb = DAL_SuDung.getPhong();
            cboPhong.DataSource = tb;
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "MaPh";
            //AutoCoplete thêm gợi ý để hoàn thành textbox khi nhập
            var source = new AutoCompleteStringCollection();
            for (int _i = 0; _i < tb.Rows.Count; _i++) source.Add(tb.Rows[_i]["SoPhong"].ToString());
            cboPhong.AutoCompleteCustomSource = source;

            tb = DAL_SuDung.getDV();
            cboDichVu.DataSource = tb;
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
            //AutoCoplete thêm gợi ý để hoàn thành textbox khi nhập
            var source2 = new AutoCompleteStringCollection();
            for (int _i = 0; _i < tb.Rows.Count; _i++) source2.Add(tb.Rows[_i]["TenDV"].ToString());
            cboDichVu.AutoCompleteCustomSource = source2;

            data = DAL_SuDung.getDanhSach();
            dgvDanhSach.DataSource = data;
            if (dgvDanhSach.RowCount != 0) btnXoa.Enabled = true;
            _koload = true;
        }

        private void dgvDanhSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_koload) timer1.Enabled = false;
            cboDichVu.SelectedIndex = -1;
            cboDichVu.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenPhong"].Value.ToString();
            txtHoaDon.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            string s = dgvDanhSach.Rows[e.RowIndex].Cells["ThoiGian"].Value.ToString();
            labNgay.Text = s.Substring(0, 11);
            labGio.Text = s.Substring(11, s.Length - 11);
            _dong = e.RowIndex;
        }



        private void cboPhong_Validated(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null)
            {
                MessageBox.Show("Không có Phòng");
                //cboPhong.Focus();
                return;
            }
            txtHoaDon.Text = DAL_SuDung.getMaHD(cboPhong.Text);
            if (txtHoaDon.Text == null)
            {
                MessageBox.Show("Phòng chưa được thuê");
                cboPhong.Focus();
            }
        }

        private void cboDichVu_Validated(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedValue == null)
            {
                MessageBox.Show("Không có Dich vụ");
                cboDichVu.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            cboDichVu.Enabled = false;
            cboPhong.Enabled = false;
            txtTimPhong.Clear();
            txtTimDV.Clear();
            timer1.Enabled = true;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
            timer1.Enabled = false;
            cboPhong.Enabled = true;
            cboDichVu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cboPhong.ResetText();
            cboDichVu.ResetText();
            txtHoaDon.ResetText();
            _them = true;
            btnXoa.Enabled = false;


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SuDung.MaDV = cboDichVu.SelectedValue.ToString();
            SuDung.MaHD = txtHoaDon.Text;


            SuDung.ThoiGian = DateTime.Now;

            DichVuDAO DichVuDAO = new DichVuDAO();
            SuDung.Gia = DichVuDAO.GetGia(cboDichVu.SelectedValue.ToString());

            DAL_SuDung.addSuDung(SuDung);
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();

            _them = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            timer1.Enabled = true;
            cboPhong.Enabled = false;
            cboDichVu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _xoa = true;
            string temp = dgvDanhSach.Rows[_dong].Cells["ThoiGian"].Value.ToString();
            
            SuDung.ThoiGian = DateTime.Parse( temp);
            SuDung.MaDV = cboDichVu.SelectedValue.ToString();
            SuDung.MaHD = txtHoaDon.Text;

            DAL_SuDung.delSuDung(SuDung);
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();

            timer1.Enabled = true;

            if (dgvDanhSach.RowCount == 0) btnXoa.Enabled = false;
            _xoa = false;

        }

        private void txtTimPhong_Click(object sender, EventArgs e)
        {
            
            txtTimDV.Text = "";
        }

        private void txtTimDV_Click(object sender, EventArgs e)
        {
            txtTimPhong.Text = "";
        }

        private void txtTimPhong_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[SoPhong] like '%{0}%'", txtTimPhong.Text);
            data.DefaultView.RowFilter = st;
        }

        private void txtTimDV_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[TenDV] like '%{0}%'", txtTimDV.Text);
            data.DefaultView.RowFilter = st;
        }
    }
}
