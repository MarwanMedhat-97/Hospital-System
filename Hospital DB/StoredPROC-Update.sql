USE Hospital;
GO

create Procedure UpdateDrug @DQuantity int,@DName varchar(50)
AS
BEGIN
Update Pharmacy
Set Quantity=@DQuantity
where DrugName=@DName
END
GO

EXEC UpdateDrug @DQuantity = 1102,
@DName = Panadol
GO
---------------------------------------------------------------------------------------------
--------------------------------Update A Patient
create Procedure UpdatePatient @Contact int,@Age int,@Visit varchar(50),@DOCID int,@SSN int
AS
BEGIN
Update Patient
Set ContactInfo=@Contact,
Age=@Age,
VisitType=@Visit,
DOCID=@DOCID
where SSN=@SSN
END
GO

EXEC UpdatePatient @SSN = 355546,@Contact=1231231,@Age=14,@Visit='3RD VISIT',@DOCID=1101
GO
---------------------------------------------------------------------------------------------
--------------------------------Update A Patient
create Procedure UpdateDepartment @HDOCID int,@HNURSEID int, @Capacity int, @DEPID int
AS
BEGIN
Update Department
Set Capacity=@Capacity,
HDOCID=@HDOCID,
HNURSEID=@HNURSEID
where DID=@DEPID
END
GO

EXEC UpdateDepartment @DEPID = 1,@Capacity=120,@HDOCID=1103,@HNURSEID=2201
GO
---------------------------------------------------------------------------------------------
--------------------------------Update A Clinic
create Procedure UpdateClinic @TYP int,@Price int, @Capacity int, @WHours int,@HDOCID int,@HNURSEID int
AS
BEGIN
Update Clinics
Set Capacity=@Capacity,
Price=@Price,
HNURSEID=@HNURSEID,
HDOCID=@HDOCID,
Whours=@WHours
where TYP=@TYP
END
GO

EXEC UpdateClinic @TYP = 1,@Capacity=120,@HDOCID=1103,@HNURSEID=2201,@WHours=7,@Price=6000
GO
----------------------------------------------------------------------------------
----------read this function and apply it for the rest of the employees
----------Note:there is no need to get the super_SSN or DID or ERID since we are using combo box is C#
create Procedure UpdateDoctor @DRID int,@Contact int, @Salary int,@Whours int,@Preformance varchar(50),
@Holiday varchar(50),@Position varchar(50), @Super_SSN int, @DID int, @ERID int
AS
BEGIN
Update Doctor
Set ContactInfo=@Contact,
Salary=@Salary,
Whours=@Whours,
preformance=@Preformance,
Holiday=@Holiday,
position=@Position,
Super_SSN=@Super_SSN,
DID=@DID,
ERID=@ERID
where DRID=@DRID
END
GO

EXEC UpdateDoctor @Contact = 355546,@Salary=1231231,@Whours=14,@Preformance='3RD VISIT',@DRID=1103,@Holiday='Sun',
@Position='head',@Super_SSN=1101,@DID=2,@ERID=1
GO
------------------------------------------------------------------------------------------
----------------------------------------update Recp ( MARWAN )
create Procedure UpdateRECP @RID int,@Contact int,@gender varchar(2),@Super_SSN int,@Salary int,@Whours int,
@preformance varchar(50),@Holiday varchar (50),@TypeC int,@DID int
AS
BEGIN
Update Recipient
set ContactInfo=@Contact,
Gender=@gender,
Super_SSN=@Super_SSN,	
Salary=@Salary,
Whours=@Whours,
preformance=@Preformance,
Holiday=@Holiday,
TypeC=@TypeC,
DID=@DID
where RID=@RID	
END 
GO

EXEC UpdateRECP  @Contact = 355546,@gender='M',@Salary=1231231,@Whours=14,@Preformance='HIGH',@Holiday='Sun',@Super_SSN=1101,@DID=2,
@TypeC=2,@RID=4403
GO 
------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------
create Procedure UpdatePharmacist @pid int,@Contact int,@gender varchar(2),@Super_SSN int,@Salary int,@Whours int,
@preformance varchar(50),@Holiday varchar (50)
AS
BEGIN
Update Pharmacist 
set ContactInfo=@Contact,
Gender=@gender,
Super_SSN=@Super_SSN,	
Salary=@Salary,
Whours=@Whours,
preformance=@Preformance,
Holiday=@Holiday
where PID=@pid
END
GO
EXEC UpdatePharmacist  @Contact = 355546,@gender='M',@Salary=1231231,@Whours=14,@Preformance='LOW',@Holiday='FRI',@Super_SSN=1101,@DID=2,
@TypeC=2,@pid=3302
GO 








