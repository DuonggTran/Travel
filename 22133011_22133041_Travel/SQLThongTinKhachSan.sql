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