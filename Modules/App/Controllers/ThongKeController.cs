using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applications;

namespace App.Controllers {
    public class ThongKeController : Singleton<ThongKeController> {

        public UserControl IndexAction()
        {
            return new Views.ThongKe.Index();
        }


        public UserControl SaleReportAction(string tourcode, string doancode, DateTime from, DateTime to)
        {
            Views.ThongKe.SaleReport view = new Views.ThongKe.SaleReport();
            view.SetThongKeReport(
                Models.DoanModel.Instance.GetReport( tourcode,  doancode,  from, to)
            );
            return view;
        }
    }
}
