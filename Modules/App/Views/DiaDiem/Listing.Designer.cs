namespace App.Views.DiaDiem {
    partial class Listing {
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblQuocGia = new System.Windows.Forms.Label();
            this.lblTenLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.dataListView = new System.Windows.Forms.DataGridView();
            this.txtTenQuocGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTenTinhThanh = new System.Windows.Forms.Label();
            this.txtTenTinhThanh = new System.Windows.Forms.TextBox();
            this.chbLaKhachSan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(74, 20);
            this.lblHeader.TabIndex = 35;
            this.lblHeader.Text = "Địa Điểm";
            // 
            // lblQuocGia
            // 
            this.lblQuocGia.AutoSize = true;
            this.lblQuocGia.Location = new System.Drawing.Point(537, 42);
            this.lblQuocGia.Name = "lblQuocGia";
            this.lblQuocGia.Size = new System.Drawing.Size(77, 13);
            this.lblQuocGia.TabIndex = 33;
            this.lblQuocGia.Text = "Tên Quốc Gia:";
            // 
            // lblTenLoaiHinhDuLich
            // 
            this.lblTenLoaiHinhDuLich.AutoSize = true;
            this.lblTenLoaiHinhDuLich.Location = new System.Drawing.Point(3, 42);
            this.lblTenLoaiHinhDuLich.Name = "lblTenLoaiHinhDuLich";
            this.lblTenLoaiHinhDuLich.Size = new System.Drawing.Size(75, 13);
            this.lblTenLoaiHinhDuLich.TabIndex = 34;
            this.lblTenLoaiHinhDuLich.Text = "Tên Địa Điểm:";
            // 
            // dataListView
            // 
            this.dataListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListView.Location = new System.Drawing.Point(3, 94);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.ReadOnly = true;
            this.dataListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListView.Size = new System.Drawing.Size(794, 500);
            this.dataListView.TabIndex = 32;
            // 
            // txtTenQuocGia
            // 
            this.txtTenQuocGia.Location = new System.Drawing.Point(620, 39);
            this.txtTenQuocGia.Name = "txtTenQuocGia";
            this.txtTenQuocGia.Size = new System.Drawing.Size(176, 20);
            this.txtTenQuocGia.TabIndex = 30;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(84, 39);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(186, 20);
            this.txtTen.TabIndex = 31;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(721, 65);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 27;
            this.btnChinhSua.Text = "Chỉnh Sừa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(640, 65);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 28;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(559, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTenTinhThanh
            // 
            this.lblTenTinhThanh.AutoSize = true;
            this.lblTenTinhThanh.Location = new System.Drawing.Point(276, 42);
            this.lblTenTinhThanh.Name = "lblTenTinhThanh";
            this.lblTenTinhThanh.Size = new System.Drawing.Size(87, 13);
            this.lblTenTinhThanh.TabIndex = 37;
            this.lblTenTinhThanh.Text = "Tên Tỉnh Thành:";
            // 
            // txtTenTinhThanh
            // 
            this.txtTenTinhThanh.Location = new System.Drawing.Point(369, 39);
            this.txtTenTinhThanh.Name = "txtTenTinhThanh";
            this.txtTenTinhThanh.Size = new System.Drawing.Size(162, 20);
            this.txtTenTinhThanh.TabIndex = 36;
            // 
            // chbLaKhachSan
            // 
            this.chbLaKhachSan.AutoSize = true;
            this.chbLaKhachSan.Location = new System.Drawing.Point(84, 69);
            this.chbLaKhachSan.Name = "chbLaKhachSan";
            this.chbLaKhachSan.Size = new System.Drawing.Size(94, 17);
            this.chbLaKhachSan.TabIndex = 38;
            this.chbLaKhachSan.Text = "Là Khách Sạn";
            this.chbLaKhachSan.UseVisualStyleBackColor = true;
            // 
            // Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.chbLaKhachSan);
            this.Controls.Add(this.lblTenTinhThanh);
            this.Controls.Add(this.txtTenTinhThanh);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblQuocGia);
            this.Controls.Add(this.lblTenLoaiHinhDuLich);
            this.Controls.Add(this.dataListView);
            this.Controls.Add(this.txtTenQuocGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnSearch);
            this.Name = "Listing";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblQuocGia;
        private System.Windows.Forms.Label lblTenLoaiHinhDuLich;
        private System.Windows.Forms.DataGridView dataListView;
        private System.Windows.Forms.TextBox txtTenQuocGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTenTinhThanh;
        private System.Windows.Forms.TextBox txtTenTinhThanh;
        private System.Windows.Forms.CheckBox chbLaKhachSan;
    }
}
