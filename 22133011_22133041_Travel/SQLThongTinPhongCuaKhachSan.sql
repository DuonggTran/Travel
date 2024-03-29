Use DoAnCuoiKy
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

insert into ThongTinPhongCuaKhachSan values
(1,'Phong Giuong Do', '10', '100000', 'bon tam', 'nha ve sinh', 'voi sen', 'do ve sinh ca nhan mien phi', 'nhin ra thanh pho', 'nhin ra bien', 'tv', 'tu lanh', 'dieu hoa', 'wifi free', 'he thong cach am', 'ban lam viec', 'duoc hut thuoc', null, null ,null);
insert into ThongTinPhongCuaKhachSan values
(1,'Phong Giuong Don', '20', '300000', 'bon tam', 'nha ve sinh', 'voi sen', 'do ve sinh ca nhan mien phi', 'nhin ra thanh pho', 'nhin ra bien', 'tv', 'tu lanh', 'dieu hoa', 'wifi free', 'he thong cach am', 'ban lam viec', 'duoc hut thuoc', null, null ,null);
insert into ThongTinPhongCuaKhachSan values
(2,'Phong Giuong Doi', '20', '500000', 'bon tam', 'nha ve sinh', 'voi sen', 'do ve sinh ca nhan mien phi', 'nhin ra thanh pho', 'nhin ra bien', 'tv', 'tu lanh', 'dieu hoa', 'wifi free', 'he thong cach am', 'ban lam viec', 'duoc hut thuoc', null, null ,null);
insert into ThongTinPhongCuaKhachSan values
(2,'Phong Giuong Don', '15', '200000', 'bon tam', 'nha ve sinh', 'voi sen', 'do ve sinh ca nhan mien phi', 'nhin ra thanh pho', 'nhin ra bien', 'tv', 'tu lanh', 'dieu hoa', 'wifi free', 'he thong cach am', 'ban lam viec', 'duoc hut thuoc', null, null ,null);
insert into ThongTinPhongCuaKhachSan values
(3,'Phong Giuong Doi', '20', '500000', 'bon tam', 'nha ve sinh', 'voi sen', 'do ve sinh ca nhan mien phi', 'nhin ra thanh pho', 'nhin ra bien', 'tv', 'tu lanh', 'dieu hoa', 'wifi free', 'he thong cach am', 'ban lam viec', 'duoc hut thuoc', null, null ,null);
insert into ThongTinPhongCuaKhachSan values
(3,'Phong Giuong Don', '20', '100000', 'bon tam', 'nha ve sinh', 'voi sen', 'do ve sinh ca nhan mien phi', 'nhin ra thanh pho', 'nhin ra bien', 'tv', 'tu lanh', 'dieu hoa', 'wifi free', 'he thong cach am', 'ban lam viec', 'duoc hut thuoc', null, null ,null);