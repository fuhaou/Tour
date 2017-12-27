using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications;
using Models.Dao;
using Models.View;

namespace Models {
    public class DoanModel : Singleton<DoanModel> {
        private DBTableEntities _db;
        protected DoanModel() {
            this._db = new DBTableEntities();
        }

        public string ThemKhach(int id, string khachHangCode)
        {
            var message = "";
            try {
                khachHangCode = khachHangCode ?? "";
                khachHangCode = khachHangCode.Trim().ToUpper();
                KhachHang a = Models.KhachHangModel.Instance.GetByCode(khachHangCode);
                if (_db.CTDoanKhaches.Count(x => x.FkKhachHang == a.KhachHangId && x.FkDoan == id) > 0) {
                    return "";
                }
                _db.CTDoanKhaches.Add(new CTDoanKhach() {
                    CTDoanKhachTenNguoiDi = a.KhachHangTen,
                    CTDoanKhachSdtNguoiDi = a.KhachHangSdt,
                    CTDoanKhachDiaChiNguoiDi = a.KhachHangDiaChi,
                    CTDoanKhachCMNDNguoiDi = a.CMND,
                    FkDoan = id,
                    FkKhachHang = a.KhachHangId
                });
                _db.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string PhanCongNv(int id, string nvCode) {
            var message = "";
            try {
                nvCode = nvCode ?? "";
                nvCode = nvCode.Trim().ToUpper();
                NhanVien a = Models.NhanVienModel.Instance.GetByCode(nvCode);
                if (_db.CTDoanNVs.Count(x => x.FkNhanVien == a.NhanVienId && x.FkDoan == id) > 0) {
                    return "";
                }
                _db.CTDoanNVs.Add(new CTDoanNV() {
                    FkDoan = id,
                    FkNhanVien = a.NhanVienId,
                });
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public List<CTDoanNV> GetCtDoanNvsByDoanId(int id)
        {
            return _db.CTDoanNVs.Where(x => x.FkDoan == id).Include(x => x.NhanVien).ToList();
        }


        public Dao.Doan GetByCode(string code) {
            return this._db.Doans.First(x => x.DoanCode == code);
        }

        public Dao.Doan GetById(int id) {
            return this._db.Doans.Find(id);
        }

        public List<Doan> SearchQuery(string tourcode, string doancode, DateTime from, DateTime to, int status = Applications.Constants.Db.Doan.STATUS_COMPLETED)
        {
            List<Doan> res = new List<Doan>();
            try {
                tourcode = tourcode.Trim();
                doancode = doancode.Trim();
                IQueryable<Dao.Doan> data = _db.Doans;
                data = data.Where(x => x.DoanNgayTao >= from && x.DoanNgayTao <= to && x.DoanTrangThai == status);
                if (tourcode.Length > 0) {
                    data = data.Where(x => tourcode == x.Tour.TourCode);
                }
                if (doancode.Length > 0) {
                    data = data.Where(x => x.DoanCode == doancode);
                }
                data.Include(x => x.Tour);
                res = data.ToList();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return res;
        }

        public List<Doan> GetAll()
        {
            return _db.Doans.Include(x => x.Tour).ToList();
        }


        public View.ThongKeSaleReportViewModel GetReport(string tourcode, string doancode, DateTime from, DateTime to)
        {
            var tongdoanhthu = 0.0;
            var tongthu = 0.0;
            var tongchi = 0.0;
            List<object> list = new List<object>();
            try {
                List<Doan> RawData = this.SearchQuery(tourcode, doancode, from, to);
                foreach (Doan item in RawData) {
                    var soluonghanhkhach = Models.CTDoanKhachModel.Instance.CountHanhKhachTrongDoan(item.DoanId);
                    list.Add(new {
                        DoanCode = item.DoanCode,
                        TourCode = item.Tour.TourCode,
                        TourTen = item.Tour.TourTen,
                        NgayTao = item.DoanNgayTao,
                        TienKhachSan = item.DoanHotelCost,
                        TienXe = item.DoanVehicleCost,
                        PhuChi = item.DoanAdditionalCost,
                        GiaTour = item.DoanTourPrice,
                        TongSoLuongHanhKhach = soluonghanhkhach
                    });
                    tongchi = tongchi + item.DoanFoodCost.GetValueOrDefault(0) +
                              item.DoanAdditionalCost.GetValueOrDefault(0) + item.DoanHotelCost.GetValueOrDefault(0) +
                              item.DoanVehicleCost.GetValueOrDefault(0);
                    tongthu = tongthu + (float)(item.DoanTourPrice * soluonghanhkhach);
                }
                tongdoanhthu = tongthu - tongchi;
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            return new ThongKeSaleReportViewModel() {
                ListData = list,
                TongThu = (float) tongthu,
                TongChiPhi = (float) tongchi,
                TongDoanhThu = (float) tongdoanhthu,
                TongSoDoan = list.Count
            };
        }

        private string GenerateCode()
        {
            return "DT" + DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond;
        }

        public string Insert(string doanTen, DateTime? doanNgayDi, DateTime? doanNgayVe, float? doanHotelCost,
            float? doanFoodCost, float? doanVehicleCost,
            float? doanAdditionalCost, string tourCode)
        {
            var dateQuery = _db.Database.SqlQuery<DateTime>("SELECT getdate()");
            DateTime serverDate = dateQuery.AsEnumerable().First();
            var message = "";
            try {
                Tour a = Models.TourModel.Instance.GetByCode(tourCode);
                Doan newItem = new Doan() {
                    DoanTen = doanTen,
                    DoanCode = GenerateCode(),
                    DoanNgayTao = serverDate,
                    DoanTourPrice = a.TourPrice,
                    FkTour = a.TourId,
                    DoanAdditionalCost = doanAdditionalCost,
                    DoanHotelCost = doanHotelCost,
                    DoanFoodCost = doanFoodCost,
                    DoanNgayDi = doanNgayDi,
                    DoanNgayVe = doanNgayVe,
                    DoanVehicleCost = doanVehicleCost,
                    DoanTrangThai = Applications.Constants.Db.Doan.STATUS_INIT
                };
                _db.Doans.Add(newItem);
                _db.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string Update(int id ,string doanTen, DateTime? doanNgayDi, DateTime? doanNgayVe, float? doanHotelCost,
            float? doanFoodCost, float? doanVehicleCost,
            float? doanAdditionalCost, string tourCode) {
            var dateQuery = _db.Database.SqlQuery<DateTime>("SELECT getdate()");
            DateTime serverDate = dateQuery.AsEnumerable().First();
            var message = "";
            try {
                Tour a = Models.TourModel.Instance.GetByCode(tourCode);
                Doan updateItem = _db.Doans.Find(id);
                updateItem.DoanTen = doanTen;
                updateItem.DoanNgayTao = serverDate;
                updateItem.DoanTourPrice = a.TourPrice;
                updateItem.DoanAdditionalCost = doanAdditionalCost;
                updateItem.DoanHotelCost = doanHotelCost;
                updateItem.DoanFoodCost = doanFoodCost;
                updateItem.DoanVehicleCost = doanVehicleCost;
                updateItem.DoanNgayDi = doanNgayDi;
                updateItem.DoanNgayVe = doanNgayVe;
                updateItem.FkTour = a.TourId;
                updateItem.DoanTourPrice = a.TourPrice;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }

        public string UpdateStatus(int id, int status) {
            var message = "";
            try {
                Doan updateItem = _db.Doans.Find(id);
                updateItem.DoanTrangThai = status;
                _db.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
            }
            return message;
        }
    }
}
