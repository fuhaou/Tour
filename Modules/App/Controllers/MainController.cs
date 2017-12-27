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
            this.SetAction("Tour", "LoaiHinhDuLichListing", new [] {""});
        }

        public MainFrame GetMainFrame()
        {
            return this.mainFrame;
        }

        public string SetAction(string controller, string action, object[] paObjects = null)
        {
            var dataMessage = "";
            try {
                controller = "App.Controllers." + controller + "Controller";
                action = action + "Action";
                Type t = Type.GetType(controller);
                var instance = t.BaseType.GetProperty("Instance").GetValue(null);
                MethodInfo actionMethod = t.GetMethod(action);
                var view = actionMethod.Invoke(instance, paObjects);
                if (view != null) {
                    if (view is string) {
                        dataMessage = view.ToString();
                    } else {
                        this.mainFrame.SetMainScreen((UserControl)view);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            return dataMessage;
        }
    }
}
