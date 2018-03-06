USE QuanLyThuVien
GO

CREATE proc ThemKeSach
(	
	@Ma nvarchar(20),
	@Ten nvarchar(20),
	@ViTri NVARCHAR(20)
)
as
insert into dbo.KeSach
values (@Ma, @Ten, @ViTri);

create proc XoaKeSach
(	
	@Ma nvarchar(20)
)
as
delete dbo.KeSach
where MaKS=@Ma;

create proc SuaKeSach
(
	@Ma nvarchar(20),
	@Ten nvarchar(20),
	
	@ViTri nvarchar(20)
	
)
as
update dbo.KeSach
set MaKS=@Ma,
    TenKS=@Ten,
	ViTri=@ViTri
where MaKS=@Ma;

create proc TimKeSach

	@Ten nvarchar(20)
as
begin
select *from dbo.KeSach t
where
	t.MaKS like '%' + (case isnull(@Ten,'')
						when '' then t.TenKS
						else convert(nvarchar,@Ten)
						end) +'%'

end


create proc ThemSach
(
	@Ma  nvarchar(20),
	@MDS nvarchar(20),
	@MKS nvarchar(20),
	@NamXB int
	
)
as
insert into dbo.Sach

values (@Ma, @MDS, @MKS, @NamXB);

create proc XoaSach
(
	@Ma nvarchar(20)
)
as
delete dbo.Sach
where MaSach=@Ma;

CREATE proc SuaSach
(
	@Ma  nvarchar(20),
	@MDS nvarchar(20),
	@MKS nvarchar(20),
	@NamXB int		
)
as
update dbo.Sach
set MaSach =@Ma,
	MaDS =@MDS,
	MaKS =@MKS,
	NamXuatBan =@NamXB
where MaSach=@Ma;
create proc TimSach	

	@Ten nvarchar(20)
as
begin
select *from dbo.Sach t
where
	t.MaDS like '%' + (case isnull(@Ten,'')
						when '' then t.MaDS
						else convert(nvarchar,@Ten)
						end) +'%'

end