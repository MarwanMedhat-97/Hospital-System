use Hospital;
GO
-----use this procedures as a refernce for the rest tasks(nurse-recp-pharmacist)
-----when you finish making the new get query make the file name as Get-----Details(like this file)
-----cut and paste the Get all, get by ID, get by name from the original file(StoredProc-Get) because i already made on there
-----send the codes maximum by tomorrow 
-----------------------------------------------------
-----also send me the Electronic-1 Project DX
-----------------------------------------------------
-----one last thing i may need a help in C# so anyone can help please do so we can finish faster
------------------------------------------- Get all Docotors
CREATE PROCEDURE GetDoctors
AS
BEGIN
SELECT * FROM Doctor
END
GO
------------------------------------------ 
EXEC GetDoctors
GO
------------------------------------------
----------------------------Get Doctor By ID
CREATE PROCEDURE GetDoctorID @Doctor_ID int
AS
BEGIN
SELECT*
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorID @Doctor_ID = 1102
GO
----------------------------------------------
-----------------------------------------
----------------------------Get Doctor By name
CREATE PROCEDURE GetDoctorName @Doctor_Name varchar(50)
AS
BEGIN
SELECT*
FROM Doctor
WHERE Fname = @Doctor_Name
END
GO
------------------------------------------
EXEC GetDoctorName @Doctor_Name = 'Motochika'
GO
-----------------------------------------
----------------------------Get Doctor Contact By ID
CREATE PROCEDURE GetDoctorContact @Doctor_ID int
AS
BEGIN
SELECT ContactInfo
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorContact @Doctor_ID = 1101
GO
----------------------------------------------
----------------------------Get Doctor Salary By ID
CREATE PROCEDURE GetDoctorSalary @Doctor_ID int
AS
BEGIN
SELECT Salary
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorSalary @Doctor_ID = 1101
GO
----------------------------------------------
----------------------------Get Doctor working hours By ID
CREATE PROCEDURE GetDoctorWhours @Doctor_ID int
AS
BEGIN
SELECT Whours
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorWhours @Doctor_ID = 1101
GO
----------------------------------------------
----------------------------Get Doctor Preformance By ID
CREATE PROCEDURE GetDoctorPreformance @Doctor_ID int
AS
BEGIN
SELECT preformance
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorPreformance @Doctor_ID = 1101--EXEC is used just for testing the Codes
GO
----------------------------------------------
----------------------------Get Doctor Holiday By ID
CREATE PROCEDURE GetDoctorHoliday @Doctor_ID int
AS
BEGIN
SELECT Holiday
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorHoliday @Doctor_ID = 1101
GO
----------------------------------------------
----------------------------Get Doctor Position By ID
CREATE PROCEDURE GetDoctorPosition @Doctor_ID int
AS
BEGIN
SELECT position
FROM Doctor
WHERE DRID = @Doctor_ID
END
GO
------------------------------------------
EXEC GetDoctorPosition @Doctor_ID = 1101
GO
----------------------------------------------
--Note:there is no need to get the super_SSN or DID or ERID since we are using combo box is C#