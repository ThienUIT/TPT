create database TPT
go
use TPT
go

set dateformat dmy

create table Diem
(MaMonHoc varchar(50) ,
MaSinhVien varchar(50),
DiemGK float,
DiemCK float,
Lanthi int,
NgayThi smalldatetime,
GhiChu nvarchar(500),
primary key (MaMonHoc,MaSinhVien),

)
GO
CREATE TABLE DK_MonHoc
(
MaMonHoc varchar(50) ,
MaSinhVien varchar(50),
 NgayDangKy smalldatetime,
 SoTinChi int,
 HocKy int,
primary key (MaMonHoc,MaSinhVien)

)
go
create table GiaoVien
(
MaGiaoVien varchar(50) primary key,
TenGiaoVien nvarchar(50),
MaKhoa varchar(50),
GhiChu nvarchar(500),

)
go
create table Khoa
(
MaKhoa varchar(50) primary key,
TenKhoa nvarchar(50),
GhiChu varchar(500),

)
GO
CREATE TABLE KhoaHoc
(
MaKhoaHoc varchar(50) primary key,
TenKhoaHoc nvarchar(500),
NgayBatDau smalldatetime,
NgayKetThuc smalldatetime,
GhiChu nvarchar(500),
)
go
create table Lop
(
MaLop varchar(50) primary key,
MaKhoaHoc varchar(50),
MaNganh varchar(50),
TenLop nvarchar(50),
GhiChu nvarchar(500),


)
go
create table MonHoc
(
MaMonHoc varchar(50) primary key,
TenMonHoc nvarchar(50),
MaKhoa varchar(50),
SoTinChi int,
HinhThuc nvarchar(20),
TongSoTiet int,
SoTietLyThuyet int,
SoTietThucHanh int,
GhiChu nvarchar(500),
)
GO
CREATE TABLE Nganh
(
MaNganh varchar(50) primary key,
TenNganh nvarchar(50),
GhiChu nvarchar(500),

)
go
create table SinhVien
(MaSinhVien varchar(50) primary key,
HoTen nvarchar(150),
QueQuan nvarchar(350),
NgaySinh smalldatetime,
NoiSinh nvarchar(400),
GioiTinh nvarchar(5),
MaLop varchar(50),
Hinh nvarchar(150),
GhiChu nvarchar(500),

)
go
create table tb_User
(
ID bit not null,
Username nvarchar(50) primary key,
Pass nvarchar(50)
)
go

-- khoá ngoại điểm
alter table Diem add constraint FK_Dien_MonHoc foreign key (MaMonHoc) references MonHoc(MaMonHoc)
alter table Diem add constraint FK_Dien_SinhVien foreign key (MaSinhVien) references SinhVien(MaSinhVien)
--khoá ngoại ĐKMH
alter table DK_MonHoc add constraint FK_DKMH_MH foreign key (MaMonHoc) references MonHoc(MaMonHoc)
alter table DK_MonHoc add constraint FK_DKMH_SV foreign key (MaSinhVien) references SinhVien(MaSinhVien)
--khoá ngoại giáo viên
alter table GiaoVien add constraint FK_GV_Khoa foreign key (MaKhoa) references Khoa(MaKhoa)
-- khoá ngoại Lớp
alter table Lop add constraint Fk_Lop_KhoaHoc foreign key (MaKhoaHoc) references KhoaHoc(MaKhoaHoc)
alter table Lop add constraint Fk_Lop_Nganh foreign key (MaNganh) references Nganh(MaNganh)
--khoá ngoại Môn Học
alter table MonHoc add constraint FK_MonHoc_Khoa foreign key (MaKhoa) references Khoa(MaKhoa)
--Khoá ngoại SinhVien
alter table SinhVien add constraint FK_SV_Lop foreign key(MaLop) references Lop(MaLop)