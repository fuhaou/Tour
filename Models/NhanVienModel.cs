using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Applications;
using Models.Dao;

namespace Models {
    public  class NhanVienModel : Singleton<NhanVienModel> {
        private DBTableEntities _db;
        protected NhanVienModel() {
            this._db = new DBTableEntities();
        }

        public NhanVien GetById(int id) {
            return _db.NhanViens.Find(id);
        }
        public Dao.NhanVien GetByCode(string code) {
            return this._db.NhanViens.First(x => x.NhanVienCode == code);
        }

        public List<NhanVien> SearchData(string searchdata)
        {
            List<Dao.NhanVien> res = new List<Dao.NhanVien>();
            try {
                IQueryable<Dao.NhanVien> data = _db.NhanViens.Include(n => n.LoaiNv);
                searchdata = searchdata ?? "";
                searchdata = searchdata.Trim();
                if (searchdata.Length > 0) {
                    data = data.Where(
                        x =>
                            x.NhanVienTen.Contains(searchdata) ||
                            x.NhanVienDiaChi.Contains(searchdata) ||
                            x.NhanVienSdt.Contains(searchdata) ||
                            x.NhanVienCode.Contains(searchdata) ||
                            x.NhanVienCMND.Contains(searchdata)
                    );
                }
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        private string GenerateCode()
        {
            return "NV" + DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond;
        }

        public string Insert(string nhanVienTen, string nhanVienDiaChi, string nhanVienSdt, string nhanVienCmnd, int fkLoaiNv)
        {
            string message = "";
            try {
                nhanVienTen = nhanVienTen.Trim();
                nhanVienDiaChi = nhanVienDiaChi.Trim();
                nhanVienSdt = nhanVienSdt.Trim();
                nhanVienCmnd = nhanVienCmnd.Trim();
                NhanVien newItem = new NhanVien() {
                    NhanVienCode = GenerateCode(),
                    NhanVienTen = nhanVienTen,
                    NhanVienDiaChi = nhanVienDiaChi,
                    NhanVienSdt = nhanVienSdt,
                    NhanVienCMND = nhanVienCmnd,
                    FkLoaiNv = fkLoaiNv
                };
                _db.NhanViens.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string UpdateById(int id, string nhanVienTen, string nhanVienDiaChi, string nhanVienSdt, string nhanVienCmnd, int fkLoaiNv) {
            string message = "";
            try {
                nhanVienTen = nhanVienTen.Trim();
                nhanVienDiaChi = nhanVienDiaChi.Trim();
                nhanVienSdt = nhanVienSdt.Trim();
                nhanVienCmnd = nhanVienCmnd.Trim();
                var updateData = _db.NhanViens.Find(id);
                updateData.NhanVienTen = nhanVienTen;
                updateData.NhanVienSdt = nhanVienSdt;
                updateData.NhanVienDiaChi = nhanVienDiaChi;
                updateData.NhanVienCMND = nhanVienCmnd;
                updateData.FkLoaiNv = fkLoaiNv;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
