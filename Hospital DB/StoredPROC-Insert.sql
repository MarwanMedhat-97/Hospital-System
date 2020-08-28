USE Hospital; -- The DB we created in Lab6
GO
CREATE PROCEDURE insertDoctor
	-- Add the parameters for the stored procedure here
	@DRID  int, 
	@Fname Varchar(50),
	@Minit varchar(2), 
	@Lname varchar(50),
	@Sdate varchar(50),
	@contactinfo int,
	@Gender Varchar(50),
	@Super_SSN int,
	@Salary int,
	@Whours int,
	@Preformance varchar(50),
	@Holidays varchar(50),
	@Position varchar(50),
	@DID int 
AS
BEGIN
INSERT INTO Doctor(DRID,Fname,Minit,Lname,Sdate,ContactInfo,Gender,Super_SSN,Salary,Whours,preformance,Holiday,position,DID)
Values (@DRID,@Fname,@Minit,@Lname,@Sdate,@contactinfo,@Gender,@Super_SSN,@Salary,@Whours,@Preformance,@Holidays,@Position,@DID)
END
GO
-----------------------------------------------------------------------------------------------
------------------------------Insert Nurse
CREATE PROCEDURE insertNurse
	-- Add the parameters for the stored procedure here
	@NID  int, 
	@Fname Varchar(50),
	@Minit varchar(2), 
	@Lname varchar(50),
	@Sdate varchar(50),
	@contactinfo int,
	@Gender Varchar(50),
	@Super_SSN INT,
	@Salary int,
	@Whours int,
	@Preformance varchar(50),
	@Holidays varchar(50),
	@Position varchar(50),
	@DID int 
AS
BEGIN
INSERT INTO Nurse(NID,Fname,Minit,Lname,Sdate,ContactInfo,Gender,Super_SSN,Salary,Whours,preformance,Holiday,Position,DID)
Values (@NID,@Fname,@Minit,@Lname,@Sdate,@contactinfo,@Gender,@Super_SSN,@Salary,@Whours,@Preformance,@Holidays,@Position,@DID)
END
GO
-----------------------------------------------------------------------------------------------
------------------------------Insert Pharmacist
CREATE PROCEDURE insertPharmacist
	-- Add the parameters for the stored procedure here
	@PID  int, 
	@Fname Varchar(50),
	@Minit varchar(2), 
	@Lname varchar(50),
	@Sdate varchar(50),
	@contactinfo int,
	@Gender Varchar(50),
	@Super_SSN INT,
	@Salary int,
	@Whours int,
	@Preformance varchar(50),
	@Holidays varchar(50)
AS
BEGIN
INSERT INTO Pharmacist(PID,Fname,Minit,Lname,Sdate,ContactInfo,Gender,Super_SSN,Salary,Whours,preformance,Holiday)
Values (@PID,@Fname,@Minit,@Lname,@Sdate,@contactinfo,@Gender,@Super_SSN,@Salary,@Whours,@Preformance,@Holidays)
END
GO
-----------------------------------------------------------------------------------------------
------------------------------Insert Recp
CREATE PROCEDURE insertRecp
	-- Add the parameters for the stored procedure here
	@RID  int, 
	@Fname Varchar(50),
	@Minit varchar(2), 
	@Lname varchar(50),
	@Sdate varchar(50),
	@contactinfo int,
	@Gender Varchar(50),
	@Super_SSN INT,
	@Salary int,
	@Whours int,
	@Preformance varchar(50),
	@Holidays varchar(50),
	@TypeC int,
	@DID int
AS
BEGIN
INSERT INTO Recipient(RID,Fname,Minit,Lname,Sdate,ContactInfo,Gender,Super_SSN,Salary,Whours,preformance,Holiday,TypeC,DID)
Values (@RID,@Fname,@Minit,@Lname,@Sdate,@contactinfo,@Gender,@Super_SSN,@Salary,@Whours,@Preformance,@Holidays,@TypeC,@DID)
END
GO
-----------------------------------------------------------------------------------------------
------------------------------Insert Clinic
CREATE PROCEDURE insertClinic
	-- Add the parameters for the stored procedure here
	@TYP  int, 
	@TypeC Varchar(50),
	@Price int,
	@Capacity int,
	@Whours int,
	@HDOCID int,
	@HNURSEID int
AS
BEGIN
INSERT INTO Clinics(TYP,TypeC,Price,Capacity,Whours,HDOCID,HNURSEID)
Values (@TYP,@TypeC,@Price,@Capacity,@Whours,@HDOCID,@HNURSEID)
END
GO
------------------------------------------------------------------------------------------------
--------------------------------INSERT DEPARTMENT
CREATE PROCEDURE insertDepartment
		
		@DID INT,
		@DLocation varchar(50),
		@Capacity int,
		@Dtype Varchar(50),
		@HDOCID INT,
		@HNURSEID INT
AS
BEGIN
INSERT INTO Department(DID,DLocation,Capacity,Dtype,HDOCID,HNURSEID)
VALUES (@DID,@DLocation,@Capacity,@Dtype,@HDOCID,@HNURSEID)
END
GO
------------------------------------------------------------------------------------------------
--------------------------------INSERT ER
CREATE PROCEDURE insertER
		
		@ERID INT,
		@ERType varchar(50),
		@EMRLEVEL int,
		@HDOCID INT,
		@HNURSEID INT
AS
BEGIN
INSERT INTO ER(ERID,ERType,EMRLEVEL,HDOCID,HNURSEID)
VALUES (@ERID,@ERType,@EMRLEVEL,@HDOCID,@HNURSEID)
END
GO
---------------------------------------------------------------------------------------------------
--------------------------------INSERT Drug
CREATE PROCEDURE insertDrug
		
		@DrugName Varchar(50),
		@Quantity INT
AS
BEGIN
INSERT INTO Pharmacy(DrugName,Quantity)
VALUES (@DrugName,@Quantity)
END
GO
-----------------------------------------------------------------------------------------------------
CREATE PROCEDURE insertWorkC
		
		@DOCID INT,
		@C_TYP INT,
		@CWHours int
AS
BEGIN
INSERT INTO Work_OnC(DOCID,C_TYP,Clinic_Hours)
VALUES (@DOCID,@C_TYP,@CWHours)
END
GO
-----------------------------------------------------------------------------------------------
------------------------------Insert Recp
CREATE PROCEDURE insertPatient
	-- Add the parameters for the stored procedure here
	@SSN  int, 
	@Fname Varchar(50),
	@Minit varchar(2), 
	@Lname varchar(50),
	@BLOODC varchar(10),
	@contactinfo int,
	@Gender Varchar(2),
	@Age int,
	@Record varchar(50),
	@VisitType varchar(50),
	@DOCID int
AS
BEGIN
INSERT INTO Patient(SSN,Fname,Minit,Lname,BloodCategory,ContactInfo,Gender,Age,Record,VisitType,DOCID)
Values (@SSN,@Fname,@Minit,@Lname,@BLOODC,@contactinfo,@Gender,@Age,@Record,@VisitType,@DOCID)
END
GO
-----------------------------------------------------------------------------------------------