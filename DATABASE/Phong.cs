using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DATABASE
{
	public class Phong
	{
		private string _MaPh;

		public string MaPh
		{
			get { return _MaPh; }
			set { _MaPh = value; }
		}
		private string _SoPhong;

		public string SoPhong
		{
			get { return _SoPhong; }
			set { _SoPhong = value; }
		}
		private string _TrangThai;

		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

	}
}
