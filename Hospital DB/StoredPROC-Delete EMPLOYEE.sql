USE Hospital;
GO
--------------------------------------------------------------------------------------
----------------------------------------Deleting Employee By ID
CREATE PROCEDURE DeleteDocID @DOCID int
AS
BEGIN
Delete  From Doctor
where DRID=@DOCID
END
GO
--------------------------------------
--EXEC DeleteDocID @DOCID = 12
--GO
---------------------------------------------------------------------
CREATE PROCEDURE DeleteNurseID @NURSEID int
AS
BEGIN
Delete  From Nurse
where NID=@NURSEID
END
GO
--------------------------------------
--EXEC DeleteNurseID @NURSEID = 22
--GO
---------------------------------------------------------------------
CREATE PROCEDURE DeleteRecpID @RecpID int
AS
BEGIN
Delete  From Recipient
where RID=@RecpID
END
GO
--------------------------------------
--EXEC DeleteRecpID @RecpID = 42
--GO
---------------------------------------------------------------------
CREATE PROCEDURE DeletePharmID @PHARMID int
AS
BEGIN
Delete  From Pharmacist
where PID=@PHARMID
END
GO
--------------------------------------
--EXEC DeletePharmID @PHARMID = 32
--GO
---------------------------------------------------------------------
-----------------------------------Deleting Employee by name
CREATE PROCEDURE DeleteDocName @DOCFNAME VARCHAR(50),@DOCLNAME VARCHAR(50)
AS
BEGIN
Delete  From Doctor
where Fname=@DOCFNAME AND Lname=@DOCLNAME
END
GO
--------------------------------------
--EXEC DeleteDocName @DOCFNAME = 'Karolain',
--@DOCLNAME ='Sai'
--GO
----------------------------------------------------------
CREATE PROCEDURE DeleteNurseName @NURSEFNAME VARCHAR(50),@NURSELNAME VARCHAR(50)
AS
BEGIN
Delete  From Nurse
where Fname=@NURSEFNAME AND Lname=@NURSELNAME
END
GO
--------------------------------------
--EXEC DeleteNurseName @NURSEFNAME = 'Karo',
--@NURSELNAME ='Hao'
--GO
----------------------------------------------------------
CREATE PROCEDURE DeleteRecpName @RECPFNAME VARCHAR(50),@RECPLNAME VARCHAR(50)
AS
BEGIN
Delete  From Recipient
where Fname=@RECPFNAME AND Lname=@RECPLNAME
END
GO
--------------------------------------
--EXEC DeleteRecpName @RECPFNAME = 'Rika',
--@RECPLNAME ='Saitama'
--GO
----------------------------------------------------------
CREATE PROCEDURE DeletePharmName @PHARMFNAME VARCHAR(50),@PHARMLNAME VARCHAR(50)
AS
BEGIN
Delete  From Pharmacist
where Fname=@PHARMFNAME AND Lname=@PHARMLNAME
END
GO
--------------------------------------
--EXEC DeletePharmName @PHARMFNAME = 'Lacie',
--@PHARMLNAME ='Lance'
--GO
----------------------------------------------------------