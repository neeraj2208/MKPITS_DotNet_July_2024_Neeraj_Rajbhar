CREATE TABLE Customer (
    CustomerID int primary key identity(1,1),
    CustomerName varchar (100) NOT NULL,
    Email varchar (100) NOT NULL
);

CREATE TABLE Product (
    ProductID int primary key identity(1,1),
    ProductName varchar(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);

CREATE TABLE OrderItem (
    OrderItemID int primary key identity(1,1),
    OrderID int,
    ProductID int,
    Quantity int NOT NULL,
);

CREATE TABLE Orders (
    OrderID int primary key identity(1,1)),
    CustomerID int,
    OrderDate DATE NOT NULL,
);

INSERT INTO Customer (CustomerName, Email) VALUES
('John Doe', 'john@example.com'),
('Jane Smith', 'jane@example.com');

INSERT INTO Product (ProductName, Price) VALUES
('laptop', 10.00),
('Mouse', 20.00),
('Keyboard',75);
 select * from Product;

INSERT INTO Orders (CustomerID, OrderDate) VALUES
(1, '2024-01-01'),
(2, '2024-01-02');

INSERT INTO OrderItem (OrderID, ProductID, Quantity) VALUES
(1, 1, 2),  
(1, 2, 1),  
(2, 1, 3);  

SELECT 
    Customer.CustomerName,
    Orders.OrderID,
    Orders.OrderDate,
    Product.ProductName,
    OrderItem.Quantity,
    Product.Price,
    (OrderItem.Quantity * Product.Price) AS TotalPrice
FROM 
    Customer
INNER JOIN 
    Orders ON Customer.CustomerID = Orders.CustomerID
INNER JOIN 
    OrderItem ON Orders.OrderID = OrderItem.OrderID
INNER JOIN 
    Product ON OrderItem.ProductID = Product.ProductID
ORDER BY 
    Orders.OrderDate;

