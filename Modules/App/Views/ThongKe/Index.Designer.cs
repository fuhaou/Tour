namespace App.Views.ThongKe {
    partial class Index {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnQuocGia = new System.Windows.Forms.Button();
            this.btnTinhThanh = new System.Windows.Forms.Button();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuocGia
            // 
            this.btnQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuocGia.Location = new System.Drawing.Point(70, 330);
            this.btnQuocGia.Name = "btnQuocGia";
            this.btnQuocGia.Size = new System.Drawing.Size(300, 200);
            this.btnQuocGia.TabIndex = 7;
            this.btnQuocGia.Text = "Quốc Gia";
            this.btnQuocGia.UseVisualStyleBackColor = true;
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhThanh.Location = new System.Drawing.Point(430, 70);
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.Size = new System.Drawing.Size(300, 200);
            this.btnTinhThanh.TabIndex = 5;
            this.btnTinhThanh.Text = "Tỉnh Thành";
            this.btnTinhThanh.UseVisualStyleBackColor = true;
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReport.Location = new System.Drawing.Point(70, 70);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(300, 200);
            this.btnSaleReport.TabIndex = 6;
            this.btnSaleReport.Text = "Thống Kê Đoàn Đi Tour";
            this.btnSaleReport.UseVisualStyleBackColor = true;
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuocGia);
            this.Controls.Add(this.btnTinhThanh);
            this.Controls.Add(this.btnSaleReport);
            this.Name = "Index";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuocGia;
        private System.Windows.Forms.Button btnTinhThanh;
        private System.Windows.Forms.Button btnSaleReport;
    }
}
