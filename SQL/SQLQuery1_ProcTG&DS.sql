--Procedure bảng Tác giả
/* Thủ tục thêm mới tác giả*/
CREATE PROC ThemTG
(
     @MaTG nvarchar(20),
     @TenTG nvarchar(20),
	 @GhiChu nvarchar(20)
)
AS
INSERT INTO TacGia
VALUES(@MaTG,@TenTG,@GhiChu);
 
/* Thủ xóa tác giả*/
CREATE PROC XoaTG
(
     @MaTG nvarchar(20)
)
AS
DELETE TacGia
WHERE MaTG= @MaTG;
 
/* Thủ tục sửa thông tin tác giả*/
CREATE PROC SuaTG
(
     @MaTG nvarchar(20),
     @TenTG nvarchar(20),
     @GhiChu nvarchar(20)
)
AS
UPDATE TacGia
SET MaTG = @MaTG,
     TenTG = @TenTG,
	 GhiChu=@GhiChu
WHERE MaTG= @MaTG;

--Procedure bảng đầu sách
/* Thủ tục thêm mới đầu sách*/
CREATE PROC ThemDS
(
     @MaDS nvarchar(20),
     @TenDS nvarchar(20),
	 @MaTG nvarchar(20),
	 @MaNXB nvarchar(20),
	 @SoLuong int
)
AS
INSERT INTO DauSach
VALUES(@MaDS,@TenDS,@MaTG,@MaNXB,@SoLuong);
 
/* Thủ xóa đầu sách*/
CREATE PROC XoaDS
(
     @MaDS nvarchar(20)
)
AS
DELETE DauSach
WHERE MaDS= @MaDS;
 
/* Thủ tục sửa thông tin đầu sách*/
CREATE PROC SuaDS
(
     @MaDS nvarchar(20),
     @TenDS nvarchar(20),
     @MaTG nvarchar(20),
	 @MaNXB nvarchar(20),
	 @SoLuong int
)
AS
UPDATE DauSach
SET MaDS = @MaDS,
     TenDS = @TenDS,
	 MaTG=@MaTG,
	 MaNXB=@MaNXB,
	 SoLuong=@SoLuong
WHERE MaDS= @MaDS;
