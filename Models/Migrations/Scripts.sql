
CREATE TABLE LoaiHinhDulich
(
  LoaiHinhDulichId INT IDENTITY ,
  LoaiHinhDulichTen NVARCHAR(100) NOT NULL ,
  LoaiHinhDulichNote TEXT,
  PRIMARY KEY (LoaiHinhDulichId)
);

CREATE TABLE KhachHang
(
  KhachHangId INT IDENTITY,
  KhachHangTen NVARCHAR(100),
  KhachHangSdt VARCHAR(20),
  KhachHangDiaChi NVARCHAR(100),
  CMND VARCHAR(20),
  PRIMARY KEY (KhachHangId)
);


CREATE TABLE LoaiNv
(
  LoaiNvId INT IDENTITY,
  LoaiNvName NVARCHAR(100),
  PRIMARY KEY (LoaiNvId)
);
CREATE TABLE QuocGia
(
  QuocGiaId INT IDENTITY ,
  QuocGiaTen NVARCHAR(100) NOT NULL ,
  PRIMARY KEY (QuocGiaId)
);
CREATE TABLE TinhThanh
(
  TinhThanhId INT IDENTITY ,
  TinhThanhTen NVARCHAR(100),
  FkQuocGIa INT,
  PRIMARY KEY (TinhThanhId),
  FOREIGN KEY (FkQuocGia) REFERENCES QuocGia(QuocGiaId)
);

CREATE TABLE DiaDiem
(
  DiaDiemId INT IDENTITY ,
  DiaDiemTen NVARCHAR(255) NOT NULL,
  FkTinhThanh INT NOT NULL,
  PRIMARY KEY (DiaDiemId),
  FOREIGN KEY (FkTinhThanh) REFERENCES TinhThanh(TinhThanhId)
);

CREATE TABLE Tour
(
  TourId INT IDENTITY,
  TourCode VARCHAR(50) UNIQUE ,
  TourTen  NVARCHAR(50) NOT NULL ,
  FkLoaiHinhDulich int NOT NULL ,
  TourPrice FLOAT,
  PRIMARY KEY (TourId),
  FOREIGN KEY (FkLoaiHinhDulich) REFERENCES LoaiHinhDulich(LoaiHinhDulichId)
);

CREATE TABLE CTTour
(
  CTTourId INT IDENTITY ,
  FkTour INT NOT NULL ,
  FkDiaDiem INT NOT NULL ,
  CTourGia FLOAT,
  PRIMARY KEY (CTTourId),
  FOREIGN KEY (FkTour) REFERENCES Tour(TourId),
  FOREIGN KEY (FkDiaDiem) REFERENCES DiaDiem(DiaDiemId)
);


CREATE TABLE Doan
(
  DoanId INT IDENTITY ,
  DoanCode VARCHAR(50) UNIQUE ,
  DoanTen NVARCHAR(50) NOT NULL ,
  DoanNgayDi DATETIME,
  DoanNgayVe DATETIME,
  FkTour INT NOT NULL,
  DoanHotelCost FLOAT,
  DoanFoodCost FLOAT,
  DoanVehicleCost FLOAT,
  DoanAdditionalCost FLOAT,
  PRIMARY KEY (DoanId),
  FOREIGN KEY (FkTour) REFERENCES Tour(TourId)
);

CREATE TABLE CTDoanKhach
(
  CTDoanKhachId INT IDENTITY ,
  FkDoan INT NOT NULL ,
  FkKhachHang INT NOT NULL ,
  CTDoanKhachTenNguoiDi NVARCHAR(100),
  CTDoanKhachSdtNguoiDi VARCHAR(20),
  CTDoanKhachDiaChiNguoiDi NVARCHAR(100),
  CTDoanKhachCMNDNguoiDi VARCHAR(20),
  PRIMARY KEY (CTDoanKhachId),
  FOREIGN KEY (FkDoan) REFERENCES Doan(DoanId),
  FOREIGN KEY (FkKhachHang) REFERENCES KhachHang(KhachHangId)
);

CREATE TABLE NhanVien
(
  NhanVienId INT IDENTITY ,
  NhanVienCode VARCHAR(50) UNIQUE ,
  NhanVienTen  NVARCHAR(100) NOT NULL ,
  NhanVienDiaChi NVARCHAR(100) NOT NULL ,
  NhanVienSdt VARCHAR(20) NOT NULL ,
  NhanVienCMND VARCHAR(20) NOT NULL ,
  FkLoaiNv INT NOT NULL ,
  PRIMARY KEY (NhanVienId),
  FOREIGN KEY (FkLoaiNv) REFERENCES LoaiNv(LoaiNvId)
);

CREATE TABLE CTDoanNV
(
  CTDoanNVId INT IDENTITY,
  FkDoan INT NOT NULL ,
  FkNhanVien INT NOT NULL ,
  CTDoanNVNote TEXT,
  PRIMARY KEY (CTDoanNVId),
  UNIQUE (FkDoan, FkNhanVien),
  FOREIGN KEY (FkDoan) REFERENCES Doan(DoanId),
  FOREIGN KEY (FkNhanVien) REFERENCES NhanVien(NhanVienId)
);

ALTER table Doan 
	ADD DoanTourPrice FLOAT;
ALTER table Doan 
	ADD DoanNgayTao DateTime;
ALTER table Doan 
	ADD DoanTrangThai int; --	0 chua di, 1 da di , 2 dang di,3  huy
ALTER table DiaDiem
	ADD DiaDiemKhachSan int; -- 0 ko phai khach san 1 la` khach san 