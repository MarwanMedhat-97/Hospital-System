use Hospital;
GO

----------------------------------------- Get all Pharmacy information
CREATE PROCEDURE GetPharmacy
AS
BEGIN
SELECT * FROM Pharmacy
END
GO
------------------------------------------
EXEC GetPharmacy
GO

----------------------------Get Drug By name
CREATE PROCEDURE GetDrugName @Drug_Name varchar(50)
AS
BEGIN
SELECT*
FROM Pharmacy
WHERE DrugName = @Drug_Name
END
GO
------------------------------------------
EXEC GetDrugName @Drug_Name = 'Morphine'
GO
-----------------------------------------

----------------------------Get DrugQ By name
CREATE PROCEDURE GetDrugQuantity @Drug_Name varchar(50)
AS
BEGIN
SELECT Quantity
FROM Pharmacy
WHERE DrugName = @Drug_Name
END
GO
------------------------------------------
EXEC GetDrugName @Drug_Name = 'Morphine'
GO
-----------------------------------------