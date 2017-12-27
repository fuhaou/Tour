using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class QuocGiaModel : Singleton<QuocGiaModel> {
        private DBTableEntities _db;

        protected QuocGiaModel() {
            this._db = new DBTableEntities();
        }

        public Dao.QuocGia GetById(int id) {
            var res = new QuocGia();
            try {
                var data = _db.QuocGias.First(x => x.QuocGiaId == id);
                if (data != null) {
                    res = data;
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public List<Dao.QuocGia> SearchList(string name) {
            name = name.Trim();
            List<Dao.QuocGia> res = new List<Dao.QuocGia>();
            try {
                IQueryable<Dao.QuocGia> data = _db.QuocGias;
                if (name.Length > 0) {
                    data = data.Where(x => x.QuocGiaTen.Contains(name));
                }
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public string Insert(string name) {
            string message = "";
            try {
                var _name = name.Trim();
                Dao.QuocGia newItem = new Dao.QuocGia();
                newItem.QuocGiaTen = _name;
                _db.QuocGias.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string Update(int id, string name) {
            string message = "";
            try {
                name = name.Trim();
                var updateData = _db.QuocGias.First(x => x.QuocGiaId == id);
                updateData.QuocGiaTen = name;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
