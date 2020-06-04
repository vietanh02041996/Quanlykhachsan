using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Khach_San.DATABASE;
using Quan_Ly_Khach_San.TRUY_VAN;
namespace Quan_Ly_Khach_San.GIAO_DIEN
{
    public partial class frmThanhToan : Form
    {
        PhongF dalPh = new PhongF();
        KetNoiData cn = new KetNoiData();
        HoaDon ecHD = new HoaDon();
        HoaDonF dalHD = new HoaDonF();
        private int _Gia;
        public frmThanhToan()
        {
            InitializeComponent();
        }
        public static int getCost(DateTime dateIn, DateTime dateOut, int cost)
        {
            TimeSpan Time = dateOut - dateIn;
            int sum = Time.Days;
            return sum * cost;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            DataTable tb = cn.GetDataTable("Select * from tblKhachHang");
            cmbKhachhang.DataSource = tb;
            cmbKhachhang.ValueMember = "MaKH";
            cmbKhachhang.DisplayMember = "tenKH";
            SetValueFor_dgvThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = cn.GetDataTable("Select distinct h.MaHD from tblKhachHang k, tblHoaDon h, tblPhieuThue p where k.MaKH = p.MaKH and p.MaPhieu = h.MaPhieuThue and k.MaKH='" + cmbKhachhang.SelectedValue.ToString() + "'");
            cmbMahd.DataSource = tb;
            cmbMahd.DisplayMember = "MaHD";
        }

        private void cmbMahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetValueFor_dgvThongTin();
        }

        private void SetValueFor_dgvThongTin()
        {
            DataTable tb = dalHD.ThongTinThanhToan(cmbMahd.Text);
            dgvThongtin.DataSource = tb;
            dtpNgayVao.Text = cn.GetValue(@"select NgayVao from tblHoaDon where MaHD = '" + cmbMahd.Text + "'");
            dtpNgayra.Text = cn.GetValue(@"select NgayRa from tblHoaDon where MaHD = '" + cmbMahd.Text + "'");
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dgvThongtin.Rows.Count; i++)
                {
                    sum += int.Parse(dgvThongtin.Rows[i].Cells["Gia"].Value.ToString());//tính tổng tiền dịch vụ
                }
                _Gia = int.Parse(cn.GetValue(@"select DonGiaHT from tblHoaDon where MaHD = '" + cmbMahd.Text + "'"));
                sum += getCost(dtpNgayVao.Value, dtpNgayra.Value, _Gia); // tính tổng tiền cần phải thanh toán
                MessageBox.Show("Tổng số tiền thanh toán: " + sum.ToString());
                //xoa dich vu
                cn.ThucHienLenh("delete tblSuDungDV where MaHD = '" + cmbMahd.Text + "'");
                //update hoa don - bang hoa don trong csdl
                ecHD.ThanhTien = sum;
                ecHD.MaHD = cmbMahd.Text;
                dalHD.XoaTTHoaDon(ecHD);
                //thay doi thong tin phong -trả lại phòng về trạng thái ban đầu , trạng thái tốt
                Phong ph = new Phong();
                ph.MaPh = cn.GetValue(@"select MaPh from tblPhieuThue where MaPhieu = '" + cmbMahd.Text + "'");
                ph.TrangThai = "Tốt";
                dalPh.TraPhong(ph);
                cmbKhachhang.ResetText();
                cmbMahd.ResetText();
                dgvThongtin.DataSource = null;
            }
            catch (Exception)
            {
                
            }
        }
    }
}