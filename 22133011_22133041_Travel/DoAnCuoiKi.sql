CREATE DATABASE DoAnCuoiKi
USE DoAnCuoiKi
CREATE TABLE ThongTinPhong
(
	TenKhachSan nvarchar(100) Null,
	DiaDiem nvarchar(100)Null,
	LoaiPhong nvarchar(100)Null,
	PhuongTien nvarchar(100)Null,
	GiaTien nvarchar(100)Null,
	TienIch nvarchar(100)Null,
	TienNghi nvarchar(100)Null,
	AnUong nvarchar(100)Null,
	MoTa nvarchar(300)Null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	HinhAnh3 IMAGE,
	HinhAnh4 IMAGE
);
SELECT *FROM ThongTinPhong
DROP TABLE ThongTinPhong
