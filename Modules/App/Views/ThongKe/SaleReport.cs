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

namespace App.Views.ThongKe {
    public partial class SaleReport : UserControl {
        public SaleReport() {
            InitializeComponent();
        }

        public void SetThongKeReport(Models.View.ThongKeSaleReportViewModel data)
        {
            lblTongChiPhiValue.Text = data.TongChiPhi.ToString("#,#") == "" ? "0" : data.TongChiPhi.ToString("#,#");
            lblTongDoanhThuValue.Text = data.TongDoanhThu.ToString("#,#") == "" ? "0" :  data.TongDoanhThu.ToString("#,#");
            lblTongSoDoanValue.Text = data.TongSoDoan.ToString("#,#") == "" ? "0" : data.TongSoDoan.ToString("#,#");
            lblTongThuValue.Text = data.TongThu.ToString("#,#") == "" ? "0" : data.TongThu.ToString("#,#") ;
            dataListView.DataSource = data.ListData;
            dataListView.Refresh();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var tourcode = txtMaTour.Text;
            var doancode = txtMaDoan.Text;
            var datefrom = dtpFrom.Value;
            var dateto = dtpTo.Value;
            MainController.Instance.SetAction(
                "ThongKe",
                "SaleReport",
                new object[] {tourcode, doancode, dateto, datefrom}
            );
        }
    }
}
