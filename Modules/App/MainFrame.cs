using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Views;

namespace App
{
    public partial class MainFrame : Form {
        private Views.Layout layout;
        public MainFrame()
        {
            InitializeComponent();
            layout = new Layout();
            this.Controls.Add(layout);
        }

        public void SetMainScreen(UserControl control)
        {
            this.layout.SetMainPanel(control);
        }

        private void MainFrame_Load(object sender, EventArgs e) {
            
        }
    }
}
