using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;

namespace Models
{
    public class TourModel : Singleton<TourModel>
    {
        private DBTableEntities _db;

        protected TourModel()
        {
            this._db = new DBTableEntities();
        }

        public List<Dao.Tour> SearchList(string code, string name)
        {
            code = code.Trim();
            name = name.Trim();
            List<Dao.Tour> res = new List<Dao.Tour>();
            try {
                IQueryable<Dao.Tour> data = _db.Tours;
                if (code.Length > 0) {
                    data = data.Where(x => x.TourCode == code);
                }
                if (name.Length > 0) {
                    data = data.Where(x => x.TourTen.Contains(name));
                }
                data.Include(x => x.LoaiHinhDulich);
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        private string GenerateCode()
        {
            return "T" + DateTime.Now.ToString("yyyymmddHHMMSS");
        }

        public string Insert(string name, int? loaihinhdulich, float? gia) {
            string message = "";
            try {
                var _name = name.Trim();
                var _loaihinhdulich = loaihinhdulich.GetValueOrDefault(0);
                var _gia = gia.GetValueOrDefault(0);
                var _code = GenerateCode();
                Dao.Tour newItem = new Dao.Tour();
                newItem.TourCode = _code;
                newItem.TourTen = _name;
                newItem.FkLoaiHinhDulich = _loaihinhdulich;
                newItem.TourPrice = _gia;
                _db.Tours.Add(newItem);
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }



        public string Update(string code, string name, int? loaihinhdulich, float? gia) {
            string message = "";
            try {
                var _name = name.Trim();
                var _loaihinhdulich = loaihinhdulich.GetValueOrDefault(0);
                var _gia = gia.GetValueOrDefault(0);
                var _code = code.Trim().ToUpper();
                var updateData = _db.Tours.First(x => x.TourCode == _code);
                updateData.TourTen = _name;
                updateData.FkLoaiHinhDulich = _loaihinhdulich;
                updateData.TourPrice = _gia;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
