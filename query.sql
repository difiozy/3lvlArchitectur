CREATE DATABASE Product_Ware_House
COLLATE Cyrillic_General_CI_AS
GO

CREATE TABLE Products (
	[ID_Product][int] NOT NULL IDENTITY (1, 1),
	[ProductName][varchar] (50) NOT NULL,
	[ShelfLife][DateTime],
	[DateCome][DateTime],
	[DateOut][DateTime],
	[DateUtilization][DateTime]
)
ALTER TABLE Products
ADD
PRIMARY KEY (ID_Product)
GO


CREATE PROCEDURE GetAllProducts
AS
BEGIN
	SELECT * FROM Products
END
GO

CREATE PROCEDURE AddNewProduct
@idProduct int OUTPUT,
@productName varchar(50),
@shelfLife DateTime,
@dateCome DateTime,
@dateOut DateTime,
@dateUtilization DateTime
AS
BEGIN
	IF @dateUtilization is null
		INSERT INTO Products(ProductName,DateCome,DateOut,ShelfLife) VALUES(@productName,@dateCome,@dateOut,@shelfLife)
	else INSERT INTO Products(ProductName,DateCome,DateOut,ShelfLife,DateUtilization) VALUES(@productName,@dateCome,@dateOut,@shelfLife,@dateUtilization)
	
END
GO

select * from Products

CREATE PROCEDURE UpdateProduct
@idProduct int OUTPUT,
@productName varchar(50),
@shelfLife DateTime,
@dateCome DateTime,
@dateOut DateTime,
@dateUtilization DateTime
AS
BEGIN
	UPDATE Products SET
		ProductName = @productName,
		ShelfLife = @shelfLife,
		DateCome = @dateCome,
		DateOut = @dateOut,
		DateUtilization = @dateUtilization
	WHERE ID_Product = @idProduct
END
GO

CREATE PROCEDURE DeleteProduct
@idProduct int
AS
BEGIN
	DELETE FROM Products WHERE ID_Product = @idProduct
END
GO


CREATE PROCEDURE SearchByProductName

@productName varchar(50)
AS
BEGIN
	SELECT * FROM Products WHERE ProductName = @productName
END
GO


CREATE PROCEDURE SearchByDateCome
@currentDate DateTime
AS
BEGIN
	SELECT * FROM Products WHERE DateCome = @currentDate
END
GO

CREATE PROCEDURE SearchByDateOut
@currentDate DateTime
AS
BEGIN
	SELECT * FROM Products WHERE DateOut = @currentDate
END
GO

CREATE PROCEDURE SearchByDateUtilization
@currentDate DateTime
AS
BEGIN
	SELECT * FROM Products WHERE DateUtilization = @currentDate
END
GO

CREATE PROCEDURE SearchByShelfLife
@currentDate DateTime
AS
BEGIN
	SELECT * FROM Products WHERE ShelfLife = @currentDate
END
GO
	
select*from Products