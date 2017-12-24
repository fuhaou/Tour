using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Views.Tour;
using Applications;

namespace App.Controllers
{
    public class IndexControler : Singleton<IndexControler>
    {
        public UserControl IndexAction()
        {
            return new LoaiHinhDuLichListing();
        }
    }
}
