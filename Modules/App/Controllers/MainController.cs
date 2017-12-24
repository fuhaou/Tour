using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applications;

namespace App.Controllers {
    public class MainController : Singleton<MainController> {
        private MainFrame mainFrame;

        protected MainController()
        {
            mainFrame = new MainFrame();
            this.SetAction("Tour", "LoaiHinhDuLichListing");
        }

        public MainFrame GetMainFrame()
        {
            return this.mainFrame;
        }

        public void SetAction(string controller, string action)
        {
            controller = "App.Controllers." + controller + "Controller";
            action = action + "Action";
            Type t = Type.GetType(controller);
            var instance = t.BaseType.GetProperty("Instance").GetValue(null);
            MethodInfo actionMethod = t.GetMethod(action);
            var view = (UserControl)actionMethod.Invoke(instance, null);
            this.mainFrame.SetMainScreen(view);
        }
    }
}
