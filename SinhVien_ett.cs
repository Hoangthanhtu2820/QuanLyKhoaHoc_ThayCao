using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoaHoc
{
    internal class SinhVien_ett: tbl_SinhVien
    {
        public String STT { get; set; }
        public SinhVien_ett()
        {

        }

        private void BindObj(tbl_SinhVien obj)
        {
            this.MSSV = obj.MSSV;
            this.Hoten = obj.Hoten;
            this.LopQL = obj.LopQL;
            //switch(obj.GioiTinh)
            //{
            //    case true:
            //        this.GioiTinh = "Nam";
            //        break;
            //    case false:
            //        this.GioiTinh = "Nữ";
            //        break;
            // }
            this.GioiTinh = obj.GioiTinh;
            this.NgaySinh = obj.NgaySinh;
            this.SDT = obj.SDT;
            this.Email = obj.Email;
        }

        public SinhVien_ett(tbl_SinhVien obj)
        {
            BindObj(obj);
        }
    }
}
