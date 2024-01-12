using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoaHoc
{
    internal class KhoaHoc_ett : tbl_KhoaHoc
    {
        public String STT { get; set; }
        public KhoaHoc_ett()
        {

        }

        private void BindObj(tbl_KhoaHoc obj)
        {
            this.MaKhoaHoc = obj.MaKhoaHoc;
            this.TenKhoaHoc = obj.TenKhoaHoc;
            this.ThoiGian = obj.ThoiGian;
            this.GioiHanSinhVien = obj.GioiHanSinhVien;
            this.GioiHanGiangVien = obj.GioiHanGiangVien;
            this.SoBuoiThucHanh = obj.SoBuoiThucHanh;
            this.SoBuoiLyThuyet = obj.SoBuoiLyThuyet;
            this.KinhPhiDongGop = obj.KinhPhiDongGop;
        }

        public KhoaHoc_ett(tbl_KhoaHoc obj)
        {
            BindObj(obj);
        }
    }
}
