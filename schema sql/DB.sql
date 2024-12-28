create database SoleiletSoie;
GO

USE SoleiletSoie;

--done
create table Users(
UserName varchar(30) not null unique,
UserID int IDENTITY (0,1) PRIMARY KEY, --first account created will be SoleiletSoie
Password VARCHAR(300) NOT NULL,
PhoneNumber BIGINT,
Address varchar(50),
Email varchar(50) not null unique,
DateCreated date not null,
UserType varchar(30) not null,
Status varchar(30) not null,
Gender varchar(30),
ProfilePicture VARBINARY(MAX)
);

--done
create table Category(
CategoryID int IDENTITY (1,1) Primary Key,
CategoryName varchar(50) not null unique,
Description varchar(100)
);

--done
create table Designs(
DesignID int IDENTITY (1,1) Primary Key,
DesignName varchar(50) unique,
ApprovalDate Date not null,
SubmissionDate Date not null,
DesignImage VARBINARY(MAX),
ApprovalStatus varchar(30) not null,
DesignCategory_ID int not null,
Designer_ID int not null DEFAULT 0,
Description VARCHAR(200),
Material_ID INT,
Collection_ID INT,
Material_Quantity INT,
foreign key (Designer_ID) references Users(UserID)
ON UPDATE CASCADE
ON DELETE SET DEFAULT,
foreign key (DesignCategory_ID) references Category(CategoryID)
ON UPDATE CASCADE
ON DELETE CASCADE
);


--done
create table Products(
ProductID int IDENTITY (1,1) Primary Key,
ProductName varchar(50) not null unique,
DateAdded date not null,
StockQuantity int not null,
Price money not null,
Description varchar(100) not null,
Status varchar(30) not null,
Collection_ID int,
Category_ID INT NOT NULL,
Design_ID int,
foreign key (Design_ID) references Designs(DesignID)
ON UPDATE NO ACTION --do the cascade manually in vs to avoid cascade
ON DELETE SET NULL,
foreign key (Category_ID) references Category(CategoryID)
ON UPDATE NO ACTION --do the cascade manually in vs to avoid cascade
ON DELETE NO ACTION --do the cascade manually in vs to avoid cascade
);


--done
create table Feedback(
FeedBackID int IDENTITY (1,1) Primary key,
Rating int not null,
FeedbackDate date not null,
Comment varchar(100),
User_FB int not null,
Product_FB int not null,
foreign key (User_FB) references Users(UserID)
ON UPDATE CASCADE
ON DELETE CASCADE,
foreign key (Product_FB) references Products(ProductID)
ON UPDATE CASCADE
ON DELETE CASCADE
);

--done
create table Orders(
OrderID int IDENTITY (1,1) Primary key,
User_ID int DEFAULT 0, --if order is made to vendor then this att is null
UserType varchar(30) not null,
OrderDate date not null,
Status varchar(30) not null,
TotalAmount money not null,
DeliveryAddress varchar(50) not null,
DeliveryDate date,
foreign key (User_ID) references Users(UserID)
ON UPDATE CASCADE
ON DELETE SET DEFAULT --we keep track of orders after user is deleted for stats --????
);

--done
create table Vendor(
VendorID int IDENTITY (1,1) Primary key,
VendorName varchar(30) not null,
DateAdded date not null,
Address varchar(50) not null,
PhoneNumber BIGINT not null,
Email varchar(30) 
);

--done
create table Materials (
MaterialID int IDENTITY (1,1) Primary key,
MaterialName varchar(30) not null unique,
DateAdded date not null,
StockQuantity int not null,
UnitCost money not null,
Status varchar(30) not null,
Vendor_ID INT NOT NULL
FOREIGN KEY (Vendor_ID) REFERENCES Vendor
ON UPDATE NO ACTION
ON DELETE NO ACTION
);

--done
create table Collection(
CollectionID int IDENTITY (1,1) Primary key,
CollectionName varchar(30) not null unique,
Season varchar(30) not null,
StartDate date not null,
EndDate date not null,
Description varchar(100)
);

--done
create table ProductOrders(
Product_ID int,
Order_ID int,
Quantity int not null,
PRIMARY KEY (Product_ID,Order_ID),
foreign key (Order_ID) references Orders(OrderID)
ON UPDATE CASCADE
ON DELETE NO ACTION,
foreign key (Product_ID) references Products(ProductID)
ON UPDATE CASCADE
ON DELETE NO ACTION
);

--done
create table ProductMaterial(
Product_ID int,
Material_ID int,
QuantityRequired int not null,
PRIMARY KEY (Product_ID,Material_ID),
FOREIGN KEY (Product_ID) references Products
ON UPDATE CASCADE
ON DELETE CASCADE,
FOREIGN KEY (Material_ID) references Materials
ON UPDATE CASCADE
ON DELETE NO ACTION
);

