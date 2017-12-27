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
    public partial class Index : UserControl {
        public Index() {
            InitializeComponent();
        }

        private void btnDiaDiem_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "DiaDiem",
                "Listing",
                new Object[] { "", 0, "", "" }
            );
        }

        private void btnTinhThanh_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "DiaDiem",
                "TinhThanhListing",
                new Object[] { "", "" }
            );
        }

        private void btnQuocGia_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "DiaDiem",
                "QuocGiaListing",
                new Object[] { "" }
            );
        }
    }
}
