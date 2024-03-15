CREATE TABLE ThongTinPhong
(
	TenKhachSan varchar(20),
	DiaDiem varchar(20),
	LoaiPhong varchar(20),
	PhuongTien varchar(20),
	GiaTien varchar(20),
	TienIch varchar(20),
	TienNghi varchar(20),
	AnUong varchar(20),
	MoTa varchar(300),
	--HinhAnh IMAGE NULL
);
INSERT INTO ThongTinPhong(TenKhachSan, DiaDiem, LoaiPhong, PhuongTien, GiaTien, TienIch, TienNghi, AnUong, MoTa)
VALUES('Sky','HCM','Giuong Doi','Xe may','500.000','Wifi','Ho boi rieng','Free','Tuyet voi');
SELECT *FROM ThongTinPhong
DROP TABLE ThongTinPhong