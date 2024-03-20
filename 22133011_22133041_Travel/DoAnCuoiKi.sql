CREATE DATABASE DoAnCuoiKi
USE DoAnCuoiKi
CREATE TABLE ThongTinPhong
(
	TenKhachSan varchar(100) Null,
	DiaDiem varchar(100)Null,
	LoaiPhong varchar(100)Null,
	PhuongTien varchar(100)Null,
	GiaTien varchar(100)Null,
	TienIch varchar(100)Null,
	TienNghi varchar(100)Null,
	AnUong varchar(100)Null,
	MoTa varchar(300)Null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	HinhAnh3 IMAGE,
	HinhAnh4 IMAGE
);
SELECT *FROM ThongTinPhong
DROP TABLE ThongTinPhong
