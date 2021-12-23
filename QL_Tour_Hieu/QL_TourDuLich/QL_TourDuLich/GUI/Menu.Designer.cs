
namespace QL_TourDuLich.GUI
{
    partial class Menu
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
            this.btnTour = new System.Windows.Forms.Button();
            this.btnGiaTour = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnKhac = new System.Windows.Forms.Button();
            this.btnChiPhi = new System.Windows.Forms.Button();
            this.buttonDoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTour
            // 
            this.btnTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.Location = new System.Drawing.Point(18, 100);
            this.btnTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(162, 45);
            this.btnTour.TabIndex = 0;
            this.btnTour.Text = "Tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnGiaTour
            // 
            this.btnGiaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaTour.Location = new System.Drawing.Point(18, 221);
            this.btnGiaTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiaTour.Name = "btnGiaTour";
            this.btnGiaTour.Size = new System.Drawing.Size(162, 45);
            this.btnGiaTour.TabIndex = 1;
            this.btnGiaTour.Text = "Giá Tour";
            this.btnGiaTour.UseVisualStyleBackColor = true;
            this.btnGiaTour.Click += new System.EventHandler(this.btnGiaTour_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Location = new System.Drawing.Point(18, 160);
            this.btnKhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(162, 45);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách Hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnKhac
            // 
            this.btnKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.Location = new System.Drawing.Point(205, 221);
            this.btnKhac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(162, 45);
            this.btnKhac.TabIndex = 3;
            this.btnKhac.Text = "Khác";
            this.btnKhac.UseVisualStyleBackColor = true;
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // btnChiPhi
            // 
            this.btnChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiPhi.Location = new System.Drawing.Point(205, 160);
            this.btnChiPhi.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiPhi.Name = "btnChiPhi";
            this.btnChiPhi.Size = new System.Drawing.Size(162, 45);
            this.btnChiPhi.TabIndex = 4;
            this.btnChiPhi.Text = "Chi Phí";
            this.btnChiPhi.UseVisualStyleBackColor = true;
            this.btnChiPhi.Click += new System.EventHandler(this.btnChiPhi_Click);
            // 
            // buttonDoan
            // 
            this.buttonDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoan.Location = new System.Drawing.Point(205, 100);
            this.buttonDoan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDoan.Name = "buttonDoan";
            this.buttonDoan.Size = new System.Drawing.Size(162, 45);
            this.buttonDoan.TabIndex = 5;
            this.buttonDoan.Text = "Đoàn";
            this.buttonDoan.UseVisualStyleBackColor = true;
            this.buttonDoan.Click += new System.EventHandler(this.buttonDoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "NHÓM 1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDoan);
            this.Controls.Add(this.btnChiPhi);
            this.Controls.Add(this.btnKhac);
            this.Controls.Add(this.btnKhachhang);
            this.Controls.Add(this.btnGiaTour);
            this.Controls.Add(this.btnTour);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnGiaTour;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnKhac;
        private System.Windows.Forms.Button btnChiPhi;
        private System.Windows.Forms.Button buttonDoan;
        private System.Windows.Forms.Label label1;
    }
}