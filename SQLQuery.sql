alter proc USP_GetAccountByUserName
@username nvarchar(100)
as
begin
	select * from Nguoi_Quan_Li where Ten = @username;
end


 go


alter proc USP_InsertBill
@idTable int, @idQuanLi varchar(15)                                                                                                                                                                                                                                                                                                                                                                                                                         
as
begin 
	declare @macoupon varchar(15) = '0';
	declare @endKhuyenMai date;
	set @macoupon = (select Ma_Coupon from Coupon where GETDATE() < Ngay_Ket_Thuc and Ma_Coupon != '0')
	if(isnull(@macoupon,'0') = '0')
		begin
			set @macoupon = '0'
		end
	insert Hoa_Don(Ngay_Nhap,ID_Ban,Trang_Thai_Thanh_Toan,ID_Quan_Li, Ma_Coupon, Ten, Email, Dia_Chi_Khach, So_Dien_Thoai, Tong_Tien) values (GETDATE(),@idTable,'0',@idQuanLi,@macoupon,'0','0','0','0','0')
end --insert vào bill

go

alter proc USP_InsertBillInfor
@idBill int, @idFood int, @count INT, @giaHienTai int
as 
begin
	declare @isExistBill int
	declare @foodCount int =  1
	declare @checkRowBill int = 0 
	select  @isExistBill = ID_TTHD, @foodCount = TTHD.So_Mon from Thong_Tin_Hoa_Don as TTHD where ID_Bill = @idBill and ID_Mon = @idFood

	if(@isExistBill > 0)
		begin
			declare @newCount int = @foodCount + @count		
				if(@newCount>0)
			begin 						
				update Thong_Tin_Hoa_Don set So_Mon = @foodCount + @count, Gia_Hien_Tai = @giaHienTai, Tong_Tien_Mon = @giaHienTai * (@foodCount + @count) where ID_Mon = @idFood					
			end		
				else
			begin
				delete Thong_Tin_Hoa_Don where ID_Bill = @idBill and ID_Mon = @idFood
			
				set @checkRoWBill = (select count(ID_TTHD) from Thong_Tin_Hoa_Don where ID_Bill = @idBill)
				if(@checkRowBill = 0)
					delete from Hoa_Don where ID_Bill = @idBill
			end
		end
	else
	begin
		insert Thong_Tin_Hoa_Don( ID_Bill,ID_Mon,So_Mon,Gia_Hien_Tai,Tong_Tien_Mon) values (@idBill,@idFood,@count,@giaHienTai,@giaHienTai * @count)
	end
end

go

alter trigger UTG_UpdateBillInfo
on Thong_Tin_Hoa_Don for insert, update
as 
begin
	declare @idBill int
	select @idBill = ID_Bill from inserted
	declare @idBan int
	select @idBan = ID_Ban  from Hoa_Don where ID_Bill = @idBill and Trang_Thai_Thanh_Toan = 0
	update Ban set Tinh_Trang_Ban = N'Có Người' where ID_Ban = @idBan
end

go 


alter trigger UTG_UpdateBill
on Hoa_Don for update
as 
begin
	declare @idBill int 
	select @idBill = ID_Bill from inserted
	declare @idBan int
	select @idBan = ID_Ban from Hoa_Don where ID_Bill = @idBill
	declare @count int = 0
	select @count = COUNT(*) from Hoa_Don where ID_Ban = @idBan and Trang_Thai_Thanh_Toan = 0
	if(@count = 0)
		update Ban set Tinh_Trang_Ban = N'Trống' where ID_Ban = @idBan
end

go

alter proc USP_UpdateProfile
@emailLogin varchar(100),@Ten nvarchar(100),@diaChi nvarchar(255),@gioiTinh nvarchar(15), @ngaySinh Date,@soDienThoai varchar(15), @passWord varchar(255) , @TangPhucVu int
as 
begin
	declare @isRightPass int = 0
	select @isRightPass = count(*) from Nguoi_Quan_Li where @emailLogin = Email_Dang_Nhap and @passWord = Nguoi_Quan_Li.Password
	if(@isRightPass = 1)
		begin
			update Nguoi_Quan_Li set Tang = @TangPhucVu, Ten = @Ten, Dia_Chi = @diaChi, Gioi_Tinh = @gioiTinh, Ngay_Sinh = @ngaySinh, So_Dien_Thoai = @soDienThoai where Email_Dang_Nhap = @emailLogin and Password = @passWord
		end
