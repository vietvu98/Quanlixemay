USE QUANLICUAHANG_XEMAY
-- Proc nhà cung cấp
GO
create proc NCC_INSERT (
@MANHACUNGCAP NVARCHAR(50),
@TENNHACUNGCAP NVARCHAR(50),
@DIACHI NVARCHAR(100),
@DIENTHOAI FLOAT,
@EMAIL NVARCHAR(50),
@HINHANH IMAGE
)
AS BEGIN
INSERT INTO NHACUNGCAP VALUES (@MANHACUNGCAP, @TENNHACUNGCAP, @DIACHI, @DIENTHOAI, @EMAIL, @HINHANH)
END
-----------------------------------------------------------------------------------------
GO
CREATE PROC NCC_UPDATE (
@MANHACUNGCAP NVARCHAR(50),
@TENNHACUNGCAP NVARCHAR(50),
@DIACHI NVARCHAR(100),
@DIENTHOAI FLOAT,
@EMAIL NVARCHAR(50),
@HINHANH IMAGE
)
AS BEGIN 
   UPDATE NHACUNGCAP SET TENNHACUNGCAP=@TENNHACUNGCAP, DIACHI=@DIACHI, DIENTHOAI=@DIENTHOAI, 
   EMAIL=@EMAIL, HINHANH=@HINHANH WHERE MANHACUNGCAP=@MANHACUNGCAP
   END
-----------------------------------------------------------------------------------------
GO 
CREATE PROC NCC_DELETE(
@MANHACUNGCAP   NVARCHAR(50)
)
AS BEGIN 
    DELETE FROM NHACUNGCAP WHERE MANHACUNGCAP=@MANHACUNGCAP
END	
-----------------------------------------------------------------------------------------
GO 
Create PROC NCC_SEARCH(@TKNHACUNGCAP NVARCHAR(50))
AS BEGIN
   SELECT MANHACUNGCAP, TENNHACUNGCAP, DIACHI, DIENTHOAI, EMAIL FROM NHACUNGCAP WHERE   CONCAT(MANHACUNGCAP, TENNHACUNGCAP, DIACHI, DIENTHOAI, EMAIL) LIKE '%'+@TKNHACUNGCAP+'%'
END
-----------------------------------------------------------------------------------------
GO 
CREATE PROC NCC_SELECT
AS BEGIN 
    SELECT * FROM NHACUNGCAP
END
-----------------------------------------------------------------------------------------
GO 
CREATE PROC NCC_SELECTMANCC(@MANHACUNGCAP NVARCHAR(50))
AS BEGIN
   SELECT * FROM NHACUNGCAP WHERE MANHACUNGCAP=@MANHACUNGCAP
END
--Proc khach hang
GO
create proc KH_SELECT
AS BEGIN 
   SELECT * FROM KHACHHANG 
END
-----------------------------------------------------------------------------------------
GO
CREATE PROC KH_INSERT(
    @MAKH NVARCHAR(50),
	@TENKH NVARCHAR(50),
	@DIACHI NVARCHAR(50),
	@DIENTHOAI FLOAT,
	@GMAIL NVARCHAR(50)
)
AS BEGIN 
   INSERT INTO KHACHHANG VALUES (@MAKH, @TENKH, @DIACHI, @DIENTHOAI, @GMAIL)
END
-----------------------------------------------------------------------------------------
GO 
CREATE PROC KH_UPDATE(
     @MAKH NVARCHAR(50),
	@TENKH NVARCHAR(50),
	@DIACHI NVARCHAR(50),
	@DIENTHOAI FLOAT,
	@GMAIL NVARCHAR(50)
)
AS BEGIN
    UPDATE KHACHHANG SET TENKH=@TENKH, DIACHI= @DIACHI, DIENTHOAI= @DIENTHOAI, GMAIL= @GMAIL Where MAKH= @MAKH
end
-----------------------------------------------------------------------------------------
go
CREATE PROC KH_DELETE(@MAKH NVARCHAR(50))
AS BEGIN 
   DELETE FROM KHACHHANG WHERE MAKH=@MAKH
END
-----------------------------------------------------------------------------------------
GO 
create PROC KH_SEARCH(@TKKH NVARCHAR(50))
AS BEGIN
   SELECT MAKH, TENKH, DIACHI, DIENTHOAI, GMAIL FROM KHACHHANG WHERE CONCAT(MAKH, TENKH, DIACHI, DIENTHOAI, GMAIL) LIKE '%'+@TKKH+'%'
