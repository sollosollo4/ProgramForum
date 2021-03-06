USE [C:\USERS\СЛАВА\DOCUMENTS\FORUM.MDF]
GO
/****** Object:  Table [dbo].[AccountSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountSet](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[AccountType] [int] NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[Email] [nchar](55) NULL,
	[CreateDate] [datetime] NULL,
	[Points] [int] NULL,
	[Reputation] [int] NULL,
 CONSTRAINT [PK_AccountSet] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnswerSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnswerSet](
	[AnswerId] [int] IDENTITY(1,1) NOT NULL,
	[AnswerVarible] [nvarchar](max) NOT NULL,
	[QuestionQuestionId] [int] NOT NULL,
 CONSTRAINT [PK_AnswerSet] PRIMARY KEY CLUSTERED 
(
	[AnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommentorySet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommentorySet](
	[CommentoryId] [int] IDENTITY(0,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[CommentoryText] [nvarchar](max) NOT NULL,
	[ThemeId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CommentorySet] PRIMARY KEY CLUSTERED 
(
	[CommentoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConversationSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConversationSet](
	[ConversationId] [int] IDENTITY(0,1) NOT NULL,
	[RecipientId] [int] NOT NULL,
	[SenderId] [int] NOT NULL,
 CONSTRAINT [PK_ConversationSet] PRIMARY KEY CLUSTERED 
(
	[ConversationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanguageSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageSet](
	[LanguageId] [int] IDENTITY(1,1) NOT NULL,
	[LanguageName] [nvarchar](max) NOT NULL,
	[LanguageDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_LanguageSet] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageSet](
	[MessageId] [int] IDENTITY(0,1) NOT NULL,
	[MessageText] [nvarchar](max) NOT NULL,
	[Date] [datetime] NULL,
	[ConversationId] [int] NOT NULL,
	[SenderId] [int] NOT NULL,
 CONSTRAINT [PK_MessageSet] PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionSet](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionText] [nvarchar](max) NOT NULL,
	[LanguageLanguageId] [int] NOT NULL,
	[QuestionTypeQuestionTypeId] [int] NOT NULL,
	[CorrectOption] [int] NOT NULL,
	[AccountAccountId] [int] NOT NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_QuestionSet] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionTypeSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionTypeSet](
	[QuestionTypeId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionTypeText] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_QuestionTypeSet] PRIMARY KEY CLUSTERED 
(
	[QuestionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThemeSet]    Script Date: 18.12.2019 14:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThemeSet](
	[ThemeId] [int] IDENTITY(0,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[ThemeName] [nvarchar](max) NOT NULL,
	[ThemeText] [nvarchar](max) NULL,
	[ThemePoints] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_ThemeSet] PRIMARY KEY CLUSTERED 
(
	[ThemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccountSet] ON 

INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (1, N'admin', N'admin', -1, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (2, N'sollosollo4', N'12sollo34', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (3, N'kentuha', N'tre67swq', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (4, N'myMemory', N'67shfr4', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (5, N'myCodeEstet', N'tyreas7878', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (6, N'Mor9k', N'retroGrags22', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (7, N'Pol9k_Krito', N'fgtral4', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (8, N'StStStStSt', N'nm_9c2jzS', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (9, N'CounterS', N'554%^%Sax', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (10, N'MyColorIsBlack', N'blackblackblack', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (11, N'Saske_Uchiha', N'naruto000', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (12, N'Kak_Shit', N'@mailSpice', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (13, N'Roflan_Lico', N'mem22sa8', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (14, N'Polerwoli', N'hsdfZXsdwq', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (15, N'Qwerty', N'jkdf78XZcad', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (16, N'Poljoriono', N'llkxc9*7asdk', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (17, N'Maksimka23', N'la:ksd8VVdfd', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (18, N'Artemka99', N'ghtf%6ad332', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (19, N'AndreyProvidec', N'ghfvb^7cz', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (20, N'AndryCool', N'colSsa45545', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (21, N'Boris_Tr9pka', N'bghv5^czxs8', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (22, N'MadokaExtra', N'aniSime', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (23, N'kartishok', N'nbv786fgh23', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (24, N'Partizanka', N'miu34567ty', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (25, N'CoolSportik', N'bnvyurt4556', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (26, N'Maximal', N'jhay4512d', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (27, N'DrugoyMir', N'htyf67as2', -1, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (28, N'Marinka', N'marinka678', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (29, N'BigDaddy', N'daddyCoolBoy', -1, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (30, N'Maksimilian', N'wtfBrosd34', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (31, N'RakGubbI', N'roflan454556', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (32, N'NARUTO', N'saskesaskesaske', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (33, N'KakTakTikTak', N'tik678tak234', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (34, N'VoprosOtvet', N'rakiSaki', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (35, N'MyDadIsBad', N'dadddre234tyuio', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (36, N'Lolsssssss', N'Colsj8xjdS', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (37, N'PoMa', N'pomag56DfD', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (38, N'Nu9sa', N'tryHard', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (39, N'BEZ_OBID', N'hgf56daew', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (40, N'11_BOY_22', N'11_treSasd', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (41, N'Rofl_Negr', N'negrsa00', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (42, N'Pon9tno', N'pon9ato', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (43, N'MyMom_Good', N'mom0067', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (45, N'BalkaMaka', N'sad456yt', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (46, N'RikiTikiTavi', N'dikiydikiyparen', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (47, N'BACON', N'bacon', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (48, N'CanTrash', N'yufd67ASdv', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (49, N'Dat_Boy', N'uziuziuzi', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (50, N'OG_Dad', N'wtf56wtf78', 0, N'NoName', NULL, NULL, NULL, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation]) VALUES (51, N'Coomir', N'weuf^&sad67', 0, N'NoName', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[AccountSet] OFF
SET IDENTITY_INSERT [dbo].[AnswerSet] ON 

INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (9, N'Диаграмма', 4)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (10, N'Функция', 4)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (11, N'Алебарда', 4)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (12, N'Алгоритм', 4)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (13, N'Набор команд', 5)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (14, N'Команда', 5)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (15, N'Оператор', 5)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (16, N'Переменная', 5)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (17, N'Компьютерная программа - исполняющий файл', 6)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (18, N'Компьютерная программа - комбинация инструкций и данных, позволяющая аппаратному обеспечению вычислительной системы', 6)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (19, N'Компьютерная программа - тоже, что и компьютерная игра или браузер', 6)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (20, N'Компьютерная программа - часть операционной системы обеспечивающая её работу', 6)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (21, N'operator', 7)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (22, N'newClass', 7)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (23, N'class', 7)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (24, N'Class = new Class', 7)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (25, N'get', 8)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (26, N'set', 8)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (27, N'new', 8)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (28, N'protected', 8)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (29, N'Data', 9)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (30, N'iostream', 9)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (31, N'System', 9)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (32, N'Windows', 9)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (33, N'Первая строка', 10)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (34, N'Основная функция', 10)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (35, N'От <iostream>', 10)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (36, N'Функция getParametrs()', 10)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (37, N'Запятой (,)', 11)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (38, N'Точки с запятой (;)', 11)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (39, N'Точка (.)', 11)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (40, N'Двоеточие (:)', 11)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (41, N'X = X + X', 12)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (42, N'X = X + 1', 12)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (43, N'X = X : X', 12)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (44, N'X = X / X', 12)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (45, N'4', 13)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (46, N'5', 13)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (47, N'6', 13)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (48, N'7', 13)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (49, N'3', 14)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (50, N'4', 14)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (51, N'5', 14)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (52, N'Ошибка', 14)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (53, N'Тип ссылки', 15)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (54, N'Тип метода', 15)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (55, N'Тип ценности', 15)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (56, N'Ничего из этого', 15)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (57, N'Кэш', 16)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (58, N'Оперативная память', 16)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (59, N'Память', 16)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (60, N'Стэк', 16)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (61, N'Куча', 17)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (62, N'Стэк', 17)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (63, N'Память', 17)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (64, N'Оперативная память', 17)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (65, N'get', 18)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (66, N'set', 18)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (67, N'return', 18)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (68, N'pet', 18)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (69, N'Кэше', 19)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (70, N'Стэке', 19)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (71, N'Куче', 19)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (72, N'Процессоре', 19)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (73, N'private', 20)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (74, N'public', 20)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (75, N'protected', 20)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (76, N'static', 20)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (77, N'Объект является экземпляром класса', 21)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (78, N'Объект - это метод класса', 21)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (79, N'Объект является членом класса', 21)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (80, N'Объект ялвяется свойством класса', 21)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (81, N'pet', 22)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (82, N'get', 22)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (83, N'set', 22)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (84, N'var', 22)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (85, N'Bob: 11 Mike: 12', 23)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (86, N'Bob: 9 Mike 12', 23)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (87, N'Ann: 9 Bob 11', 23)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (88, N'Mike: 12 Ann: 9', 23)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (89, N'То же имя метода, разные параметры', 24)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (90, N'Печатные значения', 24)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (91, N'Те же параметры, разные имена методов', 24)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (92, N'Те же значения свойства', 24)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (93, N'Определяющие конструкторы', 25)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (94, N'Определение постоянных членов класса', 25)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (95, N'Определение постоянных конструкторов класса', 25)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (96, N'Определение пользовательских действий для операторов', 25)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (97, N'Переменные члена класса', 26)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (98, N'Вызывается при инициализация', 26)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (99, N'Вызывается, только если конструктор не вызывается', 26)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (100, N'Вызывается при удалении объекта', 26)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (101, N'Exception', 27)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (102, N'Main', 27)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (103, N'System', 27)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (104, N'Windows', 27)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (105, N'Person e = new Person;', 28)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (106, N'Person p;', 28)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (107, N'Person p = new Person("Bob");', 28)
GO
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (108, N'Person p = new Person{''18'', ''Bob''}', 28)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (109, N'Структура может быть абстрактной', 29)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (110, N'Вы не можете получить из структуры данные', 29)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (111, N'Структура может содержать виртуальные методы', 29)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (112, N'Структура это тоже самое, что и класс', 29)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (113, N'*', 30)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (114, N'%', 30)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (115, N'&', 30)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (116, N'!', 30)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (117, N'один', 31)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (118, N'false', 31)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (119, N'бесконечно', 31)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (120, N'нисколько', 31)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (121, N'Convert.ToInt32', 32)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (122, N'Console.ReadLine', 32)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (123, N'Console.Write', 32)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (124, N'Console.Read', 32)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (125, N'«case» будет рабботать', 33)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (126, N'Ничего такого', 33)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (127, N'Ошибка компиляции', 33)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (128, N'«case» не будет рабботать', 33)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (129, N'==', 34)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (130, N'знак равно', 34)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (131, N'>=', 34)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (132, N'<=', 34)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (133, N'Ни одного', 35)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (134, N'Только два', 35)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (135, N'Столько, сколько вы хотите', 35)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (136, N'Не больше 4,13*10^413', 35)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (137, N'Либо А, либо Б - правда', 36)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (138, N'И a, и b ложны', 36)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (139, N'И a, и b верны', 36)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (140, N'Никогда', 36)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (141, N'Столько, сколько вы хотите', 37)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (142, N'Два', 37)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (143, N'Один раз', 37)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (144, N'Максимум 3,14*10^314', 37)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (145, N'Правда', 38)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (146, N'Ложный', 38)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (147, N'Не определено', 38)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (148, N'Ошибка компиляции', 38)
SET IDENTITY_INSERT [dbo].[AnswerSet] OFF
SET IDENTITY_INSERT [dbo].[ConversationSet] ON 

INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (9, 2, 1)
INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (12, 2, 3)
INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (13, 1, 1)
INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (14, 1, 13)
SET IDENTITY_INSERT [dbo].[ConversationSet] OFF
SET IDENTITY_INSERT [dbo].[LanguageSet] ON 

INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (1, N'C#', N' объектно-ориентированный язык программирования. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft .NET Framework. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (2, N'C', N'Си (англ. C) — компилируемый статически типизированный язык программирования общего назначения, разработанный в 1969—1973 годах сотрудником Bell Labs Деннисом Ритчи как развитие языка Би. Первоначально был разработан для реализации операционной системы UNIX, но впоследствии был перенесён на множество других платформ. Согласно дизайну языка, его конструкции близко сопоставляются типичным машинным инструкциям, благодаря чему он нашёл применение в проектах, для которых был свойственен язык ассемблера, в том числе как в операционных системах, так и в различном прикладном программном обеспечении для множества устройств — от суперкомпьютеров до встраиваемых систем. Язык программирования Си оказал существенное влияние на развитие индустрии программного обеспечения, а его синтаксис стал основой для таких языков программирования, как C++, C#, Java и Objective-C.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (3, N'C++', N'C++ (читается си-плюс-плюс) — компилируемый, статически типизированный язык программирования общего назначения.

Поддерживает такие парадигмы программирования, как процедурное программирование, объектно-ориентированное программирование, обобщённое программирование. Язык имеет богатую стандартную библиотеку, которая включает в себя распространённые контейнеры и алгоритмы, ввод-вывод, регулярные выражения, поддержку многопоточности и другие возможности. C++ сочетает свойства как высокоуровневых, так и низкоуровневых языков. В сравнении с его предшественником — языком C, — наибольшее внимание уделено поддержке объектно-ориентированного и обобщённого программирования.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (4, N'Java', N'Java — строго типизированный объектно-ориентированный язык программирования, разработанный компанией Sun Microsystems (в последующем приобретённой компанией Oracle). Разработка ведётся сообществом, организованным через Java Community Process, язык и основные реализующие его технологии распространяются по лицензии GPL. Права на торговую марку принадлежат корпорации Oracle.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (5, N'JavaScript', N'JavaScript — мультипарадигменный язык программирования. Поддерживает объектно-ориентированный, императивный и функциональный стили. Является реализацией языка ECMAScript (стандарт ECMA-262[6]).

JavaScript обычно используется как встраиваемый язык для программного доступа к объектам приложений. Наиболее широкое применение находит в браузерах как язык сценариев для придания интерактивности веб-страницам[7].

Основные архитектурные черты: динамическая типизация, слабая типизация, автоматическое управление памятью, прототипное программирование, функции как объекты первого класса.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (6, N'PHP', N'PHP — «Инструменты для создания персональных веб-страниц») — скриптовый язык общего назначения, интенсивно применяемый для разработки веб-приложений. В настоящее время поддерживается подавляющим большинством хостинг-провайдеров и является одним из лидеров среди языков, применяющихся для создания динамических веб-сайтов.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (7, N'Pascal', N'Паска́ль (англ. Pascal) — один из наиболее известных языков программирования, используется для обучения программированию в старших классах и на первых курсах вузов, является основой для ряда других языков.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (8, N'Objective C', N'Objective-C — компилируемый объектно-ориентированный язык программирования, используемый корпорацией Apple, построенный на основе языка Си и парадигм Smalltalk. В частности, объектная модель построена в стиле Smalltalk — то есть объектам посылаются сообщения.

Язык Objective-C является надмножеством языка Си, поэтому Си-код полностью понятен компилятору Objective-C.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (9, N'Python', N'Python (МФА: [ˈpʌɪθ(ə)n]; в русском языке распространено название питон) — высокоуровневый язык программирования общего назначения, ориентированный на повышение производительности разработчика и читаемости кода. Синтаксис ядра Python минималистичен. В то же время стандартная библиотека включает большой объём полезных функций.

Python поддерживает структурное, объектно-ориентированное, функциональное, императивное и аспектно-ориентированное программирование. Основные архитектурные черты — динамическая типизация, автоматическое управление памятью, полная интроспекция, механизм обработки исключений, поддержка многопоточных вычислений, высокоуровневые структуры данных. Поддерживается разбиение программ на модули, которые, в свою очередь, могут объединяться в пакеты.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (10, N'Ruby', N'Ruby (англ. ruby — рубин, произносится [ru:bɪ] — ру́би) — динамический, рефлективный, интерпретируемый высокоуровневый язык программирования. Язык обладает независимой от операционной системы реализацией многопоточности, сильной динамической типизацией, сборщиком мусора и многими другими возможностями. По особенностям синтаксиса он близок к языкам Perl и Eiffel, по объектно-ориентированному подходу — к Smalltalk. Также некоторые черты языка взяты из Python, Lisp, Dylan и Клу.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (11, N'Swift', N'Swift — открытый мультипарадигмальный компилируемый язык программирования общего назначения. Создан компанией Apple в первую очередь для разработчиков iOS и macOS. Swift работает с фреймворками Cocoa и Cocoa Touch и совместим с основной кодовой базой Apple, написанной на Objective-C. Swift задумывался как более лёгкий для чтения и устойчивый к ошибкам программиста язык, нежели предшествовавший ему Objective-C. Программы на Swift компилируются при помощи LLVM, входящей в интегрированную среду разработки Xcode 6 и выше. Swift может использовать рантайм Objective-C, что делает возможным использование обоих языков (а также С) в рамках одной программы.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (12, N'Delphi', N'Delphi (Де́лфи, произносится /ˈdɘlˌfi:/) — императивный, структурированный, объектно-ориентированный, высокоуровневый язык программирования со строгой статической типизацией переменных. Основная область использования — написание прикладного программного обеспечения.

Этот язык программирования является диалектом языка Object Pascal. Изначально язык Object Pascal относился к несколько другому языку, который был разработан в фирме Apple в 1986 году группой Ларри Теслера. Однако, начиная с Delphi 7 в официальных документах компании Borland название Delphi стало использоваться для обозначения языка, ранее известного как Object Pascal.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (13, N'Visual Basic', N'Microsoft Visual Basic — язык программирования, а также интегрированная среда разработки программного обеспечения, разрабатываемые корпорацией Microsoft. Язык Visual Basic унаследовал дух, стиль и отчасти синтаксис своего предка — языка BASIC, у которого есть немало диалектов. В то же время Visual Basic сочетает в себе процедуры и элементы объектно-ориентированных и компонентно-ориентированных языков программирования. Интегрированная среда разработки VB включает инструменты для визуального проектирования пользовательского интерфейса, редактор кода с возможностью IntelliSense и подсветкой синтаксиса, а также инструменты для отладки приложений.')
INSERT [dbo].[LanguageSet] ([LanguageId], [LanguageName], [LanguageDescription]) VALUES (14, N'SQL', N'SQL (ˈɛsˈkjuˈɛl; англ. structured query language — «язык структурированных запросов») — декларативный язык программирования, применяемый для создания, модификации и управления данными в реляционной базе данных, управляемой соответствующей системой управления базами данных.

Является, прежде всего, информационно-логическим языком, предназначенным для описания, изменения и извлечения данных, хранимых в реляционных базах данных. SQL считается языком программирования, в общем случае (без ряда современных расширений) не является тьюринг-полным, но вместе с тем стандарт языка спецификацией SQL/PSM предусматривает возможность его процедурных расширений.')
SET IDENTITY_INSERT [dbo].[LanguageSet] OFF
SET IDENTITY_INSERT [dbo].[MessageSet] ON 

INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (8, N'hello', CAST(N'2019-12-12T10:02:58.980' AS DateTime), 9, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (9, N'how ar u?', CAST(N'2019-12-12T10:03:14.933' AS DateTime), 9, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (10, N'i am good)', CAST(N'2019-12-12T10:06:50.660' AS DateTime), 9, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (11, N'what ar u?', CAST(N'2019-12-12T10:06:56.867' AS DateTime), 9, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (15, N'hello!', CAST(N'2019-12-12T10:08:38.617' AS DateTime), 12, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (16, N'qq', CAST(N'2019-12-12T10:08:51.323' AS DateTime), 12, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (17, N'g', CAST(N'2019-12-12T10:09:28.913' AS DateTime), 12, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (18, N'
g', CAST(N'2019-12-12T10:09:29.520' AS DateTime), 12, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (19, N'
g', CAST(N'2019-12-12T10:09:30.087' AS DateTime), 12, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (20, N'
g', CAST(N'2019-12-12T10:09:30.840' AS DateTime), 12, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (21, N'ахуенный чат', CAST(N'2019-12-12T10:09:38.207' AS DateTime), 12, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (22, N'ПРИВЕТ Я', CAST(N'2019-12-12T10:10:14.620' AS DateTime), 13, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (23, N'ЭТО Я', CAST(N'2019-12-12T10:10:20.677' AS DateTime), 13, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (24, N'КРУТЯК', CAST(N'2019-12-12T10:11:19.403' AS DateTime), 14, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (25, N'да', CAST(N'2019-12-12T10:11:37.123' AS DateTime), 14, 13)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (26, N'
паибемся?', CAST(N'2019-12-12T10:11:46.660' AS DateTime), 14, 13)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (27, N'давай', CAST(N'2019-12-12T10:12:01.763' AS DateTime), 14, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (28, N'hI hi hihi sndfnajqerq', CAST(N'2019-12-12T14:02:28.537' AS DateTime), 9, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (29, N'hello', CAST(N'2019-12-12T14:02:48.673' AS DateTime), 9, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (30, N'
', CAST(N'2019-12-12T14:03:26.133' AS DateTime), 9, 2)
SET IDENTITY_INSERT [dbo].[MessageSet] OFF
SET IDENTITY_INSERT [dbo].[QuestionSet] ON 

INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (4, N'Как называется фрагмент программного кода, к которому можно обратиться из другого места программы?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (5, N'Как именуется наименьшая автономная часть языка программирования?', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (6, N'Какое из следующих выражений является верным?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (7, N'Каким оператором объявляется класс в C#?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (8, N'Оператор который выделяет память', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (9, N'Какая библиоетка подключается первой в исходном коде программы?', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (10, N'Что является отправной точкой для компьютерной программы?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (11, N'Каждая инструкция должна заканчиваться на', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (12, N'X++ имеет то же значение, что и:', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (13, N'Каков вывод следующего кода? 
int a = 3; 
int b = 2; 
b = a++;
Console.WriteLine(++B);', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (14, N'Что выведет следующий код?
string s = "SoloLearn потрясающий"; 
Console.Write(s.IndexOf( ''е''));', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (15, N'Массив представляет собой:', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (16, N'Область в памяти, в которой хранится содержимое типа значения, называется:', 1, 1, 3, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (17, N'Какая память используется для динамического выделения?', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (18, N'Какой из данных аксессоров используется для read-only свойства?', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (19, N'Значения объектов любого класса в программе хранятся в..', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (20, N'Чтобы сделать член класса доступным извне объявления класса, вы должны объявить его следующим образом:', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (21, N'Какое из утверждений верно?', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (22, N'Какой аксессор используется для установки значения члена?', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (23, N'Что выведет следующий код?
SortedList<string, int> pupil = new SortedList<string, int>();
pupil.Add("Bob", 11);
pupil.Add("Ann", 9);
pupil.Add("Mike", 12);
pupil.Remove("Ann");
foreach (string s in pupil.Keys)
 Console.WriteLine(s + ": " + pupil[s]);', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (24, N'Перегруженный метод означает..', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (25, N'Перегрузка оператора подразумевает..', 1, 1, 3, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (26, N'Деструктор это..', 1, 1, 3, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (27, N'Какой класс вы должны использовать для обработки всех возможных исключений?', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (28, N'Что из нижеперечисленного является правильным способом определения переменной структуры Person, объявленной ниже?
struct Person {
  private string name; 
  private int age; 
}', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (29, N'Какие из следующих утверждений верны?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (30, N'Какой оператор используется для определения остатка?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (31, N'Сколько раз этот цикл будет работать? 
do {} 
while (false);', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (32, N'Что из следующего используется для ввода данных пользователем?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (33, N'Что произойдет, если мы забудем добавить оператор break в конце кода case?', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (34, N'Какой правильный оператор для проверки на равенство?', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (35, N'Сколько вложенных операторов if может содержать оператор if?', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (36, N'Результат a && b равен true, если:', 1, 1, 2, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (37, N'Сколько операторов && можно использовать в одном операторе if? ', 1, 1, 0, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (38, N'Если a истинно, а b ложно, каков результат! (A && b)?', 1, 1, 0, 1, NULL)
SET IDENTITY_INSERT [dbo].[QuestionSet] OFF
SET IDENTITY_INSERT [dbo].[QuestionTypeSet] ON 

INSERT [dbo].[QuestionTypeSet] ([QuestionTypeId], [QuestionTypeText]) VALUES (1, N'Выберите один из вариантов')
INSERT [dbo].[QuestionTypeSet] ([QuestionTypeId], [QuestionTypeText]) VALUES (2, N'Выберите правильные варианты')
INSERT [dbo].[QuestionTypeSet] ([QuestionTypeId], [QuestionTypeText]) VALUES (3, N'Перетащите куски кода')
SET IDENTITY_INSERT [dbo].[QuestionTypeSet] OFF
/****** Object:  Index [IX_FK_AnswerQuestion]    Script Date: 18.12.2019 14:24:53 ******/
CREATE NONCLUSTERED INDEX [IX_FK_AnswerQuestion] ON [dbo].[AnswerSet]
(
	[QuestionQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_AccountQuestion]    Script Date: 18.12.2019 14:24:53 ******/
CREATE NONCLUSTERED INDEX [IX_FK_AccountQuestion] ON [dbo].[QuestionSet]
(
	[AccountAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_LanguageQuestion]    Script Date: 18.12.2019 14:24:53 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LanguageQuestion] ON [dbo].[QuestionSet]
(
	[LanguageLanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_QuestionTypeQuestion]    Script Date: 18.12.2019 14:24:53 ******/
CREATE NONCLUSTERED INDEX [IX_FK_QuestionTypeQuestion] ON [dbo].[QuestionSet]
(
	[QuestionTypeQuestionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccountSet] ADD  DEFAULT ('NoName') FOR [Name]
GO
ALTER TABLE [dbo].[AccountSet] ADD  CONSTRAINT [DF_AccountSet_Points]  DEFAULT ((0)) FOR [Points]
GO
ALTER TABLE [dbo].[AccountSet] ADD  CONSTRAINT [DF_AccountSet_Reputation]  DEFAULT ((0)) FOR [Reputation]
GO
ALTER TABLE [dbo].[ThemeSet] ADD  CONSTRAINT [DF_ThemeSet_ThemePoints]  DEFAULT ((0)) FOR [ThemePoints]
GO
ALTER TABLE [dbo].[AnswerSet]  WITH CHECK ADD  CONSTRAINT [FK_AnswerQuestion] FOREIGN KEY([QuestionQuestionId])
REFERENCES [dbo].[QuestionSet] ([QuestionId])
GO
ALTER TABLE [dbo].[AnswerSet] CHECK CONSTRAINT [FK_AnswerQuestion]
GO
ALTER TABLE [dbo].[CommentorySet]  WITH CHECK ADD  CONSTRAINT [FK_CommentorySet_AccountSet] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[CommentorySet] CHECK CONSTRAINT [FK_CommentorySet_AccountSet]
GO
ALTER TABLE [dbo].[CommentorySet]  WITH CHECK ADD  CONSTRAINT [FK_CommentorySet_ThemeSet] FOREIGN KEY([ThemeId])
REFERENCES [dbo].[ThemeSet] ([ThemeId])
GO
ALTER TABLE [dbo].[CommentorySet] CHECK CONSTRAINT [FK_CommentorySet_ThemeSet]
GO
ALTER TABLE [dbo].[ConversationSet]  WITH CHECK ADD  CONSTRAINT [FK_ConversationSet_AccountSet] FOREIGN KEY([RecipientId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[ConversationSet] CHECK CONSTRAINT [FK_ConversationSet_AccountSet]
GO
ALTER TABLE [dbo].[ConversationSet]  WITH CHECK ADD  CONSTRAINT [FK_ConversationSet_AccountSet1] FOREIGN KEY([SenderId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[ConversationSet] CHECK CONSTRAINT [FK_ConversationSet_AccountSet1]
GO
ALTER TABLE [dbo].[MessageSet]  WITH CHECK ADD  CONSTRAINT [FK_MessageSet_ConversationSet] FOREIGN KEY([ConversationId])
REFERENCES [dbo].[ConversationSet] ([ConversationId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MessageSet] CHECK CONSTRAINT [FK_MessageSet_ConversationSet]
GO
ALTER TABLE [dbo].[MessageSet]  WITH CHECK ADD  CONSTRAINT [FK_MessageSet_ConversationSet_Sender] FOREIGN KEY([ConversationId])
REFERENCES [dbo].[AccountSet] ([AccountId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MessageSet] CHECK CONSTRAINT [FK_MessageSet_ConversationSet_Sender]
GO
ALTER TABLE [dbo].[QuestionSet]  WITH CHECK ADD  CONSTRAINT [FK_AccountQuestion] FOREIGN KEY([AccountAccountId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[QuestionSet] CHECK CONSTRAINT [FK_AccountQuestion]
GO
ALTER TABLE [dbo].[QuestionSet]  WITH CHECK ADD  CONSTRAINT [FK_LanguageQuestion] FOREIGN KEY([LanguageLanguageId])
REFERENCES [dbo].[LanguageSet] ([LanguageId])
GO
ALTER TABLE [dbo].[QuestionSet] CHECK CONSTRAINT [FK_LanguageQuestion]
GO
ALTER TABLE [dbo].[QuestionSet]  WITH CHECK ADD  CONSTRAINT [FK_QuestionTypeQuestion] FOREIGN KEY([QuestionTypeQuestionTypeId])
REFERENCES [dbo].[QuestionTypeSet] ([QuestionTypeId])
GO
ALTER TABLE [dbo].[QuestionSet] CHECK CONSTRAINT [FK_QuestionTypeQuestion]
GO
ALTER TABLE [dbo].[ThemeSet]  WITH CHECK ADD  CONSTRAINT [FK_ThemeSet_AccountSet] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[ThemeSet] CHECK CONSTRAINT [FK_ThemeSet_AccountSet]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Recipient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConversationSet', @level2type=N'COLUMN',@level2name=N'RecipientId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sender' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConversationSet', @level2type=N'COLUMN',@level2name=N'SenderId'
GO
