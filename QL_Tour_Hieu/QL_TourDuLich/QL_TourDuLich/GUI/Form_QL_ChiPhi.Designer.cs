
namespace QL_TourDuLich.GUI
{
    partial class Form_QL_ChiPhi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiemGiaTour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvChiPhi = new System.Windows.Forms.DataGridView();
            this.MaChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaChiPhi = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.comboBoxMaDoan = new System.Windows.Forms.ComboBox();
            this.comboBoxLoaiChiPhi = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txtTimKiemGiaTour);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnDatLai);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvChiPhi);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Location = new System.Drawing.Point(15, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 697);
            this.panel2.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(774, 41);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 44);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiemGiaTour
            // 
            this.txtTimKiemGiaTour.Location = new System.Drawing.Point(264, 50);
            this.txtTimKiemGiaTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemGiaTour.Name = "txtTimKiemGiaTour";
            this.txtTimKiemGiaTour.Size = new System.Drawing.Size(379, 22);
            this.txtTimKiemGiaTour.TabIndex = 9;
            this.txtTimKiemGiaTour.TextChanged += new System.EventHandler(this.txtTimKiemGiaTour_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "tìm kiếm";
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(1158, 41);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(130, 44);
            this.btnDatLai.TabIndex = 6;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách chi phí";
            // 
            // dgvChiPhi
            // 
            this.dgvChiPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiPhi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiPhi,
            this.MaDoan,
            this.GiaTien,
            this.LoaiChiPhi});
            this.dgvChiPhi.Location = new System.Drawing.Point(14, 93);
            this.dgvChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiPhi.Name = "dgvChiPhi";
            this.dgvChiPhi.ReadOnly = true;
            this.dgvChiPhi.RowHeadersWidth = 51;
            this.dgvChiPhi.RowTemplate.Height = 24;
            this.dgvChiPhi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiPhi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiPhi.Size = new System.Drawing.Size(848, 593);
            this.dgvChiPhi.TabIndex = 4;
            this.dgvChiPhi.SelectionChanged += new System.EventHandler(this.dgvGiaTour_SelectionChanged);
            // 
            // MaChiPhi
            // 
            this.MaChiPhi.FillWeight = 80F;
            this.MaChiPhi.HeaderText = "Mã Giá Tour";
            this.MaChiPhi.MinimumWidth = 6;
            this.MaChiPhi.Name = "MaChiPhi";
            this.MaChiPhi.ReadOnly = true;
            // 
            // MaDoan
            // 
            this.MaDoan.FillWeight = 80F;
            this.MaDoan.HeaderText = "Mã Tour";
            this.MaDoan.MinimumWidth = 6;
            this.MaDoan.Name = "MaDoan";
            this.MaDoan.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // LoaiChiPhi
            // 
            this.LoaiChiPhi.HeaderText = "Loại Chi Phí";
            this.LoaiChiPhi.MinimumWidth = 6;
            this.LoaiChiPhi.Name = "LoaiChiPhi";
            this.LoaiChiPhi.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(961, 586);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.80605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.19395F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMaChiPhi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoTien, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMaDoan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxLoaiChiPhi, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(890, 95);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chi Phí";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đoàn";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tiền";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Chi Phí";
            // 
            // txtMaChiPhi
            // 
            this.txtMaChiPhi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaChiPhi.Enabled = false;
            this.txtMaChiPhi.Location = new System.Drawing.Point(174, 40);
            this.txtMaChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChiPhi.Name = "txtMaChiPhi";
            this.txtMaChiPhi.Size = new System.Drawing.Size(168, 22);
            this.txtMaChiPhi.TabIndex = 5;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoTien.Location = new System.Drawing.Point(174, 244);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(168, 22);
            this.txtSoTien.TabIndex = 8;
            // 
            // comboBoxMaDoan
            // 
            this.comboBoxMaDoan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxMaDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaDoan.FormattingEnabled = true;
            this.comboBoxMaDoan.Location = new System.Drawing.Point(173, 141);
            this.comboBoxMaDoan.Name = "comboBoxMaDoan";
            this.comboBoxMaDoan.Size = new System.Drawing.Size(225, 24);
            this.comboBoxMaDoan.TabIndex = 14;
            // 
            // comboBoxLoaiChiPhi
            // 
            this.comboBoxLoaiChiPhi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxLoaiChiPhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiChiPhi.FormattingEnabled = true;
            this.comboBoxLoaiChiPhi.Location = new System.Drawing.Point(173, 347);
            this.comboBoxLoaiChiPhi.Name = "comboBoxLoaiChiPhi";
            this.comboBoxLoaiChiPhi.Size = new System.Drawing.Size(225, 24);
            this.comboBoxLoaiChiPhi.TabIndex = 15;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1144, 586);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 44);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form_QL_ChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QL_ChiPhi";
            this.Text = "Quản lý chi phí";
            this.Load += new System.EventHandler(this.Form_QL_ChiPhi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiemGiaTour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvChiPhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaChiPhi;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.ComboBox comboBoxMaDoan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox comboBoxLoaiChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiChiPhi;
    }
}