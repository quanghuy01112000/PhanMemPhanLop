
namespace QL_TourDuLich.GUI
{
    partial class Form_QL_ChiTietTour
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtTenLoaiHinh = new System.Windows.Forms.TextBox();
            this.txtDacDiem = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiaDiem = new System.Windows.Forms.DataGridView();
            this.TenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDoan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTenDiaDiem = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMaTour, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenTour, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenLoaiHinh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDacDiem, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGia, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNgayBatDau, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNgayKetThuc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTrangThai, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Tour";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Tour";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại Hình";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đặc Điểm";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thành Tiền";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày Bắt Đầu";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(561, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ngày Kết thúc";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(561, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Trạng Thái";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaTour.Enabled = false;
            this.txtMaTour.Location = new System.Drawing.Point(206, 16);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(124, 28);
            this.txtMaTour.TabIndex = 8;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenTour.Enabled = false;
            this.txtTenTour.Location = new System.Drawing.Point(206, 76);
            this.txtTenTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(316, 28);
            this.txtTenTour.TabIndex = 9;
            // 
            // txtTenLoaiHinh
            // 
            this.txtTenLoaiHinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenLoaiHinh.Enabled = false;
            this.txtTenLoaiHinh.Location = new System.Drawing.Point(206, 136);
            this.txtTenLoaiHinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoaiHinh.Name = "txtTenLoaiHinh";
            this.txtTenLoaiHinh.Size = new System.Drawing.Size(316, 28);
            this.txtTenLoaiHinh.TabIndex = 10;
            // 
            // txtDacDiem
            // 
            this.txtDacDiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDacDiem.Location = new System.Drawing.Point(206, 197);
            this.txtDacDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(316, 28);
            this.txtDacDiem.TabIndex = 11;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGia.Location = new System.Drawing.Point(764, 16);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(232, 28);
            this.txtGia.TabIndex = 12;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgayBatDau.Location = new System.Drawing.Point(764, 76);
            this.txtNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(232, 28);
            this.txtNgayBatDau.TabIndex = 13;
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(764, 136);
            this.txtNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(232, 28);
            this.txtNgayKetThuc.TabIndex = 14;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(764, 197);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(232, 28);
            this.txtTrangThai.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(42, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 297);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách địa điểm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDiaDiem
            // 
            this.dgvDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDiaDiem,
            this.ThuTu});
            this.dgvDiaDiem.Location = new System.Drawing.Point(789, 425);
            this.dgvDiaDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDiaDiem.Name = "dgvDiaDiem";
            this.dgvDiaDiem.RowHeadersWidth = 51;
            this.dgvDiaDiem.RowTemplate.Height = 24;
            this.dgvDiaDiem.Size = new System.Drawing.Size(369, 159);
            this.dgvDiaDiem.TabIndex = 3;
            // 
            // TenDiaDiem
            // 
            this.TenDiaDiem.FillWeight = 70F;
            this.TenDiaDiem.HeaderText = "Tên Địa Điểm";
            this.TenDiaDiem.MinimumWidth = 6;
            this.TenDiaDiem.Name = "TenDiaDiem";
            this.TenDiaDiem.ReadOnly = true;
            // 
            // ThuTu
            // 
            this.ThuTu.FillWeight = 30F;
            this.ThuTu.HeaderText = "Thứ tự";
            this.ThuTu.MinimumWidth = 6;
            this.ThuTu.Name = "ThuTu";
            this.ThuTu.ReadOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(990, 592);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 53);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Danh Sách Đoàn Tham Quan";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDoan
            // 
            this.dgvDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvDoan.Location = new System.Drawing.Point(41, 392);
            this.dgvDoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDoan.Name = "dgvDoan";
            this.dgvDoan.RowHeadersWidth = 51;
            this.dgvDoan.RowTemplate.Height = 24;
            this.dgvDoan.Size = new System.Drawing.Size(732, 244);
            this.dgvDoan.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 70F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Địa Điểm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Thứ tự";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(818, 592);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 53);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1030, 392);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 29);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTenDiaDiem
            // 
            this.cbbTenDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbTenDiaDiem.FormattingEnabled = true;
            this.cbbTenDiaDiem.Location = new System.Drawing.Point(789, 392);
            this.cbbTenDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenDiaDiem.Name = "cbbTenDiaDiem";
            this.cbbTenDiaDiem.Size = new System.Drawing.Size(234, 30);
            this.cbbTenDiaDiem.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1097, 392);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 29);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form_QL_ChiTietTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1198, 649);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbbTenDiaDiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDoan);
            this.Controls.Add(this.dgvDiaDiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_QL_ChiTietTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QL_ChiTietTour";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDiaDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtTenLoaiHinh;
        private System.Windows.Forms.TextBox txtDacDiem;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.TextBox txtNgayKetThuc;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuTu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbTenDiaDiem;
        private System.Windows.Forms.Button btnXoa;
    }
}