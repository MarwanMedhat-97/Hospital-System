use Hospital;
GO

----------------------------Get Clinics By ID
CREATE PROCEDURE GetClinicID @Clinic_ID int
AS
BEGIN
SELECT*
FROM Clinics
WHERE TYP = @Clinic_ID
END
GO
------------------------------------------
EXEC GetClinicID @Clinic_ID = 2
GO
----------------------------------------- Get all Clinics
CREATE PROCEDURE GetClinic 
AS
BEGIN
SELECT * FROM Clinics
END
GO
------------------------------------------
EXEC GetClinic
GO
---------------------------------------------------
CREATE PROCEDURE GetClinicTypeC @Clinic_ID INT
AS
BEGIN 
SELECT TypeC
FROM Clinics
WHERE TYP=@Clinic_ID
END
GO

EXEC GetClinicTypeC @Clinic_ID = 2
GO
----------------------------------------------------
CREATE PROCEDURE GetClinicPrice @Clinic_ID INT
AS
BEGIN
SELECT Price
FROM Clinics
WHERE TYP=@Clinic_ID
END
GO

EXEC GetClinicPrice @Clinic_ID = 2
GO
-----------------------------------------------------
CREATE PROCEDURE GetClinicCapacity @Clinic_ID INT
AS
BEGIN
SELECT Capacity
FROM Clinics
WHERE TYP=@Clinic_ID
END
GO

EXEC GetClinicCapacity @Clinic_ID = 2
GO
-------------------------------------------------------
CREATE PROCEDURE GetClinicWHourse @Clinic_ID INT
AS
BEGIN
SELECT Whours
FROM Clinics
WHERE TYP=@Clinic_ID
END
GO

EXEC GetClinicWHourse @Clinic_ID = 2
GO