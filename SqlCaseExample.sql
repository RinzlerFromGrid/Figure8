CREATE TABLE Products
(
    Id   INT PRIMARY KEY,
    Name TEXT
);

INSERT INTO Products
VALUES (1, 'Milk'),
       (2, 'Gnusmas Galaxy S1000'),
       (3, 'C++ for 24 hours');

CREATE TABLE Categories
(
    Id   INT PRIMARY KEY,
    Name TEXT
);

INSERT INTO Categories
VALUES (1, 'Phone'),
       (2, 'Book'),
       (3, 'Education'),
       (4, 'Clothes');

CREATE TABLE ProductsCategories
(
    ProductId  INT FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsCategories
VALUES
    (2, 1),
    (3, 3),
    (3, 2);

SELECT P.Name as ProductName, C.Name as Category
FROM Products P
         LEFT JOIN ProductsCategories PC
                   ON P.Id = PC.ProductId
         LEFT JOIN Categories C
                   ON PC.CategoryId = C.Id;