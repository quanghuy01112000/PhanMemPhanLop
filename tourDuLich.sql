CREATE DATABASE TourDL
ON(
	NAME = 'TourDL_DATA',
	FILENAME = 'D:\tai lieu sql sever\TourDL_DATA.mdf',
	SIZE = 10MB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 2MB)
LOG ON(
	NAME = 'TourDL_LOG',
	FILENAME = 'D:\tai lieu sql sever\TourDL_LOG.ldf',
	SIZE = 5MB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 2MB)
	use TourDL
	drop database TourDL

	CREATE TABLE DiaDiem
	(
		MaDiaDiem int primary key not null,
		TenDiaDiem nvarchar(30)
	)
	CREATE TABLE LoaiHinhDuLich
	(
		MaLoaiHinh int primary key not null,
		TenLoaiHinh nvarchar(30)
	)
	CREATE TABLE TourDuLich
	(
		MaTour int primary key not null,
		TenTour nvarchar(50),
		DacDiem nvarchar(10),
		TrangThai nvarchar(15),
		MaLoaiHinh int references LoaiHinhDuLich(MaLoaiHinh),
		NgayBatDau datetime,
		NgayKetThuc datetime,
		HienThi bit default 1
	)
	CREATE TABLE ThamQuan
	(
		MaTour int references TourDuLich(MaTour),
		MaDiaDiem int references DiaDiem(MaDiaDiem),
		ThuTu int,
		constraint PK_LOAI primary key(MaTour,MaDiaDiem,ThuTu)
	)
	CREATE TABLE GiaTour
	(
		MaGia int primary key not null,
		ThanhTien float,
		ThoiGianBatDau datetime,
		ThoiGianKetThuc datetime,
		MaTour int references TourDuLich(MaTour)
	)
	CREATE TABLE DoanDuLich
	(
		MaDoan int primary key not null,
		NgayKhoiHanh datetime,
		NgayKetThuc datetime,
		DoanhThu float,
		MaTour int references TourDuLich(MaTour)
	)
	CREATE TABLE NoiDungTour
	(
		MaDoan int primary key not null references DoanDuLich(MaDoan),
		HanhTrinh nvarchar(100),
		KhachSan nvarchar(15),
		DiaDiemThamQuan nvarchar(100)
	)
	CREATE TABLE KhachHang
	(
		MaKhachHang int primary key not null,
		HoTen nvarchar(20),
		soCMND nvarchar(12),
		DiaChi nvarchar(30),
		GioiTinh nvarchar(10),
		SDT nvarchar(10),
		QuocTich nvarchar(15)
	)
	CREATE TABLE NhanVien
	(
		MaNhanVien int primary key not null,
		TenNhanVien nvarchar(15)
	)
	CREATE TABLE ChiTietDoan
	(
		MaDoan int references DoanDuLich(MaDoan),
		MaKhachHang int references KhachHang(MaKhachHang),
		constraint PK_ChiTietDoan primary key(MaDoan,MaKhachHang)
	)
	CREATE TABLE LoaiChiPhi
	(
		MaLoaiChiPhi int primary key not null,
		TenLoaiChiPhi nvarchar(15)
	)
	CREATE TABLE ChiPhi
	(
		MaChiPhi int primary key not null,
		MaDoan int references DoanDuLich(MaDoan),
		SoTien float,
		MaLoaiChiPhi int references LoaiChiPhi(MaLoaiChiPhi)
	)
	CREATE TABLE PhanBoNhanVien_Doan
	(
		MaNhanVien int references NhanVien(MaNhanVien),
		MaDoan int references DoanDuLich(MaDoan),
		NhiemVu nvarchar(10),
		constraint PK_PhanBoNV primary key(MaDoan,MaNhanVien)
	)
	

insert into DiaDiem (madiadiem, tendiadiem) values (1, N'Hà Nội');
insert into DiaDiem (madiadiem, tendiadiem) values (2, N'Sa Pa');
insert into DiaDiem (madiadiem, tendiadiem) values (3, N'Cần Giờ');
insert into DiaDiem (madiadiem, tendiadiem) values (4, N'Hà Giang');
insert into DiaDiem (madiadiem, tendiadiem) values (5, N'Đà Nẵng');
insert into DiaDiem (madiadiem, tendiadiem) values (6, N'Huế');
insert into DiaDiem (madiadiem, tendiadiem) values (7, N'Ninh Bình');
insert into DiaDiem (madiadiem, tendiadiem) values (8, N'Phong Nha- Kẻ Bàng');
insert into DiaDiem (madiadiem, tendiadiem) values (9, N'Vịnh Hạ Long');
insert into DiaDiem (madiadiem, tendiadiem) values (10,N'phố cổ Hội An');

insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (1, N'Du lịch xanh');
insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (2, N'Du lịch gia đình');
insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (3, N'Du lịch ẩm thực');
insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (4, N'Du lịch văn hóa');
insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (5, N'Du lịch tham quan');
insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (6, N'Du lịch xanh');
insert into LoaiHinhDuLich (maloaihinh, tenloaihinh) values (7, N'Du lịch di động');

insert into TourDuLich (matour, tentour, dacdiem, trangthai, maloaihinh,NgayBatDau,NgayKetThuc) values (1, N'Phong Nha Kẻ Bàng 7 ngày 7 đêm', N'Vui', N'kết thúc', 2,'2021/10/31','2021/12/31');
insert into TourDuLich (matour, tentour, dacdiem, trangthai, maloaihinh,NgayBatDau,NgayKetThuc) values (2, N'Hà Nội đi tự do', N'Vui', N'chưa đăng ký', 4,'2021/10/31','2021/12/31');

insert into GiaTour values (1,100,'2021/01/01','2021/06/01',1);
insert into GiaTour values (2,200,'2021/06/02','2021/12/31',1);
insert into GiaTour values (3,300,'2021/01/01','2021/06/01',2);
insert into GiaTour values (4,400,'2021/06/02','2021/12/31',2);

insert into ThamQuan values (1,1,1);
insert into ThamQuan values (1,2,3);
insert into ThamQuan values (1,6,2);
insert into ThamQuan values (2,9,4);
insert into ThamQuan values (2,5,1);
insert into ThamQuan values (2,4,3);
insert into ThamQuan values (2,6,2);

