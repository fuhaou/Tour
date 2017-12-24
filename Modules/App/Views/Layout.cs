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

namespace App.Views {
    public partial class Layout : UserControl {

        public Layout() {
            InitializeComponent();
        }

        public void SetMainPanel(UserControl control)
        {
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(control);
        }

        private void btnQLTour_Click(object sender, EventArgs e)
        {
            MainController.Instance.SetAction(
                "Tour",
                "Index"
            );
        }
    }
}
