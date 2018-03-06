create proc ThemDocGia
(	
	@Ma nvarchar(20),
	@Ten nvarchar(20),
	@NS date,
	@Add nvarchar(20),
	@SDT int
)
as

insert into DocGia
values (@Ma, @Ten, @NS, @Add,@SDT);

create proc XoaDocGia
(	
	@Ma nvarchar(20)
)
as
delete DocGia
where MaDG=@Ma;

create proc SuaDocGia
(
	@Ma nvarchar(20),
	@Ten nvarchar(20),
	@NS date,
	@Add nvarchar(20),
	@SDT int
)
as
update DocGia
set MaDG=@Ma,
    TenDG=@Ten,
	NgaySinh=@NS,
	DiaChi=@Add,
	SDT=@SDT
where MaDG=@Ma;

create proc TimDocGia	

	@Ten nvarchar(20)
as
begin
select *from DocGia t
where
	t.MaDG like '%' + (case isnull(@Ten,'')
						when '' then t.TenDG
						else convert(nvarchar,@Ten)
						end) +'%'

end


create proc ThemNXB
(
	@Ma  nvarchar(20),
	@Ten nvarchar(20),
	@Add nvarchar(20),
	@SDT int
)
as
insert into NhaXuatBan
values (@Ma, @Ten, @Add, @SDT);

create proc XoaNXB
(
	@Ma nvarchar(20)
)
as
delete NhaXuatBan
where MaNXB=@Ma;
drop proc XoaNXB

create proc SuaNXB
(
	@Ma  nvarchar(20),
	@Ten nvarchar(20),
	@Add nvarchar(20),
	@SDT int		
)
as
update NhaXuatBan
set MaNXB =@Ma,
	TenNXB =@Ten,
	DiaChi =@Add,
	SDT =@SDT
where MaNXB=@Ma;

create proc TimNXB	

	@Ten nvarchar(20)
as
begin
select *from NhaXuatBan t
where
	t.MaNXB like '%' + (case isnull(@Ten,'')
						when '' then t.TenNXB
						else convert(nvarchar,@Ten)
						end) +'%'

end

