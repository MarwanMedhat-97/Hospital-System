USE Hospital;
GO

--------------------------------------------------------------------------------------
----------------------------------------Deleting HEntities By ID
CREATE PROCEDURE DeleteDepID @DEPID int
AS
BEGIN
Delete  From Department
where DID=@DEPID
END
GO
--------------------------------------
--EXEC DeleteDepID @DEPID = 1
--GO
---------------------------------------------------------------------
CREATE PROCEDURE DeleteClinicID @CLINICID int
AS
BEGIN
Delete  From Clinics
where TYP=@CLINICID
END
GO
--------------------------------------
--EXEC DeleteClinicID @CLINICID = 2
--GO
---------------------------------------------------------------------
CREATE PROCEDURE DeleteERID @ERID int
AS
BEGIN
Delete  From ER
where ERID=@ERID
END
GO
--------------------------------------
--EXEC DeleteERID @ERID = 2
--GO
---------------------------------------------------------------------
-----------------------------------Deleting Employee by name
CREATE PROCEDURE DeleteDepName @DEPNAME VARCHAR(50)
AS
BEGIN
Delete  From Department
where Dtype=@DEPNAME
END
GO
--------------------------------------
--EXEC DeleteDepName @DEPNAME = 'MD'
--GO
----------------------------------------------------------
CREATE PROCEDURE DeleteClinicName @CLINICNAME VARCHAR(50)
AS
BEGIN
Delete  From Clinics
where TypeC=@CLINICNAME
END
GO
--------------------------------------
--EXEC DeleteClinicName @CLINICNAME = 'Body'
--GO
----------------------------------------------------------
CREATE PROCEDURE DeleteERName @ERNAME VARCHAR(50)
AS
BEGIN
Delete  From ER
where ERType=@ERNAME
END
GO
--------------------------------------
--EXEC DeleteERName @ERNAME = 'Cardiac Arest'
--GO
----------------------------------------------------------
CREATE PROCEDURE DeleteDrugName @DRUGNAME VARCHAR(50)
AS
BEGIN
Delete  From Pharmacy
where DrugName=@DRUGNAME
END
GO
--------------------------------------
--EXEC DeleteDrugName @DRUGNAME = 'panadol'
--GO
----------------------------------------------------------