﻿CREATE PROCEDURE [dbo].[Employee_Service_Add]
	@EmployeeId int,
	@ServiceId int
AS
BEGIN
INSERT INTO dbo.Employee_Service(
	EmployeeId,
	ServiceId)

VALUES(
	@EmployeeId,
	@ServiceId)
SELECT @@IDENTITY
END