
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/05/2023 07:00:03
-- Generated from EDMX file: C:\X2MO\InSys\InSys\DataAccessLibrary\Model\InSysModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [X2MO_InSys];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- Creating table 'ProfitSharings'
CREATE TABLE [dbo].[ProfitSharings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SellerName] nvarchar(100)  NOT NULL,
    [SharePercentage] int  NOT NULL
);
GO


-- Creating primary key on [Id] in table 'ProfitSharings'
ALTER TABLE [dbo].[ProfitSharings]
ADD CONSTRAINT [PK_ProfitSharings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------