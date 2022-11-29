create database QLNSTL
go
use QLNSTL
go
create table NHANVIEN
(
MaNV varchar(20) NOT NULL,
TenNV nvarchar(100),
NamSinh numeric,
DiaChi nvarchar(100),
SDT numeric,
GioiTinh varchar(10),
CONSTRAINT PK_MaNV PRIMARY KEY(MaNV)
)

create table BANGCHAMCONG
(
MaNV varchar(20),
Thang int,
SoNgayDiLam int,
LuongTru float,
LuongThuong float,
TongLuong float,
PRIMARY KEY(MaNV,Thang)
)
ALTER TABLE BANGCHAMCONG ADD CONSTRAINT FK_MaNV_BANGCHAMCONG FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV)

create table TAIKHOANNV
(
MaNV varchar(20),
Username varchar(20),
Pass numeric
PRIMARY KEY(MaNV, Username)
)

create table TAIKHOANADMIN
(
Username varchar(20) primary key,
Pass numeric
)
ALTER TABLE TAIKHOANNV ADD CONSTRAINT FK_MaNV_TAIKHOANNV FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV)

INSERT INTO NHANVIEN
VALUES ('0001', 'Le Van Vu', 2003, 'Quan 5', 0944337065, 'Nam' );
INSERT INTO NHANVIEN
VALUES ('0002', 'Tran Duc Nhat Khai', 2002, 'Quan 5', 0844337065, 'Nam' );
INSERT INTO NHANVIEN
VALUES ('0003', 'Le Duc Trong', 2003, 'Quan 5', 0244337065, 'Nam' );
INSERT INTO NHANVIEN
VALUES ('0004', 'Luong Tran Ngoc Khiet', 1990, 'Quan 5', 0344337065, 'Nam' );
INSERT INTO NHANVIEN
VALUES ('0005', 'Nguyen Dang Khoi', 2003, 'Quan 5', 0444337065, 'Nam' );