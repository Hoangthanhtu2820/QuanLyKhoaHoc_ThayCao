﻿using System;
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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void frm_Main_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frm_QuanLyKhoaHoc" || f.Name == "frm_QuanLySinhVien" || f.Name == "frm_QuanLyGiangVien" || f.Name == "frm_QuanLyLopHoc")
                {
                    f.Height = Main_pnl.Height;
                    f.Width = Main_pnl.Width;
                }
            }
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //click quản lý sinh viên
            frm_QuanLySinhVien f = new frm_QuanLySinhVien();
            f.TopLevel = false;
            f.Height = Main_pnl.Height;
            f.Width = Main_pnl.Width;
            Main_pnl.Controls.Clear();
            Main_pnl.Controls.Add(f);
            f.Show();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //click quản lý giảng viên
            frm_QuanLyGiangVien f = new frm_QuanLyGiangVien();
            f.TopLevel = false;
            f.Height = Main_pnl.Height;
            f.Width = Main_pnl.Width;
            Main_pnl.Controls.Clear();
            Main_pnl.Controls.Add(f);
            f.Show();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //click quản lý lớp học
            frm_QuanLyLopHoc f = new frm_QuanLyLopHoc();
            f.TopLevel = false;
            f.Height = Main_pnl.Height;
            f.Width = Main_pnl.Width;
            Main_pnl.Controls.Clear();
            Main_pnl.Controls.Add(f);
            f.Show();
        }

        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //click quản lý khóa học
            frm_QuanLyKhoaHoc f = new frm_QuanLyKhoaHoc();
            f.TopLevel = false;
            f.Height = Main_pnl.Height;
            f.Width = Main_pnl.Width;
            Main_pnl.Controls.Clear();
            Main_pnl.Controls.Add(f);
            f.Show();
        }
    }
}
