using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Views.Tour;
using Applications;
using Models;

namespace App.Controllers {
    public class TourController : Singleton<TourController> {
        public UserControl IndexAction()
        {
            UserControl view = new Views.Tour.Index();
            return view;
        }

        public UserControl ListingAction(string code , string name)
        {
            UserControl view = new Views.Tour.Listing();
            //TODO: STILL HAS TO DO
            return view;
        }

        public UserControl LoaiHinhDuLichListingAction(string name) {
            LoaiHinhDuLichListing view = new LoaiHinhDuLichListing();
            Console.WriteLine(name);
            view.SetList<Models.Dao.LoaiHinhDulich>(
                Models.LoaiHinhDuLichModel.Instance.SearchList(name)
            );
            return view;
        }

        public UserControl LoaiHinhDuLichEditorAction(int id) {
            LoaiHinhDuLichEditor view = new LoaiHinhDuLichEditor();
            if (id != 0) {
                var data = Models.LoaiHinhDuLichModel.Instance.GetById(id);
                view.SetTen(data.LoaiHinhDulichTen);
                view.SetNote(data.LoaiHinhDulichNote);
            }
            view.SetId(id);
            return view;
        }

        public UserControl LoaiHinhDuLichEditorSaveAction(int id, string name, string note) {
            if (id != 0) {
                LoaiHinhDuLichModel.Instance.Update(
                    id,
                    name,
                    note
                );
            } else {
                LoaiHinhDuLichModel.Instance.Insert(
                    name, note
                );
            }
            return this.LoaiHinhDuLichListingAction("");
        }
    }
}
