
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/10/2019 13:09:32
-- Generated from EDMX file: C:\Users\Слава\source\repos\ProgramForum\ProgramForum\Forum.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\Users\Слава\Documents\Forum.mdf];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LanguageQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionSet] DROP CONSTRAINT [FK_LanguageQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_QuestionTypeQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionSet] DROP CONSTRAINT [FK_QuestionTypeQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_AccountQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionSet] DROP CONSTRAINT [FK_AccountQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_AnswerQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnswerSet] DROP CONSTRAINT [FK_AnswerQuestion];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AccountSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountSet];
GO
IF OBJECT_ID(N'[dbo].[QuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionSet];
GO
IF OBJECT_ID(N'[dbo].[LanguageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LanguageSet];
GO
IF OBJECT_ID(N'[dbo].[QuestionTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionTypeSet];
GO
IF OBJECT_ID(N'[dbo].[AnswerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnswerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AccountSet'
CREATE TABLE [dbo].[AccountSet] (
    [AccountId] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [AccountType] int  NOT NULL
);
GO

-- Creating table 'QuestionSet'
CREATE TABLE [dbo].[QuestionSet] (
    [QuestionId] int IDENTITY(1,1) NOT NULL,
    [QuestionText] nvarchar(max)  NOT NULL,
    [LanguageLanguageId] int  NOT NULL,
    [QuestionTypeQuestionTypeId] int  NOT NULL,
    [CorrectOption] nvarchar(max)  NOT NULL,
    [AccountAccountId] int  NOT NULL
);
GO

-- Creating table 'LanguageSet'
CREATE TABLE [dbo].[LanguageSet] (
    [LanguageId] int IDENTITY(1,1) NOT NULL,
    [LanguageName] nvarchar(max)  NOT NULL,
    [LanguageDescription] nvarchar(max)  NULL
);
GO

-- Creating table 'QuestionTypeSet'
CREATE TABLE [dbo].[QuestionTypeSet] (
    [QuestionTypeId] int IDENTITY(1,1) NOT NULL,
    [QuestionTypeText] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AnswerSet'
CREATE TABLE [dbo].[AnswerSet] (
    [AnswerId] int IDENTITY(1,1) NOT NULL,
    [AnswerVarible] nvarchar(max)  NOT NULL,
    [QuestionQuestionId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AccountId] in table 'AccountSet'
ALTER TABLE [dbo].[AccountSet]
ADD CONSTRAINT [PK_AccountSet]
    PRIMARY KEY CLUSTERED ([AccountId] ASC);
GO

-- Creating primary key on [QuestionId] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [PK_QuestionSet]
    PRIMARY KEY CLUSTERED ([QuestionId] ASC);
GO

-- Creating primary key on [LanguageId] in table 'LanguageSet'
ALTER TABLE [dbo].[LanguageSet]
ADD CONSTRAINT [PK_LanguageSet]
    PRIMARY KEY CLUSTERED ([LanguageId] ASC);
GO

-- Creating primary key on [QuestionTypeId] in table 'QuestionTypeSet'
ALTER TABLE [dbo].[QuestionTypeSet]
ADD CONSTRAINT [PK_QuestionTypeSet]
    PRIMARY KEY CLUSTERED ([QuestionTypeId] ASC);
GO

-- Creating primary key on [AnswerId] in table 'AnswerSet'
ALTER TABLE [dbo].[AnswerSet]
ADD CONSTRAINT [PK_AnswerSet]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LanguageLanguageId] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [FK_LanguageQuestion]
    FOREIGN KEY ([LanguageLanguageId])
    REFERENCES [dbo].[LanguageSet]
        ([LanguageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LanguageQuestion'
CREATE INDEX [IX_FK_LanguageQuestion]
ON [dbo].[QuestionSet]
    ([LanguageLanguageId]);
GO

-- Creating foreign key on [QuestionTypeQuestionTypeId] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [FK_QuestionTypeQuestion]
    FOREIGN KEY ([QuestionTypeQuestionTypeId])
    REFERENCES [dbo].[QuestionTypeSet]
        ([QuestionTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuestionTypeQuestion'
CREATE INDEX [IX_FK_QuestionTypeQuestion]
ON [dbo].[QuestionSet]
    ([QuestionTypeQuestionTypeId]);
GO

-- Creating foreign key on [AccountAccountId] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [FK_AccountQuestion]
    FOREIGN KEY ([AccountAccountId])
    REFERENCES [dbo].[AccountSet]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountQuestion'
CREATE INDEX [IX_FK_AccountQuestion]
ON [dbo].[QuestionSet]
    ([AccountAccountId]);
GO

-- Creating foreign key on [QuestionQuestionId] in table 'AnswerSet'
ALTER TABLE [dbo].[AnswerSet]
ADD CONSTRAINT [FK_AnswerQuestion]
    FOREIGN KEY ([QuestionQuestionId])
    REFERENCES [dbo].[QuestionSet]
        ([QuestionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnswerQuestion'
CREATE INDEX [IX_FK_AnswerQuestion]
ON [dbo].[AnswerSet]
    ([QuestionQuestionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------