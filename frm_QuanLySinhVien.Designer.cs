namespace QuanLyKhoaHoc
{
    partial class frm_QuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NgaySinh_dtp = new System.Windows.Forms.DateTimePicker();
            this.GioiTinh_cmb = new System.Windows.Forms.ComboBox();
            this.SDT_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.SDT_lbl = new System.Windows.Forms.Label();
            this.GioiTinh_lbl = new System.Windows.Forms.Label();
            this.NgaySinh_lbl = new System.Windows.Forms.Label();
            this.LopQuanLy_lbl = new System.Windows.Forms.Label();
            this.HoVaTen_lbl = new System.Windows.Forms.Label();
            this.MaSinhVien_lbl = new System.Windows.Forms.Label();
            this.LopQuanLy_txt = new System.Windows.Forms.TextBox();
            this.HoVaTen_txt = new System.Windows.Forms.TextBox();
            this.MaSinhVien_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.SearchType_cmb = new System.Windows.Forms.ComboBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.SuaSinhVien_btn = new System.Windows.Forms.Button();
            this.LamMoiSinhVien_btn = new System.Windows.Forms.Button();
            this.XoaSinhVien_btn = new System.Windows.Forms.Button();
            this.ThemSinhVien_btn = new System.Windows.Forms.Button();
            this.NextPage_lbl = new System.Windows.Forms.LinkLabel();
            this.PrePage_lbl = new System.Windows.Forms.LinkLabel();
            this.PageTotal_lbl = new System.Windows.Forms.Label();
            this.page_lbl = new System.Windows.Forms.Label();
            this.PageSite_num = new System.Windows.Forms.NumericUpDown();
            this.Page_cmb = new System.Windows.Forms.ComboBox();
            this.SoBanGhiTrenTrang_lbl = new System.Windows.Forms.Label();
            this.DSSinhVien_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSite_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSinhVien_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.SuaSinhVien_btn);
            this.splitContainer1.Panel1.Controls.Add(this.LamMoiSinhVien_btn);
            this.splitContainer1.Panel1.Controls.Add(this.XoaSinhVien_btn);
            this.splitContainer1.Panel1.Controls.Add(this.ThemSinhVien_btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NextPage_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.PrePage_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.PageTotal_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.page_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.PageSite_num);
            this.splitContainer1.Panel2.Controls.Add(this.Page_cmb);
            this.splitContainer1.Panel2.Controls.Add(this.SoBanGhiTrenTrang_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.DSSinhVien_dgv);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 805);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NgaySinh_dtp);
            this.groupBox2.Controls.Add(this.GioiTinh_cmb);
            this.groupBox2.Controls.Add(this.SDT_txt);
            this.groupBox2.Controls.Add(this.Email_txt);
            this.groupBox2.Controls.Add(this.Email_lbl);
            this.groupBox2.Controls.Add(this.SDT_lbl);
            this.groupBox2.Controls.Add(this.GioiTinh_lbl);
            this.groupBox2.Controls.Add(this.NgaySinh_lbl);
            this.groupBox2.Controls.Add(this.LopQuanLy_lbl);
            this.groupBox2.Controls.Add(this.HoVaTen_lbl);
            this.groupBox2.Controls.Add(this.MaSinhVien_lbl);
            this.groupBox2.Controls.Add(this.LopQuanLy_txt);
            this.groupBox2.Controls.Add(this.HoVaTen_txt);
            this.groupBox2.Controls.Add(this.MaSinhVien_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 399);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết sinh viên";
            // 
            // NgaySinh_dtp
            // 
            this.NgaySinh_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NgaySinh_dtp.Location = new System.Drawing.Point(143, 204);
            this.NgaySinh_dtp.Name = "NgaySinh_dtp";
            this.NgaySinh_dtp.Size = new System.Drawing.Size(276, 26);
            this.NgaySinh_dtp.TabIndex = 27;
            // 
            // GioiTinh_cmb
            // 
            this.GioiTinh_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GioiTinh_cmb.FormattingEnabled = true;
            this.GioiTinh_cmb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GioiTinh_cmb.Location = new System.Drawing.Point(143, 254);
            this.GioiTinh_cmb.Name = "GioiTinh_cmb";
            this.GioiTinh_cmb.Size = new System.Drawing.Size(276, 28);
            this.GioiTinh_cmb.TabIndex = 26;
            // 
            // SDT_txt
            // 
            this.SDT_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SDT_txt.Location = new System.Drawing.Point(143, 307);
            this.SDT_txt.Name = "SDT_txt";
            this.SDT_txt.Size = new System.Drawing.Size(276, 26);
            this.SDT_txt.TabIndex = 25;
            // 
            // Email_txt
            // 
            this.Email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_txt.Location = new System.Drawing.Point(143, 360);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(276, 26);
            this.Email_txt.TabIndex = 22;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.Location = new System.Drawing.Point(19, 366);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(51, 20);
            this.Email_lbl.TabIndex = 10;
            this.Email_lbl.Text = "Email";
            // 
            // SDT_lbl
            // 
            this.SDT_lbl.AutoSize = true;
            this.SDT_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT_lbl.Location = new System.Drawing.Point(19, 307);
            this.SDT_lbl.Name = "SDT_lbl";
            this.SDT_lbl.Size = new System.Drawing.Size(111, 20);
            this.SDT_lbl.TabIndex = 11;
            this.SDT_lbl.Text = "Số điện thoại ";
            // 
            // GioiTinh_lbl
            // 
            this.GioiTinh_lbl.AutoSize = true;
            this.GioiTinh_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh_lbl.Location = new System.Drawing.Point(19, 257);
            this.GioiTinh_lbl.Name = "GioiTinh_lbl";
            this.GioiTinh_lbl.Size = new System.Drawing.Size(76, 20);
            this.GioiTinh_lbl.TabIndex = 12;
            this.GioiTinh_lbl.Text = "Giới Tính";
            // 
            // NgaySinh_lbl
            // 
            this.NgaySinh_lbl.AutoSize = true;
            this.NgaySinh_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh_lbl.Location = new System.Drawing.Point(19, 209);
            this.NgaySinh_lbl.Name = "NgaySinh_lbl";
            this.NgaySinh_lbl.Size = new System.Drawing.Size(83, 20);
            this.NgaySinh_lbl.TabIndex = 13;
            this.NgaySinh_lbl.Tag = "";
            this.NgaySinh_lbl.Text = "Ngày sinh";
            // 
            // LopQuanLy_lbl
            // 
            this.LopQuanLy_lbl.AutoSize = true;
            this.LopQuanLy_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopQuanLy_lbl.Location = new System.Drawing.Point(19, 161);
            this.LopQuanLy_lbl.Name = "LopQuanLy_lbl";
            this.LopQuanLy_lbl.Size = new System.Drawing.Size(95, 20);
            this.LopQuanLy_lbl.TabIndex = 14;
            this.LopQuanLy_lbl.Text = "Lớp quản lý";
            // 
            // HoVaTen_lbl
            // 
            this.HoVaTen_lbl.AutoSize = true;
            this.HoVaTen_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoVaTen_lbl.Location = new System.Drawing.Point(19, 111);
            this.HoVaTen_lbl.Name = "HoVaTen_lbl";
            this.HoVaTen_lbl.Size = new System.Drawing.Size(81, 20);
            this.HoVaTen_lbl.TabIndex = 15;
            this.HoVaTen_lbl.Text = "Họ và tên";
            // 
            // MaSinhVien_lbl
            // 
            this.MaSinhVien_lbl.AutoSize = true;
            this.MaSinhVien_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSinhVien_lbl.Location = new System.Drawing.Point(19, 47);
            this.MaSinhVien_lbl.Name = "MaSinhVien_lbl";
            this.MaSinhVien_lbl.Size = new System.Drawing.Size(103, 20);
            this.MaSinhVien_lbl.TabIndex = 16;
            this.MaSinhVien_lbl.Text = "Mã sinh viên";
            // 
            // LopQuanLy_txt
            // 
            this.LopQuanLy_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LopQuanLy_txt.Location = new System.Drawing.Point(143, 155);
            this.LopQuanLy_txt.Name = "LopQuanLy_txt";
            this.LopQuanLy_txt.Size = new System.Drawing.Size(276, 26);
            this.LopQuanLy_txt.TabIndex = 18;
            // 
            // HoVaTen_txt
            // 
            this.HoVaTen_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoVaTen_txt.Location = new System.Drawing.Point(143, 105);
            this.HoVaTen_txt.Name = "HoVaTen_txt";
            this.HoVaTen_txt.Size = new System.Drawing.Size(276, 26);
            this.HoVaTen_txt.TabIndex = 17;
            // 
            // MaSinhVien_txt
            // 
            this.MaSinhVien_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaSinhVien_txt.Location = new System.Drawing.Point(143, 47);
            this.MaSinhVien_txt.Name = "MaSinhVien_txt";
            this.MaSinhVien_txt.Size = new System.Drawing.Size(276, 26);
            this.MaSinhVien_txt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_btn);
            this.groupBox1.Controls.Add(this.SearchType_cmb);
            this.groupBox1.Controls.Add(this.Search_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(344, 42);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(98, 28);
            this.Search_btn.TabIndex = 14;
            this.Search_btn.Text = "Tìm kiếm";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // SearchType_cmb
            // 
            this.SearchType_cmb.FormattingEnabled = true;
            this.SearchType_cmb.Items.AddRange(new object[] {
            "Tìm kiếm theo",
            "Mã",
            "Tên"});
            this.SearchType_cmb.Location = new System.Drawing.Point(168, 42);
            this.SearchType_cmb.Name = "SearchType_cmb";
            this.SearchType_cmb.Size = new System.Drawing.Size(149, 28);
            this.SearchType_cmb.TabIndex = 13;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(6, 45);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(145, 26);
            this.Search_txt.TabIndex = 12;
            // 
            // SuaSinhVien_btn
            // 
            this.SuaSinhVien_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SuaSinhVien_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SuaSinhVien_btn.FlatAppearance.BorderSize = 0;
            this.SuaSinhVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuaSinhVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaSinhVien_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SuaSinhVien_btn.Location = new System.Drawing.Point(71, 714);
            this.SuaSinhVien_btn.Name = "SuaSinhVien_btn";
            this.SuaSinhVien_btn.Size = new System.Drawing.Size(108, 62);
            this.SuaSinhVien_btn.TabIndex = 23;
            this.SuaSinhVien_btn.Text = "Sửa ";
            this.SuaSinhVien_btn.UseVisualStyleBackColor = false;
            this.SuaSinhVien_btn.Click += new System.EventHandler(this.SuaSinhVien_btn_Click);
            // 
            // LamMoiSinhVien_btn
            // 
            this.LamMoiSinhVien_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LamMoiSinhVien_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(179)))));
            this.LamMoiSinhVien_btn.FlatAppearance.BorderSize = 0;
            this.LamMoiSinhVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LamMoiSinhVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LamMoiSinhVien_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LamMoiSinhVien_btn.Location = new System.Drawing.Point(71, 574);
            this.LamMoiSinhVien_btn.Name = "LamMoiSinhVien_btn";
            this.LamMoiSinhVien_btn.Size = new System.Drawing.Size(110, 68);
            this.LamMoiSinhVien_btn.TabIndex = 22;
            this.LamMoiSinhVien_btn.Text = "Làm Mới";
            this.LamMoiSinhVien_btn.UseVisualStyleBackColor = false;
            this.LamMoiSinhVien_btn.Click += new System.EventHandler(this.LamMoiSinhVien_btn_Click);
            // 
            // XoaSinhVien_btn
            // 
            this.XoaSinhVien_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XoaSinhVien_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.XoaSinhVien_btn.FlatAppearance.BorderSize = 0;
            this.XoaSinhVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoaSinhVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaSinhVien_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.XoaSinhVien_btn.Location = new System.Drawing.Point(281, 714);
            this.XoaSinhVien_btn.Name = "XoaSinhVien_btn";
            this.XoaSinhVien_btn.Size = new System.Drawing.Size(119, 62);
            this.XoaSinhVien_btn.TabIndex = 24;
            this.XoaSinhVien_btn.Text = "Xóa";
            this.XoaSinhVien_btn.UseVisualStyleBackColor = false;
            this.XoaSinhVien_btn.Click += new System.EventHandler(this.XoaSinhVien_btn_Click);
            // 
            // ThemSinhVien_btn
            // 
            this.ThemSinhVien_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemSinhVien_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ThemSinhVien_btn.FlatAppearance.BorderSize = 0;
            this.ThemSinhVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemSinhVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemSinhVien_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ThemSinhVien_btn.Location = new System.Drawing.Point(281, 574);
            this.ThemSinhVien_btn.Name = "ThemSinhVien_btn";
            this.ThemSinhVien_btn.Size = new System.Drawing.Size(119, 68);
            this.ThemSinhVien_btn.TabIndex = 21;
            this.ThemSinhVien_btn.Text = "Thêm";
            this.ThemSinhVien_btn.UseVisualStyleBackColor = false;
            this.ThemSinhVien_btn.Click += new System.EventHandler(this.ThemSinhVien_btn_Click);
            // 
            // NextPage_lbl
            // 
            this.NextPage_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPage_lbl.AutoSize = true;
            this.NextPage_lbl.Location = new System.Drawing.Point(559, 760);
            this.NextPage_lbl.Name = "NextPage_lbl";
            this.NextPage_lbl.Size = new System.Drawing.Size(70, 16);
            this.NextPage_lbl.TabIndex = 26;
            this.NextPage_lbl.TabStop = true;
            this.NextPage_lbl.Text = "Trang Sau";
            this.NextPage_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextPage_lbl_LinkClicked);
            // 
            // PrePage_lbl
            // 
            this.PrePage_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrePage_lbl.AutoSize = true;
            this.PrePage_lbl.Location = new System.Drawing.Point(280, 760);
            this.PrePage_lbl.Name = "PrePage_lbl";
            this.PrePage_lbl.Size = new System.Drawing.Size(81, 16);
            this.PrePage_lbl.TabIndex = 25;
            this.PrePage_lbl.TabStop = true;
            this.PrePage_lbl.Text = "Trang Trước";
            this.PrePage_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrePage_lbl_LinkClicked);
            // 
            // PageTotal_lbl
            // 
            this.PageTotal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTotal_lbl.AutoSize = true;
            this.PageTotal_lbl.Location = new System.Drawing.Point(507, 760);
            this.PageTotal_lbl.Name = "PageTotal_lbl";
            this.PageTotal_lbl.Size = new System.Drawing.Size(46, 16);
            this.PageTotal_lbl.TabIndex = 22;
            this.PageTotal_lbl.Text = "/ Tổng";
            // 
            // page_lbl
            // 
            this.page_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.page_lbl.AutoSize = true;
            this.page_lbl.Location = new System.Drawing.Point(376, 760);
            this.page_lbl.Name = "page_lbl";
            this.page_lbl.Size = new System.Drawing.Size(63, 16);
            this.page_lbl.TabIndex = 21;
            this.page_lbl.Text = "Số Trang";
            // 
            // PageSite_num
            // 
            this.PageSite_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PageSite_num.Location = new System.Drawing.Point(169, 758);
            this.PageSite_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageSite_num.Name = "PageSite_num";
            this.PageSite_num.Size = new System.Drawing.Size(55, 22);
            this.PageSite_num.TabIndex = 23;
            this.PageSite_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageSite_num.ValueChanged += new System.EventHandler(this.PageSite_num_ValueChanged);
            // 
            // Page_cmb
            // 
            this.Page_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Page_cmb.FormattingEnabled = true;
            this.Page_cmb.Location = new System.Drawing.Point(445, 752);
            this.Page_cmb.Name = "Page_cmb";
            this.Page_cmb.Size = new System.Drawing.Size(56, 24);
            this.Page_cmb.TabIndex = 24;
            this.Page_cmb.SelectedIndexChanged += new System.EventHandler(this.Page_cmb_SelectedIndexChanged);
            // 
            // SoBanGhiTrenTrang_lbl
            // 
            this.SoBanGhiTrenTrang_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SoBanGhiTrenTrang_lbl.AutoSize = true;
            this.SoBanGhiTrenTrang_lbl.Location = new System.Drawing.Point(15, 764);
            this.SoBanGhiTrenTrang_lbl.Name = "SoBanGhiTrenTrang_lbl";
            this.SoBanGhiTrenTrang_lbl.Size = new System.Drawing.Size(139, 16);
            this.SoBanGhiTrenTrang_lbl.TabIndex = 20;
            this.SoBanGhiTrenTrang_lbl.Text = "Số bản ghi trên 1 trang";
            // 
            // DSSinhVien_dgv
            // 
            this.DSSinhVien_dgv.AllowUserToAddRows = false;
            this.DSSinhVien_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DSSinhVien_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DSSinhVien_dgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DSSinhVien_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSinhVien_dgv.Location = new System.Drawing.Point(3, 0);
            this.DSSinhVien_dgv.Name = "DSSinhVien_dgv";
            this.DSSinhVien_dgv.ReadOnly = true;
            this.DSSinhVien_dgv.RowHeadersWidth = 51;
            this.DSSinhVien_dgv.RowTemplate.Height = 24;
            this.DSSinhVien_dgv.Size = new System.Drawing.Size(641, 741);
            this.DSSinhVien_dgv.TabIndex = 19;
            this.DSSinhVien_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSSinhVien_dgv_CellClick);
            this.DSSinhVien_dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DSSinhVien_dgv_ColumnHeaderMouseClick);
            // 
            // frm_QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1166, 805);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLySinhVien";
            this.Text = "frm_QuanLySinhVien";
            this.Load += new System.EventHandler(this.frm_QuanLySinhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSite_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSinhVien_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label SDT_lbl;
        private System.Windows.Forms.Label GioiTinh_lbl;
        private System.Windows.Forms.Label NgaySinh_lbl;
        private System.Windows.Forms.Label LopQuanLy_lbl;
        private System.Windows.Forms.Label HoVaTen_lbl;
        private System.Windows.Forms.Label MaSinhVien_lbl;
        private System.Windows.Forms.TextBox LopQuanLy_txt;
        private System.Windows.Forms.TextBox HoVaTen_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.ComboBox SearchType_cmb;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button LamMoiSinhVien_btn;
        private System.Windows.Forms.Button SuaSinhVien_btn;
        private System.Windows.Forms.Button XoaSinhVien_btn;
        private System.Windows.Forms.Button ThemSinhVien_btn;
        private System.Windows.Forms.LinkLabel NextPage_lbl;
        private System.Windows.Forms.LinkLabel PrePage_lbl;
        private System.Windows.Forms.Label PageTotal_lbl;
        private System.Windows.Forms.Label page_lbl;
        private System.Windows.Forms.NumericUpDown PageSite_num;
        private System.Windows.Forms.ComboBox Page_cmb;
        private System.Windows.Forms.Label SoBanGhiTrenTrang_lbl;
        private System.Windows.Forms.DataGridView DSSinhVien_dgv;
        private System.Windows.Forms.TextBox SDT_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox MaSinhVien_txt;
        private System.Windows.Forms.ComboBox GioiTinh_cmb;
        private System.Windows.Forms.DateTimePicker NgaySinh_dtp;
    }
}