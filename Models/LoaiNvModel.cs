using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class LoaiNvModel  : Singleton<LoaiNvModel> {
        private DBTableEntities _db;
        protected LoaiNvModel() {
            this._db = new DBTableEntities();
        }

        public List<LoaiNv> GetAll()
        {
            return _db.LoaiNvs.ToList();
        }

        public LoaiNv GetById(int Id)
        {
            return _db.LoaiNvs.Find(Id);
        }

        public string Insert(string name)
        {
            var message = "";
            name = name.Trim();
            try {
                LoaiNv newItem = new LoaiNv();
                newItem.LoaiNvName = name;
                _db.LoaiNvs.Add(newItem);
                _db.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string Update(int id, string name) {
            var message = "";
            name = name.Trim();
            try {
                var updateIem = _db.LoaiNvs.Find(id);
                updateIem.LoaiNvName = name;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
