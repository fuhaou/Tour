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
    public partial class Listing : UserControl {
        public Listing() {
            InitializeComponent();
        }
        public void SetList<T>(List<Models.Dao.DiaDiem> list) {
            List<object> dataList = new List<object>();
            foreach (var item in list) {
                var tinhthanh = item.TinhThanh == null ? "" : item.TinhThanh.TinhThanhTen;
                var quocgia = item.TinhThanh.QuocGia == null ? "" : item.TinhThanh.QuocGia.QuocGiaTen;
                dataList.Add(new {
                    id = item.DiaDiemId,
                    ten = item.DiaDiemTen,
                    TinhThanh = tinhthanh,
                    QuocGia = quocgia
                });
            }
            this.dataListView.DataSource = dataList;
            this.dataListView.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            var name = txtTen.Text;
            var isHotel = chbLaKhachSan.Checked ? 1 : 0;
            var tenQuocgia = txtTenQuocGia.Text;
            var tenTinhThanh = txtTenTinhThanh.Text;
            MainController.Instance.SetAction(
                "DiaDiem",
                "Listing",
                new Object[] { name, isHotel, tenTinhThanh, tenQuocgia }
            );
        }

        private void btnThemMoi_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "DiaDiem",
                "Editor",
                new Object[] { 0 }
            );
        }

        private void btnChinhSua_Click(object sender, EventArgs e) {
            var id = 0;
            if (dataListView.SelectedRows.Count > 0) {
                id = int.Parse(dataListView.SelectedRows[0].Cells[0].Value.ToString());
            }
            MainController.Instance.SetAction(
                "DiaDiem",
                "Editor",
                new Object[] { id }
            );
        }
    }
}
