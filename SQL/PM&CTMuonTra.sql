
create proc [dbo].[Sp_AddCTMuonTra]
@mapm nvarchar(20),
@masach nvarchar(20),
@trangthai nvarchar(20),
@ngaytra date,
@ghichu nvarchar(20)
as
begin
	insert into CTMuonTra(MaPM,MaSach,TrangThai,NgayTra,GhiChu) values(@mapm,@masach,@trangthai,@ngaytra,@ghichu)
end
-------------------
GO
create proc [dbo].[Sp_AddPhieuMuon]
@mapm nvarchar(20),
@madg nvarchar(20),
@ngaymuon date,
@ngayhentra date
as
begin
	insert into PhieuMuon values (@mapm,@madg,@ngaymuon,@ngayhentra)
end
-----------------------------
GO
create proc [dbo].[Sp_DeleteCTMuonTra]
@mapm nvarchar(20)
as
begin
	delete CTMuonTra where MaPM = @mapm
end
-----------------------------
GO
create proc [dbo].[Sp_DeletePhieuMuon]
@mapm nvarchar(20)
as
begin
	delete CTMuonTra where MaPM = @mapm
	delete PhieuMuon where MaPM =@mapm
end
-------------------------------
GO
create proc [dbo].[Sp_UpdateCTMuonTra]
@mapm nvarchar(20),
@masach nvarchar(20),
@trangthai nvarchar(20),
@ngaytra date,
@ghichu nvarchar(20)
as
begin
	update CTMuonTra
	set
	MaPM = @mapm,
	MaSach = @masach,
	TrangThai = @trangthai,
	NgayTra =@ngaytra,
	GhiChu = @ghichu
	where MaPM =@mapm
end
------------------------------------

create proc [dbo].[Sp_UpdatePhieuMuon]
@mapm nvarchar(20),
@madg nvarchar(20),
@ngaymuon date,
@ngayhentra date
as
begin
		update PhieuMuon
		set 
			MaPM = @mapm,
			MaDG =@madg,
			NgayMuon =@ngaymuon,
			NgayHenTra = @ngayhentra
		where MaPM =@mapm
end
--------------------------------
