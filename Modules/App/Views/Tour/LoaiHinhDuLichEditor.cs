using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace App.Views.Tour {
    public partial class LoaiHinhDuLichEditor : UserControl {
        private int _id;
        public void SetId(int id) {
            this._id = id;
        }

        public LoaiHinhDuLichEditor() {
            InitializeComponent();
            this._id = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtTen.Text;
            var note = this.txtNote.Text;
            if (this._id != 0 ) {
                LoaiHinhDuLichModel.Instance.Update(
                    this._id,
                    name,
                    note
                );
            } else {
                LoaiHinhDuLichModel.Instance.Insert(
                    name, note
                );
            }
        }
    }
}
