﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San
{
    public class SuDungDichVu
    {
        private string _MaHD;
        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        private string _MaDV;
        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        private DateTime _ThoiGian;
        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }

        private string _Gia;
        public string Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
    }
}
