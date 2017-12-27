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
    public partial class QuocGiaListing : UserControl {
        public QuocGiaListing() {
            InitializeComponent();
        }

        public void SetList<T>(List<T> list) {
            this.dataListView.DataSource = list;
            this.dataListView.Columns["TinhThanhs"].Visible = false;
            this.dataListView.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            var name = this.txtTenQuocGia.Text;
            MainController.Instance.SetAction(
                "DiaDiem",
                "QuocGiaListing",
                new[] { name }
            );
        }

        private void btnThemMoi_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "DiaDiem",
                "QuocGiaEditor",
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
                "QuocGiaEditor",
                new Object[] { id }
            );
        }
    }
}
