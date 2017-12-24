using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Views.Tour;
using Applications;

namespace App.Controllers {
    public class TourController : Singleton<TourController> {
        public UserControl LoaiHinhDuLichListingAction()
        {
            return new LoaiHinhDuLichListing();
        }
    }
}
