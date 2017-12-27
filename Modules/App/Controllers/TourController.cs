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
using Models.Dao;

namespace App.Controllers {
    public class TourController : Singleton<TourController> {
        public UserControl IndexAction()
        {
            UserControl view = new Views.Tour.Index();
            return view;
        }

        public UserControl ListingAction(string code , string name)
        {
            Listing view = new Views.Tour.Listing();
            view.SetList<Models.Dao.Tour>(
                Models.TourModel.Instance.SearchList(code, name)
            );
            return view;
        }
        public UserControl EditorAction(int id) {
            Views.Tour.Editor view = new Views.Tour.Editor();
            var code = "";
            view.SetLoaiHinhDuLichDataList<LoaiHinhDulich>(
                Models.LoaiHinhDuLichModel.Instance.SearchList("")
            );
            if (id != 0) {
                Tour data = Models.TourModel.Instance.GetById(id);
                code = data.TourCode;
                view.SetCtListView(
                    Models.CTTourModel.Instance.SearchByTourId(id)
                );
                view.SetName(data.TourTen);
                view.SetPrice((float)data.TourPrice.GetValueOrDefault(0));
                view.SetLoaiHinhDuLich(data.FkLoaiHinhDulich);
                view.SetDiaDiemList(
                    Models.DiaDiemModel.Instance.SearchList("", -1, "", "")
                );
            }
            view.SetId(id, code);
            return view;
        }

        public UserControl EditorSaveAction(int id,string name, float price, int loaihinhdulich)
        {
            var _id = 0;
            if (id != 0) {
                 _id = id;
                var msg = TourModel.Instance.Update(
                    id,
                    name,
                    loaihinhdulich,
                    price
                );
                if (msg.Length > 0) {
                    Console.WriteLine(msg);
                    MessageBox.Show("Lỗi", "Hệ Thống quá tải xin Vui lòng thử lại!");
                    return null;
                }
            } else {
                _id = TourModel.Instance.InsertAndGetId(
                    name,
                    loaihinhdulich,
                    price
                );
                if (_id == 0) {
                    MessageBox.Show("Lỗi", "Hệ Thống quá tải xin Vui lòng thử lại!");
                    return null;
                }
            }
            return this.EditorAction(_id);
        }

        public UserControl EditorCtSaveAction(int tourId, List<int> diadiemIds)
        {
            Models.CTTourModel.Instance.DeleteByTourId(tourId);
            foreach (var item in diadiemIds) {
                Models.CTTourModel.Instance.Insert(tourId, item);
            }
            return this.EditorAction(tourId);
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
