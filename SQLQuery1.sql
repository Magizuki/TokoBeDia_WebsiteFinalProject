CREATE TABLE [ProductTypes] (
	ProductTypeID INT PRIMARY KEY  NOT NULL IDENTITY(1,1),
	ProductTypeName VARCHAR(255) NOT NULL,
	ProductTypeDescription VARCHAR (255) NOT NULL
)
GO
CREATE TABLE PaymentType (
	PaymentTypeID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	PaymentTypeName VARCHAR(255) NOT NULL
)
GO
CREATE TABLE Roles (
	RoleID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	RoleName VARCHAR(255) NOT NULL
)
GO
CREATE TABLE Products (
	ProductID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ProductTypeID INT NOT NULL,
	ProductName VARCHAR(255) NOT NULL,
	ProductPrice INT,
	ProductStock INT
	FOREIGN KEY (ProductTypeID) REFERENCES [ProductTypes] (ProductTypeID) 
)
GO
CREATE TABLE Users (
	UserID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	RoleID  INT  NOT NULL,
	UserName VARCHAR(255) NOT NULL,
	UserEmail VARCHAR(255),
	UserPassword VARCHAR(255) NOT NULL,
	UserGender VARCHAR(255),
	UserStatus VARCHAR(255) NOT NULL, 
	FOREIGN KEY (RoleID) REFERENCES Roles (RoleID) 
)
GO
CREATE TABLE Carts (
	UserID INT NOT NULL,
	ProductID INT NOT NULL,
	Quantity INT ,
	FOREIGN KEY (UserID) REFERENCES Users (UserID),
	FOREIGN KEY (ProductID) REFERENCES Products (ProductID), 
	PRIMARY KEY (UserID,ProductID)
)
GO
CREATE TABLE HeaderTransactions (
	HeaderTransactionID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	UserID INT NOT NULL,
	PaymentTypeID INT NOT NULL,
	[Date] Date NOT NULL,
	FOREIGN KEY (UserID) REFERENCES Users (UserID),
	FOREIGN KEY (PaymentTypeID) REFERENCES PaymentType (PaymentTypeID) 
)
GO
CREATE TABLE DetailTransactions (
	HeaderTransactionID INT NOT NULL,
	ProductID INT NOT NULL,
	FOREIGN KEY (HeaderTransactionID) REFERENCES HeaderTransactions (HeaderTransactionID),
	FOREIGN KEY (ProductID) REFERENCES Products (ProductID), 
	PRIMARY KEY (HeaderTransactionID,ProductID)
)
GO
ALTER TABLE DetailTransactions
ADD Quantity INT NOT NULL;



