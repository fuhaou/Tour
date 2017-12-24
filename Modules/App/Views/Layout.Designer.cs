namespace App.Views {
    partial class Layout {
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnQLTour = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(221, 3);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(800, 600);
            this.pnMain.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Fuchsia;
            this.pnMenu.Controls.Add(this.btnQLTour);
            this.pnMenu.Location = new System.Drawing.Point(3, 3);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(212, 600);
            this.pnMenu.TabIndex = 1;
            // 
            // btnQLTour
            // 
            this.btnQLTour.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTour.Location = new System.Drawing.Point(3, 3);
            this.btnQLTour.Name = "btnQLTour";
            this.btnQLTour.Size = new System.Drawing.Size(206, 100);
            this.btnQLTour.TabIndex = 0;
            this.btnQLTour.Text = "Quản Lý Tour";
            this.btnQLTour.UseVisualStyleBackColor = true;
            this.btnQLTour.Click += new System.EventHandler(this.btnQLTour_Click);
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnMain);
            this.Name = "Layout";
            this.Size = new System.Drawing.Size(1024, 606);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnQLTour;
    }
}
