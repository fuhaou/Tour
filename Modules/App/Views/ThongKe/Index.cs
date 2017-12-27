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
    public partial class Index : UserControl {
        public Index() {
            InitializeComponent();
        }

        private void btnSaleReport_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "ThongKe",
                "SaleReport",
                new Object[] {"", "", DateTime.MinValue, DateTime.MaxValue}
            );
        }
    }
}
