USE Hospital; -- The DB we created in Lab6
GO


------------------------------------------- Get all Nurse
CREATE PROCEDURE GetNurses
AS
BEGIN
SELECT * FROM Nurse
END
GO
------------------------------------------
EXEC GetNurses
GO
---------------------------------------- 
---------------------------------------- Get all Recp
CREATE PROCEDURE GetRecp
AS
BEGIN
SELECT * FROM Recipient
END
GO
------------------------------------------
EXEC GetRecp
GO
-----------------------------------------
----------------------------------------- Get all Pharmacist
CREATE PROCEDURE GetPharmacist
AS
BEGIN
SELECT * FROM Pharmacist
END
GO
------------------------------------------
EXEC GetPharmacist
GO
-----------------------------------------
----------------------------------------- Get all Departments
CREATE PROCEDURE GetDepartment
AS
BEGIN
SELECT * FROM Department
END
GO
------------------------------------------
EXEC GetDepartment
GO
-----------------------------------------
-----------------------------------------
----------------------------------------- Get all ER
CREATE PROCEDURE GetER
AS
BEGIN
SELECT * FROM ER
END
GO
------------------------------------------
EXEC GetER
GO


---------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------- Get Anything By ID

----------------------------Get Nurse By ID
CREATE PROCEDURE GetNurseID @Nurse_ID int
AS
BEGIN
SELECT*
FROM Nurse
WHERE NID = @Nurse_ID
END
GO
------------------------------------------
EXEC GetNurseID @Nurse_ID = 2202
GO
----------------------------------------------
----------------------------Get Pharmacist By ID
CREATE PROCEDURE GetPharmacistID @Pharmacist_ID int
AS
BEGIN
SELECT*
FROM Pharmacist
WHERE PID = @Pharmacist_ID
END
GO
------------------------------------------
EXEC GetPharmacistID @Pharmacist_ID = 3303
GO
----------------------------------------------
----------------------------Get Recp By ID
CREATE PROCEDURE GetRecpID @Recp_ID int
AS
BEGIN
SELECT*
FROM Recipient
WHERE RID = @Recp_ID
END
GO
------------------------------------------
EXEC GetRecpID @Recp_ID = 4401
GO
----------------------------------------------
----------------------------Get Department By ID
CREATE PROCEDURE GetDeparmentID @Department_ID int
AS
BEGIN
SELECT*
FROM Department
WHERE DID = @Department_ID
END
GO
------------------------------------------
EXEC GetDeparmentID @Department_ID = 1
GO
----------------------------------------------

----------------------------------------------
----------------------------Get ER By ID
CREATE PROCEDURE GetERID @ER_ID int
AS
BEGIN
SELECT*
FROM ER
WHERE ERID = @ER_ID
END
GO
------------------------------------------
EXEC GetERID @ER_ID = 3
GO
----------------------------------------------

-------------------------------------------------------------------------Get Anything By name 

----------------------------Get Nurse By name
CREATE PROCEDURE GetNurseName @Nurse_Name varchar(50)
AS
BEGIN
SELECT*
FROM Nurse
WHERE Fname = @Nurse_Name
END
GO
------------------------------------------
EXEC GetNurseName @Nurse_Name = 'chika'
GO
-----------------------------------------
----------------------------Get Pharmacist By name
CREATE PROCEDURE GetPharmacistName @Pharmacist_Name varchar(50)
AS
BEGIN
SELECT*
FROM Pharmacist
WHERE Fname = @Pharmacist_Name
END
GO
------------------------------------------
EXEC GetPharmacistName @Pharmacist_Name = 'Suzuki'
GO
-----------------------------------------
----------------------------Get Recp By name
CREATE PROCEDURE GetRecpName @Recp_Name varchar(50)
AS
BEGIN
SELECT*
FROM Recipient
WHERE Fname = @Recp_Name
END
GO
------------------------------------------
EXEC GetRecpName @Recp_Name = 'aya'
GO
-----------------------------------------
----------------------------Get Department By name
CREATE PROCEDURE GetDepartmentName @Department_Name varchar(50)
AS
BEGIN
SELECT*
FROM Department
WHERE Dtype = @Department_Name
END
GO
------------------------------------------
EXEC GetDepartmentName @Department_Name = 'Radiology'
GO
-----------------------------------------
----------------------------Get Clinic By name
CREATE PROCEDURE GetClinicName @Clinic_Name varchar(50)
AS
BEGIN
SELECT*
FROM Clinics
WHERE TypeC = @Clinic_Name
END
GO
------------------------------------------
EXEC GetClinicName @Clinic_Name = 'Arch'
GO
-----------------------------------------
----------------------------Get ER By name
CREATE PROCEDURE GetERName @ER_Name varchar(50)
AS
BEGIN
SELECT*
FROM ER
WHERE ERType = @ER_Name
END
GO
------------------------------------------
EXEC GetERName @ER_Name = 'Broken Bones'
GO
-----------------------------------------


