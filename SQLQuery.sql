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
@idBill int, @idFood int, @count INT, @giaHienTai int, @tongTien bigint
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
	update Hoa_Don set Tong_Tien = @tongTien where ID_Bill = @idBill and Trang_Thai_Thanh_Toan = 0
end*/
