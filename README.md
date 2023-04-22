# MindboxTestLibrary

SQLTask

CREATE TABLE Products (
	ID INT PRIMARY KEY not null,
	Name TEXT not null);

CREATE TABLE Categories (
	ID INT PRIMARY KEY not null,
	Name TEXT not null
);

CREATE TABLE Intersections (
	ProductID INT not null,
	CategoryID INT not null
);

SELECT P.Name, C.Name
  FROM Products P
LEFT JOIN Intersections I
  ON P.ID = I.ProductID
LEFT JOIN Categories C
	ON I.CategoryID = C.ID;
