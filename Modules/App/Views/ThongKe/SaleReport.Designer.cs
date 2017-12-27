namespace App.Views.ThongKe {
    partial class SaleReport {
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
            this.lblMaDoan = new System.Windows.Forms.Label();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblMaTour = new System.Windows.Forms.Label();
            this.dataListView = new System.Windows.Forms.DataGridView();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.lblTongChiPhiValue = new System.Windows.Forms.Label();
            this.lblTongSoDoan = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblTongSoDoanValue = new System.Windows.Forms.Label();
            this.lblTongDoanhThuValue = new System.Windows.Forms.Label();
            this.lblTongThuValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDoan
            // 
            this.lblMaDoan.AutoSize = true;
            this.lblMaDoan.Location = new System.Drawing.Point(193, 42);
            this.lblMaDoan.Name = "lblMaDoan";
            this.lblMaDoan.Size = new System.Drawing.Size(54, 13);
            this.lblMaDoan.TabIndex = 49;
            this.lblMaDoan.Text = "Mã Đoàn:";
            // 
            // txtMaDoan
            // 
            this.txtMaDoan.Location = new System.Drawing.Point(253, 39);
            this.txtMaDoan.Name = "txtMaDoan";
            this.txtMaDoan.Size = new System.Drawing.Size(134, 20);
            this.txtMaDoan.TabIndex = 48;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(184, 20);
            this.lblHeader.TabIndex = 47;
            this.lblHeader.Text = "Thống Kê - Đoàn Đi Tour";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(393, 42);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(51, 13);
            this.lblFrom.TabIndex = 45;
            this.lblFrom.Text = "Từ Ngày:";
            // 
            // lblMaTour
            // 
            this.lblMaTour.AutoSize = true;
            this.lblMaTour.Location = new System.Drawing.Point(3, 42);
            this.lblMaTour.Name = "lblMaTour";
            this.lblMaTour.Size = new System.Drawing.Size(50, 13);
            this.lblMaTour.TabIndex = 46;
            this.lblMaTour.Text = "Mã Tour:";
            // 
            // dataListView
            // 
            this.dataListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListView.Location = new System.Drawing.Point(3, 66);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.ReadOnly = true;
            this.dataListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListView.Size = new System.Drawing.Size(794, 494);
            this.dataListView.TabIndex = 44;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(59, 39);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(128, 20);
            this.txtMaTour.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(730, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd - MM - yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(450, 39);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(104, 20);
            this.dtpFrom.TabIndex = 51;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(560, 42);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(53, 13);
            this.lblTo.TabIndex = 45;
            this.lblTo.Text = "Tới Ngày:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd - MM - yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(619, 39);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(105, 20);
            this.dtpTo.TabIndex = 51;
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChiPhi.Location = new System.Drawing.Point(352, 571);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(80, 15);
            this.lblTongChiPhi.TabIndex = 46;
            this.lblTongChiPhi.Text = "Tổng Chi Phí:";
            // 
            // lblTongChiPhiValue
            // 
            this.lblTongChiPhiValue.AutoSize = true;
            this.lblTongChiPhiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChiPhiValue.Location = new System.Drawing.Point(438, 571);
            this.lblTongChiPhiValue.Name = "lblTongChiPhiValue";
            this.lblTongChiPhiValue.Size = new System.Drawing.Size(15, 15);
            this.lblTongChiPhiValue.TabIndex = 57;
            this.lblTongChiPhiValue.Text = "0";
            // 
            // lblTongSoDoan
            // 
            this.lblTongSoDoan.AutoSize = true;
            this.lblTongSoDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoDoan.Location = new System.Drawing.Point(4, 571);
            this.lblTongSoDoan.Name = "lblTongSoDoan";
            this.lblTongSoDoan.Size = new System.Drawing.Size(89, 15);
            this.lblTongSoDoan.TabIndex = 59;
            this.lblTongSoDoan.Text = "Tổng Số Đoàn:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(558, 571);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(102, 15);
            this.lblTongDoanhThu.TabIndex = 60;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu:";
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.Location = new System.Drawing.Point(161, 571);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(62, 15);
            this.lblTongThu.TabIndex = 61;
            this.lblTongThu.Text = "Tổng Thu:";
            // 
            // lblTongSoDoanValue
            // 
            this.lblTongSoDoanValue.AutoSize = true;
            this.lblTongSoDoanValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoDoanValue.Location = new System.Drawing.Point(99, 571);
            this.lblTongSoDoanValue.Name = "lblTongSoDoanValue";
            this.lblTongSoDoanValue.Size = new System.Drawing.Size(15, 15);
            this.lblTongSoDoanValue.TabIndex = 62;
            this.lblTongSoDoanValue.Text = "0";
            // 
            // lblTongDoanhThuValue
            // 
            this.lblTongDoanhThuValue.AutoSize = true;
            this.lblTongDoanhThuValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThuValue.Location = new System.Drawing.Point(666, 571);
            this.lblTongDoanhThuValue.Name = "lblTongDoanhThuValue";
            this.lblTongDoanhThuValue.Size = new System.Drawing.Size(15, 15);
            this.lblTongDoanhThuValue.TabIndex = 63;
            this.lblTongDoanhThuValue.Text = "0";
            // 
            // lblTongThuValue
            // 
            this.lblTongThuValue.AutoSize = true;
            this.lblTongThuValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThuValue.Location = new System.Drawing.Point(229, 571);
            this.lblTongThuValue.Name = "lblTongThuValue";
            this.lblTongThuValue.Size = new System.Drawing.Size(15, 15);
            this.lblTongThuValue.TabIndex = 64;
            this.lblTongThuValue.Text = "0";
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTongSoDoan);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lblTongThu);
            this.Controls.Add(this.lblTongSoDoanValue);
            this.Controls.Add(this.lblTongDoanhThuValue);
            this.Controls.Add(this.lblTongThuValue);
            this.Controls.Add(this.lblTongChiPhiValue);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblMaDoan);
            this.Controls.Add(this.txtMaDoan);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTongChiPhi);
            this.Controls.Add(this.lblMaTour);
            this.Controls.Add(this.dataListView);
            this.Controls.Add(this.txtMaTour);
            this.Controls.Add(this.btnSearch);
            this.Name = "SaleReport";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaDoan;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblMaTour;
        private System.Windows.Forms.DataGridView dataListView;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.Label lblTongChiPhiValue;
        private System.Windows.Forms.Label lblTongSoDoan;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblTongSoDoanValue;
        private System.Windows.Forms.Label lblTongDoanhThuValue;
        private System.Windows.Forms.Label lblTongThuValue;
    }
}
