/*create proc USP_GetAccountByUserName
@username nvarchar(100)
as
begin
	select * from Nguoi_Quan_Li where Ten = @username;
end*/

/*alter proc USP_InsertBill
@idTable int, @idQuanLi varchar(15)                                                                                                                                                                                                                                                                                                                                                                                                                         
as
begin 
	insert Hoa_Don(Ngay_Nhap,ID_Ban,Trang_Thai_Thanh_Toan,ID_Quan_Li) values (GETDATE(),@idTable,'0',@idQuanLi)
end --insert vào bill*/

/*create proc USP_InsertBillInfor
@idBill int, @idFood int, @count INT
as
begin
	insert Thong_Tin_Hoa_Don( ID_Bill,ID_Mon,So_Mon) values (@idBill,@idFood,@count)
end
go*/

/*alter proc USP_InsertBillInfor
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
end*/

/*create trigger UTG_UpdateBillInfo
on Thong_Tin_Hoa_Don for insert, update
as 
begin
	declare @idBill int
	select @idBill = ID_Bill from inserted
	declare @idBan int
	select @idBan = ID_Ban  from Hoa_Don where ID_Bill = @idBill and Trang_Thai_Thanh_Toan = 0
	update Ban set Tinh_Trang_Ban = N'Có Người' where ID_Ban = @idBan
end*/
/*create trigger UTG_UpdateBill
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
go*/