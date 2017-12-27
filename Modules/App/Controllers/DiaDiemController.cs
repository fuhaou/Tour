using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Views.DiaDiem;
using Applications;
using Models;
using Models.Dao;

namespace App.Controllers {
    public class DiaDiemController : Singleton<DiaDiemController> {
        public UserControl IndexAction()
        {
            return new Views.DiaDiem.Index(); 
        }

        public UserControl ListingAction(string name, int isHotel, string tinhthanh, string quocgia)
        {
            Views.DiaDiem.Listing view = new Listing();
            view.SetList<DiaDiem>(
                Models.DiaDiemModel.Instance.SearchList(name, isHotel, tinhthanh, quocgia)
            );
            return view;
        }

        public UserControl EditorAction(int id) {
            Views.DiaDiem.Editor view = new Editor();
            view.SetList<TinhThanh>(
                Models.TinhThanhModel.Instance.SearchList("", "")
            );
            if (id != 0) {
                var data = Models.DiaDiemModel.Instance.GetById(id);

                view.SetTen(data.DiaDiemTen);
                view.SetTinhThanh(data.FkTinhThanh);
                view.SetKhachSan(data.DiaDiemKhachSan.GetValueOrDefault(0));
            }
            view.SetId(id);
            return view;
        }

        public UserControl EditorSaveAction(int id, string name, int isHotel, int tinhthanh) {
            string res = "";
            if (id != 0) {
                res = DiaDiemModel.Instance.Update(
                    id,
                    name,
                    tinhthanh,
                    isHotel
                );
            } else {
                res = DiaDiemModel.Instance.Insert(
                    name,
                    tinhthanh,
                    isHotel
                );
            }
            if (res.Trim().Length == 0) {
                return this.ListingAction("", 0, "","");
            } else {
                MessageBox.Show(
                    "Server Quá tải xin thử lại!",
                    "Lỗi"
                );
                return this.EditorAction(id);
            }
        }

        public UserControl QuocGiaListingAction(string name)
        {
            Views.DiaDiem.QuocGiaListing view = new QuocGiaListing();
            view.SetList<Models.Dao.QuocGia>(
                Models.QuocGiaModel.Instance.SearchList(name)
            );
            return view;
        }

        public UserControl QuocGiaEditorAction(int id)
        {
            Views.DiaDiem.QuocGiaEditor view = new QuocGiaEditor();
            if (id != 0) {
                var data = Models.QuocGiaModel.Instance.GetById(id);
                view.SetTen(data.QuocGiaTen);
            }
            view.SetId(id);
            return view;
        }

        public UserControl QuocGiaEditorSaveAction(int id, string name)
        {
            string res = "";
            if (id != 0) {
                res = QuocGiaModel.Instance.Update(
                    id,
                    name
                );
            } else {
                res = QuocGiaModel.Instance.Insert(
                    name
                );
            }
            if (res.Trim().Length == 0) {
                return this.QuocGiaListingAction("");
            }
            else {
                MessageBox.Show(
                    "Server Quá tải xin thử lại!",
                    "Lỗi"
                );
                return this.QuocGiaEditorAction(id);
            }
        }

        public UserControl TinhThanhListingAction(string name, string quocgia)
        {
            Views.DiaDiem.TinhThanhListing view = new TinhThanhListing();
            view.SetList<Models.Dao.TinhThanh>(
                Models.TinhThanhModel.Instance.SearchList(name, quocgia)
            );
            return view;
        }

        public UserControl TinhThanhEditorAction(int id) {
            Views.DiaDiem.TinhThanhEditor view = new TinhThanhEditor();
            List<QuocGia> li = Models.QuocGiaModel.Instance.SearchList("");
            li.Insert(0, new QuocGia() {QuocGiaId = 0, QuocGiaTen = "NONE"});
            view.SetQuocGiaData(li);
            if (id != 0) {
                var data = Models.TinhThanhModel.Instance.GetById(id);
                view.SetTen(data.TinhThanhTen);
                view.SetQuocGia(data.FkQuocGIa.GetValueOrDefault(0));
            }
            view.SetId(id);
            return view;
        }

        public UserControl TinhThanhEditorSaveAction(int id, string name, int quocGiaId) {
            string res = "";
            if (id != 0) {
                res = TinhThanhModel.Instance.Update(
                    id,
                    name,
                    quocGiaId
                );
            } else {
                res = TinhThanhModel.Instance.Insert(
                    name,
                    quocGiaId
                );
            }
            if (res.Trim().Length == 0) {
                return this.TinhThanhListingAction("", "");
            } else {
                MessageBox.Show(
                    "Server Quá tải xin thử lại!",
                    "Lỗi"
                );
                return this.TinhThanhEditorAction(id);
            }
        }
    }
}
