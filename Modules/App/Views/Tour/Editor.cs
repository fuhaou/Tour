using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Controllers;
using Models.Dao;

namespace App.Views.Tour {
    public partial class Editor : UserControl {
        private List<Models.Dao.DiaDiem> diaDiemList;
        private List<object> ctTourList;

        public Editor() {
            InitializeComponent();
            subContainer.Visible = false;
        }
        private int _id;


        public void SetCtListView(List<CTTour> list)
        {
            List<object> dataList = new List<object>();
            foreach (var item in list) {
                var tinhThanh = item.DiaDiem.TinhThanh;
                var quocgia = item.DiaDiem.TinhThanh.QuocGia == null ? "" : item.DiaDiem.TinhThanh.QuocGia.QuocGiaTen;
                dataList.Add(new {
                    id = item.CTTourId,
                    ten = item.DiaDiem.DiaDiemTen,
                    TinhThanh = tinhThanh.TinhThanhTen,
                    QuocGia = quocgia,
                    DiaDiemId = item.FkDiaDiem
                });
            }
            ctTourList = dataList;
            this.ctListView.AutoGenerateColumns = true;
            this.ctListView.DataSource = dataList;
            if (
                this.ctListView.Columns.Count == 5
                ) {
            }
            this.ctListView.Refresh();
        }

        public void SetName(string name) {
            this.txtTen.Text = name;
        }

        public void SetPrice(float price) {
            this.txtGia.Text = price.ToString();
        }

        public void SetDiaDiemList(List<Models.Dao.DiaDiem> list)
        {
            this.subContainer.Visible = true;
            List<object> dataList = new List<object>();
            foreach (var item in list) {
                var tinhThanh = item.TinhThanh;
                var quocgia = tinhThanh.QuocGia == null ? "" : tinhThanh.QuocGia.QuocGiaTen;
                dataList.Add(new {
                    Id = item.DiaDiemId,
                    Ten = item.DiaDiemTen,
                    TinhThanh = tinhThanh.TinhThanhTen,
                    QuocGia = quocgia
                });
            }
            diaDiemList = list;
            this.dataListView.DataSource = dataList;
            this.dataListView.Refresh();
        }

        public void SetId(int id, string code)
        {
            this._id = id;
            lblAction.Text = id == 0 ? "Thêm Mới" : "Chỉnh sửa (" + code + ")";
        }

        public void SetLoaiHinhDuLich(int loaihinhdulich)
        {
            this.cbxLoaiHinhDuLich.SelectedValue = loaihinhdulich;
        }

        public void SetLoaiHinhDuLichDataList<T>(List<Models.Dao.LoaiHinhDulich> data) {
            this.cbxLoaiHinhDuLich.DataSource = data;
            cbxLoaiHinhDuLich.ValueMember = "LoaiHinhDulichId";
            cbxLoaiHinhDuLich.DisplayMember = "LoaiHinhDulichTen";
        }
//EditorSaveAction(int id,string name, float price, int loaihinhdulich)
        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtTen.Text;
            var price = float.Parse(txtGia.Text);
            var loaihinhdulich = cbxLoaiHinhDuLich.SelectedValue;
            MainController.Instance.SetAction(
                "Tour",
                "EditorSave",
                new object[] { _id, name, price, loaihinhdulich }
            );
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = this.txtDiaDiemTen.Text;
            List<Models.Dao.DiaDiem> list = diaDiemList.Where(x => x.DiaDiemTen.Contains(name)).ToList();
            List<object> dataList = new List<object>();
            foreach (var item in list) {
                var tinhThanh = item.TinhThanh;
                var quocgia = tinhThanh.QuocGia == null ? "" : tinhThanh.QuocGia.QuocGiaTen;
                dataList.Add(new {
                    Id = item.DiaDiemId,
                    Ten = item.DiaDiemTen,
                    TinhThanh = tinhThanh.TinhThanhTen,
                    QuocGia = quocgia
                });
            }
            dataListView.DataSource = dataList;
            dataListView.Refresh();
        }

        private void btnCTSave_Click(object sender, EventArgs e) {
            List<int> inpdata = new List<int>();
            foreach (DataGridViewRow item in ctListView.Rows) {
                inpdata.Add((int)item.Cells[4].Value);
            }
            MainController.Instance.SetAction(
                "Tour",
                "EditorCtSave",
                new object[] {_id, inpdata}
            );
        }

        private void ctListView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataListView.SelectedRows.Count > 0) {
                List<object> tmp = new List<object>();
                foreach (DataGridViewRow row in ctListView.SelectedRows) {
                    tmp.Add(new {
                        id = (int)row.Cells[0].Value,
                        ten = row.Cells[1].Value.ToString(),
                        TinhThanh = row.Cells[2].Value.ToString(),
                        QuocGia = row.Cells[3].Value.ToString(),
                        DiaDiemId = (int)row.Cells[4].Value
                    });
                }
                for (var index = 0; index < tmp.Count; index++) {
                    var item = tmp[index];
                    ctTourList.Remove(item);
                }
                ctListView.DataSource = null;
                ctListView.DataSource = ctTourList;
                ctListView.Refresh(); ;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (dataListView.SelectedRows.Count > 0) {
                foreach (DataGridViewRow row in dataListView.SelectedRows) {
                    ctTourList.Add(new {
                        id = 0,
                        ten = row.Cells[1].Value.ToString(),
                        TinhThanh = row.Cells[2].Value.ToString(),
                        QuocGia = row.Cells[3].Value.ToString(),
                        DiaDiemId = (int)row.Cells[0].Value
                    });
                }
                ctListView.DataSource = null;
                ctListView.DataSource = ctTourList;
                ctListView.Refresh();;
            }
        }
    }
}
