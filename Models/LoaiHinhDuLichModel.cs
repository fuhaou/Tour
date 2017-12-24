using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class LoaiHinhDuLichModel : Singleton<LoaiHinhDuLichModel> {
        private DBTableEntities _db;

        protected LoaiHinhDuLichModel() {
            this._db = new DBTableEntities();
        }

        public List<Dao.LoaiHinhDulich> SearchList(string name) {
            name = name.Trim();
            List<Dao.LoaiHinhDulich> res = new List<Dao.LoaiHinhDulich>();
            try {
                IQueryable<Dao.LoaiHinhDulich> data = _db.LoaiHinhDuliches;
                if (name.Length > 0) {
                    data = data.Where(x => x.LoaiHinhDulichTen.Contains(name));
                }
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public string Insert(string name, string note) {
            string message = "";
            try {
                var _name = name.Trim();
                var _note = note.Trim();
                Dao.LoaiHinhDulich newItem = new Dao.LoaiHinhDulich();
                newItem.LoaiHinhDulichTen = _name;
                newItem.LoaiHinhDulichNote = _note;
                _db.LoaiHinhDuliches.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string Update(int? id, string name, string note) {
            string message = "";
            try {
                var _name = name.Trim();
                var _note = note.Trim();
                var _id = id.GetValueOrDefault(0);
                var updateData = _db.LoaiHinhDuliches.First(x => x.LoaiHinhDulichId == _id);
                updateData.LoaiHinhDulichTen = _name;
                updateData.LoaiHinhDulichNote = _note;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
