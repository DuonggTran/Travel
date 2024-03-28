﻿Use DoAnCuoiKy
CREATE TABLE ThongTinPhongCuaKhachSan
(
	ID INT,
	TenPhong nvarchar(30) null,
	KichThuocPhong nvarchar(30) null,
	GiaPhong nvarchar (30) null,
	TienNghiPhongTam1 nvarchar (30) null,
	TienNghiPhongTam2 nvarchar (30) null,
	TienNghiPhongTam3 nvarchar (30) null,
	TienNghiPhongTam4 nvarchar (30) null,
	HuongTamNhin1 nvarchar (30) null,
	HuongTamNhin2 nvarchar (30) null,
	TienNghiPhong1 nvarchar (30) null,
	TienNghiPhong2 nvarchar (30) null,
	TienNghiPhong3 nvarchar (30) null,
	TienNghiPhong4 nvarchar (30) null,
	TienNghiPhong5 nvarchar (30) null,
	TienNghiPhong6 nvarchar (30) null,
	HutThuoc1 nvarchar (30) null,
	HutThuoc2 nvarchar (30) null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE
	Foreign key (ID) References ThongTinKhachSan(ID)
);
SELECT *FROM ThongTinPhongCuaKhachSan
DROP TABLE ThongTinPhongCuaKhachSan