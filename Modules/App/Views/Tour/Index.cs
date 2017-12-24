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

    public partial class Index : UserControl {
        public Index() {
            InitializeComponent();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            MainController.Instance.SetAction(
                "Tour",
                "Listing",
                new[] {"", ""}
            );
        }

        private void btnLoaiHinhDuLich_Click(object sender, EventArgs e) {
            MainController.Instance.SetAction(
                "Tour",
                "LoaiHinhDuLichListing",
                new[] { "" }
            );
        }

        private void Index_Load(object sender, EventArgs e) {

        }
    }
}
