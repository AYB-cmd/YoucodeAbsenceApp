﻿CREATE PROCEDURE [dbo].spStudentRegister
	@user_ID nvarchar(128),
	@email nvarchar(50)
AS
begin
	insert into [User] ([user_ID], [email]) VALUES (@user_ID,@email);
	insert into [student] ([user_ID]) VALUES (@user_ID)
end