using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoaHoc
{
    internal class GiangVien_Ett : tbl_GiangVien
    {
        public string STT { get; set; }

        public GiangVien_Ett()
        {

        }

        private void BindObj(tbl_GiangVien obj)
        {
            this.maGV = obj.maGV;
            this.hoTen = obj.hoTen;
            this.SDT = obj.SDT;
            this.CCCD = obj.CCCD;
            this.DiaChi = obj.DiaChi;   
        }

        public GiangVien_Ett(tbl_GiangVien obj)
        {
            BindObj(obj);
        }
    }
}
