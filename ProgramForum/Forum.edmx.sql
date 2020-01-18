
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/18/2020 15:18:37
-- Generated from EDMX file: D:\SourceWorks\source\ProgramForum\ProgramForum\Forum.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Forum];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AccountQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionSet] DROP CONSTRAINT [FK_AccountQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_AnswerQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnswerSet] DROP CONSTRAINT [FK_AnswerQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentorySet_AccountSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentorySet] DROP CONSTRAINT [FK_CommentorySet_AccountSet];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentorySet_ThemeSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommentorySet] DROP CONSTRAINT [FK_CommentorySet_ThemeSet];
GO
IF OBJECT_ID(N'[dbo].[FK_ConversationSet_AccountSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConversationSet] DROP CONSTRAINT [FK_ConversationSet_AccountSet];
GO
IF OBJECT_ID(N'[dbo].[FK_ConversationSet_AccountSet1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConversationSet] DROP CONSTRAINT [FK_ConversationSet_AccountSet1];
GO
IF OBJECT_ID(N'[dbo].[FK_LanguageQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionSet] DROP CONSTRAINT [FK_LanguageQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_MessageSet_ConversationSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MessageSet] DROP CONSTRAINT [FK_MessageSet_ConversationSet];
GO
IF OBJECT_ID(N'[dbo].[FK_MessageSet_ConversationSet_Sender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MessageSet] DROP CONSTRAINT [FK_MessageSet_ConversationSet_Sender];
GO
IF OBJECT_ID(N'[dbo].[FK_QuestionTypeQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionSet] DROP CONSTRAINT [FK_QuestionTypeQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_ThemeSet_AccountSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ThemeSet] DROP CONSTRAINT [FK_ThemeSet_AccountSet];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AccountSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountSet];
GO
IF OBJECT_ID(N'[dbo].[AnswerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnswerSet];
GO
IF OBJECT_ID(N'[dbo].[CommentorySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommentorySet];
GO
IF OBJECT_ID(N'[dbo].[ConversationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConversationSet];
GO
IF OBJECT_ID(N'[dbo].[LanguageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LanguageSet];
GO
IF OBJECT_ID(N'[dbo].[MessageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MessageSet];
GO
IF OBJECT_ID(N'[dbo].[QuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionSet];
GO
IF OBJECT_ID(N'[dbo].[QuestionTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionTypeSet];
GO
IF OBJECT_ID(N'[dbo].[ThemeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ThemeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AccountSet'
CREATE TABLE [dbo].[AccountSet] (
    [AccountId] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [AccountType] int  NOT NULL,
    [Name] nchar(100)  NOT NULL,
    [Email] nchar(55)  NULL,
    [CreateDate] datetime  NULL,
    [Points] int  NULL,
    [Reputation] int  NULL
);
GO

-- Creating table 'AnswerSet'
CREATE TABLE [dbo].[AnswerSet] (
    [AnswerId] int IDENTITY(1,1) NOT NULL,
    [AnswerVarible] nvarchar(max)  NOT NULL,
    [QuestionQuestionId] int  NOT NULL
);
GO

-- Creating table 'CommentorySet'
CREATE TABLE [dbo].[CommentorySet] (
    [CommentoryId] int IDENTITY(1,1) NOT NULL,
    [AuthorId] int  NOT NULL,
    [CommentoryText] nvarchar(max)  NOT NULL,
    [ThemeId] int  NOT NULL,
    [CreateDate] datetime  NOT NULL
);
GO

-- Creating table 'ConversationSet'
CREATE TABLE [dbo].[ConversationSet] (
    [ConversationId] int IDENTITY(1,1) NOT NULL,
    [RecipientId] int  NOT NULL,
    [SenderId] int  NOT NULL
);
GO

-- Creating table 'LanguageSet'
CREATE TABLE [dbo].[LanguageSet] (
    [LanguageId] int IDENTITY(1,1) NOT NULL,
    [LanguageName] nvarchar(max)  NOT NULL,
    [LanguageDescription] nvarchar(max)  NULL
);
GO

-- Creating table 'MessageSet'
CREATE TABLE [dbo].[MessageSet] (
    [MessageId] int IDENTITY(1,1) NOT NULL,
    [MessageText] nvarchar(max)  NOT NULL,
    [Date] datetime  NULL,
    [ConversationId] int  NOT NULL,
    [SenderId] int  NOT NULL
);
GO

-- Creating table 'QuestionSet'
CREATE TABLE [dbo].[QuestionSet] (
    [QuestionId] int IDENTITY(1,1) NOT NULL,
    [QuestionText] nvarchar(max)  NOT NULL,
    [LanguageLanguageId] int  NOT NULL,
    [QuestionTypeQuestionTypeId] int  NOT NULL,
    [CorrectOption] int  NOT NULL,
    [AccountAccountId] int  NOT NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'QuestionTypeSet'
CREATE TABLE [dbo].[QuestionTypeSet] (
    [QuestionTypeId] int IDENTITY(1,1) NOT NULL,
    [QuestionTypeText] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ThemeSet'
CREATE TABLE [dbo].[ThemeSet] (
    [ThemeId] int IDENTITY(1,1) NOT NULL,
    [AuthorId] int  NOT NULL,
    [ThemeName] nvarchar(max)  NOT NULL,
    [ThemeText] nvarchar(max)  NULL,
    [ThemePoints] int  NOT NULL,
    [CreateDate] datetime  NULL
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

-- Creating primary key on [AnswerId] in table 'AnswerSet'
ALTER TABLE [dbo].[AnswerSet]
ADD CONSTRAINT [PK_AnswerSet]
    PRIMARY KEY CLUSTERED ([AnswerId] ASC);
GO

-- Creating primary key on [CommentoryId] in table 'CommentorySet'
ALTER TABLE [dbo].[CommentorySet]
ADD CONSTRAINT [PK_CommentorySet]
    PRIMARY KEY CLUSTERED ([CommentoryId] ASC);
GO

-- Creating primary key on [ConversationId] in table 'ConversationSet'
ALTER TABLE [dbo].[ConversationSet]
ADD CONSTRAINT [PK_ConversationSet]
    PRIMARY KEY CLUSTERED ([ConversationId] ASC);
GO

-- Creating primary key on [LanguageId] in table 'LanguageSet'
ALTER TABLE [dbo].[LanguageSet]
ADD CONSTRAINT [PK_LanguageSet]
    PRIMARY KEY CLUSTERED ([LanguageId] ASC);
GO

-- Creating primary key on [MessageId] in table 'MessageSet'
ALTER TABLE [dbo].[MessageSet]
ADD CONSTRAINT [PK_MessageSet]
    PRIMARY KEY CLUSTERED ([MessageId] ASC);
GO

-- Creating primary key on [QuestionId] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [PK_QuestionSet]
    PRIMARY KEY CLUSTERED ([QuestionId] ASC);
GO

-- Creating primary key on [QuestionTypeId] in table 'QuestionTypeSet'
ALTER TABLE [dbo].[QuestionTypeSet]
ADD CONSTRAINT [PK_QuestionTypeSet]
    PRIMARY KEY CLUSTERED ([QuestionTypeId] ASC);
GO

-- Creating primary key on [ThemeId] in table 'ThemeSet'
ALTER TABLE [dbo].[ThemeSet]
ADD CONSTRAINT [PK_ThemeSet]
    PRIMARY KEY CLUSTERED ([ThemeId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [AuthorId] in table 'CommentorySet'
ALTER TABLE [dbo].[CommentorySet]
ADD CONSTRAINT [FK_CommentorySet_AccountSet]
    FOREIGN KEY ([AuthorId])
    REFERENCES [dbo].[AccountSet]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentorySet_AccountSet'
CREATE INDEX [IX_FK_CommentorySet_AccountSet]
ON [dbo].[CommentorySet]
    ([AuthorId]);
GO

-- Creating foreign key on [RecipientId] in table 'ConversationSet'
ALTER TABLE [dbo].[ConversationSet]
ADD CONSTRAINT [FK_ConversationSet_AccountSet]
    FOREIGN KEY ([RecipientId])
    REFERENCES [dbo].[AccountSet]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationSet_AccountSet'
CREATE INDEX [IX_FK_ConversationSet_AccountSet]
ON [dbo].[ConversationSet]
    ([RecipientId]);
GO

-- Creating foreign key on [SenderId] in table 'ConversationSet'
ALTER TABLE [dbo].[ConversationSet]
ADD CONSTRAINT [FK_ConversationSet_AccountSet1]
    FOREIGN KEY ([SenderId])
    REFERENCES [dbo].[AccountSet]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationSet_AccountSet1'
CREATE INDEX [IX_FK_ConversationSet_AccountSet1]
ON [dbo].[ConversationSet]
    ([SenderId]);
GO

-- Creating foreign key on [ConversationId] in table 'MessageSet'
ALTER TABLE [dbo].[MessageSet]
ADD CONSTRAINT [FK_MessageSet_ConversationSet_Sender]
    FOREIGN KEY ([ConversationId])
    REFERENCES [dbo].[AccountSet]
        ([AccountId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageSet_ConversationSet_Sender'
CREATE INDEX [IX_FK_MessageSet_ConversationSet_Sender]
ON [dbo].[MessageSet]
    ([ConversationId]);
GO

-- Creating foreign key on [AuthorId] in table 'ThemeSet'
ALTER TABLE [dbo].[ThemeSet]
ADD CONSTRAINT [FK_ThemeSet_AccountSet]
    FOREIGN KEY ([AuthorId])
    REFERENCES [dbo].[AccountSet]
        ([AccountId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ThemeSet_AccountSet'
CREATE INDEX [IX_FK_ThemeSet_AccountSet]
ON [dbo].[ThemeSet]
    ([AuthorId]);
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

-- Creating foreign key on [ThemeId] in table 'CommentorySet'
ALTER TABLE [dbo].[CommentorySet]
ADD CONSTRAINT [FK_CommentorySet_ThemeSet]
    FOREIGN KEY ([ThemeId])
    REFERENCES [dbo].[ThemeSet]
        ([ThemeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentorySet_ThemeSet'
CREATE INDEX [IX_FK_CommentorySet_ThemeSet]
ON [dbo].[CommentorySet]
    ([ThemeId]);
GO

-- Creating foreign key on [ConversationId] in table 'MessageSet'
ALTER TABLE [dbo].[MessageSet]
ADD CONSTRAINT [FK_MessageSet_ConversationSet]
    FOREIGN KEY ([ConversationId])
    REFERENCES [dbo].[ConversationSet]
        ([ConversationId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageSet_ConversationSet'
CREATE INDEX [IX_FK_MessageSet_ConversationSet]
ON [dbo].[MessageSet]
    ([ConversationId]);
GO

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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------