use SQLPractice
GO
CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY,
    Name VARCHAR(100),
    Specialty VARCHAR(100)
);
GO
CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    Name VARCHAR(100),
    Gender CHAR(1),
    DOB DATE
);
GO
CREATE TABLE Visits (
    VisitID INT PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    VisitDate DATE,
    Diagnosis VARCHAR(255),
    BillAmount DECIMAL(10, 2),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);
GO

-- Doctors
INSERT INTO Doctors VALUES
(1, 'Dr. Smith', 'Cardiologist'),
(2, 'Dr. Allen', 'Neurologist'),
(3, 'Dr. Lisa', 'General Physician');
GO
-- Patients
INSERT INTO Patients VALUES
(101, 'Alice', 'F', '1990-04-15'),
(102, 'Bob', 'M', '1982-11-23'),
(103, 'Charlie', 'M', '1978-05-02'),
(104, 'Diana', 'F', '2001-03-30');
GO
-- Visits
INSERT INTO Visits VALUES
(1001, 101, 1, '2023-01-10', 'High BP', 250.00),
(1002, 101, 3, '2023-03-15', 'Cold', 80.00),
(1003, 102, 2, '2023-02-05', 'Migraine', 300.00),
(1004, 103, 3, '2023-03-10', 'Checkup', 100.00),
(1005, 104, 3, '2023-04-20', 'Fever', 90.00),
(1006, 104, 1, '2023-05-25', 'Chest Pain', 275.00);
GO