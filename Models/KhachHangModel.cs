using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models {
    public class KhachHangModel : Singleton<KhachHangModel> {
        private DBTableEntities _db;

        protected KhachHangModel() {
            this._db = new DBTableEntities();
        }
        public Dao.KhachHang GetByCode(string code) {
            return this._db.KhachHangs.First(x => x.KhachHangCode == code);
        }

        public KhachHang GetById(int id)
        {
            return _db.KhachHangs.Find(id);
        }

        public List<KhachHang> SearchSearchQuery(string searchdata)
        {
            List<Dao.KhachHang> res = new List<Dao.KhachHang>();
            try {
                IQueryable<Dao.KhachHang> data = _db.KhachHangs;
                searchdata = searchdata.Trim();
                if (searchdata.Length > 0) {
                    data = data.Where(
                        x =>
                            x.KhachHangTen.Contains(searchdata) ||
                            x.KhachHangDiaChi.Contains(searchdata) ||
                            x.KhachHangSdt.Contains(searchdata) ||
                            x.KhachHangCode.Contains(searchdata)
                    );
                }
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public void InsertObject(KhachHang khachHang)
        {
            khachHang.KhachHangCode = GenerateCode();
            _db.KhachHangs.Add(khachHang);
            _db.SaveChanges();
        }

        private string GenerateCode()
        {
            return "KH" + DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond;
        }

        public string UpdateById(int khachHangId, string khachHangTen, string khachHangSdt, string khachHangDiaChi,
            string CMND)
        {
            string message = "";
            try {
                khachHangTen = khachHangTen.Trim();
                khachHangSdt = khachHangSdt.Trim();
                khachHangDiaChi = khachHangDiaChi.Trim();
                CMND = CMND.Trim();
                var updateData = _db.KhachHangs.Find(khachHangId);
                updateData.KhachHangTen = khachHangTen;
                updateData.KhachHangSdt = khachHangSdt;
                updateData.KhachHangDiaChi = khachHangDiaChi;
                updateData.CMND = CMND;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
