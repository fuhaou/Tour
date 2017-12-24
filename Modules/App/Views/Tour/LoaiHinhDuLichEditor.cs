using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Controllers;
using Models;

namespace App.Views.Tour {
    public partial class LoaiHinhDuLichEditor : UserControl {
        private int _id;
        public void SetId(int id) {
            this._id = id;
            if (id == 0) {
                lblAction.Text = "Thêm Mới";
            }
            else {
                lblAction.Text = "Chỉnh sửa";
            }
        }

        public void SetTen(string name)
        {
            txtTen.Text = name;
        }

        public void SetNote(string note)
        {
            txtNote.Text = note;
        }

        public LoaiHinhDuLichEditor() {
            InitializeComponent();
            this._id = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtTen.Text;
            var note = this.txtNote.Text;
            MainController.Instance.SetAction(
                "Tour",
                "LoaiHinhDuLichEditorSave",
                new Object[] { _id , name , note  }
            );
        }
    }
}
