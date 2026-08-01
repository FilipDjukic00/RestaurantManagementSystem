-- =============================================
-- Restaurant Management System
-- Database Schema
-- =============================================

-- Ako baza već postoji, obriši je
IF DB_ID('RestaurantManagementDB') IS NOT NULL
BEGIN
    ALTER DATABASE RestaurantManagementDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE RestaurantManagementDB;
END
GO

-- Kreiranje baze
CREATE DATABASE RestaurantManagementDB;
GO

USE RestaurantManagementDB;
GO

-- =============================================
-- Foods
-- =============================================

CREATE TABLE Foods
(
    FoodId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Description NVARCHAR(255),
    IsAvailable BIT NOT NULL DEFAULT 1
);

-- =============================================
-- SideDishes
-- =============================================

CREATE TABLE SideDishes
(
    SideDishId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    IsAvailable BIT NOT NULL DEFAULT 1
);

-- =============================================
-- FoodSideDishes (Many-to-Many)
-- =============================================

CREATE TABLE FoodSideDishes
(
    FoodId INT NOT NULL,
    SideDishId INT NOT NULL,

    CONSTRAINT PK_FoodSideDishes
        PRIMARY KEY (FoodId, SideDishId),

    CONSTRAINT FK_FoodSideDishes_Foods
        FOREIGN KEY (FoodId)
        REFERENCES Foods(FoodId)
        ON DELETE CASCADE,

    CONSTRAINT FK_FoodSideDishes_SideDishes
        FOREIGN KEY (SideDishId)
        REFERENCES SideDishes(SideDishId)
        ON DELETE CASCADE
);

-- =============================================
-- Users
-- Role:
-- 0 = Admin
-- 1 = Waiter
-- 2 = Customer
-- =============================================

CREATE TABLE Users
(
    UserId INT IDENTITY(1,1) PRIMARY KEY,

    Username NVARCHAR(50) NOT NULL UNIQUE,

    Password NVARCHAR(255) NOT NULL,

    FullName NVARCHAR(100) NOT NULL,

    Role INT NOT NULL,

    IsActive BIT NOT NULL DEFAULT 1,

    CONSTRAINT CHK_Users_Role
        CHECK (Role IN (0,1,2))
);

-- =============================================
-- Invoices
-- Status:
-- 0 = Open
-- 1 = Paid
-- 2 = Cancelled
-- =============================================

CREATE TABLE Invoices
(
    InvoiceId INT IDENTITY(1,1) PRIMARY KEY,

    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CreatedByUserId INT NOT NULL,

    TotalPrice DECIMAL(10,2) NOT NULL DEFAULT 0,

    Status INT NOT NULL DEFAULT 0,

    CONSTRAINT FK_Invoices_Users
        FOREIGN KEY (CreatedByUserId)
        REFERENCES Users(UserId),

    CONSTRAINT CHK_Invoices_Status
        CHECK (Status IN (0,1,2))
);

-- =============================================
-- InvoiceItems
-- =============================================

CREATE TABLE InvoiceItems
(
    InvoiceItemId INT IDENTITY(1,1) PRIMARY KEY,

    InvoiceId INT NOT NULL,

    FoodId INT NOT NULL,

    SideDishId INT NULL,

    FoodPrice DECIMAL(10,2) NOT NULL,

    SideDishPrice DECIMAL(10,2) NOT NULL DEFAULT 0,

    CONSTRAINT FK_InvoiceItems_Invoices
        FOREIGN KEY (InvoiceId)
        REFERENCES Invoices(InvoiceId)
        ON DELETE CASCADE,

    CONSTRAINT FK_InvoiceItems_Foods
        FOREIGN KEY (FoodId)
        REFERENCES Foods(FoodId),

    CONSTRAINT FK_InvoiceItems_SideDishes
        FOREIGN KEY (SideDishId)
        REFERENCES SideDishes(SideDishId)
);

-- =============================================
-- LoginHistory
-- =============================================

CREATE TABLE LoginHistory
(
    LoginHistoryId INT IDENTITY(1,1) PRIMARY KEY,

    UserId INT NULL,

    Username NVARCHAR(50) NOT NULL,

    LoginTime DATETIME NOT NULL DEFAULT GETDATE(),

    IsSuccessful BIT NOT NULL,

    CONSTRAINT FK_LoginHistory_Users
        FOREIGN KEY (UserId)
        REFERENCES Users(UserId)
);
GO