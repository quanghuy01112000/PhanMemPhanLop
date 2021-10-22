
namespace GUI_QuanLyTourDuLich
{
    partial class TourDuLichForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelLoaiTour = new System.Windows.Forms.Label();
            this.cBLoaiTour = new System.Windows.Forms.ComboBox();
            this.labelNBD = new System.Windows.Forms.Label();
            this.gBoxQuanLyTour = new System.Windows.Forms.GroupBox();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelNKT = new System.Windows.Forms.Label();
            this.cBTrangThai = new System.Windows.Forms.ComboBox();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.gBDanhSachTour = new System.Windows.Forms.GroupBox();
            this.labelTitleDanhSach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.lvTour = new System.Windows.Forms.ListView();
            this.gBoxQuanLyTour.SuspendLayout();
            this.gBDanhSachTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoaiTour
            // 
            this.labelLoaiTour.AutoSize = true;
            this.labelLoaiTour.Location = new System.Drawing.Point(22, 16);
            this.labelLoaiTour.Name = "labelLoaiTour";
            this.labelLoaiTour.Size = new System.Drawing.Size(48, 13);
            this.labelLoaiTour.TabIndex = 1;
            this.labelLoaiTour.Text = "Loại tour";
            this.labelLoaiTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLoaiTour.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBLoaiTour
            // 
            this.cBLoaiTour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBLoaiTour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBLoaiTour.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cBLoaiTour.Items.AddRange(new object[] {
            "-- Tất cả --",
            "Du lịch xanh",
            "Du lịch gia đình",
            "Du lịch ẩm thực",
            "Du lịch văn hóa"});
            this.cBLoaiTour.Location = new System.Drawing.Point(25, 33);
            this.cBLoaiTour.Name = "cBLoaiTour";
            this.cBLoaiTour.Size = new System.Drawing.Size(121, 21);
            this.cBLoaiTour.TabIndex = 2;
            this.cBLoaiTour.Text = "--Tất cả--";
            this.cBLoaiTour.SelectedIndexChanged += new System.EventHandler(this.cBLoaiTour_SelectedIndexChanged);
            // 
            // labelNBD
            // 
            this.labelNBD.AutoSize = true;
            this.labelNBD.Location = new System.Drawing.Point(181, 16);
            this.labelNBD.Name = "labelNBD";
            this.labelNBD.Size = new System.Drawing.Size(72, 13);
            this.labelNBD.TabIndex = 3;
            this.labelNBD.Text = "Ngày bắt đầu";
            // 
            // gBoxQuanLyTour
            // 
            this.gBoxQuanLyTour.Controls.Add(this.btnLoc);
            this.gBoxQuanLyTour.Controls.Add(this.btnLamMoi);
            this.gBoxQuanLyTour.Controls.Add(this.cBTrangThai);
            this.gBoxQuanLyTour.Controls.Add(this.labelTrangThai);
            this.gBoxQuanLyTour.Controls.Add(this.dateTimePicker1);
            this.gBoxQuanLyTour.Controls.Add(this.labelNKT);
            this.gBoxQuanLyTour.Controls.Add(this.datePickerStart);
            this.gBoxQuanLyTour.Controls.Add(this.labelNBD);
            this.gBoxQuanLyTour.Controls.Add(this.cBLoaiTour);
            this.gBoxQuanLyTour.Controls.Add(this.labelLoaiTour);
            this.gBoxQuanLyTour.Location = new System.Drawing.Point(20, 13);
            this.gBoxQuanLyTour.Name = "gBoxQuanLyTour";
            this.gBoxQuanLyTour.Size = new System.Drawing.Size(748, 97);
            this.gBoxQuanLyTour.TabIndex = 0;
            this.gBoxQuanLyTour.TabStop = false;
            // 
            // datePickerStart
            // 
            this.datePickerStart.CustomFormat = "dd/MM/yyy";
            this.datePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStart.Location = new System.Drawing.Point(184, 33);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(106, 20);
            this.datePickerStart.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // labelNKT
            // 
            this.labelNKT.AutoSize = true;
            this.labelNKT.Location = new System.Drawing.Point(327, 16);
            this.labelNKT.Name = "labelNKT";
            this.labelNKT.Size = new System.Drawing.Size(74, 13);
            this.labelNKT.TabIndex = 5;
            this.labelNKT.Text = "Ngày kết thúc";
            // 
            // cBTrangThai
            // 
            this.cBTrangThai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBTrangThai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBTrangThai.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cBTrangThai.Items.AddRange(new object[] {
            "-- Tất cả --",
            "chuẩn bị",
            "đang xử lý",
            "bắt đầu",
            "đang diễn ra",
            "kết thúc"});
            this.cBTrangThai.Location = new System.Drawing.Point(475, 32);
            this.cBTrangThai.Name = "cBTrangThai";
            this.cBTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cBTrangThai.TabIndex = 8;
            this.cBTrangThai.Text = "--Tất cả--";
            this.cBTrangThai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(472, 16);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(55, 13);
            this.labelTrangThai.TabIndex = 7;
            this.labelTrangThai.Text = "Trạng thái";
            this.labelTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTrangThai.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(25, 60);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(626, 32);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(92, 51);
            this.btnLoc.TabIndex = 10;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBDanhSachTour
            // 
            this.gBDanhSachTour.Controls.Add(this.lvTour);
            this.gBDanhSachTour.Controls.Add(this.btnXemChiTiet);
            this.gBDanhSachTour.Controls.Add(this.tBTimKiem);
            this.gBDanhSachTour.Controls.Add(this.labelTimKiem);
            this.gBDanhSachTour.Controls.Add(this.btnXoa);
            this.gBDanhSachTour.Controls.Add(this.btnSua);
            this.gBDanhSachTour.Controls.Add(this.btnThem);
            this.gBDanhSachTour.Controls.Add(this.numericUpDownDong);
            this.gBDanhSachTour.Controls.Add(this.label2);
            this.gBDanhSachTour.Controls.Add(this.labelTitleDanhSach);
            this.gBDanhSachTour.Location = new System.Drawing.Point(20, 128);
            this.gBDanhSachTour.Name = "gBDanhSachTour";
            this.gBDanhSachTour.Size = new System.Drawing.Size(748, 310);
            this.gBDanhSachTour.TabIndex = 1;
            this.gBDanhSachTour.TabStop = false;
            // 
            // labelTitleDanhSach
            // 
            this.labelTitleDanhSach.AutoSize = true;
            this.labelTitleDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleDanhSach.Location = new System.Drawing.Point(25, 20);
            this.labelTitleDanhSach.Name = "labelTitleDanhSach";
            this.labelTitleDanhSach.Size = new System.Drawing.Size(117, 16);
            this.labelTitleDanhSach.TabIndex = 0;
            this.labelTitleDanhSach.Text = "Danh sách Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số dòng hiển thị :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDownDong
            // 
            this.numericUpDownDong.Location = new System.Drawing.Point(121, 43);
            this.numericUpDownDong.Name = "numericUpDownDong";
            this.numericUpDownDong.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownDong.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(194, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(296, 43);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(401, 43);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Location = new System.Drawing.Point(521, 45);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(55, 13);
            this.labelTimKiem.TabIndex = 6;
            this.labelTimKiem.Text = "Tìm kiếm: ";
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.Location = new System.Drawing.Point(579, 43);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(139, 20);
            this.tBTimKiem.TabIndex = 7;
            this.tBTimKiem.Text = " tìm kiếm ...";
            this.tBTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXemChiTiet.Location = new System.Drawing.Point(643, 13);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 8;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // lvTour
            // 
            this.lvTour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvTour.HideSelection = false;
            this.lvTour.Location = new System.Drawing.Point(25, 84);
            this.lvTour.Name = "lvTour";
            this.lvTour.Size = new System.Drawing.Size(693, 205);
            this.lvTour.TabIndex = 9;
            this.lvTour.UseCompatibleStateImageBehavior = false;
            this.lvTour.View = System.Windows.Forms.View.Details;
            this.lvTour.SelectedIndexChanged += new System.EventHandler(this.lvTour_SelectedIndexChanged);
            // 
            // TourDuLichForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.gBDanhSachTour);
            this.Controls.Add(this.gBoxQuanLyTour);
            this.Name = "TourDuLichForm";
            this.Text = "Tour Du lịch";
            this.Load += new System.EventHandler(this.TourDuLichForm_Load);
            this.gBoxQuanLyTour.ResumeLayout(false);
            this.gBoxQuanLyTour.PerformLayout();
            this.gBDanhSachTour.ResumeLayout(false);
            this.gBDanhSachTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelLoaiTour;
        private System.Windows.Forms.ComboBox cBLoaiTour;
        private System.Windows.Forms.Label labelNBD;
        private System.Windows.Forms.GroupBox gBoxQuanLyTour;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelNKT;
        private System.Windows.Forms.ComboBox cBTrangThai;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gBDanhSachTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitleDanhSach;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numericUpDownDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Label labelTimKiem;
        private System.Windows.Forms.ListView lvTour;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}