--------------------other getting condition Function
--------------------Get HDocotor Department
CREATE PROCEDURE GetHDoctorDep @HDoctor_Name varchar(50)
AS
BEGIN
SELECT Fname,Minit,Lname,Dtype,DLocation,Dep.Capacity
FROM Doctor as D,Department as Dep 
WHERE D.DRID=Dep.HDOCID AND D.Fname=@HDoctor_Name
END
GO
------------------------------------------
EXEC GetHDoctorDep @HDoctor_Name = 'Motochika'
GO
-------------------------------------------------------------
--------------------Get HNurse Department
CREATE PROCEDURE GetHNurseDep @HNurse_Name varchar(50)
AS
BEGIN
SELECT Fname,Minit,Lname,Dtype,DLocation,Dep.Capacity
FROM Nurse as N,Department as Dep 
WHERE N.NID=Dep.HNURSEID AND N.Fname=@HNurse_Name
END
GO
------------------------------------------
EXEC GetHNurseDep @HNurse_Name = 'chika'
GO
----------------------------------------------------------

----------------------Get DepHDoc doctor
CREATE PROCEDURE GetDepHDoc @DepartmentID int
AS
BEGIN
SELECT	*	FROM DoctorWHERE DRID IN  (SELECT  HDOCID	FROM Department	WHERE	DID=@DepartmentID ) 
END
GO

EXEC GetDepHDoc @DepartmentID = 1
GO
----------------------------------------------------------
----------------------Get DepHNurse Nurse
CREATE PROCEDURE GetDepHNurse @DepartmentID int
AS
BEGIN
SELECT	*	FROM NurseWHERE NID IN  (SELECT  HNURSEID	FROM Department	WHERE	DID=@DepartmentID ) 
END
GO

EXEC GetDepHNurse @DepartmentID = 1
GO
----------------------------------------------------------
----------------------Get DepEmployees
CREATE PROCEDURE GetDepEmployees @DepartmentID int
AS
BEGIN
SELECT	*	
FROM Doctor as D,Nurse as N
WHERE N.DID = @DepartmentID AND D.DID = @DepartmentID
END
GO

EXEC GetDepEmployees @DepartmentID = 1
GO
--------------------------------------------------------------------------------
--------------------------------------------------get all employees working in a department ( MARWAN )
CREATE PROCEDURE Getnumber_of_Doctors @DepartmentID int
AS
BEGIN
SELECT *
FROM Doctor as D 
WHERE  D.DID = @DepartmentID 
END
GO
EXEC Getnumber_of_Employees @DepartmentID=1
GO
--------------------------------------------------------------------------------------
-------------------------------------------------------------------
CREATE PROCEDURE Getnumber_of_Nurses @DepartmentID int
AS
BEGIN
SELECT *
FROM Nurse as N
WHERE  N.DID = @DepartmentID 
END
GO
EXEC Getnumber_of_Nurses @DepartmentID=1
GO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------
CREATE PROCEDURE Getnumber_of_Recp @DepartmentID int
AS
BEGIN
SELECT *
FROM Recipient as R
WHERE  R.DID = @DepartmentID
END
GO
EXEC Getnumber_of_Recp @DepartmentID=1
GO
-----------------------------------------------------------------------------------------------
---------------------------------------------------------------------------
CREATE PROCEDURE Get_Nurses_clinic @typ int
AS
BEGIN
SELECT *
FROM Nurse as N
WHERE  N.TypeC=@typ
END
GO
EXEC Get_Nurses_clinic @typ=1
GO
--------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------
CREATE PROCEDURE Get_Recp_clinic @typ int
AS
BEGIN
SELECT *
FROM Recipient as R
WHERE  R.TypeC=@typ
END
GO
EXEC Get_Recp_clinic @typ=1
GO
-------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE Get_Doctors_clinic @typ int
AS
BEGIN
SELECT DOCID
FROM Work_OnC
WHERE  C_TYP=@typ
END
GO
EXEC Get_Doctors_clinic @typ=1
GO
----------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
CREATE PROCEDURE Get_Nurses_ER @ERID int
AS
BEGIN
SELECT *
FROM Nurse as N
WHERE  N.ERID=@ERID
END
GO
EXEC Get_Nurses_ER @ERID=1
GO
----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE Get_Doctors_ER @ERID int
AS
BEGIN
SELECT *
FROM Doctor as D 
WHERE  D.ERID=@ERID
END
GO
EXEC Get_Doctors_ER @ERID=1
GO
----------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------
 CREATE PROCEDURE Get_MAX_Salary_doctor
