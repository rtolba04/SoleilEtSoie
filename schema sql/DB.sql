create database SoleiletSoie;
GO

USE SoleiletSoie;

--done
create table Users(
UserName varchar(30) not null unique,
UserID int IDENTITY (0,1) PRIMARY KEY, --first account created will be SoleiletSoie
Password VARCHAR(50) NOT NULL,
PhoneNumber BIGINT,
Address varchar(50),
Email varchar(50) not null unique,
DateCreated date not null,
UserType varchar(30) not null,
Status varchar(30) not null,
Gender varchar(30)
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
Status varchar(30) not null
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
ON UPDATE CASCADE
ON DELETE NO ACTION
);

ALTER TABLE Products
ADD CONSTRAINT FK_Products_Collection foreign key (Collection_ID) references Collection(CollectionID)
ON UPDATE CASCADE
ON DELETE SET NULL;

INSERT INTO Users (UserName, Password, PhoneNumber, Address, Email, DateCreated, UserType, Status)VALUES 
('Soleil et Soie' , 'password',01234567890,'123 Baker st.','soleil.fashion@gmail.com','2024/12/23','admin','active');