END
-----------------------------------------------------------------------------------------
--Proc San pham
go
create proc SELECTALL_VND
as begin
   select MASP, TENSP,MALOAI, DUNGTICHXL, KICHTHUOC, CONCAT(KHOILUONG, ' Kg') As KHOILUONGSP, CONGSUATTD, HANGXE, SOLUONG, CONCAT (GIABAN, N' VNĐ') AS GIASP  from SANPHAM 
   END
  EXEC SELECTALL_VND
  -----------------------------------------------------------------------------------------
 GO
 CREATE PROC SP_INSERT(
 @MASP NVARCHAR(50),
 @TENSP NVARCHAR(50),
 @MALOAI NVARCHAR(50),
 @DUNGTICHXL NVARCHAR(50),
 @KICHTHUOC NVARCHAR(50),
 @KHOILUONG INT,
 @CONGSAUTTD NVARCHAR(50),
 @HANGXE NVARCHAR(50),
 @SOLUONG        INT,
 @GIABAN BIGINT,
 @HINHANH IMAGE
)
AS BEGIN 
INSERT INTO SANPHAM VALUES (@MASP, @TENSP, @MALOAI, @DUNGTICHXL, @KICHTHUOC, @KHOILUONG, @CONGSAUTTD, @HANGXE, @SOLUONG, @GIABAN, @HINHANH)
END
 -----------------------------------------------------------------------------------------
 GO
 CREATE PROC SP_UPDATE(
 @MASP NVARCHAR(50),
 @TENSP NVARCHAR(50),
 @MALOAI NVARCHAR(50),
 @DUNGTICHXL NVARCHAR(50),
 @KICHTHUOC NVARCHAR(50),
 @KHOILUONG INT,
 @CONGSAUTTD NVARCHAR(50),
 @HANGXE NVARCHAR(50),
 @SOLUONG        INT,
 @GIABAN BIGINT,
 @HINHANH IMAGE
 )
 AS BEGIN 
 UPDATE SANPHAM SET TENSP=@TENSP, MALOAI=@MALOAI, DUNGTICHXL=@DUNGTICHXL, KICHTHUOC=@KICHTHUOC, KHOILUONG=@KHOILUONG, CONGSUATTD=@CONGSAUTTD, HANGXE=@HANGXE, SOLUONG=@SOLUONG, GIABAN=@GIABAN, HINHANH=@HINHANH
 WHERE MASP=@MASP
 END
  -----------------------------------------------------------------------------------------
 GO
 CREATE PROC SP_DELETE(
@MASP   NVARCHAR(50)
)
AS BEGIN 
    DELETE FROM SANPHAM WHERE MASP=@MASP
END	
-----------------------------------------------------------------------------------------
GO 
create PROC SP_SEARCH(@TKSP NVARCHAR(50))
AS BEGIN
   SELECT MASP, TENSP,MALOAI, DUNGTICHXL, KICHTHUOC, CONCAT(KHOILUONG, ' Kg') As KHOILUONGSP, CONGSUATTD, HANGXE, SOLUONG, CONCAT (GIABAN, N' VNĐ') AS GIASP FROM SANPHAM WHERE  CONCAT(MASP, TENSP, HANGXE) LIKE '%'+@TKSP+'%'
END
-----------------------------------------------------------------------------------------
GO
CREATE PROC LOAIXE (@MALOAI NVARCHAR(50))
AS BEGIN 
select MASP, TENSP,MALOAI, DUNGTICHXL, KICHTHUOC, CONCAT(KHOILUONG, ' Kg') As KHOILUONGSP, CONGSUATTD, HANGXE, SOLUONG, CONCAT (GIABAN, N' VNĐ') AS GIASP  from SANPHAM 
WHERE MALOAI=@MALOAI 
END
-----------------------------------------------------------------------------------------
--Nhân viên 
GO
CREATE PROC NV_INSERT (
@MANHANVIEN NVARCHAR(50),
@TENNHANVIEN NVARCHAR(50),
@SDT          FLOAT,
@DIACHI      NVARCHAR(50),
@EMAIL       NVARCHAR(50),
@NGAYSINH    DATE,
@GIOITINH    NVARCHAR(50),
@QUEQUAN     NVARCHAR(50),
@PASSWORD    NVARCHAR(50),
@USERLOGIN   NVARCHAR(50),
@MACV        NVARCHAR(50)
)
AS BEGIN 
INSERT INTO NHANVIEN VALUES (@MANHANVIEN, @TENNHANVIEN, @SDT, @DIACHI, @EMAIL, @NGAYSINH, @GIOITINH, @QUEQUAN, @PASSWORD, @USERLOGIN,@MACV)
END
-----------------------------------------------------------------------------------------
GO
CREATE PROC NV_UPDATE (
@MANHANVIEN NVARCHAR(50),
@TENNHANVIEN NVARCHAR(50),
@SDT          FLOAT,
@DIACHI      NVARCHAR(50),
@EMAIL       NVARCHAR(50),
@NGAYSINH    DATE,
@GIOITINH    nvarchar(50),
@QUEQUAN     NVARCHAR(50),
@MACV        NVARCHAR(50)
)
AS BEGIN 
UPDATE NHANVIEN SET TENNHANVIEN=@TENNHANVIEN, SDT=@SDT, DIACHI=@DIACHI, EMAIL=@EMAIL, NGAYSINH=@NGAYSINH, GIOITINH=@GIOITINH, QUEQUAN=@QUEQUAN, MACV=@MACV
WHERE MANHANVIEN=@MANHANVIEN
END
 -----------------------------------------------------------------------------------------
 GO
 CREATE PROC NV_DELETE(
@MANHANVIEN   NVARCHAR(50)
)
AS BEGIN 
    DELETE FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN
