--Вывести общее количество приемов у каждого из врачей.--
SELECT Doctors.FIO, tmp.NumberOfAppointments FROM Doctors JOIN (
SELECT DoctorID AS ID, COUNT(Appointments.ID) AS NumberOfAppointments FROM Appointments 
	JOIN Doctor_Patient ON Doctor_Patient.ID = Appointments.Doctor_PatientID
GROUP BY DoctorID) AS tmp ON tmp.ID = Doctors.ID

--Вывести название и цену препаратов, которые были куплены в аптеке по назначению врача.--
SELECT Medicines.Name, PharmacyProducts.Price FROM Medicines
JOIN PharmacyProducts ON Medicines.ID = PharmacyProducts.MedicineID WHERE PharmacyProducts.ID in(
SELECT PharmacyProductID FROM OrderItems INTERSECT
SELECT PharmacyProductID FROM Prescriptions)

--Вывести три самые популярные услуги.--
SELECT TOP 3 Services.Name, COUNT(ServiceID) as Frequency FROM Journal
JOIN Services ON Journal.ServiceID = Services.ID WHERE StatusID = 3
GROUP BY Services.Name ORDER BY Frequency

--Вывести количество дней между двумя последними визитами пациента к врачу.--
SELECT Doctor_patient, MIN(Period) AS DaysBetweenLastAppiontments FROM(
SELECT A.Doctor_PatientID AS Doctor_patient, DATEDIFF(DAY, A.Date, B.Date) 
	as Period FROM Appointments A JOIN Appointments B ON A.Doctor_PatientID = B.Doctor_PatientID
WHERE DATEDIFF(DAY, A.Date, B.Date) > 0) AS tmp
GROUP BY Doctor_patient

--Вывести месяц/месяца с наибольшей прибылью.--
SELECT TOP 1 WITH TIES SUM(Services.Price) AS TotalPrice FROM Journal 
JOIN Services ON Journal.ServiceID = Services.ID
JOIN Appointments ON Journal.AppoitmentID = Appointments.ID GROUP BY MONTH(Date)
ORDER BY TotalPrice DESC

--Вывести имена пациентов, которые уже делали заказы в аптеке на сумму больше 500 рублей--
SELECT Patients.FIO FROM Patients WHERE EXISTS(
SELECT * FROM Orders
WHERE Orders.Total > 500 AND Orders.PatientID = Patients.ID)

--Вывести названия препаратов, которые ни разу не назначали врачами.--
SELECT Medicines.Name FROM Medicines
JOIN PharmacyProducts ON Medicines.ID = PharmacyProducts.ID WHERE PharmacyProducts.ID IN(
SELECT ID FROM PharmacyProducts EXCEPT
SELECT Prescriptions.PharmacyProductID FROM Prescriptions)

--Вывести в подядке убывания разницу в цене одного и того же лекарства, полученного различными поставщиками.--
SELECT DISTINCT Medicines.Name, ABS(A.Price - B.Price) AS PriceDifference FROM 
PharmacyProducts A JOIN PharmacyProducts B ON A.MedicineID = B.MedicineID AND A.ID != B.ID
JOIN Medicines ON A.MedicineID = Medicines.ID ORDER BY PriceDifference DESC

--Вывести месяца, где количество отмен приемов больше среднего за месяц.--
WITH tmp AS(
SELECT COUNT(Journal.ID) AS AmountOfCanceled, MONTH(Appointments.Date) AS Month 
	FROM Journal JOIN Appointments ON Appointments.ID = Journal.AppoitmentID
WHERE Journal.StatusID = 2
GROUP BY MONTH(Appointments.Date)) SELECT tmp.Month, tmp.AmountOfCanceled FROM tmp
WHERE AmountOfCanceled > (SELECT AVG(tmp.AmountOfCanceled) FROM tmp)

--Вывести месяца, в которые не было ни одной отмены приема.--
SELECT DISTINCT MONTH(Date) AS Month FROM Appointments EXCEPT
(SELECT DISTINCT MONTH(Date) AS Month FROM Appointments JOIN (
SELECT Journal.AppoitmentID AS id FROM Journal
EXCEPT
SELECT Journal.AppoitmentID AS id FROM Journal
WHERE StatusID != 2) AS tmp ON Appointments.ID = tmp.id)

--Вывести специализации, по которым работают больше одного врача и специализации, по которым не работает ни один врач.--
SELECT Specializations.Name FROM Specializations
JOIN Doctor_Specialization ON Specializations.ID = Doctor_Specialization.SpecializationID 
GROUP BY Specializations.Name
HAVING COUNT(Doctor_Specialization.ID) > 1 UNION
SELECT Specializations.Name FROM Doctor_Specialization
RIGHT JOIN Specializations ON Doctor_Specialization.SpecializationID = Specializations.ID 
WHERE Doctor_Specialization.ID IS NULL



