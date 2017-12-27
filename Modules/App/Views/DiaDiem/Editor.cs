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
    public partial class Editor : UserControl {
        public Editor() {
            InitializeComponent();
        }
        private int _id;
        public void SetId(int id) {
            this._id = id;
            lblAction.Text = id == 0 ? "Thêm Mới" : "Chỉnh sửa";
        }

        public void SetList<T>(List<Models.Dao.TinhThanh> list) {
            List<object> dataList = new List<object>();
            foreach (var item in list) {
                var quocgia = item.QuocGia == null ? "" : item.QuocGia.QuocGiaTen;
                dataList.Add(new {
                    id = item.TinhThanhId,
                    ten = item.TinhThanhTen,
                    QuocGia = quocgia
                });
            }
            this.dataListView.DataSource = dataList;
            this.dataListView.Refresh();
        }

        public void SetTen(string name) {
            txtTen.Text = name;
        }

        public void SetKhachSan(int khachsan) {
            chbLaKhachSan.Checked = khachsan == 1;
        }

        public void SetTinhThanh(int tinhthanh)
        {
            dataListView.ClearSelection();
            foreach (DataGridViewRow item in dataListView.Rows) {
                if (int.Parse(item.Cells[0].Value.ToString()) == tinhthanh) {
                    item.Selected = true;
                    dataListView.CurrentCell = item.Cells[0];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var name = this.txtTen.Text;
            var isHotel = chbLaKhachSan.Checked ? 1 : 0;
            var id = 0;
            if (dataListView.SelectedRows.Count > 0) {
                id = int.Parse(dataListView.SelectedRows[0].Cells[0].Value.ToString());
            }
            MainController.Instance.SetAction(
                "DiaDiem",
                "EditorSave",
                new Object[] { _id, name, isHotel, id }
            );
        }
    }
}
