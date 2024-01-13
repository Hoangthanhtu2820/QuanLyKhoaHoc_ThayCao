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
    public partial class frm_QuanLyGiangVien : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int currentPageIndex = 1;
        int pageSite = 10; // số bản ghi trên 1 trang
        int pageNumber = 0;  // số trang
        int rows;
        private bool sortAscending = false;
        public frm_QuanLyGiangVien()
        {
            InitializeComponent();
        }

        private void ClearData_btn_Click(object sender, EventArgs e)
        {
            MaGiangVien_txt.Text = "";
            HoVaTen_txt.Text = "";
            CCCD_txt.Text = "";
            DiaChi_txt.Text = "";
            SDT_txt.Text = "";
        }

        private void LoadData()
        {
            var dsgv = db.tbl_GiangViens.ToList();
            rows = dsgv.Count();
            XoaGiangVien_btn.Visible = false;
            SuaGiangVien_btn.Visible = false;
            PageSite_num.Value = pageSite;
            pageTotal();
        }

        void pageTotal()
        {
            pageNumber = rows % pageSite != 0 ? rows / pageSite + 1 : rows / pageSite;
            PageTotal_lbl.Text = " / " + pageNumber.ToString();
            Page_cmb.Items.Clear();
            if (pageNumber == 0)
            {
                return;
            }
            else
                for (int i = 1; i <= pageNumber; i++)
                {
                    Page_cmb.Items.Add(i + "");
                }
            Page_cmb.SelectedIndex = 0;
        }
        private void ThemGiangVien_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MaGiangVien_txt.Text != "" && HoVaTen_txt.Text != "")
                {
                    tbl_GiangVien newObj = new tbl_GiangVien();
                    newObj.maGV = MaGiangVien_txt.Text;
                    MaGiangVien_txt.ReadOnly = false;
                    newObj.hoTen = HoVaTen_txt.Text;
                    newObj.SDT = SDT_txt.Text;
                    newObj.CCCD = CCCD_txt.Text;
                    newObj.DiaChi = DiaChi_txt.Text;
                    db.tbl_GiangViens.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm giảng viên thành công!");
                    LoadData();
                    ClearData_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã giảng viên và tên giảng viên không được để trống");
                }
            }
            catch (Exception)
            {
                if (db.GetChangeSet().Inserts.Count() > 0)
                {
                    foreach (tbl_GiangVien item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_GiangViens.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm giảng viên không thành công");
            }
        }

        private void SuaGiangVien_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mgv = MaGiangVien_txt.Text;
                tbl_GiangVien editObj = db.tbl_GiangViens.Where(o => o.maGV.Equals(mgv)).FirstOrDefault();
                editObj.maGV = MaGiangVien_txt.Text;
                editObj.hoTen = HoVaTen_txt.Text;
                editObj.CCCD = CCCD_txt.Text;
                editObj.DiaChi = DiaChi_txt.Text;
                editObj.SDT = SDT_txt.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin giảng viên thành công!");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin giảng viên không thành công");
            }
        }

        private void XoaGiangVien_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_GiangVien delObj = db.tbl_GiangViens.Where(o => o.maGV.Equals(MaGiangVien_txt.Text)).FirstOrDefault();
                db.tbl_GiangViens.DeleteOnSubmit(delObj);
                db.SubmitChanges();
                MessageBox.Show("Xóa giảng viên thành công");
                LoadData();
                SuaGiangVien_btn.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa khóa học không thành công");
            }

            ClearData_btn_Click(sender, e);
        }

        private void LamMoiGiangVien_btn_Click(object sender, EventArgs e)
        {
            ClearData_btn_Click(sender, e);
            MaGiangVien_txt.ReadOnly = false;
            ThemGiangVien_btn.Visible = true;
            SuaGiangVien_btn.Visible = false;
            XoaGiangVien_btn.Visible = false;
        }

        private void PageSite_num_ValueChanged(object sender, EventArgs e)
        {
            pageSite = Convert.ToInt32(PageSite_num.Value);
            pageTotal();
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dsgv = db.tbl_GiangViens.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            List<GiangVien_Ett> list_GiangVien_ett = new List<GiangVien_Ett>();
            for (int i = 0; i < dsgv.Count; i++)
            {
                GiangVien_Ett GiangVien_ett = new GiangVien_Ett(dsgv[i]);
                GiangVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                list_GiangVien_ett.Add(GiangVien_ett);
            }
            DSGiangVien_dvg.DataSource = list_GiangVien_ett;
        }

        private void frm_QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SearchType_cmb.SelectedIndex = 0;
        }

        private void DSGiangVien_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                XoaGiangVien_btn.Visible = true;
                SuaGiangVien_btn.Visible = true;
                LamMoiGiangVien_btn.Visible = true;
                DataGridViewRow row = new DataGridViewRow();
                row = DSGiangVien_dvg.Rows[e.RowIndex];
                MaGiangVien_txt.Text = Convert.ToString(row.Cells["MaGV"].Value);
                MaGiangVien_txt.ReadOnly = true;
                HoVaTen_txt.Text = Convert.ToString(row.Cells["HoTen"].Value);
                SDT_txt.Text = Convert.ToString(row.Cells["SDT"].Value);
                DiaChi_txt.Text = Convert.ToString(row.Cells["DiaChi"].Value);
                CCCD_txt.Text = Convert.ToString(row.Cells["CCCD"].Value);
                ThemGiangVien_btn.Visible = false;
            }
        }

        private void PrePage_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPageIndex == 1)
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
            if (currentPageIndex == pageNumber)
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
            EnumSearchType search_type = (EnumSearchType)SearchType_cmb.SelectedIndex;
            List<tbl_GiangVien> dsgv = new List<tbl_GiangVien>();
            List<tbl_GiangVien> list_GiangVien_ett = new List<tbl_GiangVien>();
            switch (search_type)
            {
                case EnumSearchType.Tatca:
                    dsgv = db.tbl_GiangViens.ToList();
                    for (int i = 0; i < dsgv.Count; i++)
                    {
                        GiangVien_Ett GiangVien_ett = new GiangVien_Ett(dsgv[i]);
                        GiangVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_GiangVien_ett.Add(GiangVien_ett);
                    }
                    DSGiangVien_dvg.DataSource = list_GiangVien_ett;
                    break;
                case EnumSearchType.Ma:
                    dsgv = db.tbl_GiangViens.Where(o => o.maGV.Contains(search_value)).ToList();
                    for (int i = 0; i < dsgv.Count; i++)
                    {
                        GiangVien_Ett GiangVien_ett = new GiangVien_Ett(dsgv[i]);
                        GiangVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_GiangVien_ett.Add(GiangVien_ett);
                    }
                    DSGiangVien_dvg.DataSource = list_GiangVien_ett;
                    break;
                case EnumSearchType.Ten:
                    dsgv = db.tbl_GiangViens.Where(o => o.hoTen.Contains(search_value)).ToList();
                    for (int i = 0; i < dsgv.Count; i++)
                    {
                        GiangVien_Ett GiangVien_ett = new GiangVien_Ett(dsgv[i]);
                        GiangVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_GiangVien_ett.Add(GiangVien_ett);
                    }
                    DSGiangVien_dvg.DataSource = list_GiangVien_ett;
                    break;
                default:
                    break;
            }
        }

        private void DSGiangVien_dvg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var dskh = db.tbl_KhoaHocs.ToList();
            //List<KhoaHoc_ett> list_KhoaHoc_ett = new List<KhoaHoc_ett>();
            //for (int i = 0; i < dskh.Count; i++)
            //{
            //    KhoaHoc_ett khoaHoc_Ett = new KhoaHoc_ett(dskh[i]);
            //    khoaHoc_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //    list_KhoaHoc_ett.Add(khoaHoc_Ett);
            //}

            //List<KhoaHoc_ett> newData = new List<KhoaHoc_ett>();
            //if (sortAscending)
            //{
            //    newData = list_KhoaHoc_ett.OrderBy(DSKhoaHoc_dvg.Columns[e.ColumnIndex].DataPropertyName).ToList();
            //    for (int i = 0; i < newData.Count; i++)
            //    {
            //        newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //    }
            //}
            //else
            //{
            //    newData = list_KhoaHoc_ett.OrderBy(DSKhoaHoc_dvg.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            //    for (int i = 0; i < newData.Count; i++)
            //    {
            //        newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //    }
            //}

            //newData = newData.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            //DSKhoaHoc_dvg.DataSource = newData;
            //sortAscending = !sortAscending;
        }
    }
}
