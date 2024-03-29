Use DoAnCuoiKy
CREATE TABLE ThongTinKhachSan
(
	ID INT PRIMARY KEY IDENTITY,
	TenKhachSan nvarchar(100) Null,
	DiaDiemKhachSan nvarchar(100)Null,
	Loai nvarchar(100)Null,
	MoTa nvarchar(500)Null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	HinhAnh3 IMAGE,
	HinhAnh4 IMAGE
);
SELECT *FROM ThongTinKhachSan
DROP TABLE ThongTinKhachSan

insert into ThongTinKhachSan values
(1,'Chill and Free', 'Nha Trang', 'Homestay', ' co nhan vien phuc vu tot, view dep', null, null, null, null);
insert into ThongTinKhachSan values
(2,'Paradise', N'Huế', 'Hotel', 'view dep, do an ngon, thai do nhan vien tot', null, null, null, null);
insert into ThongTinKhachSan values
(3,'Heaven', 'Nha Trang', 'Homestay', 'do an ngon, nhan vien nhiet tinh, sach se, thom', null, null, null, null);