--done
CREATE TABLE Order_Vendor_Material(
Order_ID INT,
Vendor_ID INT,
Material_ID INT,
Quantity INT NOT NULL,
PRIMARY KEY (Order_ID, Vendor_ID, Material_ID),
FOREIGN KEY (Order_ID) REFERENCES Orders(OrderID)
ON UPDATE CASCADE
ON DELETE CASCADE,
FOREIGN KEY (Vendor_ID) REFERENCES Vendor(VendorID)
ON UPDATE CASCADE
ON DELETE CASCADE,
FOREIGN KEY (Material_ID) REFERENCES Materials(MaterialID)
ON UPDATE NO ACTION
ON DELETE NO ACTION
);

CREATE TABLE CardDetails(
User_ID INT,
CardNumber VARCHAR(300) not null unique,
CardHolder VARCHAR(50) NOT NULL,
CVV VARCHAR(300) NOT NULL,
ExpDate DATE NOT NULL,
EndsIn INT not null,
PRIMARY KEY (User_ID,CardNumber),
FOREIGN KEY (User_ID) REFERENCES Users
ON UPDATE CASCADE
ON DELETE CASCADE
);

INSERT INTO Users (UserName, Password, PhoneNumber, Address, Email, DateCreated, UserType, Status)VALUES 
('Soleil et Soie' , '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8',01234567890,'123 Baker st.','soleil.fashion@gmail.com','2024/12/23','admin','active');



--DESIGNS TABLE
Use SoleiletSoie
ALTER TABLE Designs
ADD CONSTRAINT FK_Design_Materials FOREIGN KEY (Material_ID) REFERENCES Materials(MaterialID)
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE Designs
ADD CONSTRAINT FK_Designs_Collections FOREIGN KEY (Collection_ID) REFERENCES Collection(CollectionID)
ON UPDATE no action
ON DELETE no action

--Use SoleiletSoie
--ALTER TABLE Users 
--ADD ProfilePicture VARBINARY(MAX);

--Use SoleiletSoie
--ALTER TABLE Users
--ALTER COLUMN Password VARCHAR(300);

--Use SoleiletSoie
--ALTER TABLE Feedback
--ALTER COLUMN Product_FB INT NULL;

--Use SoleiletSoie
--ALTER TABLE CardDetails
--ALTER COLUMN CVV VARCHAR(300);

--ALTER TABLE Designs
--ADD Material_ID INT;

--ALTER TABLE Designs
--ADD CONSTRAINT FK_Design_Material foreign key (Material_ID) references Materials(MaterialID)
--ON UPDATE CASCADE
--ON DELETE CASCADE;

--ALTER TABLE Designs
--ADD Collection_ID INT;

--ALTER TABLE Designs
--ADD CONSTRAINT FK_Design_Collection foreign key (Collection_ID) references Collection(CollectionID)
--ON UPDATE no action
--ON DELETE no action;



--ALTER TABLE Designs
--ADD Material_Quantity INT;
--Use SoleiletSoie
--UPDATE Users SET UserType='designer' WHERE UserName='george'; --changing main admin pass to hashed version



--TESTING SQL
--Use SoleiletSoie
--INSERT INTO Category(CategoryName) VALUES ('testcat');

--Use SoleiletSoie
--INSERT INTO Designs(DesignName,ApprovalDate,SubmissionDate,ApprovalStatus,DesignCategory_ID,Designer_ID) VALUES ('test2','2024-12-26','2024-12-26','Approved',1,16);
--INSERT INTO Designs(DesignName,ApprovalDate,SubmissionDate,ApprovalStatus,DesignCategory_ID,Designer_ID) VALUES ('test','2024-12-26','2024-12-26','Approved',1,16);

--INSERT INTO Products(ProductName,DateAdded,StockQuantity,Price,Description,Status,Category_ID,Design_ID) VALUES 
--('dress1','2024/12/26',20,500,'wow so dress','approved',1,3),
--('dress2','2024/12/26',30,1000,'wow so dress','approved',1,4);


--Use SoleiletSoie
--INSERT INTO Orders VALUES (1009,'User', '2024/12/12','Out For Delivery','3000','wtv','2024/12/14')

--Use SoleiletSoie
--UPDATE Products SET StockQuantity=20 WHERE ProductName='dress1';

--Use SoleiletSoie
--SELECT EndsIn FROM CardDetails WHERE User_ID=15;
--INSERT INTO CardDetails(User_ID,CardHolder,CardNumber,CVV,ExpDate,EndsIn) VALUES (15,'JayJay mshmsh',300,2,'2026-12-20',300);

--Use SoleiletSoie
--SELECT ProductsID,ProductName FROM Products

--Use SoleiletSoie
--INSERT INTO Category(CategoryName) VALUES
--('Clothes'),
--('Bags'),
--('Shoes'),
--('Jewelry');

--Use SoleiletSoie
--INSERT INTO Collection(CollectionName,Season,StartDate,EndDate) VALUES
--('Spring','Spring','2024/12/28','2025/3/28'),
--('Summer','Summer','2024/12/28','2025/3/28'),
--('Winter','Winter','2024/12/28','2025/3/28'),
--('Fall','Fall','2024/12/28','2025/3/28');

