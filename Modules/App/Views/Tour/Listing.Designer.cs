namespace App.Views.Tour
{
    partial class Listing
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
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(407, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(59, 47);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(145, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(276, 47);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(125, 20);
            this.txtTenTour.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 520);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 50);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(50, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Mã Tour:";
            // 
            // lblTenTour
            // 
            this.lblTenTour.AutoSize = true;
            this.lblTenTour.Location = new System.Drawing.Point(210, 50);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(60, 13);
            this.lblTenTour.TabIndex = 4;
            this.lblTenTour.Text = "- Tên Tour:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(488, 45);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(569, 45);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 0;
            this.btnChinhSua.Text = "Chỉnh Sừa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(104, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Quản Lý Tour";
            // 
            // Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTenTour);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnSearch);
            this.Name = "Listing";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTenTour;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label lblHeader;
    }
}
