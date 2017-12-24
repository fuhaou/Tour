namespace App.Views.Tour {
    partial class LoaiHinhDuLichEditor {
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
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.GroupBox();
            this.lblTypeAction = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(655, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(107, 102);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(648, 26);
            this.txtTen.TabIndex = 16;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(107, 147);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(648, 105);
            this.txtNote.TabIndex = 16;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(30, 150);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(71, 20);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "Ghi Chú:";
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.btnSave);
            this.mainContainer.Controls.Add(this.lblNote);
            this.mainContainer.Controls.Add(this.txtNote);
            this.mainContainer.Controls.Add(this.txtTen);
            this.mainContainer.Controls.Add(this.lblAction);
            this.mainContainer.Controls.Add(this.lblTypeAction);
            this.mainContainer.Controls.Add(this.lblTen);
            this.mainContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainContainer.Location = new System.Drawing.Point(3, 3);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(794, 594);
            this.mainContainer.TabIndex = 17;
            this.mainContainer.TabStop = false;
            this.mainContainer.Text = "Chỉnh Sửa/Thêm Mới Loại Hình Du Lịch";
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
            // LoaiHinhDuLichEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "LoaiHinhDuLichEditor";
            this.Size = new System.Drawing.Size(800, 600);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox mainContainer;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblTypeAction;
    }
}
