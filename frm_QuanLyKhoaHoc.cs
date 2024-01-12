using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic;

namespace QuanLyKhoaHoc
{
    public partial class frm_QuanLyKhoaHoc : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int currentPageIndex = 1;
        int pageSite = 10; // số bản ghi trên 1 trang
        int pageNumber = 0;  // số trang
        int rows;
        private bool sortAscending = false;
        public frm_QuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        void pageTotal()
        {
            pageNumber = rows%pageSite!=0 ? rows/pageSite+1 : rows/pageSite;   
            PageTotal_lbl.Text = " / " + pageNumber.ToString();
            Page_cmb.Items.Clear();
            if (pageNumber == 0)
            {
                return;
            }
            else
                for (int i = 1; i<= pageNumber; i++)
            {
                Page_cmb.Items.Add(i + "");
            }
            Page_cmb.SelectedIndex = 0;
        }
       
        private void LoadData() 
        {
            var dskh = db.tbl_KhoaHocs.ToList();
            rows = dskh.Count();
            XoaKhoaHoc_btn.Visible = false;
            SuaKhoaHoc_btn.Visible = false;
            PageSite_num.Value = pageSite;
            pageTotal();
        }

        private void ClearData_btn_Click( object sender, EventArgs e)
        {
            MaKhoaHoc_txt.Text = "";
            TenKhoaHoc_txt.Text = "";
            ThoiGian_txt.Text = "";
            GioiHanSinhVien_num.Text = "";
            GioiHanGiangVien_num.Text = "";
            KinhPhiDongGop_num.Text = "";
            SoBuoiThucHanh_num.Text = "";
            SoBuoiLyThuyet_num.Text = "";

        }