end

go

alter proc USP_ChangeFoodInAdmin
@ID_Mon int , @Ten_Mon nvarchar(100), @ID_Loai varchar(20),@Tinh_Trang nvarchar(50), @Gia int,@Don_Vi_Tinh nvarchar(MAX)
as
begin
	update Thuc_An set Ten_Mon = @Ten_Mon, ID_Loai = @ID_Loai, Tinh_Trang = @Tinh_Trang, Gia = @Gia, Don_Vi_Tinh = @Don_Vi_Tinh where ID_Mon = @ID_Mon
end


go 


alter proc USP_SelectBan
@tang int
as
begin
    if(@tang < 4 )
	begin
	select B.ID_Ban,B.Tang,B.Ten_Ban,B.Tinh_Trang_Ban from Ban as B where Tang = @Tang 
	end
	else if(@tang = 4)
	begin
	select * from Ban 
	end
end

go

alter proc USP_getListBillByDate
@dateStart Date,@dateEnd Date
as 
begin
	select HD.* from Hoa_Don as HD where Ngay_Xuat >= @dateStart and Ngay_Nhap <= @dateEnd
end

go

alter proc USP_selectListAccount
as
begin
select NQL.Email_Dang_Nhap, NQL.Ten, NQL.Gioi_Tinh , NQL.So_Dien_Thoai, NQL.Ngay_Sinh , NQL.Dia_Chi,NQL.Tang from Nguoi_Quan_Li as NQL
end
exec USP_selectListAccount


go

alter proc USP_insertNewAccount
@ten nvarchar(100), @diachi nvarchar(255), @gioiTinh nvarchar(15), @ngaySinh date, @soDienThoai varchar(15),@email varchar(100),@passWord varchar(255),@chuQuan int,@tang int
as
begin
	insert into Nguoi_Quan_Li(Ten,Dia_Chi,Gioi_Tinh,Ngay_Sinh,So_Dien_Thoai,Email_Dang_Nhap,Password,Chu_Quan,Trang_Thai_Dang_Nhap,Tang) values (@ten,@diachi,@gioiTinh,@ngaySinh,@soDienThoai,@email,@passWord,@chuQuan,0,@tang)
	if(@chuQuan = 1) update Nguoi_Quan_Li set Tang = 4 where Email_Dang_Nhap = @email
end


go 
--------------------------------------------------------------------------
create trigger UTG_deleteBillInfo
on Thong_Tin_Hoa_Don for delete
as
begin
	declare @idBillInfo int 
	declare @idBill int
	select @idBillInfo = ID_TTHD, @idBill = deleted.ID_Bill from deleted

	declare @idTable int
	select @idTable = ID_Ban from Hoa_Don where ID_Bill = @idBill

	declare @count int = 0

	select @count = count(*) from Thong_Tin_Hoa_Don as tthd, Hoa_Don as hd where hd.ID_Bill = tthd.ID_Bill and hd.ID_Bill = @idBill and hd.Trang_Thai_Thanh_Toan = 0

	if(@count = 0)
		update Ban set Ban.Tinh_Trang_Ban = N'Trống' where Ban.ID_Ban = @idTable
end

go

alter proc USP_AddFoodInAdmin
@ID_Mon int, @Ten_Mon nvarchar(100), @ID_Loai varchar(20),@Tinh_Trang nvarchar(50),@Gia int,@Don_Vi_Tinh nvarchar(MAX)
as
begin
	insert Thuc_An values (@ID_Mon,@Ten_Mon,@ID_Loai,@Tinh_Trang,@Gia,@Don_Vi_Tinh)
end

go

alter proc USP_getCountCoupon
@now date
as
begin
	select count(*) from Coupon where Ngay_Bat_Dau < @now and Ngay_Ket_Thuc > @now and Phan_Tram_Giam != 0
end

go

alter proc USP_getPhanTramGiam
@now date
as
begin
	select Phan_Tram_Giam from Coupon where Ngay_Bat_Dau < @now and Ngay_Ket_Thuc > @now and Phan_Tram_Giam != 0
end

go 

create proc USP_insertCoupon
@ma varchar(15),@TenCT nvarchar(200), @PTG int, @dateStart date, @dateEnd date
as
begin
	insert Coupon values (@ma,@tenCT,@PTG,@dateStart,@dateEnd)
end