END	
-----------------------------------------------------------------------------------------
GO 
CREATE PROC NV_SEARCH(@MANHANVIEN NVARCHAR(50))
AS BEGIN
   SELECT * FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN
END
-----------------------------------------------------------------------------------------
GO
CREATE PROC UPDATEMAHOA(@MANHANVIEN NVARCHAR(50), @PASS NVARCHAR(50))
AS
BEGIN
	UPDATE NHANVIEN SET PASSWORD = @PASS WHERE MANHANVIEN = @MANHANVIEN
END
go
create proc quenmk(@tk nvarchar(50), @PASS NVARCHAR(50))
AS
BEGIN
	UPDATE NHANVIEN SET PASSWORD = @PASS WHERE USERLOGIN=@tk
END
----------------------------------------------------------------------
-------phiếu nhập---------------------------------------------------
go
create proc selectPN (@ma nvarchar (50))
as
select * from PNHAP where MAPN = @ma
---------------------------------------------------------------------
GO
create PROC INSERT_PNHAP(
@MAPN NVARCHAR(50),
@MANHACUNGCAP NVARCHAR(50),
@MANHANVIEN NVARCHAR(50),
@NGAYNHAP DATE,
@TONGTIEN FLOAT
)
AS
INSERT INTO PNHAP VALUES(@MAPN, @MANHACUNGCAP, @MANHANVIEN, @NGAYNHAP, @TONGTIEN)
---------------------------------------------------------------------
GO
create PROC INSERT_CTPNHAPXE(
@MAPN NVARCHAR(50),
@MASP NVARCHAR(50),
@SLNHAPXE INT,
@DONGIANHAPXE FLOAT,
@THANHTIEN FLOAT
)
AS 
INSERT INTO CTPNHAP VALUES (@MAPN, @MASP, @SLNHAPXE, @DONGIANHAPXE,@THANHTIEN) 
UPDATE SANPHAM SET SOLUONG= SOLUONG +@SLNHAPXE where MASP=@MASP
---------------------------------------------------------------------
go
create proc selectCTPNxe (@ma nvarchar (50))
as
select CTPN.MASP, SP.TENSP, CTPN.SLNHAP, CTPN.DONGIANHAP, CTPN.THANHTIEN   from CTPNHAP CTPN, SANPHAM SP where MAPN = @ma and CTPN.MASP = SP.MASP

go
create proc selectCTPN (@mapn nvarchar (50), @masp nvarchar (50))
as
select * from CTPNHAP where MAPN = @mapn and MASP = @masp
---------------------------------------------------------------------
GO
create PROC UPDATE_TIENNHAPXE(
@MAPN NVARCHAR(50),
@DONGIANHAPXE FLOAT
)
as	
UPDATE PNHAP SET TONGTIEN = @DONGIANHAPXE WHERE MAPN= @MAPN
---------------------------------------------------------------------
go
CREATE proc updateSLTCTPNX (@ma nvarchar (50), @masp nvarchar (50), @soluong int, @THANHTIEN float)
as
update CTPNHAP set SLNHAP = @soluong, THANHTIEN = @THANHTIEN where MAPN = @ma and MASP = @masp
---------------------------------------------------------------------
go
create proc delete_PhieuNhap(@ma nvarchar (50), @MASP nvarchar (50))
as begin
delete from CTPNHAP where MAPN=@ma and MASP=@MASP
end
go
create proc updateSLT (@masp nvarchar (50), @soluong int)
as 
update SANPHAM set SOLUONG = @soluong where MASP =@masp

