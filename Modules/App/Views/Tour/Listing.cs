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

namespace App.Views.Tour
{
    public partial class Listing : UserControl
    {
        public Listing()
        {
            InitializeComponent();
        }

        public void SetList<T>(List<Models.Dao.Tour> list) {
            List<object> dataList = new List<object>();
            foreach (var item in list) {
                var loaihinhdulich = item.LoaiHinhDulich == null ? "" : item.LoaiHinhDulich.LoaiHinhDulichTen;
                dataList.Add(new {
                    Id = item.TourId,
                    Code = item.TourCode,
                    Ten = item.TourTen,
                    Price = item.TourPrice,
                    LoaiHinhDuLich = loaihinhdulich
                });
            }
            this.dataListView.DataSource = dataList;
            this.dataListView.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = txtTenTour.Text;
            var code = txtCode.Text;
            MainController.Instance.SetAction(
                "Tour",
                "Listing",
                new Object[] { code, name}
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
                "Editor",
                new Object[] { id }
            );
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            MainController.Instance.SetAction(
                "Tour",
                "Editor",
                new Object[] { 0 }
            );
        }
    }
}
