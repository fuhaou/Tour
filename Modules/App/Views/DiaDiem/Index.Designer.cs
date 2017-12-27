namespace App.Views.DiaDiem {
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
            this.btnTinhThanh = new System.Windows.Forms.Button();
            this.btnDiaDiem = new System.Windows.Forms.Button();
            this.btnQuocGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhThanh.Location = new System.Drawing.Point(430, 70);
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.Size = new System.Drawing.Size(300, 200);
            this.btnTinhThanh.TabIndex = 1;
            this.btnTinhThanh.Text = "Tỉnh Thành";
            this.btnTinhThanh.UseVisualStyleBackColor = true;
            this.btnTinhThanh.Click += new System.EventHandler(this.btnTinhThanh_Click);
            // 
            // btnDiaDiem
            // 
            this.btnDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiaDiem.Location = new System.Drawing.Point(70, 70);
            this.btnDiaDiem.Name = "btnDiaDiem";
            this.btnDiaDiem.Size = new System.Drawing.Size(300, 200);
            this.btnDiaDiem.TabIndex = 2;
            this.btnDiaDiem.Text = "Địa Điểm";
            this.btnDiaDiem.UseVisualStyleBackColor = true;
            this.btnDiaDiem.Click += new System.EventHandler(this.btnDiaDiem_Click);
            // 
            // btnQuocGia
            // 
            this.btnQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuocGia.Location = new System.Drawing.Point(70, 330);
            this.btnQuocGia.Name = "btnQuocGia";
            this.btnQuocGia.Size = new System.Drawing.Size(300, 200);
            this.btnQuocGia.TabIndex = 4;
            this.btnQuocGia.Text = "Quốc Gia";
            this.btnQuocGia.UseVisualStyleBackColor = true;
            this.btnQuocGia.Click += new System.EventHandler(this.btnQuocGia_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuocGia);
            this.Controls.Add(this.btnTinhThanh);
            this.Controls.Add(this.btnDiaDiem);
            this.Name = "Index";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTinhThanh;
        private System.Windows.Forms.Button btnDiaDiem;
        private System.Windows.Forms.Button btnQuocGia;
    }
}
