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

namespace App.Views.Tour {
    public partial class LoaiHinhDuLichListing : UserControl {
        public LoaiHinhDuLichListing() {
            InitializeComponent();
        }

        public void SetList<T>(List<T> list)
        {
            this.dataListView.DataSource = list;
            Console.WriteLine(list);
            this.dataListView.Columns["LoaiHinhDuLichId"].Visible = false;
            this.dataListView.Columns["Tours"].Visible = false;
            this.dataListView.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = this.txtTenLoaiHinhDuLich.Text;
            MainController.Instance.SetAction(
                "Tour",
                "LoaiHinhDuLichListing",
                new[] {name}
            );
        }

        private void btnThemMoi_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "Tour",
                "LoaiHinhDuLichEditor",
                new Object[] { 0 }
            );
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (dataListView.SelectedRows.Count > 0) {
                id = int.Parse(dataListView.SelectedRows[0].Cells[0].Value.ToString());
            }
            MainController.Instance.SetAction(
                "Tour",
                "LoaiHinhDuLichEditor",
                new Object[] { id }
            );
        }
    }
}
