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
	public partial class frmThuePhong : Form
	{
		PhongF dalPh = new PhongF();
		KetNoiData cn = new KetNoiData();
		PhieuThue ecPT = new PhieuThue();
		HoaDon ecHD = new HoaDon();
		HoaDonF dalHD = new HoaDonF();
		private string _Gia;
		private bool _load;
		public frmThuePhong()
		{
			InitializeComponent();
		}
		public static string findCode(string name, string columnSrc, string columnDes, DataTable tb)
		{
			for (int i = 0; i < tb.Rows.Count; i++)
			{
				if (tb.Rows[i][columnSrc].ToString() == name) return tb.Rows[i][columnDes].ToString();
			}
			return null;
		}
		private void frmThuePhong_Load(object sender, EventArgs e)
		{
            ckcChuabiet.Hide();
			_load = true;
			DateTime date = DateTime.Today.AddDays(0);
			dtpNgayvao.Value = date;
			//load dgvThongTin
			DataTable tb = dalPh.ThongTinPhong("");
			dgvThongtin.DataSource = tb;
			for (int i = 0; i < dgvThongtin.RowCount; i++)
			{
				dgvThongtin.Rows[i].Cells["STT"].Value = i + 1;
				if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Tốt") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
				else
					if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Đã thuê") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
				else
						if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Hỏng") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.Red;
			}
			//load smbKhachhang
			tb = cn.GetDataTable("Select distinct MaKH, tenKH from tblKhachHang");
			cmbKhachhang.DataSource = tb;
			cmbKhachhang.DisplayMember = "tenKH";
			txtMaKH.Text = findCode(cmbKhachhang.Text, "TenKH", "MaKH", tb);

			////load Phuongthuc
			tb = cn.GetDataTable("Select distinct MaPT, TenPT from tblPhuongThucThue");
			cmbPhuongthuc.DataSource = tb;
			cmbPhuongthuc.DisplayMember = "TenPT";
			cmbPhuongthuc.ValueMember = "MaPT";
			cmbPhuongthuc.ResetText();
			txtMaPT.Text = findCode(cmbPhuongthuc.Text, "TenPT", "MaPT", tb);

			//lay dl vao ec

			ecHD.NgayVao = dtpNgayvao.Value.Year.ToString() + "-" + dtpNgayvao.Value.Month.ToString() + "-" + dtpNgayvao.Value.Day.ToString();
			_load = false;
		}

		private void cmbKhachhang_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable tb = cn.GetDataTable("Select distinct MaKH, tenKH from tblKhachHang");
			txtMaKH.Text = findCode(cmbKhachhang.Text, "TenKH", "MaKH", tb);
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dgvThongtin.RowCount; i++)
			{
				dgvThongtin.Rows[i].Cells["Thue"].Value = false;
			}
		}

		private void btnThue_Click(object sender, EventArgs e)
		{
            if(string.IsNullOrWhiteSpace(cmbPhuongthuc.Text))
            {
                MessageBox.Show("Bạn phải chọn phương thức thanh toán!");
                return;
            }
            

			int year1, month1, day1, year2, month2, day2;

			year1 = dtpNgayvao.Value.Year;
			month1 = dtpNgayvao.Value.Month;
			day1 = dtpNgayvao.Value.Day;
			year2 = dtpNgayra.Value.Year;
			month2 = dtpNgayra.Value.Month;
			day2 = dtpNgayra.Value.Day;

			if (year2 - year1 < 0 || month2 - month1 < 0 || day2 - day1 < 0)
			{
				MessageBox.Show("Thời Gian trả phòng phải sau thời gian đặt");

                return;
			}

			

			if (year1 - DateTime.Now.Year < 0 || month1 - DateTime.Now.Month < 0 || day1 - DateTime.Now.Day < 0)
			{
				MessageBox.Show("Ngày đặt không được trước ngày hiện tại");

                return;

			}
            bool chonphong = false;
			for (int i = 0; i < dgvThongtin.RowCount; i++)
			{
				if (Convert.ToBoolean(dgvThongtin.Rows[i].Cells["Thue"].Value) == true)
				{
					if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Đã thuê")
					{
						MessageBox.Show("Phòng " + dgvThongtin.Rows[i].Cells["SoPhong"].Value.ToString() + " đã được thuê rồi. Chọn phòng khác!");
						dgvThongtin.Rows[i].Cells["Thue"].Value = false;
						return;
					}
					if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Hỏng")
					{
						MessageBox.Show("Phòng " + dgvThongtin.Rows[i].Cells["SoPhong"].Value.ToString() + " đang hỏng. Chọn phòng khác!");
						dgvThongtin.Rows[i].Cells["Thue"].Value = false;
						return;
					}
					ecPT.MaPh = dgvThongtin.Rows[i].Cells["MaPh"].Value.ToString();// ecpt : phieuthue
					ecPT.MaKH = txtMaKH.Text;
					ecPT.MaPT = txtMaPT.Text;
					
					DateTime date = DateTime.Now;
					ecPT.MaPhieu = date.Day.ToString() + date.Month.ToString() + date.Hour.ToString() + date.Minute.ToString() + date.Second.ToString() + dgvThongtin.Rows[i].Cells["SoPhong"].Value.ToString();
					PhieuThueF dalPhieuthue = new PhieuThueF();
					dalPhieuthue.ThemThongTin(ecPT);

					ecHD.MaHD = ecPT.MaPhieu;
					ecHD.MaPhieuThue = ecPT.MaPhieu;
					ecHD.ThanhTien = 0;
					ecHD.Gia = 200;
					ecHD.NgayVao = dtpNgayvao.Value.Year.ToString() + "-" + dtpNgayvao.Value.Month.ToString() + "-" + dtpNgayvao.Value.Day.ToString();
					ecHD.NgayRa = dtpNgayra.Value.Year.ToString() + "-" + dtpNgayra.Value.Month.ToString() + "-" + dtpNgayra.Value.Day.ToString();
					dalHD.ThemThongTin(ecHD);

					Phong ecPh = new Phong();
					ecPh.MaPh = dgvThongtin.Rows[i].Cells["MaPh"].Value.ToString();
					ecPh.SoPhong = dgvThongtin.Rows[i].Cells["SoPhong"].Value.ToString();
					ecPh.TrangThai = "Đã thuê";
					dalPh.SuaThongTin(ecPh);
                    chonphong = true;
				}
			}
            if(chonphong)
			    MessageBox.Show("Thuê OK!");
            else
            {
                MessageBox.Show("Bạn phải chọn phòng!");
                return;
            }

			DataTable tb = dalPh.ThongTinPhong("");
			dgvThongtin.DataSource = tb;
			for (int i = 0; i < dgvThongtin.RowCount; i++)
			{
				dgvThongtin.Rows[i].Cells["STT"].Value = i + 1;
				if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Tốt") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
				else
					if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Đã thuê") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
				else
						if (dgvThongtin.Rows[i].Cells["TrangThai"].Value.ToString() == "Hỏng") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.Red;
			}
		}

        private void dgvThongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void cmbPhuongthuc_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable tb = cn.GetDataTable("Select distinct MaPT, tenPT from tblPhuongThucThue");
			txtMaPT.Text = findCode(cmbPhuongthuc.Text, "tenPT", "MaPT", tb);
		}
	}
}