AS
BEGIN
SELECT DRID,Salary 
FROM Doctor
WHERE Salary = (SELECT Max(Salary) FROM Doctor)
END
GO
EXEC Get_MAX_Salary_doctor
GO
----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
 CREATE PROCEDURE Get_MAX_Salary_doctor_in_department @DepartmentID int
AS
BEGIN
SELECT DRID,Salary 
FROM Doctor AS D
WHERE Salary = (SELECT Max(Salary) FROM Doctor)
AND D.DID = @DepartmentID 
END
GO

EXEC Get_MAX_Salary_doctor_in_department @DepartmentID=1
GO
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
 CREATE PROCEDURE Get_MAX_Salary_doctor_in_ER @ERID int
AS
BEGIN
SELECT DRID,Salary 
FROM Doctor AS D
WHERE Salary = (SELECT Max(Salary) FROM Doctor)
AND D.ERID = @ERID 
END
GO

EXEC Get_MAX_Salary_doctor_in_ER @ERID=1
GO
--------------------------------------------------------------------------------------
----------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_SALARY_Doctors_clinic @typ int
AS
BEGIN
SELECT DRID,Salary
FROM Doctor AS D
WHERE  DRID=(select DOCID   from Work_OnC   where C_TYP=@typ)
AND Salary = (SELECT Max(Salary) FROM Doctor)
END
GO
EXEC Get_MAX_SALARY_Doctors_clinic @typ=1
GO
----------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_Nurse
AS
BEGIN
SELECT NID,Salary 
FROM Nurse
WHERE Salary = (SELECT Max(Salary) FROM Nurse)
END
GO
EXEC Get_MAX_Salary_Nurse
GO
------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_nurse_in_department @DepartmentID int
AS
BEGIN
SELECT NID,Salary 
FROM Nurse AS N
WHERE Salary = (SELECT Max(Salary) FROM Nurse)
AND N.DID = @DepartmentID 
END
GO

EXEC Get_MAX_Salary_nurse_in_department @DepartmentID=1
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_nurse_in_ER @ERID int
AS
BEGIN
SELECT NID,Salary 
FROM Nurse AS N
WHERE Salary = (SELECT Max(Salary) FROM Nurse)
AND N.ERID = @ERID 
END
GO

EXEC Get_MAX_Salary_nurse_in_ER @ERID=1
GO
----------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_nurse_in_Clinic @typ int
AS
BEGIN
SELECT NID,Salary 
FROM Nurse AS N
WHERE Salary = (SELECT Max(Salary) FROM Nurse)
AND N.TypeC = @typ 
END
GO

EXEC Get_MAX_Salary_nurse_in_Clinic @typ=1
GO
---------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_Recp
AS
BEGIN
SELECT RID,Salary 
FROM Recipient
WHERE Salary = (SELECT Max(Salary) FROM Recipient)
END
GO
EXEC Get_MAX_Salary_Recp
GO
---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_Recp_in_department @DepartmentID int
AS
BEGIN
SELECT RID,Salary 
FROM Recipient AS R
WHERE Salary = (SELECT Max(Salary) FROM Recipient)
AND R.DID = @DepartmentID 
END
GO

EXEC Get_MAX_Salary_Recp_in_department @DepartmentID=1
GO
-------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_Recp_in_Clinic @typ int
AS
BEGIN
SELECT RID,Salary 
FROM Recipient AS R
WHERE Salary = (SELECT Max(Salary) FROM Recipient)
AND R.TypeC = @typ 
END
GO

EXEC Get_MAX_Salary_Recp_in_Clinic @typ=1
GO
----------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Salary_Phar
AS
BEGIN
SELECT PID,Salary 
FROM Pharmacist
WHERE Salary = (SELECT Max(Salary) FROM Pharmacist)
END
GO
EXEC Get_MAX_Salary_Phar
GO
---------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------
CREATE PROCEDURE Get_MAX_Price_clinic
AS
BEGIN
SELECT Price 
FROM Clinics
WHERE Price = (SELECT Max(Price) FROM Clinics)
END
GO
EXEC Get_MAX_Price_clinic
GO
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------