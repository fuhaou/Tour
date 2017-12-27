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

namespace App.Views.DiaDiem {
    public partial class QuocGiaEditor : UserControl {
        private int _id;
        public void SetId(int id) {
            this._id = id;
            if (id == 0) {
                lblAction.Text = "Thêm Mới";
            } else {
                lblAction.Text = "Chỉnh sửa";
            }
        }

        public void SetTen(string name) {
            txtTen.Text = name;
        }

        public QuocGiaEditor() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var name = this.txtTen.Text;
            MainController.Instance.SetAction(
                "DiaDiem",
                "QuocGiaEditorSave",
                new Object[] { _id, name }
            );
        }
    }
}
