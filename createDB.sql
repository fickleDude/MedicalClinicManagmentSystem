CREATE TABLE Specializations (
ID int PRIMARY KEY IDENTITY(1,1),
Name varchar(20) UNIQUE NOT NULL
)

CREATE TABLE JournalStatuses (
ID int PRIMARY KEY IDENTITY(1,1),
Name varchar(20) NOT NULL UNIQUE
)

CREATE TABLE OrderStatuses (
ID int PRIMARY KEY IDENTITY(1,1),
Name varchar(20) NOT NULL UNIQUE
)

CREATE TABLE Services (
ID int PRIMARY KEY IDENTITY(1,1),
Name varchar(20) UNIQUE NOT NULL, Price money
)

CREATE TABLE Roles (
ID int PRIMARY KEY IDENTITY(1,1),
Name varchar(20) UNIQUE NOT NULL
)
 

CREATE TABLE Logins (
ID bigint PRIMARY KEY IDENTITY(1,1),
Email varchar(30) UNIQUE NOT NULL, Password varchar(255) UNIQUE NOT NULL, RoleID int FOREIGN KEY REFERENCES Roles
ON UPDATE CASCADE
)

CREATE TABLE Doctors (
ID bigint PRIMARY KEY IDENTITY(1,1),
LoginID bigint FOREIGN KEY REFERENCES Logins ON UPDATE CASCADE
ON DELETE CASCADE,
FIO varchar(100) NOT NULL, Description varchar(255)
)

CREATE TABLE Doctor_Specialization (
ID int PRIMARY KEY IDENTITY(1,1),
SpecializationID int FOREIGN KEY REFERENCES Specializations, DoctorID bigint FOREIGN KEY REFERENCES Doctors
)

CREATE TABLE Patients (
ID bigint PRIMARY KEY IDENTITY(1,1),
LoginID bigint FOREIGN KEY REFERENCES Logins ON UPDATE CASCADE
ON DELETE CASCADE,
FIO varchar(100) NOT NULL,
 
Gender varchar(30), DateOfBirth date
)

CREATE TABLE Doctor_Patient (
ID bigint PRIMARY KEY IDENTITY(1,1),
PatientID bigint FOREIGN KEY REFERENCES Patients, DoctorID bigint FOREIGN KEY REFERENCES Doctors, Card varchar(255),
CONSTRAINT UQ_Patient_Doctor UNIQUE (PatientID, DoctorID)
)

CREATE TABLE Appoitments (
ID bigint PRIMARY KEY IDENTITY(1,1),
Doctor_PatientID bigint FOREIGN KEY REFERENCES MedicalCards ON UPDATE NO ACTION
ON DELETE NO ACTION,
Date datetime,

)

CREATE TABLE Journal (
ID bigint PRIMARY KEY IDENTITY(1,1),
AppoitmentID bigint FOREIGN KEY REFERENCES Appoitments ON UPDATE CASCADE
ON DELETE CASCADE,
ServiceID int FOREIGN KEY REFERENCES Services, StatusID int FOREIGN KEY REFERENCES JournalStatuses
)

CREATE TABLE PatientNotes
 
(
ID bigint PRIMARY KEY IDENTITY(1,1),
AppoitmentID bigint FOREIGN KEY REFERENCES Appoitments ON DELETE CASCADE,
Note varchar(255)
)

CREATE TABLE DoctorNotes (
ID bigint PRIMARY KEY IDENTITY(1,1),
AppointmentID bigint FOREIGN KEY REFERENCES Appointments ON DELETE CASCADE,
Symptoms varchar(255), CheckUp varchar(255), Diagnosis varchar(255)
)

CREATE TABLE Prescriptions (
ID bigint PRIMARY KEY IDENTITY(1,1),
AppointmentID bigint FOREIGN KEY REFERENCES Appointments ON DELETE CASCADE,
Name varchar(30),
PharmacyProductID bigint FOREIGN KEY REFERENCES PharmacyProducts
)

CREATE TABLE Vendors (
ID int PRIMARY KEY IDENTITY(1,1),
Name varchar(30) UNIQUE, Number varchar(30) NOT NULL, Location varchar(30),
)
 
CREATE TABLE Medicines (
ID bigint PRIMARY KEY IDENTITY(1,1),
Name varchar(30) NOT NULL, Company varchar(30)
)

CREATE TABLE PharmacyProducts (
ID bigint PRIMARY KEY IDENTITY(1,1),
MedicineID bigint FOREIGN KEY REFERENCES Medicines, VendorID int FOREIGN KEY REFERENCES Vendors,
Price Money NOT NULL,
Amount int CHECK(Amount >= 0)
)

CREATE TABLE Orders (
ID bigint PRIMARY KEY IDENTITY(1,1),
StatusID int FOREIGN KEY REFERENCES OrderStatuses, PatientID bigint FOREIGN KEY REFERENCES Patients, Total float,
Data datetime
)

CREATE TABLE OrderItems (
ID bigint PRIMARY KEY IDENTITY(1,1),
PharmacyProductID bigint FOREIGN KEY REFERENCES PharmacyProducts, OrderID bigint FOREIGN KEY REFERENCES Orders,
Quantity int CHECK(Quantity > 0),
)
