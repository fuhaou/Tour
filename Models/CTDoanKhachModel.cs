using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class CTDoanKhachModel : Singleton<CTDoanKhachModel> {
        private DBTableEntities _db;
        protected CTDoanKhachModel() {
            this._db = new DBTableEntities();
        }

        public int CountHanhKhachTrongDoan(int doanId)
        {
            return _db.CTDoanKhaches.Count(x => x.FkDoan == doanId);
        }

        public List<CTDoanKhach> GetByDoanId(int id)
        {
            return _db.CTDoanKhaches.Where(x => x.FkDoan == id).Include(x => x.KhachHang).ToList();
        }
    }
}
