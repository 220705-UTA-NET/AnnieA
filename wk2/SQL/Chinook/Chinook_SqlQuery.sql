SELECT * FROM Customer;
SELECT * FROM Employee;
SELECT * FROM Invoice;
SELECT * FROM InvoiceLine;

-- 1
SELECT * FROM Customer WHERE Country != 'USA';

-- 2
SELECT * FROM Customer WHERE Country = 'Brazil';

--3

SELECT * FROM Employee WHERE Title = 'Sales Support Agent';

--4
SELECT DISTINCT BillingCountry FROM Invoice;


--5
SELECT COUNT(InvoiceId) 
FROM Invoice 
WHERE InvoiceDate LIKE '%2009%';


SELECT SUM(Total) 
FROM Invoice 
WHERE InvoiceDate LIKE '%2009%';

--6


--7
SELECT COUNT(InvoiceId) as Sales, BillingCountry 
FROM Invoice 
GROUP BY BillingCountry 
Order By Sales DESC;

--8
SELECT SUM(Total) as Sales, BillingCountry 
FROM Invoice 
GROUP BY BillingCountry 
Order By Sales DESC;



-- JOIN 
-- 9
SELECT C.CustomerId, I.InvoiceId, C.Country 
FROM Customer AS C 
JOIN Invoice AS I ON C.CustomerId = I.CustomerId 
WHERE C.Country='Brazil';

--10

SELECT C.CustomerId, I.InvoiceId, E.EmployeeId, E.LastName, E.FirstName, E.Title
FROM Customer AS C 
JOIN Invoice AS I ON I.CustomerId = C.CustomerId 
JOIN Employee AS E ON E.EmployeeId = C.SupportRepId 
WHERE E.Title LIKE '%Agent%';

--11

SELECT * FROM Album;
SELECT * FROM Artist;
SELECT * FROM Genre;
SELECT * FROM Mediatype;
SELECT * FROM Playlist;
SELECT * FROM PlaylistTrack;

SELECT COUNT(PT.TrackId), PT.PlaylistId 
FROM Playlist AS P 
JOIN PlaylistTrack AS PT ON P.PlaylistId = PT.PlaylistId
GROUP BY PT.PlaylistId;

--12
SELECT  C.CustomerId, I.InvoiceId, SUM(I.Total), E.LastName, E.FirstName, E.Title, E.EmployeeId
FROM Customer AS C 
JOIN Invoice AS I ON I.CustomerId = C.CustomerId 
JOIN Employee AS E ON E.EmployeeId = C.SupportRepId 
WHERE E.Title LIKE '%Agent%'
GROUP BY E.EmployeeID;


SELECT CustomerId, SUM(Total)
FROM Invoice
GROUP BY CustomerId; -- Group By gives us a way to group the results of an agg. function by entries


SELECT CustomerId, SUM(Total) AS Sum_Total
FROM Invoice
WHERE BillingCountry != 'USA'
GROUP BY CustomerId
HAVING SUM(Total) > 40
ORDER BY Sum_Total DESC, CustomerId; 