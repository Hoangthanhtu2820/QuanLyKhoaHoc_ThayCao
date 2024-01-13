using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoaHoc
{
    public partial class frm_ThemLopHoc : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public frm_ThemLopHoc()
        {
            InitializeComponent();
        }

        private void ThemLopHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_LopHoc newObj = new tbl_LopHoc();

                if (MaLH_txt.Text != "" && TenLH_txt.Text != "")
                {
                    newObj.MaLH = MaLH_txt.Text;
                    MaLH_txt.ReadOnly = false;
                    newObj.TenLH = TenLH_txt.Text;
                    newObj.ThoiGianBatDau = ThoiGianBatDau_txt.Text;
                    newObj.ThoiGianKetThuc = ThoiGianKetThuc_txt.Text;
                    newObj.MaKhoaHoc = KhoaHoc_txt.Text;
                    db.tbl_LopHocs.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm lớp học thành công!");
                }
                else
                {
                    MessageBox.Show("Mã lớp học và tên lớp học không được để trống");
                }
            }
            catch (Exception)
            {
                if (db.GetChangeSet().Inserts.Count() > 0)
                {
                    foreach (tbl_LopHoc item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_LopHocs.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm lớp học không thành công");
            }
        }
    }
}
