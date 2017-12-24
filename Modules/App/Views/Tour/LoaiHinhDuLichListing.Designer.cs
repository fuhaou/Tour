namespace App.Views.Tour {
    partial class LoaiHinhDuLichListing {
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
            this.lblTenLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.dataListView = new System.Windows.Forms.DataGridView();
            this.txtTenLoaiHinhDuLich = new System.Windows.Forms.TextBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenLoaiHinhDuLich
            // 
            this.lblTenLoaiHinhDuLich.AutoSize = true;
            this.lblTenLoaiHinhDuLich.Location = new System.Drawing.Point(3, 50);
            this.lblTenLoaiHinhDuLich.Name = "lblTenLoaiHinhDuLich";
            this.lblTenLoaiHinhDuLich.Size = new System.Drawing.Size(114, 13);
            this.lblTenLoaiHinhDuLich.TabIndex = 11;
            this.lblTenLoaiHinhDuLich.Text = "Tên Loại Hình Du Lịch";
            // 
            // dataListView
            // 
            this.dataListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListView.Location = new System.Drawing.Point(3, 77);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.ReadOnly = true;
            this.dataListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListView.Size = new System.Drawing.Size(794, 520);
            this.dataListView.TabIndex = 10;
            // 
            // txtTenLoaiHinhDuLich
            // 
            this.txtTenLoaiHinhDuLich.Location = new System.Drawing.Point(123, 47);
            this.txtTenLoaiHinhDuLich.Name = "txtTenLoaiHinhDuLich";
            this.txtTenLoaiHinhDuLich.Size = new System.Drawing.Size(183, 20);
            this.txtTenLoaiHinhDuLich.TabIndex = 9;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(474, 45);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 5;
            this.btnChinhSua.Text = "Chỉnh Sừa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(393, 45);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(134, 20);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Loại Hình Du Lịch";
            // 
            // LoaiHinhDuLichListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTenLoaiHinhDuLich);
            this.Controls.Add(this.dataListView);
            this.Controls.Add(this.txtTenLoaiHinhDuLich);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnSearch);
            this.Name = "LoaiHinhDuLichListing";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenLoaiHinhDuLich;
        private System.Windows.Forms.DataGridView dataListView;
        private System.Windows.Forms.TextBox txtTenLoaiHinhDuLich;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblHeader;
    }
}
