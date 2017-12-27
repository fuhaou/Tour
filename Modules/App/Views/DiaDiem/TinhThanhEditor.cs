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
    public partial class TinhThanhEditor : UserControl {
        private int _id;
        public void SetId(int id)
        {
            this._id = id;
            lblAction.Text = id == 0 ? "Thêm Mới" : "Chỉnh sửa";
        }

        public TinhThanhEditor() {
            InitializeComponent();
        }

        public void SetQuocGiaData<T>(List<T> data)
        {
            this.cbxQuocGia.DataSource = data;
            cbxQuocGia.ValueMember = "QuocGiaId";
            cbxQuocGia.DisplayMember = "QuocGiaTen";
            cbxQuocGia.SelectedValue = 0;
        }
        
        public void SetTen(string name)
        {
            txtTen.Text = name;
        }

        public void SetQuocGia(int quocgia)
        {
            cbxQuocGia.SelectedValue = quocgia;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var name = this.txtTen.Text;
            var idquocgia = this.cbxQuocGia.SelectedValue;
            MainController.Instance.SetAction(
                "DiaDiem",
                "TinhThanhEditorSave",
                new Object[] { _id, name, idquocgia }
            );
        }
    }
}
