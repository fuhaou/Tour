namespace App.Views.DiaDiem {
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
            this.mainContainer = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTypeAction = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.chbLaKhachSan = new System.Windows.Forms.CheckBox();
            this.dataListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.label1);
            this.mainContainer.Controls.Add(this.dataListView);
            this.mainContainer.Controls.Add(this.chbLaKhachSan);
            this.mainContainer.Controls.Add(this.btnSave);
            this.mainContainer.Controls.Add(this.txtTen);
            this.mainContainer.Controls.Add(this.lblAction);
            this.mainContainer.Controls.Add(this.lblTypeAction);
            this.mainContainer.Controls.Add(this.lblTen);
            this.mainContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainContainer.Location = new System.Drawing.Point(3, 3);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(794, 594);
            this.mainContainer.TabIndex = 20;
            this.mainContainer.TabStop = false;
            this.mainContainer.Text = "Chỉnh Sửa/Thêm Mới Tỉnh Thành";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(655, 538);
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
            this.txtTen.Location = new System.Drawing.Point(128, 102);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(627, 26);
            this.txtTen.TabIndex = 16;
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
            // chbLaKhachSan
            // 
            this.chbLaKhachSan.AutoSize = true;
            this.chbLaKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLaKhachSan.Location = new System.Drawing.Point(128, 134);
            this.chbLaKhachSan.Name = "chbLaKhachSan";
            this.chbLaKhachSan.Size = new System.Drawing.Size(128, 24);
            this.chbLaKhachSan.TabIndex = 39;
            this.chbLaKhachSan.Text = "Là Khách Sạn";
            this.chbLaKhachSan.UseVisualStyleBackColor = true;
            // 
            // dataListView
            // 
            this.dataListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListView.Location = new System.Drawing.Point(43, 196);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.ReadOnly = true;
            this.dataListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListView.Size = new System.Drawing.Size(712, 336);
            this.dataListView.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Chọn Tỉnh Thành:";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblTypeAction;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.CheckBox chbLaKhachSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataListView;
    }
}
