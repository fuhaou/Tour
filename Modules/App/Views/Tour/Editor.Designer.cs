namespace App.Views.Tour {
    partial class Editor {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.GroupBox();
            this.subContainer = new System.Windows.Forms.GroupBox();
            this.ctListView = new System.Windows.Forms.DataGridView();
            this.dataListView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDiaDiemTen = new System.Windows.Forms.TextBox();
            this.btnCTSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLoaiHinhDuLich = new System.Windows.Forms.ComboBox();
            this.lblLoaiHinhDuLich = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTypeAction = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.subContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(655, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(174, 102);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(581, 26);
            this.txtTen.TabIndex = 16;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(30, 105);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(40, 20);
            this.lblTen.TabIndex = 15;
            this.lblTen.Text = "Tên:";
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.subContainer);
            this.mainContainer.Controls.Add(this.cbxLoaiHinhDuLich);
            this.mainContainer.Controls.Add(this.lblLoaiHinhDuLich);
            this.mainContainer.Controls.Add(this.txtGia);
            this.mainContainer.Controls.Add(this.lblGia);
            this.mainContainer.Controls.Add(this.btnSave);
            this.mainContainer.Controls.Add(this.txtTen);
            this.mainContainer.Controls.Add(this.lblAction);
            this.mainContainer.Controls.Add(this.lblTypeAction);
            this.mainContainer.Controls.Add(this.lblTen);
            this.mainContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainContainer.Location = new System.Drawing.Point(3, 3);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(794, 594);
            this.mainContainer.TabIndex = 18;
            this.mainContainer.TabStop = false;
            this.mainContainer.Text = "Chỉnh Sửa/Thêm Mới Tour";
            // 
            // subContainer
            // 
            this.subContainer.Controls.Add(this.ctListView);
            this.subContainer.Controls.Add(this.dataListView);
            this.subContainer.Controls.Add(this.btnSearch);
            this.subContainer.Controls.Add(this.txtDiaDiemTen);
            this.subContainer.Controls.Add(this.btnCTSave);
            this.subContainer.Controls.Add(this.btnAdd);
            this.subContainer.Controls.Add(this.label2);
            this.subContainer.Controls.Add(this.label1);
            this.subContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subContainer.Location = new System.Drawing.Point(6, 276);
            this.subContainer.Name = "subContainer";
            this.subContainer.Size = new System.Drawing.Size(782, 312);
            this.subContainer.TabIndex = 21;
            this.subContainer.TabStop = false;
            this.subContainer.Text = "Chi Tiết Tour";
            // 
            // ctListView
            // 
            this.ctListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctListView.Location = new System.Drawing.Point(419, 46);
            this.ctListView.MultiSelect = false;
            this.ctListView.Name = "ctListView";
            this.ctListView.ReadOnly = true;
            this.ctListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctListView.Size = new System.Drawing.Size(357, 227);
            this.ctListView.TabIndex = 33;
            this.ctListView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctListView_CellClick);
            // 
            // dataListView
            // 
            this.dataListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListView.Location = new System.Drawing.Point(6, 78);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.ReadOnly = true;
            this.dataListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListView.Size = new System.Drawing.Size(354, 228);
            this.dataListView.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(300, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDiaDiemTen
            // 
            this.txtDiaDiemTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiemTen.Location = new System.Drawing.Point(6, 46);
            this.txtDiaDiemTen.Name = "txtDiaDiemTen";
            this.txtDiaDiemTen.Size = new System.Drawing.Size(288, 26);
            this.txtDiaDiemTen.TabIndex = 16;
            // 
            // btnCTSave
            // 
            this.btnCTSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTSave.Location = new System.Drawing.Point(419, 279);
            this.btnCTSave.Name = "btnCTSave";
            this.btnCTSave.Size = new System.Drawing.Size(357, 27);
            this.btnCTSave.TabIndex = 14;
            this.btnCTSave.Text = "Lưu";
            this.btnCTSave.UseVisualStyleBackColor = true;
            this.btnCTSave.Click += new System.EventHandler(this.btnCTSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(366, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 112);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chi Tiết Địa Điểm Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh Sách Địa Điểm";
            // 
            // cbxLoaiHinhDuLich
            // 
            this.cbxLoaiHinhDuLich.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLoaiHinhDuLich.FormattingEnabled = true;
            this.cbxLoaiHinhDuLich.Location = new System.Drawing.Point(174, 181);
            this.cbxLoaiHinhDuLich.Name = "cbxLoaiHinhDuLich";
            this.cbxLoaiHinhDuLich.Size = new System.Drawing.Size(581, 33);
            this.cbxLoaiHinhDuLich.TabIndex = 20;
            // 
            // lblLoaiHinhDuLich
            // 
            this.lblLoaiHinhDuLich.AutoSize = true;
            this.lblLoaiHinhDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHinhDuLich.Location = new System.Drawing.Point(30, 188);
            this.lblLoaiHinhDuLich.Name = "lblLoaiHinhDuLich";
            this.lblLoaiHinhDuLich.Size = new System.Drawing.Size(138, 20);
            this.lblLoaiHinhDuLich.TabIndex = 19;
            this.lblLoaiHinhDuLich.Text = "Loại Hình Du Lịch:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(174, 143);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(581, 26);
            this.txtGia.TabIndex = 18;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(30, 146);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(38, 20);
            this.lblGia.TabIndex = 17;
            this.lblGia.Text = "Giá:";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(135, 60);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(78, 20);
            this.lblAction.TabIndex = 15;
            this.lblAction.Text = "Thêm Mới";
            // 
            // lblTypeAction
            // 
            this.lblTypeAction.AutoSize = true;
            this.lblTypeAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAction.Location = new System.Drawing.Point(30, 60);
            this.lblTypeAction.Name = "lblTypeAction";
            this.lblTypeAction.Size = new System.Drawing.Size(99, 20);
            this.lblTypeAction.TabIndex = 15;
            this.lblTypeAction.Text = "Hành Động: ";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "Editor";
            this.Size = new System.Drawing.Size(800, 600);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.subContainer.ResumeLayout(false);
            this.subContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.GroupBox mainContainer;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblTypeAction;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ComboBox cbxLoaiHinhDuLich;
        private System.Windows.Forms.Label lblLoaiHinhDuLich;
        private System.Windows.Forms.GroupBox subContainer;
        private System.Windows.Forms.DataGridView ctListView;
        private System.Windows.Forms.DataGridView dataListView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDiaDiemTen;
        private System.Windows.Forms.Button btnCTSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}
