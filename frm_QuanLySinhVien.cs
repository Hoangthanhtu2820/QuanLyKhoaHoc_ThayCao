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
    public partial class frm_QuanLySinhVien : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        int currentPageIndex = 1;
        int pageSite = 10; // số bản ghi trên 1 trang
        int pageNumber = 0;  // số trang
        int rows;
        private bool sortAscending = false;
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
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
            var dssv = db.tbl_SinhViens.ToList();
            rows = dssv.Count();
            XoaSinhVien_btn.Visible = false;
            SuaSinhVien_btn.Visible = false;
            PageSite_num.Value = pageSite;
            pageTotal();
        }

        private void ClearData_btn_Click(object sender, EventArgs e)
        {
            MaSinhVien_txt.Text = "";
            HoVaTen_txt.Text = "";
            LopQuanLy_txt.Text = "";
            GioiTinh_cmb.Text = "";
            NgaySinh_dtp.Value = DateTime.Now;
            SDT_txt.Text = "";
            Email_txt.Text = "";

        }

        private void LamMoiSinhVien_btn_Click(object sender, EventArgs e)
        {
            ClearData_btn_Click(sender, e);
            MaSinhVien_txt.ReadOnly = false;
            ThemSinhVien_btn.Visible = true;
            SuaSinhVien_btn.Visible = false;
            XoaSinhVien_btn.Visible = false;
        }

        private void ThemSinhVien_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MaSinhVien_txt.Text != "" && HoVaTen_txt.Text != "")
                {
                    tbl_SinhVien newObj = new tbl_SinhVien();
                    newObj.MSSV = MaSinhVien_txt.Text;
                    MaSinhVien_txt.ReadOnly = false;
                    newObj.Hoten = HoVaTen_txt.Text;
                    newObj.LopQL = LopQuanLy_txt.Text;
                    newObj.NgaySinh = NgaySinh_dtp.Value;
                    if (GioiTinh_cmb.SelectedIndex.ToString() == "1")
                    {
                        newObj.GioiTinh = true;
                    }
                    else if (GioiTinh_cmb.SelectedIndex.ToString() == "0")
                    {
                        newObj.GioiTinh = false;
                    }
                    newObj.SDT = SDT_txt.Text;
                    newObj.Email = Email_txt.Text;
                    db.tbl_SinhViens.InsertOnSubmit(newObj);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData();
                    ClearData_btn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã sinh viên và tên sinh viên không được để trống");
                }
            }
            catch (Exception)
            {
                if (db.GetChangeSet().Inserts.Count() > 0)
                {
                    foreach (tbl_SinhVien item in db.GetChangeSet().Inserts)
                    {
                        db.tbl_SinhViens.DeleteOnSubmit(item);
                    }
                }
                MessageBox.Show("Thêm sinh viên không thành công");
            }
        }

        private void SuaSinhVien_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var msv = MaSinhVien_txt.Text;
                tbl_SinhVien editObj = db.tbl_SinhViens.Where(o => o.MSSV.Equals(msv)).FirstOrDefault();
                editObj.MSSV = MaSinhVien_txt.Text;
                editObj.Hoten = HoVaTen_txt.Text;
                editObj.LopQL = LopQuanLy_txt.Text;
                editObj.NgaySinh = NgaySinh_dtp.Value;
                if (GioiTinh_cmb.SelectedIndex.ToString() == "1")
                {
                    editObj.GioiTinh = true;
                }
                else if (GioiTinh_cmb.SelectedIndex.ToString() == "0")
                {
                    editObj.GioiTinh = false;
                }
                editObj.SDT = SDT_txt.Text;
                editObj.Email = Email_txt.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa thông tin sinh viên thành công!");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin sinh viên không thành công");
            }
        }

        private void XoaSinhVien_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_SinhVien delObj = db.tbl_SinhViens.Where(o => o.MSSV.Equals(MaSinhVien_txt.Text)).FirstOrDefault();
                db.tbl_SinhViens.DeleteOnSubmit(delObj);
                db.SubmitChanges();
                MessageBox.Show("Xóa sinh viên thành công");
                LoadData();
                SuaSinhVien_btn.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa sinh viên không thành công");
            }

            ClearData_btn_Click(sender, e);
        }

        private void PageSite_num_ValueChanged(object sender, EventArgs e)
        {
            pageSite = Convert.ToInt32(PageSite_num.Value);
            pageTotal();
        }

        private void Page_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(Page_cmb.Text);
            var dssv = db.tbl_SinhViens.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            List<SinhVien_ett> list_SinhVien_ett = new List<SinhVien_ett>();
            for (int i = 0; i < dssv.Count; i++)
            {
                SinhVien_ett sinhVien_Ett = new SinhVien_ett(dssv[i]);
                sinhVien_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                list_SinhVien_ett.Add(sinhVien_Ett);
            }
            DSSinhVien_dgv.DataSource = list_SinhVien_ett;
        }

        private void frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SearchType_cmb.SelectedIndex = 0;
        }

        private void DSSinhVien_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                XoaSinhVien_btn.Visible = true;
                SuaSinhVien_btn.Visible = true;
                LamMoiSinhVien_btn.Visible = true;
                ThemSinhVien_btn.Visible = false;
                DataGridViewRow row = new DataGridViewRow();
                row = DSSinhVien_dgv.Rows[e.RowIndex];
                MaSinhVien_txt.Text = Convert.ToString(row.Cells["MSSV"].Value);
                MaSinhVien_txt.ReadOnly = true;
                HoVaTen_txt.Text = Convert.ToString(row.Cells["Hoten"].Value);
                NgaySinh_dtp.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                LopQuanLy_txt.Text = Convert.ToString(row.Cells["LopQL"].Value);
                if(Convert.ToBoolean(row.Cells["GioiTinh"].Value) == false)
                {
                    GioiTinh_cmb.SelectedIndex = 0;
                }
                else if(Convert.ToBoolean(row.Cells["GioiTinh"].Value) == true)
                {
                    GioiTinh_cmb.SelectedIndex = 1;
                }
                SDT_txt.Text = Convert.ToString(row.Cells["SDT"].Value);
                Email_txt.Text = Convert.ToString(row.Cells["Email"].Value);
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
            List<tbl_SinhVien> dssv = new List<tbl_SinhVien>();
            List<SinhVien_ett> list_SinhVien_ett = new List<SinhVien_ett>();
            switch (search_type)
            {
                case EnumSearchType.Tatca:
                    dssv = db.tbl_SinhViens.ToList();
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        SinhVien_ett sinhVien_Ett = new SinhVien_ett(dssv[i]);
                        sinhVien_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_SinhVien_ett.Add(sinhVien_Ett);
                    }
                    DSSinhVien_dgv.DataSource = list_SinhVien_ett;
                    break;
                case EnumSearchType.Ma:
                    dssv = db.tbl_SinhViens.Where(o => o.MSSV.Contains(search_value)).ToList();
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        SinhVien_ett sinhVien_Ett = new SinhVien_ett(dssv[i]);
                        sinhVien_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_SinhVien_ett.Add(sinhVien_Ett);
                    }
                    DSSinhVien_dgv.DataSource = list_SinhVien_ett;
                    break;
                case EnumSearchType.Ten:
                    dssv = db.tbl_SinhViens.Where(o => o.Hoten.Contains(search_value)).ToList();
                    for (int i = 0; i < dssv.Count; i++)
                    {
                        SinhVien_ett sinhVien_Ett = new SinhVien_ett(dssv[i]);
                        sinhVien_Ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
                        list_SinhVien_ett.Add(sinhVien_Ett);
                    }
                    DSSinhVien_dgv.DataSource = list_SinhVien_ett;
                    break;
                default:
                    break;
            }
        }

        private void DSSinhVien_dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //xử lý sắp xếp khi ấn vào Header
            //var dssv = db.tbl_SinhViens.ToList();
            //List<SinhVien_ett> list_SinhVien_ett = new List<SinhVien_ett>();
            //for (int i = 0; i < dssv.Count; i++)
            //{
            //    SinhVien_ett sinhVien_ett = new SinhVien_ett(dssv[i]);
            //    sinhVien_ett.STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //    list_SinhVien_ett.Add(sinhVien_ett);
            //}

            //List<SinhVien_ett> newData = new List<SinhVien_ett>();
            //if (sortAscending)
            //{
            //    newData = list_SinhVien_ett.OrderBy(sv => sv.GetType().GetProperty(DSSinhVien_dgv.Columns[e.ColumnIndex].DataPropertyName).GetValue(sv)).ToList();
            //   / newData = list_SinhVien_ett.OrderBy(DSSinhVien_dgv.Columns[e.ColumnIndex].DataPropertyName).ToList();
            //    for (int i = 0; i < newData.Count; i++)
            //    {
            //        newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //    }
            //}
            //else
            //{
            //    newData = list_SinhVien_ett.OrderBy(DSSinhVien_dgv.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            //    for (int i = 0; i < newData.Count; i++)
            //    {
            //        newData[i].STT = Convert.ToString((currentPageIndex - 1) * pageSite + i + 1);
            //    }
            //}

            //newData = newData.Skip((currentPageIndex - 1) * pageSite).Take(pageSite).ToList();
            //DSSinhVien_dgv.DataSource = newData;
            //sortAscending = !sortAscending;
        }
    }
}