        private void frm_QuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            SearchType_cmb.SelectedIndex = 0;
        }
        
        private void ThemKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try {

                if(MaKhoaHoc_txt.Text != "" && TenKhoaHoc_txt.Text != "")
                {
                    tbl_KhoaHoc newObj = new tbl_KhoaHoc();
                    newObj.MaKhoaHoc = MaKhoaHoc_txt.Text;
                    MaKhoaHoc_txt.ReadOnly = false;
                    newObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
                    newObj.ThoiGian = ThoiGian_txt.Text;
                    newObj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Value);
                    newObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_num.Value);
                    newObj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_num.Value);
                    newObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_num.Value);
                    newObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_num.Value);
                    db.tbl_KhoaHocs.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm khóa học thành công!");
                    LoadData();
                    ClearData_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã khóa học và tên khóa học không được để trống");
                }
            }
            catch(Exception)
            {
                if (db.GetChangeSet().Inserts.Count() > 0) 
                { 
                    foreach(tbl_KhoaHoc item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_KhoaHocs.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm khóa học không thành công");
            }
        }
        
        private void XoaKhoaHoc_btn_Click(object sender, EventArgs e)
        {
            try 
            { 
                tbl_KhoaHoc delObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(MaKhoaHoc_txt.Text)).FirstOrDefault();
                db.tbl_KhoaHocs.DeleteOnSubmit(delObj);
                db.SubmitChanges();
                MessageBox.Show("Xóa khóa học thành công");
                LoadData();
                SuaKhoaHoc_btn.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa khóa học không thành công");
            }

            ClearData_btn_Click(sender, e);

        }

        private void SuaKhoaHoc_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                var mkh = MaKhoaHoc_txt.Text;
                tbl_KhoaHoc editObj = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
                editObj.MaKhoaHoc = MaKhoaHoc_txt.Text;
                editObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
                editObj.ThoiGian = ThoiGian_txt.Text;
                editObj.GioiHanSinhVien = Convert.ToInt32(GioiHanSinhVien_num.Text);
                editObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_num.Text);
                editObj.KinhPhiDongGop = Convert.ToInt32(KinhPhiDongGop_num.Text);
                editObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_num.Text);
                editObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_num.Text);
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin khóa học thành công!");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin khóa học không thành công");
            }
        }

        private void LamMoiKhoaHoc_btn_Click(object sender, EventArgs e)

        {
            ClearData_btn_Click(sender, e);
            MaKhoaHoc_txt.ReadOnly = false;
            ThemKhoaHoc_btn.Visible = true;
            SuaKhoaHoc_btn.Visible = false;
            XoaKhoaHoc_btn.Visible = false;
        }
        
        private void DSKhoaHoc_dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                XoaKhoaHoc_btn.Visible = true;  
                SuaKhoaHoc_btn.Visible = true;
                LamMoiKhoaHoc_btn.Visible = true;
                DataGridViewRow row = new DataGridViewRow();
                row = DSKhoaHoc_dvg.Rows[e.RowIndex];
                MaKhoaHoc_txt.Text = Convert.ToString(row.Cells["MaKhoaHoc"].Value);
                MaKhoaHoc_txt.ReadOnly = true;
                TenKhoaHoc_txt.Text = Convert.ToString(row.Cells["TenKhoaHoc"].Value);
                ThoiGian_txt.Text = Convert.ToString(row.Cells["ThoiGian"].Value);
                GioiHanGiangVien_num.Text = Convert.ToString(row.Cells["GioiHanGiangVien"].Value);
                GioiHanSinhVien_num.Text = Convert.ToString(row.Cells["GioiHanSinhVien"].Value);
                KinhPhiDongGop_num.Text = Convert.ToString(row.Cells["KinhPhiDongGop"].Value);
                SoBuoiLyThuyet_num.Text = Convert.ToString(row.Cells["SoBuoiLyThuyet"].Value);
                SoBuoiThucHanh_num.Text = Convert.ToString(row.Cells["SoBuoiThucHanh"].Value);
                ThemKhoaHoc_btn.Visible = false;
            }
      
        }

        private void PageSite_num_ValueChanged(object sender, EventArgs e)
        {
                pageSite = Convert.ToInt32(PageSite_num.Value);
                pageTotal();
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dskh = db.tbl_KhoaHocs.Skip((currentPageIndex - 1)*pageSite).Take(pageSite).ToList();
            List<KhoaHoc_ett> list_KhoaHoc_ett = new List<KhoaHoc_ett>();
            for(int i = 0; i < dskh.Count; i++)
            {
                KhoaHoc_ett khoaHoc_Ett = new KhoaHoc_ett(dskh[i]);
                khoaHoc_Ett.STT = Convert.ToString((currentPageIndex - 1)*pageSite + i + 1);
                list_KhoaHoc_ett.Add(khoaHoc_Ett);
            }
            DSKhoaHoc_dvg.DataSource = list_KhoaHoc_ett;
        }

        private void PrePage_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(currentPageIndex == 1)
            {
                MessageBox.Show("Đây là trang đầu tiên");
                return;
            }
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            int prePageIndex = currentPageIndex - 1;
            Page_cmb.Text = prePageIndex.ToString();
        }

        private void NextPage_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(currentPageIndex == pageNumber)
            {
                MessageBox.Show("Đây là trang cuối cùng");
                return;
            }
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            int nextPageIndex = currentPageIndex + 1;
            Page_cmb.Text = nextPageIndex.ToString();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string search_value = Search_txt.Text.ToString();
            EnumSearchType search_type = (EnumSearchType) SearchType_cmb.SelectedIndex;
            List<tbl_KhoaHoc> dskh = new List<tbl_KhoaHoc>();
            List<KhoaHoc_ett> list_KhoaHoc_ett = new List<KhoaHoc_ett>();
            switch (search_type)
            {
                case EnumSearchType.Tatca:
                    dskh = db.tbl_KhoaHocs.ToList();
                    for (int i = 0; i < dskh.Count; i++)
                    {
                        KhoaHoc_ett khoaHoc_Ett = new KhoaHoc_ett(dskh[i]);
                        khoaHoc_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_KhoaHoc_ett.Add(khoaHoc_Ett);
                    }
                    DSKhoaHoc_dvg.DataSource = list_KhoaHoc_ett;
                    break;
                case EnumSearchType.Ma:
                    dskh = db.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Contains(search_value)).ToList();
                    for (int i = 0; i < dskh.Count; i++)
                    {
                        KhoaHoc_ett khoaHoc_Ett = new KhoaHoc_ett(dskh[i]);
                        khoaHoc_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_KhoaHoc_ett.Add(khoaHoc_Ett);
                    }
                    DSKhoaHoc_dvg.DataSource = list_KhoaHoc_ett;
                    break;
                case EnumSearchType.Ten:
                    dskh = db.tbl_KhoaHocs.Where(o => o.TenKhoaHoc.Contains(search_value)).ToList();
                    for (int i = 0; i < dskh.Count; i++)
                    {
                        KhoaHoc_ett khoaHoc_Ett = new KhoaHoc_ett(dskh[i]);
                        khoaHoc_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_KhoaHoc_ett.Add(khoaHoc_Ett);
                    }
                    DSKhoaHoc_dvg.DataSource = list_KhoaHoc_ett;
                    break;
                default:
                    break;
            }
        }

        private void DSKhoaHoc_dvg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // xử lý sắp xếp khi ấn vào Header
            var dskh = db.tbl_KhoaHocs.ToList();
            List<KhoaHoc_ett> list_KhoaHoc_ett = new List<KhoaHoc_ett>();
            for (int i = 0; i < dskh.Count; i++)
            {
                KhoaHoc_ett khoaHoc_Ett = new KhoaHoc_ett(dskh[i]);
                khoaHoc_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                list_KhoaHoc_ett.Add(khoaHoc_Ett);
            }

            List<KhoaHoc_ett> newData = new List<KhoaHoc_ett>();
            if (sortAscending)
            {
                newData = list_KhoaHoc_ett.OrderBy(DSKhoaHoc_dvg.Columns[e.ColumnIndex].DataPropertyName).ToList();
                for (int i = 0; i < newData.Count; i++)
                {
                    newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                }
            }
            else
            {
                newData = list_KhoaHoc_ett.OrderBy(DSKhoaHoc_dvg.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
                for (int i = 0; i < newData.Count; i++)
                {
                    newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                }
            }

            newData = newData.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            DSKhoaHoc_dvg.DataSource = newData;
            sortAscending = !sortAscending;
        }
    }
}


// Bài tập phải làm
// 1.khi tìm kiếm thì bị mất STT  --->  đã làm
// 2. sắp xếp theo Database   --->  đã làm
// 3. khi thêm 1 dữ liệu không thành công vì nhập mã khóa học bị trùng thì bắn ra lỗi KHÔNG THÀNH CÔNG
// tiếp tục thêm dữ liệu lần này nhập đúng nhưng vẫn bị bắn ra lỗi KHÔNG THÀNH CÔNG. Tại SAO ?    --->  đã làm
// 4. khi ấn tìm kiếm thì số bản ghi trên 1 trang bị sai
// 5. lỗi chạy qua chạy lại giữa các form(form trước đè lên form sau)
// 6. tìm giải pháp cho trường hợp combobox giới tính với 2 trường hợp nam và nữ(không sử dụng if else)
// nếu các trường trong combobox dày lên, có thể có nhiều trường thì sử dụng if else KHÔNG hơp lý, tìm cách
// khắc phục. Thường combobox người ta sử dụng switch case
//7. Giới tính trong database là True,False làm thế nào để hiển thị cho lên giao diện là Nam, Nữ