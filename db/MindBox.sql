CREATE TABLE Customers
(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Age INT, 
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Phone VARCHAR(20) NOT NULL UNIQUE,
    RegisterDate DATETIME NOT NULL
);
 
CREATE TABLE Orders
(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    CustomerId INT,
    CreatedAt Date,
    FOREIGN KEY (CustomerId) REFERENCES Customers (Id) ON DELETE CASCADE
);

UPDATE Customers
SET Age = 20,
	FirstName = 'Tom',
    LastName = 'Odinsan',
    Phone = '123456',
    RegisterDate = CURRENT_DATE();
    


Select c.* from Customers c;

Select o.* from Orders o;


