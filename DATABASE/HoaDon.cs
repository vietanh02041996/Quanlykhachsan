﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DATABASE
{
    public class HoaDon
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private string _MaPhieuThue;

        public string MaPhieuThue
        {
            get { return _MaPhieuThue; }
            set { _MaPhieuThue = value; }
        }
        private string _NgayVao;

        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        private string _NgayRa;

        public string NgayRa
        {
            get { return _NgayRa; }
            set { _NgayRa = value; }
        }
        private int _ThanhTien;

        public int ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        private int _Gia;
        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
    }
}
