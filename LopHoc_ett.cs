﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoaHoc
{
    internal class LopHoc_ett : tbl_LopHoc
    {
        public string STT { get; set; }

        public LopHoc_ett()
        {

        }

        private void BinOjb(tbl_LopHoc obj)
        {
            this.MaLH = obj.MaLH;
            this.TenLH = obj.TenLH;
            this.ThoiGianBatDau = obj.ThoiGianBatDau;
            this.ThoiGianKetThuc = obj.ThoiGianKetThuc;
            this.MaKhoaHoc = obj.MaKhoaHoc;
        }

        public LopHoc_ett(tbl_LopHoc obj)
        {
            BinOjb(obj);
        }
    }
}
