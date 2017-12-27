using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class DiaDiemModel: Singleton<DiaDiemModel> {
        private DBTableEntities _db;

        protected DiaDiemModel() {
            this._db = new DBTableEntities();
        }

        public Dao.DiaDiem GetById(int id) {
            var res = new DiaDiem();
            try {
                var data = _db.DiaDiems.First(x => x.DiaDiemId == id);
                if (data != null) {
                    res = data;
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public List<Dao.DiaDiem> SearchList(string name, int isKhachSan, string tinhthanh, string quocgia) {
            name = name.Trim();
            tinhthanh = tinhthanh.Trim();
            quocgia = quocgia.Trim();

            List<Dao.DiaDiem> res = new List<Dao.DiaDiem>();
            try {
                IQueryable<Dao.DiaDiem> data = _db.DiaDiems
                    .Include(x => x.TinhThanh)
                    .Include(x => x.TinhThanh.QuocGia);
                if (isKhachSan >= 0) {
                    data = data.Where(x => x.DiaDiemKhachSan == isKhachSan);
                }
                if (name.Length > 0) {
                    data = data.Where(x => x.DiaDiemTen.Contains(name));
                }
                if (tinhthanh.Length > 0) {
                    data = data.Where(x => x.TinhThanh.TinhThanhTen.Contains(tinhthanh));
                }
                if (quocgia.Length > 0) {
                    data = data.Where(x => x.TinhThanh.QuocGia.QuocGiaTen.Contains(quocgia));
                }
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public string Insert(string name, int tinhthanhid, int isKhachSan) {
            string message = "";
            try {
                var _name = name.Trim();
                Dao.DiaDiem newItem = new Dao.DiaDiem();
                newItem.DiaDiemTen = name;
                newItem.FkTinhThanh = tinhthanhid;
                newItem.DiaDiemKhachSan = isKhachSan;
                _db.DiaDiems.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }



        public string Update(int id, string name, int tinhthanhid, int isKhachSan) {
            string message = "";
            try {
                var _name = name.Trim();
                var updateData = _db.DiaDiems.First(x => x.DiaDiemId == id);
                updateData.DiaDiemTen = _name;
                updateData.FkTinhThanh = tinhthanhid;
                updateData.DiaDiemKhachSan = isKhachSan;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
