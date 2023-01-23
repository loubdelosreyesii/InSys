
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/15/2023 09:14:16
-- Generated from EDMX file: C:\X2MO\InSys\InSys\DataAccessLibrary\Model\InSysModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [X2MO_InSys];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Dealers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dealers];
GO
IF OBJECT_ID(N'[dbo].[Inventories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inventories];
GO
IF OBJECT_ID(N'[dbo].[LuckyDrawWinners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LuckyDrawWinners];
GO
IF OBJECT_ID(N'[dbo].[Participants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Participants];
GO
IF OBJECT_ID(N'[dbo].[PingPongPrizes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PingPongPrizes];
GO
IF OBJECT_ID(N'[dbo].[PingPongWinners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PingPongWinners];
GO
IF OBJECT_ID(N'[dbo].[PointOfSaleDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PointOfSaleDetails];
GO
IF OBJECT_ID(N'[dbo].[PointOfSales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PointOfSales];
GO
IF OBJECT_ID(N'[dbo].[ProfitSharings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfitSharings];
GO
IF OBJECT_ID(N'[dbo].[RaffleEntries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RaffleEntries];
GO
IF OBJECT_ID(N'[dbo].[RaffleLuckyDrawPrizes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RaffleLuckyDrawPrizes];
GO
IF OBJECT_ID(N'[dbo].[RafflePrizes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RafflePrizes];
GO
IF OBJECT_ID(N'[dbo].[Raffles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Raffles];
GO
IF OBJECT_ID(N'[dbo].[RaffleWinners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RaffleWinners];
GO
IF OBJECT_ID(N'[dbo].[References]', 'U') IS NOT NULL
    DROP TABLE [dbo].[References];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Participants'
CREATE TABLE [dbo].[Participants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NOT NULL,
    [BirthDate] nvarchar(max)  NOT NULL,
    [EmailAddress] nvarchar(max)  NOT NULL,
    [ContactNumber] nvarchar(max)  NOT NULL,
    [FacebookLink] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Inventories'
CREATE TABLE [dbo].[Inventories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeID] int  NOT NULL,
    [BrandID] int  NOT NULL,
    [Model] nvarchar(max)  NOT NULL,
    [Quantity] int  NOT NULL,
    [DistributorPrice] decimal(18,2)  NOT NULL,
    [SuggestedRetailPrice] decimal(18,2)  NOT NULL,
    [DealerID] int  NOT NULL
);
GO

-- Creating table 'References'
CREATE TABLE [dbo].[References] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CategoryID] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dealers'
CREATE TABLE [dbo].[Dealers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [ContactNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Raffles'
CREATE TABLE [dbo].[Raffles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DrawDate] datetime  NOT NULL,
    [EntryPrice] decimal(18,2)  NOT NULL,
    [MaxEntries] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NOT NULL,
    [ContactNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PointOfSaleDetails'
CREATE TABLE [dbo].[PointOfSaleDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [POSId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Quantity] int  NOT NULL,
    [Price] decimal(18,2)  NOT NULL
);
GO

-- Creating table 'PointOfSales'
CREATE TABLE [dbo].[PointOfSales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerName] varchar(200)  NOT NULL,
    [ReceiptNumber] nvarchar(max)  NOT NULL,
    [TransactionDateTime] datetime  NOT NULL,
    [SellerName] nchar(10)  NULL
);
GO

-- Creating table 'RaffleEntries'
CREATE TABLE [dbo].[RaffleEntries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ParticipantId] int  NOT NULL,
    [TransactionDateTime] datetime  NOT NULL,
    [PaymentReceipt] nvarchar(max)  NOT NULL,
    [RaffleReferenceNumber] nvarchar(100)  NOT NULL,
    [PaidAmount] decimal(18,0)  NOT NULL,
    [PaymentMethod] int  NOT NULL,
    [LuckyNumber1] int  NULL,
    [LuckyNumber2] int  NULL,
    [LuckyNumber3] int  NULL,
    [RafflePrizeId] int  NULL,
    [ProductId] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(100)  NOT NULL,
    [Password] nvarchar(100)  NOT NULL,
    [UserType] int  NOT NULL
);
GO

-- Creating table 'RafflePrizes'
CREATE TABLE [dbo].[RafflePrizes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Quantity] int  NOT NULL,
    [ShuffleLevel] int  NOT NULL
);
GO

-- Creating table 'RaffleWinners'
CREATE TABLE [dbo].[RaffleWinners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [ParticipantId] int  NOT NULL,
    [RaffleReferenceNumber] nvarchar(max)  NOT NULL,
    [PrizeId] int  NOT NULL
);
GO

-- Creating table 'RaffleLuckyDrawPrizes'
CREATE TABLE [dbo].[RaffleLuckyDrawPrizes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Quantity] int  NOT NULL,
    [ShuffleLevel] int  NOT NULL
);
GO

-- Creating table 'LuckyDrawWinners'
CREATE TABLE [dbo].[LuckyDrawWinners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [ParticipantId] int  NOT NULL,
    [RaffleReferenceNumber] nvarchar(max)  NOT NULL,
    [LuckyDrawPrizeId] int  NOT NULL
);
GO

-- Creating table 'PingPongPrizes'
CREATE TABLE [dbo].[PingPongPrizes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'PingPongWinners'
CREATE TABLE [dbo].[PingPongWinners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RaffleId] int  NOT NULL,
    [ProductId] int  NULL,
    [ParticipantId] int  NOT NULL,
    [RaffleReferenceNumber] nvarchar(max)  NOT NULL,
    [PrizeId] int  NULL,
    [PrizeOfferAmount] decimal(18,2)  NULL
);
GO

-- Creating table 'ProfitSharings'
CREATE TABLE [dbo].[ProfitSharings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SellerName] nvarchar(100)  NOT NULL,
    [SharePercentage] int  NOT NULL
);
GO

-- Creating table 'InventoryPriceHistories'
CREATE TABLE [dbo].[InventoryPriceHistories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] int  NOT NULL,
    [DistributorPrice] decimal(18,2)  NOT NULL,
    [SuggestedRetailPrice] decimal(18,2)  NOT NULL,
    [ProductId] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Participants'
ALTER TABLE [dbo].[Participants]
ADD CONSTRAINT [PK_Participants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Inventories'
ALTER TABLE [dbo].[Inventories]
ADD CONSTRAINT [PK_Inventories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'References'
ALTER TABLE [dbo].[References]
ADD CONSTRAINT [PK_References]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dealers'
ALTER TABLE [dbo].[Dealers]
ADD CONSTRAINT [PK_Dealers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Raffles'
ALTER TABLE [dbo].[Raffles]
ADD CONSTRAINT [PK_Raffles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PointOfSaleDetails'
ALTER TABLE [dbo].[PointOfSaleDetails]
ADD CONSTRAINT [PK_PointOfSaleDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PointOfSales'
ALTER TABLE [dbo].[PointOfSales]
ADD CONSTRAINT [PK_PointOfSales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RaffleEntries'
ALTER TABLE [dbo].[RaffleEntries]
ADD CONSTRAINT [PK_RaffleEntries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RafflePrizes'
ALTER TABLE [dbo].[RafflePrizes]
ADD CONSTRAINT [PK_RafflePrizes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RaffleWinners'
ALTER TABLE [dbo].[RaffleWinners]
ADD CONSTRAINT [PK_RaffleWinners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RaffleLuckyDrawPrizes'
ALTER TABLE [dbo].[RaffleLuckyDrawPrizes]
ADD CONSTRAINT [PK_RaffleLuckyDrawPrizes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LuckyDrawWinners'
ALTER TABLE [dbo].[LuckyDrawWinners]
ADD CONSTRAINT [PK_LuckyDrawWinners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PingPongPrizes'
ALTER TABLE [dbo].[PingPongPrizes]
ADD CONSTRAINT [PK_PingPongPrizes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PingPongWinners'
ALTER TABLE [dbo].[PingPongWinners]
ADD CONSTRAINT [PK_PingPongWinners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfitSharings'
ALTER TABLE [dbo].[ProfitSharings]
ADD CONSTRAINT [PK_ProfitSharings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InventoryPriceHistories'
ALTER TABLE [dbo].[InventoryPriceHistories]
ADD CONSTRAINT [PK_InventoryPriceHistories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------