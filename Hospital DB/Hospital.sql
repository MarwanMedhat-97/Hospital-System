Create DataBase Hospital 

GO

use Hospital 

create table Users_Basic
(
username varchar(50) not null,
password varchar(50) not null,
Priv int not null, /* priviledges */
primary key (username)
)
Create Table Doctor 
(
	DRID int,
	Fname Varchar(50) Not Null,
	Minit Varchar(50) Not Null,
	Lname varchar(50) not null,
	Sdate VarChar(50) NOT NULL,
	ContactInfo int not null,
	Gender varchar(2) not null,
	Super_SSN int,
	Salary int not null,
	Whours int not null,
	preformance varchar(50),
	Holiday varchar (50),
	position Varchar(50) not null,
	--Forign Keys
	DID int,
	ERID int,
	Primary key (DRID),
	--Relations
);
Create Table Nurse
(
	NID int,
	Fname Varchar(50) Not Null,
	Minit Varchar(50) Not Null,
	Lname varchar(50) not null,
	Sdate VarChar(50) NOT NULL,
	ContactInfo int not null,
	Gender varchar(2) not null,
	Super_SSN int,
	Salary int not null,
	Whours int not null,
	preformance varchar(50),
	Holiday varchar (50),
	Position varchar(50),
	--Forign Keys
	TypeC int,
	DID int,
	ERID int,
	Primary key (NID),
	--Relations
	
);
Create Table Pharmacist 
(
	PID int,
	Fname Varchar(50) Not Null,
	Minit Varchar(50) Not Null,
	Lname varchar(50) not null,
	Sdate VarChar(50) NOT NULL,
	ContactInfo int not null,
	Gender varchar(2) not null,
	Super_SSN int,
	Salary int not null,
	Whours int not null,
	preformance varchar(50),
	Holiday varchar (50),
	Primary key (PID)
);
Create Table Recipient 
(
	RID int,
	Fname Varchar(50) Not Null,
	Minit Varchar(50) Not Null,
	Lname varchar(50) not null,
	Sdate VarChar(50) NOT NULL,
	ContactInfo int not null,
	Gender varchar(2) not null,
	Super_SSN int,
	Salary int not null,
	Whours int not null,
	preformance varchar(50),
	Holiday varchar (50),
	--Forign Keys
	TypeC int,
	DID int,
	--Relations
	Primary key (RID),
);
Create Table Clinics
(
	TYP int,
	TypeC varchar(50) not null,
	Price int not null,
	Capacity int not null,
	Whours int not null,
	HDOCID int,
	HNURSEID int,
	primary key (TYP)
);
Create Table Work_OnC
(
	DOCID INT,
	C_TYP INT,
	Clinic_Hours INT not null,
	Primary key(DOCID,C_TYP)
);
Create Table Department 
(
	DID int,
	DLocation varchar(50) not null,
	Capacity int not null,
	Dtype varchar(50) not null,
	HDOCID int,
	HNURSEID int,
	primary key (DID)
);
Create Table ER
(
	ERID int,
	ERType varchar(50) not null,
	EMRLEVEL int not null,
	HDOCID int,
	HNURSEID int 
	Primary key(ERID)
);
Create Table Patient
(
	SSN int,
	Fname Varchar(50) Not Null,
	Minit Varchar(50) Not Null,
	Lname varchar(50) not null,
	BloodCategory Varchar(5) not null,
	ContactInfo int not null,
	Gender varchar(2) not null,
	Age int not null,
	Record Varchar(50),
	VisitType varchar(50) not null,
	--Forign Keys
	DOCID int
	--Relations
);
Create Table Pharmacy
(
	DrugName varchar(50),
	Quantity int not null,
	Primary Key(DrugName)
);
-- inseting Foreign Keys Doctor
alter table Doctor add foreign key (DID) references Department ON DELETE SET NULL ON UPDATE CASCADE
alter table Doctor add foreign key (ERID) references ER ON DELETE SET NULL ON UPDATE CASCADE
alter table Doctor add foreign key (Super_SSN) references Doctor
-- inseting Foreign Keys NURSE
alter table Nurse add foreign key (TypeC) references Clinics ON DELETE SET NULL ON UPDATE CASCADE
alter table Nurse add foreign key (DID) references Department ON DELETE SET NULL ON UPDATE CASCADE
alter table Nurse add foreign key (ERID) references ER ON DELETE SET NULL ON UPDATE CASCADE
alter table Nurse add foreign key (Super_SSN) references Nurse 
-- inseting Foreign Keys Rec
alter table Recipient add foreign key (TypeC) references Clinics ON DELETE SET NULL ON UPDATE CASCADE
alter table Recipient add foreign key (DID) references Department ON DELETE SET NULL ON UPDATE CASCADE
alter table Recipient add foreign key (Super_SSN) references Doctor 
-- inserting Foreign Keys Pharmacist
alter table Pharmacist add foreign key (Super_SSN) references Doctor 
--Inserting Foreign Keys Patient
alter table Patient add Foreign Key(DOCID) references Doctor ON DELETE SET NULL ON UPDATE CASCADE
-- insetring Foreign Keys Wors_ONC
alter table Work_OnC add foreign key (DOCID) references Doctor ON DELETE cascade ON UPDATE CASCADE
alter table Work_OnC add foreign key (C_TYP) references Clinics ON DELETE Cascade ON UPDATE CASCADE
--inserting information for each table
insert into Users_Basic
values
('Motochika','1',1),
('Karolain','12',2),
('Dai','123',3),
('Phi','1234',4),
('Kai','12345',5),
('Sai','123456',6);
--------------------------------------------------------------------------------------------------------------
insert into Department
values
(1,'First level',6,'Radiology',1102,2202),
(2,'second level',7,'Psycology',1103,2203),
(3,'Second level',8,'MD',1101,2201);
--------------------------------------------------------------------------------------------------------------
insert into ER
values 
(1,'Broken Bones',4,1101,2201),
(2,'Bleeding',1,1102,2202),
(3,'Cardiac Arest',5,1103,2203);
--------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------
insert into Clinics
values
(1,'Bones',2500,10,10,1101,2201),
(2,'Arch',3500,10,6,1101,2201),
(3,'Body',4500,10,7,1101,2201);
---------------------------------------------------------------------------------------------
insert into Doctor
values
(1101,'Motochika','M.','Chosokabe','25-oct-2016',01094144355,'M',NULL,2500,6,'High','Sunday','Head',1,1),
(1102,'Saika','N.','Chibi','23-oct-2016',01094144333,'M',1101,3500,5,'High','Sunday','Department Head',2,2),
(1103,'Karolain','C.','Sai','20-oct-2016',01094144325,'F',1101,4500,7,'High','Sunday','Deaprtment Head',3,3);
--------------------------------------------------------------------------------------------------------------
insert into Nurse
values
(2201,'chika','D.','Case','25-oct-2016',01094144355,'F',Null,2500,6,'High','Sunday','Head',1,1,1),
(2202,'aika','B.','Robert','23-oct-2016',01094144333,'F',2201,3500,5,'High','Sunday','Clinics',2,2,2),
(2203,'Karo','A.','Hao','20-oct-2016',01094144325,'F',2201,4500,7,'High','Sunday','Surgary',3,3,3);
--------------------------------------------------------------------------------------------------------------
insert into Pharmacist
values
(3301,'Haid','K.','Kait','25-oct-2016',01094144352,'M',1101,2500,6,'High','Sunday'),
(3302,'Lacie','L.','Lance','23-oct-2016',01094144333,'F',1101,3500,5,'High','Sunday'),
(3303,'Suzuki','S.','Walkman','20-oct-2016',01094144325,'F',1101,4500,7,'High','Sunday');
--------------------------------------------------------------------------------------------------------------
insert into Recipient
values
(4401,'Rika','R.','Saitama','25-oct-2016',01094144355,'F',1101,2500,6,'High','Sunday',1,1),
(4402,'aya','A.','Ayakashi','23-oct-2016',01094144333,'F',1101,3500,5,'High','Sunday',2,2),
(4403,'kaname','G.','Gunmayar','20-oct-2016',01094144325,'F',1101,4500,7,'High','Sunday',3,3);
--------------------------------------------------------------------------------------------------------------
insert into Work_OnC
values
(1101,1,5),
(1103,2,6),
(1102,3,4);
--------------------------------------------------------------------------------------------------------------
insert into Patient
values
(355546,'Alpha','S.','Saian','O',01932123,'M',15,'3rd shelf','Ashtma',1102),
(355542,'Beta','L.','Lam','O',01932123,'M',17,'3rd shelf','Ashtma',1101),
(355546,'Gama','U.','Kassim','OH',01932113,'M',119,'2rd shelf','Breathing',1103);
--------------------------------------------------------------------------------------------------------------
insert into Pharmacy
values
('Morphine',5),
('Vaicedan',16),
('panadol',17);