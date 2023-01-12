
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/30/2022 22:03:21
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

-- Creating primary key on [Id] in table 'RaffleWinners'
ALTER TABLE [dbo].[RaffleWinners]
ADD CONSTRAINT [PK_RaffleWinners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------