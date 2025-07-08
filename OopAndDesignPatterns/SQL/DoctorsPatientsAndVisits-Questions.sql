-- 20 Healthcare SQL Interview Questions & Answers
use SQLPractice;
--1. List all patients with their most recent visit date.
SELect p.Name, MAX(v.visitdate) as LastVisit
FROM Patients p
JOIN Visits v on p.patientid = v.patientid
GROUP BY p.Name

--2. Total number of patients per doctor.
SELECT d.Name, COUNT(DISTINCT v.PatientID) AS PatientCount
FROM Doctors d 
JOIN Visits v on d.DoctorID = v.doctorid
GROUP BY d.name;

--3. List doctors who treated more than 2 patients.
SELECT d.Name 
from Visits v
JOIN Doctors d on d.DoctorID = v.DoctorID
GROUP BY d.Name
HAVING COUNT(DISTINCT v.PatientID) > 2;

--4. Find average bill amount per specialty.
SELECT d.Specialty, AVG(v.billAmount) As AVGBill
FROM Doctors d
JOIN Visits v 
ON d.DoctorID = v.DoctorID
GROUP BY d.Specialty

--5. List patient name, age, and number of visits.
SELECT p.Name, DATEDIFF(YEAR,p.DOB,GETDATE()) AS Age, 
		COUNT(v.VisitID) As VisitCount
FROM Patients p
JOIN Visits v ON p.PatientID = v.PatientID
GROUP BY p.Name, p.DOB;

--6. Find total revenue per doctor.
SELECT d.Name ,SUM(v.BillAmount) as Revenue
FROM Doctors d 
JOIN Visits v ON d.DoctorID = v.DoctorID
GROUP BY d.Name;

--7. List all diagnoses made by Dr. Smith.
SELECT v.Diagnosis FROM
Doctors d 
JOIN Visits v ON d.DoctorID = v.DoctorID
WHERE d.Name = 'Dr. Smith'

--8. Which patient has the highest number of visits?
SELECT TOP 1 p.name, COUNT(v.VisitID) AS VisitCount FROM
Patients p
JOIN Visits v ON p.patientId = v.patientid
GROUP BY p.name
ORDER BY VisitCount DESC

--9. Find doctors who never treated patient 'Bob'.
SELECT Name
FROM Doctors d
WHERE DoctorID NOT IN(
	SELECT DISTINCT DoctorId 
	FROM Visits 
	where patientId = (SELECT PatientID FROM Patients WHERE [Name] = 'Bob')
);

SELECT * FROM Patients;
SELECT * FROM Visits;
SELECT * FROM Doctors;
SELECT * FROM Patients p JOIN Visits v on p.PatientID = v.PatientID
JOIN Doctors d on d.DoctorID = v.DoctorID;

SELECT * FROM Patients p
JOIN Visits v on p.PatientID = v.PatientID