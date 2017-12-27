namespace App.Views.Tour {
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
            this.btnTour = new System.Windows.Forms.Button();
            this.btnLoaiHinhDuLich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTour
            // 
            this.btnTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.Location = new System.Drawing.Point(70, 70);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(300, 200);
            this.btnTour.TabIndex = 0;
            this.btnTour.Text = "Tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnLoaiHinhDuLich
            // 
            this.btnLoaiHinhDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiHinhDuLich.Location = new System.Drawing.Point(430, 70);
            this.btnLoaiHinhDuLich.Name = "btnLoaiHinhDuLich";
            this.btnLoaiHinhDuLich.Size = new System.Drawing.Size(300, 200);
            this.btnLoaiHinhDuLich.TabIndex = 0;
            this.btnLoaiHinhDuLich.Text = "Loại Hình Du Lịch";
            this.btnLoaiHinhDuLich.UseVisualStyleBackColor = true;
            this.btnLoaiHinhDuLich.Click += new System.EventHandler(this.btnLoaiHinhDuLich_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoaiHinhDuLich);
            this.Controls.Add(this.btnTour);
            this.Name = "Index";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnLoaiHinhDuLich;
    }
}