--pass is 1 for all
Use SoleiletSoie
INSERT INTO Users (UserName, Password, PhoneNumber, Address, Email, DateCreated, UserType, Status)VALUES 
('cust1' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust1@email','2024/12/23','user','active'),
('cust2' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust2@email','2024/12/23','user','active'),
('cust3' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust3@email','2024/12/23','user','active'),
('cust4' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust4@email','2024/12/23','user','active'),
('cust5' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust5@email','2024/12/23','user','active'),
('cust6' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust6@email','2024/12/23','user','active'),
('cust7' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust21@email','2024/12/23','user','active'),
('cust8' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust123@email','2024/12/23','user','active'),
('cust9' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust123421@email','2024/12/23','user','active'),
('cust10' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust1065@email','2024/12/23','user','active'),
('cust11' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust121241@email','2024/12/23','admin','active'),
('cust12' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust16742@email','2024/12/23','admin','active'),
('cust13' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust111153@email','2024/12/23','admin','active'),
('cust14' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust1654@email','2024/12/23','admin','active'),
('cust15' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust1235@email','2024/12/23','admin','active'),
('cust16' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust12666@email','2024/12/23','designer','active'),
('cust17' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust715@email','2024/12/23','designer','active'),
('cust18' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust8124@email','2024/12/23','designer','active'),
('cust19' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust9124@email','2024/12/23','designer','active'),
('cust20' , '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b',01234567890,'Egypt','cust21240@email','2024/12/23','designer','active');

Use SoleiletSoie
INSERT INTO Category(CategoryName) VALUES 
('Clothes'),
('Bags'),
('Shoes'),
('Jewelry');

Use SoleiletSoie
INSERT INTO Collection(CollectionName,Season,StartDate,EndDate) VALUES
('Spring','Spring','2024/12/28','2025/3/28'),
('Summer','Summer','2024/12/28','2025/3/28'),
('Winter','Winter','2024/12/28','2025/3/28'),
('Fall','Fall','2024/12/28','2025/3/28');

Use SoleiletSoie
INSERT INTO Designs(DesignName,ApprovalDate,SubmissionDate,ApprovalStatus,DesignCategory_ID,Designer_ID,Collection_ID) VALUES
('Dress1','2024/12/12','2024/12/12','approved', 2, 1053,1 ),
('Dress2','2024/12/12','2024/12/12','approved', 2, 1053, 1),
('Dress3','2024/12/12','2024/12/12','approved', 2, 1053, 1),
('Dress30','2024/12/12','2024/12/12','approved', 2, 1053, 1),
('Dress4','2024/12/12','2024/12/12','approved', 2, 1053, 1),
('Dress5','2024/12/12','2024/12/12','approved', 3, 1054, 2),
('Dress6','2024/12/12','2024/12/12','approved', 3, 1054, 2),
('Dress7','2024/12/12','2024/12/12','approved', 3, 1054, 2),
('Dress8','2024/12/12','2024/12/12','approved', 3, 1054, 2),
('Dress9','2024/12/12','2024/12/12','approved', 3, 1054, 2),
('Dress10','2024/12/12','2024/12/12','approved', 4, 1055,3 ),
('Dress11','2024/12/12','2024/12/12','pending', 4, 1055, 3),
('Dress12','2024/12/12','2024/12/12','pending', 4,1055, 3),
('Dress13','2024/12/12','2024/12/12','pending', 4, 1055, 3),
('Dress14','2024/12/12','2024/12/12','pending', 4, 1055, 3),
('Dress15','2024/12/12','2024/12/12','pending', 4, 1055, 4),
('Dress16','2024/12/12','2024/12/12','pending', 5, 1055, 4),
('Dress17','2024/12/12','2024/12/12','pending', 5, 1055, 4),
('Dress18','2024/12/12','2024/12/12','pending', 5, 1055, 4),
('Dress19','2024/12/12','2024/12/12','pending', 5, 1055, 4),
('Dress20','2024/12/12','2024/12/12','pending', 5, 1055, 4);


Use SoleiletSoie
INSERT INTO Products(ProductName,DateAdded,StockQuantity,Price,Description,Status,Category_ID,Design_ID) VALUES 
('Dress1','2024/12/12',500,20,'awesome','approved',2,1006 ),
('Dress2','2024/12/12',1000,50,'awesome','approved', 2, 1007),
('Dress3','2024/12/12',1500,50,'awesome','approved', 3, 1012),
('Dress30','2024/12/12',200,10,'awesome','approved', 3, 1013),
('Dress4','2024/12/12',100,92,'awesome','approved', 4, 1018),
('Dress5','2024/12/12',2900,100,'awesome','approved', 4,  1019),
('Dress6','2024/12/12',900,29,'awesome','approved', 5,  1023),
('Dress7','2024/12/12',1000,53,'awesome','approved', 5, 1024);