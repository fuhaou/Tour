using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class CTTourModel : Singleton<CTTourModel> {
        private DBTableEntities _db;

        protected CTTourModel() {
            this._db = new DBTableEntities();
        }
        public List<Dao.CTTour> SearchByTourId(int tourId) {
            List<Dao.CTTour> res = new List<Dao.CTTour>();
            try {
                IQueryable<Dao.CTTour> data = _db.CTTours;
                data = data.Where(x => x.FkTour == tourId);
                data.Include(x => x.DiaDiem);
                data.Include(x => x.DiaDiem.TinhThanh);
                data.Include(x => x.DiaDiem.TinhThanh.QuocGia);
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public string DeleteByTourId(int tourId)
        {
            var message = "";
            _db.CTTours.RemoveRange(
                _db.CTTours.Where(x => x.FkTour == tourId)
            );
            _db.SaveChanges();
            return message;
        }

        public string Insert(int tourId, int diadiemId)
        {
            string message = "";
            try {
                Dao.CTTour newItem = new Dao.CTTour();
                newItem.FkTour = tourId;
                newItem.FkDiaDiem = diadiemId;
                _db.CTTours.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
