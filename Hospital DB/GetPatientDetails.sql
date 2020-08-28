use Hospital;
GO


-----------------------------------------
----------------------------------------- Get all Patient
CREATE PROCEDURE GetPatient
AS
BEGIN
SELECT * FROM Patient
END
GO
------------------------------------------
EXEC GetPatient
GO
-----------------------------------------
----------------------------Get Patient By ID
CREATE PROCEDURE GetPatientID @Patient_ID int
AS
BEGIN
SELECT*
FROM Patient
WHERE SSN = @Patient_ID
END
GO
------------------------------------------
EXEC GetPatientID @Patient_ID = 355542
GO
------------------------------------------------
----------------------------Get Patient By ID
CREATE PROCEDURE GetPatientDOCID @DOC_ID int
AS
BEGIN
SELECT*
FROM Patient
WHERE DOCID = @DOC_ID
END
GO
------------------------------------------
EXEC GetPatientDOCID @DOC_ID = 1101
GO
------------------------------------------------------------------------------------------------------------
----------------------------Get Patient By name
CREATE PROCEDURE GetPatientName @Patient_Name varchar(50)
AS
BEGIN
SELECT*
FROM Patient
WHERE Fname = @Patient_Name
END
GO
------------------------------------------
EXEC GetPatientName @Patient_Name = 'Alpha'
GO
-----------------------------------------------------------------------------------------------------------------------
----------------------Get Attending doctor
CREATE PROCEDURE GetAttendingDoc @SSN int
AS
BEGIN
SELECT	*	FROM DoctorWHERE DRID IN  (SELECT  DOCID	FROM Patient	WHERE	SSN=@SSN ) 
END
GO

EXEC GetAttendingDoc @SSN = 355542
GO
----------------------------------------------------------
----------------------------Get PatientContact By ID
CREATE PROCEDURE GetPatientContact @Patient_ID int
AS
BEGIN
SELECT ContactInfo
FROM Patient
WHERE SSN = @Patient_ID
END
GO
------------------------------------------
EXEC GetPatientID @Patient_ID = 355542
GO
------------------------------------------------
----------------------------Get Patient Age By ID
CREATE PROCEDURE GetPatientAge @Patient_ID int
AS
BEGIN
SELECT Age
FROM Patient
WHERE SSN = @Patient_ID
END
GO
------------------------------------------
EXEC GetPatientID @Patient_ID = 355542
GO
------------------------------------------------

----------------------------Get Patient By ID
CREATE PROCEDURE GetPatientVisit @Patient_ID int
AS
BEGIN
SELECT VisitType
FROM Patient
WHERE SSN = @Patient_ID
END
GO
------------------------------------------
EXEC GetPatientID @Patient_ID = 355542
GO
------------------------------------------------