/*GO
create PROC SELECT_CTNHAP
AS BEGIN
SELECT   CTX.MASP, CTX.SLNHAP, CTX.DONGIANHAP, CTP.MAPT, CTP.SLNHAP, CTP.DONGIANHAP
FROM  CTPNHAP CTX, CTPNHAPPT CTP, PNHAP PN
WHERE CTX.MAPN = PN.MAPN and CTP.MAPN = PN.MAPN
END

go
create proc selectNCC (@MA nvarchar (50))
AS
select * from NHACUNGCAP where MANHACUNGCAP = @ma
select * from SANPHAM*/

---------------------Hóa đơn -----------------------------------------------
go
create proc selectHoaDon (@ma nvarchar (50))
as
select * from HOADON where MAHD = @ma
-------------------------------------------------
go
create proc selectCTHD (@ma nvarchar (50))
as
select CTHD.MASP, SP.TENSP, CTHD.SL, SP.GIABAN, CTHD.THANHTIEN   from CTHD , SANPHAM SP where MAHD = @ma and CTHD.MASP = SP.MASP
-------------------------------------------------------------
go
create proc selectAll_CTHD (@maHD nvarchar (50), @masp nvarchar (50))
as
select * from CTHD where MAHD = @maHD and MASP = @masp
---------------------------------------------------------------
go 
create proc Insert_HoaDon(
    @MAHD			NVARCHAR(50)	,	
	@MAKH			NVARCHAR(50)	,
	@MANHANVIEN		NVARCHAR(50)	,	
	@NGAYXUATHD          DATE ,
	@CHIETKHAU       INT ,
	@THANHTIEN        FLOAT,
	@TRANGTHAI      BIT
)
as
INSERT INTO HOADON VALUES (@MAHD, @MAKH, @MANHANVIEN, @NGAYXUATHD, @CHIETKHAU, @THANHTIEN,@TRANGTHAI)
-------------------------------------------------
GO 
CREATE PROC INSERT_CTHD(
@MAHD           NVARCHAR(50),
@MASP           NVARCHAR(50),
@SL             INT,
@THANHTIEN      FLOAT
)
AS
INSERT INTO CTHD VALUES (@MAHD, @MASP, @SL, @THANHTIEN)
UPDATE SANPHAM SET SOLUONG = SOLUONG - @SL WHERE MASP=@MASP
---------------------------------------------------------------------
GO
create PROC UPDATE_ThanhTien(
@MAHD NVARCHAR(50),
@THANHTIEN FLOAT
)
as	
UPDATE HOADON SET THANHTIEN = @THANHTIEN WHERE MAHD= @MAHD
-----------------------------------------------
go
CREATE proc updateSL_CTHD (@ma nvarchar (50), @masp nvarchar (50), @soluong int, @THANHTIEN float)
as
update CTHD set SL = @soluong, THANHTIEN = @THANHTIEN where MAHD = @ma and MASP = @masp
---------------------------------------------------------------------
GO
CREATE PROC UPDATE_TONGTIEN(@MAHD NVARCHAR(50), @TONGTIEN FLOAT)
AS
UPDATE HOADON SET THANHTIEN=@TONGTIEN WHERE MAHD=@MAHD 
--------------------------------------------------------------------
go
 ALTER proc thongKeDoanhThu
 as begin
	drop  table if exists tam
	create table tam (thang int primary key,tien decimal)
	declare @tongTien decimal,@i int =1
	while (@i<13)
		begin
			insert into tam values (@i,0)
			set @i=@i+1
		end
	set @i=1
	while(@i<13)
		begin
		declare @count int =0 
			select @count=count(*) from HOADON where DATEPart(MONTH,NGAYXUATHD)=@i AND DATEPART(YEAR,NGAYXUATHD)=DATEPART(YEAR,GETDATE())
			if(@count>0)
				begin
					select @tongTien=SUM(THANHTIEN) from HOADON where DATEPart(MONTH,NGAYXUATHD)=@i AND DATEPART(YEAR,NGAYXUATHD)=DATEPART(YEAR,GETDATE())
				end
			else
				begin 
					set @tongTien=0
				end
			update tam set tien=@tongTien where thang=@i
			set @i=@i+1
		end
		select N'Month '+CAST (thang as nvarchar(2)) as [thang],tien  from tam
 end
 ----------------------------------------------------------------
 go
 ALTER proc data_xuatExcel 
as
select HOADON.MAHD, KHACHHANG.TENKH, NHANVIEN.TENNHANVIEN, HOADON.NGAYXUATHD, HOADON.CHIETKHAU, HOADON.THANHTIEN from HOADON, KHACHHANG, NHANVIEN 
where  HOADON.MAKH = KHACHHANG.MAKH AND HOADON.MANHANVIEN = NHANVIEN.MANHANVIEN

 






