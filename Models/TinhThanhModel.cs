using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class TinhThanhModel : Singleton<TinhThanhModel> {
        private DBTableEntities _db;

        protected TinhThanhModel() {
            this._db = new DBTableEntities();
        }

        public Dao.TinhThanh GetById(int id) {
            var res = new TinhThanh();
            try {
                var data = _db.TinhThanhs.First(x => x.TinhThanhId == id);
                if (data != null) {
                    res = data;
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public List<Dao.TinhThanh> SearchList(string name, string quocgia) {
            name = name.Trim();
            quocgia = quocgia.Trim();
            List<Dao.TinhThanh> res = new List<Dao.TinhThanh>();
            try {
                IQueryable<Dao.TinhThanh> data = _db.TinhThanhs.Include(x => x.QuocGia);
                if (name.Length > 0) {
                    data = data.Where(x => x.TinhThanhTen.Contains(name));
                }
                if (quocgia.Length > 0) {
                    data = data.Where(x => x.QuocGia.QuocGiaTen.Contains(quocgia));
                }
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public string Insert(string name, int quocgia) {
            string message = "";
            try {
                var _name = name.Trim();
                Dao.TinhThanh newItem = new Dao.TinhThanh();
                newItem.TinhThanhTen = _name;
                if (quocgia != 0) {
                    newItem.FkQuocGIa = quocgia;
                }
                _db.TinhThanhs.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string Update(int id, string name, int quocgia) {
            string message = "";
            try {
                name = name.Trim();
                var updateData = _db.TinhThanhs.First(x => x.TinhThanhId == id);
                updateData.TinhThanhTen = name;
                updateData.FkQuocGIa = quocgia;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
