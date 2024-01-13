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
    public partial class frm_QuanLyLopHoc : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int currentPageIndex = 1;
        int pageSite = 10; // số bản ghi trên 1 trang
        int pageNumber = 0;  // số trang
        int rows;
        private bool sortAscending = false;
        public frm_QuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void ClearData_btn_Click(object sender, EventArgs e)
        {
            MaLopHoc_txt.Text = "";
            TenLopHoc_txt.Text = "";
            ThoiGianBatDau_txt.Text = "";
            ThoiGianKetThuc_txt.Text = "";
            MaKhoaHoc_txt.Text = "";

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
        
        private void LoadData()
        {
            var dslh = db.tbl_LopHocs.ToList();
            rows = dslh.Count();
            XoaLopHoc_btn.Visible = false;
            SuaLopHoc_btn.Visible = false;
            PageSite_num.Value = pageSite;
            pageTotal();
        }

        private void Form_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            SearchType_cmb.SelectedIndex = 0;
        }
       
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string search_value = Search_txt.Text.ToString();
            EnumSearchType search_type = (EnumSearchType)SearchType_cmb.SelectedIndex;
            List<tbl_LopHoc> dslh = new List<tbl_LopHoc>();
            List<LopHoc_ett> list_LopHoc_ett = new List<LopHoc_ett>();
            switch (search_type)
            {
                case EnumSearchType.Tatca:
                    dslh = db.tbl_LopHocs.ToList();
                    for (int i = 0; i < dslh.Count; i++)
                    {
                        LopHoc_ett LopHoc_ett = new LopHoc_ett(dslh[i]);
                        LopHoc_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_LopHoc_ett.Add(LopHoc_ett);
                    }
                    DSLopHoc_dvg.DataSource = list_LopHoc_ett;
                    break;
                case EnumSearchType.Ma:
                    dslh = db.tbl_LopHocs.Where(o => o.MaLH.Contains(search_value)).ToList();
                    for (int i = 0; i < dslh.Count; i++)
                    {
                        LopHoc_ett LopHoc_ett = new LopHoc_ett(dslh[i]);
                        LopHoc_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_LopHoc_ett.Add(LopHoc_ett);
                    }
                    DSLopHoc_dvg.DataSource = list_LopHoc_ett;
                    break;
                case EnumSearchType.Ten:
                    dslh = db.tbl_LopHocs.Where(o => o.TenLH.Contains(search_value)).ToList();
                    for (int i = 0; i < dslh.Count; i++)
                    {
                        LopHoc_ett LopHoc_ett = new LopHoc_ett(dslh[i]);
                        LopHoc_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_LopHoc_ett.Add(LopHoc_ett);
                    }
                    DSLopHoc_dvg.DataSource = list_LopHoc_ett;
                    break;
                default:
                    break;
            }
        }

        private void LamMoiLopHoc_btn_Click(object sender, EventArgs e)
        {
            ClearData_btn_Click(sender, e);
            MaLopHoc_txt.ReadOnly = false;
            ThemLopHoc_btn.Visible = true;
            SuaLopHoc_btn.Visible = false;
            XoaLopHoc_btn.Visible = false;
        }

        private void ThemLopHoc_btn_Click(object sender, EventArgs e)
        {
            frm_ThemLopHoc f = new frm_ThemLopHoc();
            //lấy ra form Main
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name == "frm_Main")
                {
                    //lấy ra size của Main_Panel trong frm_Main, gán bằng size của frm_ThemMoiLH
                    var mainPanel = form.Controls[0];
                    f.TopLevel = false;
                    f.Width = mainPanel.Width;
                    f.Height = mainPanel.Height;
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(f);
                    f.Show();
                    break;
                }
            }
        }

        private void SuaLopHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var maLopHoc = MaLopHoc_txt.Text;
                tbl_LopHoc editObj = db.tbl_LopHocs.Where(o => o.MaLH.Equals(maLopHoc)).FirstOrDefault();
                editObj.MaLH = MaLopHoc_txt.Text;
                editObj.TenLH = TenLopHoc_txt.Text;
                editObj.ThoiGianBatDau = ThoiGianBatDau_txt.Text;
                editObj.ThoiGianKetThuc = ThoiGianKetThuc_txt.Text;
                editObj.MaKhoaHoc = MaKhoaHoc_txt.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin lớp học thành công!");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin lớp học không thành công");
            }
        }

        private void XoaLopHoc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_LopHoc delObj = db.tbl_LopHocs.Where(o => o.MaLH.Equals(MaLopHoc_txt.Text)).FirstOrDefault();
                db.tbl_LopHocs.DeleteOnSubmit(delObj);
                db.SubmitChanges();
                MessageBox.Show("Xóa lớp học thành công");
                LoadData();
                SuaLopHoc_btn.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa lớp học không thành công");
            }

            ClearData_btn_Click(sender, e);
        }

        private void PageSite_num_ValueChanged(object sender, EventArgs e)
        {
            pageSite = Convert.ToInt32(PageSite_num.Value);
            pageTotal();
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

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dslh = db.tbl_LopHocs.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            List<LopHoc_ett> list_LopHoc_ett = new List<LopHoc_ett>();
            for (int i = 0; i < dslh.Count; i++)
            {
                LopHoc_ett LopHoc_ett = new LopHoc_ett(dslh[i]);
                LopHoc_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                list_LopHoc_ett.Add(LopHoc_ett);
            }
            DSLopHoc_dvg.DataSource = list_LopHoc_ett;
        }

        private void DSLopHoc_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                XoaLopHoc_btn.Visible = true;
                SuaLopHoc_btn.Visible = true;
                LamMoiLopHoc_btn.Visible = true;
                DataGridViewRow row = new DataGridViewRow();
                row = DSLopHoc_dvg.Rows[e.RowIndex];
                MaLopHoc_txt.Text = Convert.ToString(row.Cells["MaLH"].Value);
                MaLopHoc_txt.ReadOnly = true;
                TenLopHoc_txt.Text = Convert.ToString(row.Cells["TenLH"].Value);
                ThoiGianBatDau_txt.Text = Convert.ToString(row.Cells["ThoiGianBatDau"].Value);
                ThoiGianKetThuc_txt.Text = Convert.ToString(row.Cells["ThoiGianKetThuc"].Value);
                MaKhoaHoc_txt.Text = Convert.ToString(row.Cells["MaKhoaHoc"].Value);
                ThemLopHoc_btn.Visible = false;
            }
        }

        private void DSLopHoc_dvg_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // xử lý sắp xếp khi ấn vào Header
            //    var dslh = db.tbl_LopHocs.ToList();
            //    List<LopHoc_ett> list_LopHoc_ett = new List<LopHoc_ett>();
            //    for (int i = 0; i < dslh.Count; i++)
            //    {
            //        LopHoc_ett LopHoc_ett = new LopHoc_ett(dslh[i]);
            //        LopHoc_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //        list_LopHoc_ett.Add(LopHoc_ett);
            //    }

            //    List<LopHoc_ett> newData = new List<LopHoc_ett>();
            //    if (sortAscending)
            //    {
            //        newData = list_LopHoc_ett.OrderBy(DSLopHoc_dvg.Columns[e.ColumnIndex].DataPropertyName).ToList();
            //        for (int i = 0; i < newData.Count; i++)
            //        {
            //            newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //        }
            //    }
            //    else
            //    {
            //        newData = list_LopHoc_ett.OrderBy(DSLopHoc_dvg.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            //        for (int i = 0; i < newData.Count; i++)
            //        {
            //            newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //        }
            //    }

            //    newData = newData.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            //    DSLopHoc_dvg.DataSource = newData;
            //    sortAscending = !sortAscending;
            //}
        }
    }
}
