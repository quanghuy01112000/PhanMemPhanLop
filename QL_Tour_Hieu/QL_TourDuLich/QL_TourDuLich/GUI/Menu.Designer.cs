
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
            this.SuspendLayout();
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(104, 81);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(75, 23);
            this.btnTour.TabIndex = 0;
            this.btnTour.Text = "Tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnGiaTour
            // 
            this.btnGiaTour.Location = new System.Drawing.Point(316, 81);
            this.btnGiaTour.Name = "btnGiaTour";
            this.btnGiaTour.Size = new System.Drawing.Size(75, 23);
            this.btnGiaTour.TabIndex = 1;
            this.btnGiaTour.Text = "GiaTour";
            this.btnGiaTour.UseVisualStyleBackColor = true;
            this.btnGiaTour.Click += new System.EventHandler(this.btnGiaTour_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Location = new System.Drawing.Point(104, 150);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(109, 23);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "KhachHang";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnKhac
            // 
            this.btnKhac.Location = new System.Drawing.Point(316, 149);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(75, 23);
            this.btnKhac.TabIndex = 3;
            this.btnKhac.Text = "Khac";
            this.btnKhac.UseVisualStyleBackColor = true;
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKhac);
            this.Controls.Add(this.btnKhachhang);
            this.Controls.Add(this.btnGiaTour);
            this.Controls.Add(this.btnTour);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnGiaTour;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnKhac;
    }
}