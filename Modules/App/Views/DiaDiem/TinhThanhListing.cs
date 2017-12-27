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
using Models.Dao;

namespace App.Views.DiaDiem {
    public partial class TinhThanhListing : UserControl {

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

        public TinhThanhListing() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = txtTen.Text;
            var tenQuocgia = txtTenQuocGia.Text;
            MainController.Instance.SetAction(
                "DiaDiem",
                "TinhThanhListing",
                new Object[] { name, tenQuocgia }
            );
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            MainController.Instance.SetAction(
                "DiaDiem",
                "TinhThanhEditor",
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
                "TinhThanhEditor",
                new Object[] { id }
            );
        }
    }
}
