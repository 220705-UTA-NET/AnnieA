CREATE SCHEMA Deals;
GO

--DROP TABLE Deals.Investors;
CREATE TABLE Deals.Investors
(
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(16) NOT NULL UNIQUE,
    Name NVARCHAR(255) NOT NULL UNIQUE,
    Email NVARCHAR(32)
);

INSERT INTO Deals.Investors(Username,Name,Email)
VALUES
('Ann872Login','Annie','Annie@gmail.com'),
('Cla123Login','Claude','Claude@gmail.com'),
('Tam123Login','Tamara','Tamara@gmail.com'),
('Amy123Login','Amy','Amy@gmail.com');

SELECT * FROM Deals.Investors;

--DROP TABLE Deals.Analysis;
CREATE TABLE Deals.Analysis
(
    TransId INT PRIMARY KEY IDENTITY,
    TimeStamp datetimeoffset(7) NOT NULL DEFAULT (SYSDATETIMEOFFSET()),
    InvestorId INT NOT NULL,
    PropertyAddress NVARCHAR(255) NOT NULL,
    AskingPrice DECIMAL(12) NOT NULL,
    RepairEstimate DECIMAL(12) NOT NULL,
    AfterRepairValue DECIMAL(12) NOT NULL,
    ProjectCostPercentage DECIMAL(12) NOT NULL,
    ExitId NVARCHAR(4) NOT NULL,
);

SELECT * FROM Deals.Analysis;

--DROP TABLE Deals.ExitStrategy;
CREATE TABLE Deals.ExitStrategy
(
    ExitId NVARCHAR(4) PRIMARY KEY,
    Strategy NVARCHAR(32) NOT NULL,
)

INSERT INTO Deals.ExitStrategy(ExitId, Strategy)
VALUES
('SELL','Wholesale Exit'),
('FXSL','Rehab then Sell Exit'),
('RENT','Rental Exit'),
('FXRN','Rehab then Rent Exit');

SELECT * FROM Deals.ExitStrategy;

ALTER TABLE Deals.Investors ADD Email NVARCHAR(32);

INSERT INTO Deals.Investors(Email)
VALUES
('Annie@gmail.com'),
('Claude@gmail.com'),
('Tamara@gmail.com'),
('Amy@gmail.com');

--DROP TABLE Deals.Analysis;

CREATE TABLE [Deals].[Analysis] (
    [TransId]               INT                IDENTITY (1, 1) NOT NULL,
    [TimeStamp]             DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [InvestorUsername]      NVARCHAR (16)      NOT NULL,
    [PropertyAddress]       NVARCHAR (255)     NOT NULL,
    [AskingPrice]           DECIMAL (12)       NOT NULL,
    [RepairEstimate]        DECIMAL (12)       NOT NULL,
    [AfterRepairValue]      DECIMAL (12)       NOT NULL,
    [ProjectCostPercentage] DECIMAL (12)       NOT NULL,
    [ExitId]                NVARCHAR (4)       NOT NULL,
    PRIMARY KEY CLUSTERED ([TransId] ASC),
    CONSTRAINT [FK_1] FOREIGN KEY ([InvestorUsername]) REFERENCES [Deals].[Investors] ([Username])
);
