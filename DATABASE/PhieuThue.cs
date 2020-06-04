using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DATABASE
{
	public class PhieuThue
	{
		private string _MaPhieu;

		public string MaPhieu
		{
			get { return _MaPhieu; }
			set { _MaPhieu = value; }
		}
		private string _MaKH;

		public string MaKH
		{
			get { return _MaKH; }
			set { _MaKH = value; }
		}
		private string _MaPh;

		public string MaPh
		{
			get { return _MaPh; }
			set { _MaPh = value; }
		}

		public string MaPT { get; set; }
	}
}
