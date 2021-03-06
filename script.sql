USE [master]
GO
/****** Object:  Database [ProgramForum]    Script Date: 25.12.2019 23:07:50 ******/
CREATE DATABASE [ProgramForum]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProgramForum', FILENAME = N'C:\ProgramForum.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProgramForum_log', FILENAME = N'C:\ProgramForum_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProgramForum] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProgramForum].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProgramForum] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProgramForum] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProgramForum] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProgramForum] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProgramForum] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProgramForum] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProgramForum] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProgramForum] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProgramForum] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProgramForum] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProgramForum] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProgramForum] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProgramForum] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProgramForum] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProgramForum] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProgramForum] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProgramForum] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProgramForum] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProgramForum] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProgramForum] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProgramForum] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProgramForum] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProgramForum] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProgramForum] SET  MULTI_USER 
GO
ALTER DATABASE [ProgramForum] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProgramForum] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProgramForum] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProgramForum] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProgramForum] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProgramForum] SET QUERY_STORE = OFF
GO
use [ProgramForum]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
use [ProgramForum]
GO
/****** Object:  Table [dbo].[AccountSet]    Script Date: 02.05.2020 16:27:28 ******/
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
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[UserName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AccountSet] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnswerSet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[CodeSet]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeSet](
	[CodeId] [int] IDENTITY(1,1) NOT NULL,
	[CodeFileName] [nvarchar](max) NOT NULL,
	[BinaryFileData] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_CodeSet] PRIMARY KEY CLUSTERED 
(
	[CodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommentorySet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[ConversationSet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[LanguageSet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[LessonSet]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LessonSet](
	[LessonId] [int] IDENTITY(1,1) NOT NULL,
	[TrainingId] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[LessonName] [nvarchar](55) NOT NULL,
	[LessonText] [nvarchar](max) NOT NULL,
	[Picture] [varbinary](max) NULL,
	[Shape] [int] NULL,
	[Color] [int] NULL,
 CONSTRAINT [PK_LessonSet] PRIMARY KEY CLUSTERED 
(
	[LessonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageSet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[ProgramForumConstants]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramForumConstants](
	[ConstantId] [nchar](10) NOT NULL,
	[ConstantName] [nvarchar](max) NOT NULL,
	[ConstantValue] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ProgramForumConstants] PRIMARY KEY CLUSTERED 
(
	[ConstantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionListLessonSet]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionListLessonSet](
	[LessonQuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[LessonId] [int] NOT NULL,
 CONSTRAINT [PK_QuestionListLessonSet] PRIMARY KEY CLUSTERED 
(
	[LessonQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionSet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[QuestionTypeSet]    Script Date: 02.05.2020 16:27:28 ******/
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
/****** Object:  Table [dbo].[ThemeSet]    Script Date: 02.05.2020 16:27:28 ******/
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
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_ThemeSet] PRIMARY KEY CLUSTERED 
(
	[ThemeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheoryLessonSet]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheoryLessonSet](
	[TheoryId] [int] IDENTITY(1,1) NOT NULL,
	[LessonId] [int] NOT NULL,
	[TheoryText] [nvarchar](max) NOT NULL,
	[Position] [int] NOT NULL,
	[CodeId] [int] NULL,
 CONSTRAINT [PK_TheoryLessonSet] PRIMARY KEY CLUSTERED 
(
	[TheoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrainingProgressSet]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainingProgressSet](
	[TrainingProgressId] [int] IDENTITY(1,1) NOT NULL,
	[TrainingId] [int] NOT NULL,
	[LessonId] [int] NOT NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_TrainingProgressSet] PRIMARY KEY CLUSTERED 
(
	[TrainingProgressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrainingSet]    Script Date: 02.05.2020 16:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainingSet](
	[TrainingId] [int] IDENTITY(1,1) NOT NULL,
	[TrainingName] [nvarchar](100) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[TrainingDescrition] [nvarchar](max) NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_TrainingSet] PRIMARY KEY CLUSTERED 
(
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccountSet] ON 

INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (1, N'admin', N'admin', -1, N'Admin                                                                                               ', N'dambas.ss@mail.ru                                      ', NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (2, N'sollosollo4', N'12sollo34', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (3, N'kentuha', N'tre67swq', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (4, N'myMemory', N'67shfr4', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (5, N'myCodeEstet', N'tyreas7878', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (6, N'Mor9k', N'retroGrags22', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (7, N'Pol9k_Krito', N'fgtral4', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (8, N'StStStStSt', N'nm_9c2jzS', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (9, N'CounterS', N'554%^%Sax', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (10, N'MyColorIsBlack', N'blackblackblack', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (11, N'Saske_Uchiha', N'naruto000', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (12, N'Kak_Shit', N'@mailSpice', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (13, N'Roflan_Lico', N'mem22sa8', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (14, N'Polerwoli', N'hsdfZXsdwq', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (15, N'Qwerty', N'jkdf78XZcad', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (16, N'Poljoriono', N'llkxc9*7asdk', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (17, N'Maksimka23', N'la:ksd8VVdfd', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (18, N'Artemka99', N'ghtf%6ad332', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (19, N'AndreyProvidec', N'ghfvb^7cz', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (20, N'AndryCool', N'colSsa45545', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (21, N'Boris_Tr9pka', N'bghv5^czxs8', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (22, N'MadokaExtra', N'aniSime', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (23, N'kartishok', N'nbv786fgh23', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (24, N'Partizanka', N'miu34567ty', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (25, N'CoolSportik', N'bnvyurt4556', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (26, N'Maximal', N'jhay4512d', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (27, N'DrugoyMir', N'htyf67as2', -1, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (28, N'Marinka', N'marinka678', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (29, N'BigDaddy', N'daddyCoolBoy', -1, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (30, N'Maksimilian', N'wtfBrosd34', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (31, N'RakGubbI', N'roflan454556', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (32, N'NARUTO', N'saskesaskesaske', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (33, N'KakTakTikTak', N'tik678tak234', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (34, N'VoprosOtvet', N'rakiSaki', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (35, N'MyDadIsBad', N'dadddre234tyuio', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (36, N'Lolsssssss', N'Colsj8xjdS', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (37, N'PoMa', N'pomag56DfD', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (38, N'Nu9sa', N'tryHard', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (39, N'BEZ_OBID', N'hgf56daew', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (40, N'11_BOY_22', N'11_treSasd', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (41, N'Rofl_Negr', N'negrsa00', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (42, N'Pon9tno', N'pon9ato', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (43, N'MyMom_Good', N'mom0067', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (45, N'BalkaMaka', N'sad456yt', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (46, N'RikiTikiTavi', N'dikiydikiyparen', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (47, N'BACON', N'bacon', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (48, N'CanTrash', N'yufd67ASdv', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (49, N'Dat_Boy', N'uziuziuzi', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (50, N'OG_Dad', N'wtf56wtf78', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (51, N'Coomir', N'weuf^&sad67', 0, N'NoName                                                                                              ', NULL, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL)
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (53, N'newUser', N'123', 0, N'TestCase                                                                                            ', N'newUser@mail.ru                                        ', CAST(N'2020-01-30T10:11:55.780' AS DateTime), 0, 0, 0, NULL, N'+79859017654', 0, N'TestCase')
INSERT [dbo].[AccountSet] ([AccountId], [Login], [Password], [AccountType], [Name], [Email], [CreateDate], [Points], [Reputation], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [UserName]) VALUES (2052, N'root', N'ACzJMVmuU9W6NYaDWrxGEZAQ8gQYMNwN3eHyudNEb9Bx0oJHsuRGJzuQQgeVLDchmA==', -1, N'Admin                                                                                               ', N'root@mail.ru                                           ', CAST(N'2020-05-02T05:05:08.170' AS DateTime), 0, 0, 0, NULL, N'+79017103072', 0, N'Admin')
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
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (149, N'0', 39)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (150, N'2', 39)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (151, N'3', 39)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (152, N'8', 39)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (2149, N'Ничего', 2039)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (2150, N'кайфовать', 2039)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (2151, N'отдыхать', 2039)
INSERT [dbo].[AnswerSet] ([AnswerId], [AnswerVarible], [QuestionQuestionId]) VALUES (2152, N'чилить с кайфом', 2039)
SET IDENTITY_INSERT [dbo].[AnswerSet] OFF
SET IDENTITY_INSERT [dbo].[CodeSet] ON 

INSERT [dbo].[CodeSet] ([CodeId], [CodeFileName], [BinaryFileData]) VALUES (2006, N'CodeLabel1588120498940', 0x2F2F20D09ED0B1D18AD18FD0B2D0BBD18FD0B5D182D181D18F20D0BED0BD20D181D0BBD0B5D0B4D183D18ED189D0B8D0BC20D181D0BFD0BED181D0BED0B1D0BED0BC200D0A0D0A696E742061203D20353B0D0A0D0A)
INSERT [dbo].[CodeSet] ([CodeId], [CodeFileName], [BinaryFileData]) VALUES (2007, N'CodeLabel1588120558214', 0x2F2F20D09020D0BED0B1D18AD18FD0B2D0BBD18FD0B5D182D181D18F20D0BED0BD20D181D0BBD0B5D0B4D183D18ED189D0B8D0BC20D181D0BFD0BED181D0BED0B1D0BED0BC0D0A0D0A737472696E67207374726F6B61203D2022D09CD0BED18F20D0BFD0B5D180D0B2D0B0D18F20D181D182D180D0BED0BAD0B0223B200D0A0D0A0D0A)
SET IDENTITY_INSERT [dbo].[CodeSet] OFF
SET IDENTITY_INSERT [dbo].[ConversationSet] ON 

INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (16, 1, 2)
INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (1020, 2, 53)
INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (2020, 3, 2)
INSERT [dbo].[ConversationSet] ([ConversationId], [RecipientId], [SenderId]) VALUES (3020, 3, 1)
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
SET IDENTITY_INSERT [dbo].[LessonSet] ON 

INSERT [dbo].[LessonSet] ([LessonId], [TrainingId], [Position], [LessonName], [LessonText], [Picture], [Shape], [Color]) VALUES (1, 1005, 0, N'Урок первый', N'??', 0x89504E470D0A1A0A0000000D4948445200000065000000650806000000547C2DCF0000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000080949444154785EEDDDD78B144D1405704557119135A06B4451141FCC181ECCA29840117D1014450531B02A9810C19C73401F54CC01D3DF38D615BABD75E6CC4C87AAAE72B71F7EE077EEEDBB5D3586DE99EEFD06341A8D5A646818AB458B163504E6ADE4ED8F050D63249B3BC09CAEC8B2D1BA7FD3A64D26E27D31A2618C920D4E601DE9DE050B169888F7C5888631D29B2CB08E746FFDA278A23759601DE9DEFA45F1446FB2C03AD2BDF58BE289DE648175A47BEB17C513BDC902EB48F7D62F8A277A93C5870F1F4CCC7B85EEAD5F140FF6ECD9936E3093F43D7DFA94D6134F9E3C497B6346C398E0C6B6327FFE7C9AA38913279AB1FC6BC58286B1C00D7509BF564C681803DC44813D5BB76E6DEA11C78F1FB77A7FFEFCD9D4B37BF76EAB2726340CEDDAB56BD606CAE6634FE2F6EDDB562FD6B5E1C38767EE0D8986A1E98DCBB2790F1F3E6C2C5EBCD8FC92D7353DF7E0C18326E27D21D13034BD71BDBDBD26E27D454C9A34299D3D6EDC3813F1BE9068185AB269026B659D3F7F3E9DED63BE0B340C4D6FDAD0A1434DC4FB8AD0B305D66340C3D0468E1CE965E36EDEBC69CD956F36B12706348C81DEBC9E9E1E13F1BE3CF44C81F558D0300683070F76BA81CF9E3DB3E6C99F1AEC89050D63A13771D6AC5926E27D59E85902EB31A1612C5C6DE4BB77EFAC39172E5C3031EF8D010D63F1FDFB776B33B37E8388F40C81F5D8D03026653714DFF772FDCDA80F348CC9C78F1FAD4D5DB76E9D89792FA38F15588F110D63536663F571FBF7EF3711EF8B090D63F3EAD5AB7463C5F6EDDB4DCC7BB551A34659C7613D56348CCDFBF7EFADCD153B76EC3025DE2FA64D9BD674CCB973E74C89F7C7848631C18D6556AE5CF9F743ABA54B97D23ABA7CF9B219CDBF5E0C68188355AB56356DA66BF8356341C3D070F312478E1C697CFDFA95D65A9179F846A4F6FAF5EBBF3D31A16148B869E2D0A143A6D4DCBB66CD9AA65ED1EAF3F7478F1ED1FE4B972E9972737F28340C05374B600FCADB2FE6CE9D6B1D23EEDCB9634ABCBF6A340C013769C68C1926E6BD1A1E87F5568E1E3D6A1D27BE7DFB664ABCBF4A34ACDAA04183ACCD59B870A189792FD2C709ACB773F1E245EBD8BCC7FB42C32A1D3B76CCDA943163C69898F732FA5881F54EE4E2411F1FC3CD1434AC92DE1081F54ECA1E2FA64F9F6ECD907710B0A74A34ACCABC79F3ACCDF8F2E58B89796F2BFA7881F5AC5CCD71818655D19B3073E64C13F1BE76F40C81F5AC6EDDBA65CD79F1E2858979AF6F34ACC2B66DDBAC4DC07A567A469939C2E5AC32685805571BE06A8EC07FF4B15E151A56412FFEF0E1C326E27D9DE83902EB79E959F2011BD6AB4043DFDEBE7D9B2E5C603D0F3DA7EC2CA1672D5FBEDC44BCCF271AFAB67AF5EA74E102EB79E839656789D9B3673B9D57040D7DD38B1E3870A089785F167A96C07A5E72D5E5725E1134F44D2FFAE4C99326E27D59E85902EB45E879A74F9F3611EFF385863E3D7FFE3C5DB0C07A5E7A968B79C2C7CC3C68E8933CD3EE72C17A9690FBBCB027AF7DFBF65933B1EE1B0D7DD28B1D31628489785F1678D3B69067EEB1AF083DB3EA4B631AFAA4175BF69EDE65CB96A5B334EC2B42CFABFAD29886BEE47992370B3D4BC3BE22A64C99E27C665634F405EFC5C27A5E7A96B677EF5E53E6C764F5E0C1036B26D67DA2A12F7A9113264C3011EFCB62E3C68DE92C06FB8BD0F3AABC34A6A12F7A91F2030CB09E879E356CD8B0C6D5AB57D3FF1667CF9E356DFCD8ACF43C81755F68E8037E1E8EF53C64C3F5AC376FDE98587EF92F13497F51BB76ED723A2F2B1AFAD0DDDDED6C817A8E9E25F70AEB7CEDDAB569AD283DAFAA4B631AFAA01757F453462177DCEB5977EFDE35F1BFBAAE894F9F3E59F5BCF4ACAA2E8D69E8835EDCBD7BF74CC4FB3AD17304D67FFCF861D5594F1E211EA7A0A16B274E9C70B2303D43FCFAF5CBC4CD7D5BB66CB1FA04F66475E3C60D2773F2A0A16B7A514517863F8562FDFAF526E6BD42F78A326FE9E839555C1AD3D035BDA83C773F26F4CFAD4F600F83C70C1932C4C4BCB71D9C8375D768E89A5E90BC758FF576E6CC99931E9BC09E76F058813D9DE05F8758778D862E1D3870A0F082F47109ECC9026708792C02FB5AC1C7BE7D5F1AD3D025BD188175061F3C4D94F9AC046789F1E3C79B12EF47FA38DF97C63474492F66C58A1526E27D09D9287D4C02FB8A183D7A349DBD61C30653E6C724BABABAAC63B0EE120D5D914B56BD90768FB24D9E3CD9EA4DC86312D85BC6993367E8D71153A74E6D7CFEFCD9B4351FE7F26DA24E68E8CACE9D3B5B2E44BED396DFA1BA8E4E9D3A651DE352AB3F3589B163C736E405D4C7E8BACF4B631ABAA2179187DC7B85B37CF8FDFB37FDFA59E13C5768E80A2EA293254B9698C3F82CDFE41F6F764EEDE00C5768E882FC5F1BD842903CB9F5F8F16373089F533579EF6CF3E6CDF45C91AF4B631ABA206F83E805C8DFE1F2DDBCDCBE13F2D98F22E437D8952B571AF8F0AAAF4B631ABAA04F5E60FD7F55C5BBC63474419F78AC3FBEBC88EBD7AFA7EB125877818665BD7CF9D2FB8987A4D7E6E3D2988665C955943E71ACFFEFF4DA7CAC8F8665E91376FD1D790CF0F626AC9745C3B2F409877894C037FC29B0AE2F8D6958C6FDFBF7AD13C67A5FA1D7E8FAD2988665C89D2AFA84B1DE57E835BA5E270DCBD0275AF6D6D498E13D66582F838665E813956B7AACF7257AAD2EFFEDA46151F20333F58962BDAFD16B75B95E1A16259F41F838C958E1434B582F8A8645E913EC8F5C5D1AD3B0283CC9FEC6D5A5310D8BC293EC6F3ADDB599150D8BC27750FB13971F61D3B016160D6B61D1B016160D6B61D1B016160D6B61D1B016160D6B61D1B016160D6B61D1B016160D6B213506FC0109A43E108543D0AF0000000049454E44AE426082, 0, 16711808)
INSERT [dbo].[LessonSet] ([LessonId], [TrainingId], [Position], [LessonName], [LessonText], [Picture], [Shape], [Color]) VALUES (2, 1005, 1, N'Урок второй', N'??', 0x89504E470D0A1A0A0000000D4948445200000065000000650806000000547C2DCF0000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000083149444154785EEDDDE9CB4D5F140770435E1121434A5EA008C9F04291122243889421649EE7799E95A14886082165887FF1FEF6E2B758E7BBBFF7DCB3CF7CEF3D2F3EE5F9AEB5F7739FB3E23CF7DE738F01AD56AB5133346C548B868D6AD1B0512D1A36AA45C346B568D8A8160D1BD5A261A35A346C548B868D6AD1B0512D1A76BB478F1EB99F6CC06F8B162D6A7DF8F0C1C5BCB78E68D8CDEC40D0D4A9535BDFBE7D736D7C6D5DD0B05BC50D04DDB973C72DE1FB548D86DD880D64F8F0E15E861E3C78E096F33DAB42C36EC306B26DDB3657FA53FFF9F3676BFEFCF95E8FA5BD7540C36EC206B27DFB7657E2FD972E5DF2FAD5EAD5AB5D0B5F57261A768BD08158B76EDDF2D62AEC2D1B0DBB419681581B366CF0F611CF9F3F7765BEA66834ACBBBC0662E17EE2D8B163AEC4FB8B44C33A2B62204F9E3CF1F6549B376F762D7C5D51685857650F446DDAB4C9B5F2F545A0611D953590AD5BB7B65EBD7AE5E5FBF7EF774BF83E79A361DD1C3972C43B48450D44EB1F3F7EF4EA0F1F3EFC5B2F120DEBA4CCBF21D8F7E6CD1BAF0F7B8A40C3BA6003B1060D1AD4FAF2E58B6BE5EB99A40351376EDCF0FAB1276F34AC834E0341EFDEBD73CBF85E2A74206AD5AA559135D3A64D7331EFCD030DABD6EE9FAC8B172F7A39C2BD54DA81285CFBE2C50B17F3DEAC6858A5A4E710799D0AFBD4BA75EB22FD5907A2700FACE7858655497352DFBB77AFB746493DAF81880B172E44F629EA054C1A5621CD40ACA54B977AEB99B40351B81FD6F340C3B2651D8885FB585907227EFDFA15D973D6AC592EE6BD69D1B04C790E442D5FBEDCDB73DCB871AEC4FB438D1E3D3AB237D6B3A261598A18083B87A8C18307BB16BE2EA9C58B177BFB2E59B2C495787F1A342C43D9035143870E75AD7C7D276C200A7BB3A061D1CA1A889E43309F3973E6EF3C44DC40C4B56BD75C1B5F1B8A86452A7B200AEBBB76ED8AD4E3B0817CFAF4C9CB705D5A342C4A550351D897E4A5997603911A3E47D23559D1B0086C20EAE4C993AE85AF8B133210F1FEFD7BAF1F7BACB881285B3B7CF870A496160DF31637102BE485BED081A803070E44D68C1831C2C57E5F928108ECC17A1A34CC53D28158E3C78F774BF97E22ED40D4902143226BE531DA7AD28188DDBB7747FAB09E060DF3D2E91CB26FDF3EAF6EC94B27DAABB20E44E11E9A870C44D95EB99E0CEBA16898874E0341A3468DF2FAD5EBD7AF5D4B7E031157AF5E8DECB37EFDFA569A81085C83F55034CC2A7420D6983163BCB562E1C2855E9676200AF743490622E43224BB0EEBA16898459681A8EFDFBF7B7BA0AC03115FBF7EA57B8BA4035176EDC68D1B5DC4FB92A0615A790CC4DAB16387B79FC863200AF716A10311B807D643D0308DBC0762E1BE422E01C2BE50EC1C12F24CDF7AF9F265649FD3A74FBB98F77642C350450E44E1FE22CB6719D94014F62695DB3E2C0C51C64094BCA184DF4BDE74C2BE4EE20622D2FE2DBC77EF5E641F790E833D49D030A93207A2D86F61D813A7DDAFBDF6EB091326B856BEBE13BB8FC07A12344CA28A81A8B973E77ADF1B7B98B8E721B8A7AE0961D7AB61C386B912EF6F87869D54391025AF59D9EF3F65CA1417F35E113710F1E3C78F484D5EBCD45A12762D0A7DAF858671EA3010858FA3DDC7B03B0D44D97AC81B61765D3BB8260E0DDBA9D340143E1EAC271D8898346952A40FEB8CED5792E3495FF32468C8D47120E2EEDDBB91C73472E44817FFA9850C44C8A5A8B6579EF1638F657B95ADA73DF7D110D575204A06611F9B9C0F4207A26CFFE4C9935DD4B94F618FC09E810307BAD8EFB36868D57D200A1F234A32102183B0EBB02E6C5D618F85BD027B2C1AAA6E198888BBA638E94084DC9DC2AE3D78F0A08BFFD56D4DD97A3BB846608FA2A1E8A681287CBC2264200AF768970BAD25816BC5D3A74F5D09FA3010DD381071F9F2E5C8637EFCF8B18B796F1CBC1BC5B973E7225F2B5C9704EE2166CC98E14AA6C77E21BA75200A1F3BD693C27D10F687983871A2B79FBCCAACF54873B70F44ECDCB933F2F8B19ED4952B5722FB58D81B8ADD17C6DE1CEE6FA384D8D86D0351F66758B060818B785F27761F853DA16EDEBCE9ED29973DD99EBF7F58B16245A4B15B0722E4226EFBB3603D09BBDEC2BE10490622A25FFCDFD8CD0311F8F9F7D0FB46DAB568CD9A35AE85AF8BC33EFA8DBF6E2B2FE815F68797F760B0DE8E5DD78E5CEA84EBE2840C44D0B017E0FD23B1CED87E25F9E7CF9F699EC4F5EBD7BDB5870E1D7225DE2F68D80BE43E2AF640601DD95E65EBEC6A4E5B67D840925C044EC35E610FC6B265CB5CD4B94F618F9833674EA23E216F6C616FD2ABF269D82BF0A0605D608FC01E0B3F842ADEBE7DEB4AFF7AD840E44E4CB6270E0D7B85BCAE640FCCB367CF5CFCAF6E6BCAD6DBC1B7A2C59E3D7B5CC9BF4659840C44D0B097E0016A970BAD25317DFA746F3D73F4E851D7CEF7688786BD64EDDAB59183D4EE3A655C97C4962D5BE85E2AED8D4169D86BF06021EC0FC16E6D28B2DCA99586BD66DEBC79DE4153D81B0ADF2E10C78F1F7725DE9F040D7B111E38813DA1D82DDAB30E44D0B017C93DC0ECC1CBFAFA1E1BC88913275C89F787A061AFC28388F5A4D81DFAF21A88A061AFC2CF9008ECE9840D24ED7D00DAA1612F9B3D7B76E4808E1D3BD6C5BC17E19DF1C4A953A75C89F7A745C35E870776E5CA952EE6BDAAAC81081AF6033CC0F67F2642E7CF9F8FF48A2C1F9FEB8486FD80DDA7857DAA975D5E54E440040DFB85FC276978C0ED3D21D940CE9C39F3B75E141AF693FBF7EF7B075E9C3D7BD6CBCA1888A061BF91DB8CE000900C09D7158586FD0A07A1CA1C88A0613F935BE5DA81C879057B8A46C37E279F9D9481DCBE7DDB7DC97B8A44C346B568D8A8160D1BD5A261A35A346C548B868D6AD1B0512D1A36AA45C346B568D8A8160D1B556A0DF80F5C48D56491C3DD940000000049454E44AE426082, 0, 255)
SET IDENTITY_INSERT [dbo].[LessonSet] OFF
SET IDENTITY_INSERT [dbo].[MessageSet] ON 

INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (34, N'Hi!', CAST(N'2020-01-20T13:50:13.860' AS DateTime), 16, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (3049, N'Привет', CAST(N'2020-01-30T14:39:26.213' AS DateTime), 16, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (3050, N'Привет', CAST(N'2020-01-30T14:39:49.020' AS DateTime), 1020, 53)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (3051, N'Ну здарова)', CAST(N'2020-01-30T14:40:10.590' AS DateTime), 1020, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (4052, N'тестовое сообщение', CAST(N'2020-03-02T22:35:45.877' AS DateTime), 2020, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (4053, N'тестовое сообщение', CAST(N'2020-03-02T22:41:16.807' AS DateTime), 2020, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (4054, N'тестовое сообщение', CAST(N'2020-03-02T22:41:46.503' AS DateTime), 2020, 3)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (5049, N'ну здарова', CAST(N'2020-03-23T15:21:01.187' AS DateTime), 16, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (5050, N'Привет)', CAST(N'2020-03-23T15:21:16.180' AS DateTime), 16, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (5051, N'да', CAST(N'2020-03-23T15:21:24.770' AS DateTime), 2020, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (5052, N'хеллоу', CAST(N'2020-03-23T15:21:30.623' AS DateTime), 1020, 2)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (6049, N'salam', CAST(N'2020-04-25T20:34:04.757' AS DateTime), 16, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (7049, N'kentuha salam', CAST(N'2020-04-26T23:26:29.557' AS DateTime), 3020, 1)
INSERT [dbo].[MessageSet] ([MessageId], [MessageText], [Date], [ConversationId], [SenderId]) VALUES (8049, N'Прикол в том, что если а
то есть ты даже по этой ссылке не переходил
мда
https://www.youtube.com/watch?v=AgFIsVr26zg
тебе нужно повторить всё что он делает
и если хочется еще что то понять советую включить субтитры
Алексей
Алексей 2:09
 
ага я пересматривал эту хуйню 3 раза
 
и при том что я знаю знаю английский и понял что он там базарит я не понял что мне делать
 
я сам от себя вахуе
Надежда
Надежда 2:11
что именно у тебя не получилось
на каком моменте
Алексей
Алексей 2:22
 
я сейчас попробую кое-что если не получиться завтра напишу
 
а то уже поздно я тебя уже своими вопросами заебал', CAST(N'2020-04-29T07:56:40.323' AS DateTime), 16, 1)
SET IDENTITY_INSERT [dbo].[MessageSet] OFF
INSERT [dbo].[ProgramForumConstants] ([ConstantId], [ConstantName], [ConstantValue]) VALUES (N'0         ', N'ProjectName', N'ProgramForum')
SET IDENTITY_INSERT [dbo].[QuestionListLessonSet] ON 

INSERT [dbo].[QuestionListLessonSet] ([LessonQuestionId], [QuestionId], [Position], [LessonId]) VALUES (1002, 28, 1, 1)
INSERT [dbo].[QuestionListLessonSet] ([LessonQuestionId], [QuestionId], [Position], [LessonId]) VALUES (1003, 23, 1, 2)
SET IDENTITY_INSERT [dbo].[QuestionListLessonSet] OFF
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
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (39, N'Сколько программных модулей использует EntityFramework?', 1, 1, 1, 1, NULL)
INSERT [dbo].[QuestionSet] ([QuestionId], [QuestionText], [LanguageLanguageId], [QuestionTypeQuestionTypeId], [CorrectOption], [AccountAccountId], [Date]) VALUES (2039, N'Что делать с си?', 2, 1, 0, 1, NULL)
SET IDENTITY_INSERT [dbo].[QuestionSet] OFF
SET IDENTITY_INSERT [dbo].[QuestionTypeSet] ON 

INSERT [dbo].[QuestionTypeSet] ([QuestionTypeId], [QuestionTypeText]) VALUES (1, N'Выберите один из вариантов')
INSERT [dbo].[QuestionTypeSet] ([QuestionTypeId], [QuestionTypeText]) VALUES (2, N'Выберите правильные варианты')
INSERT [dbo].[QuestionTypeSet] ([QuestionTypeId], [QuestionTypeText]) VALUES (3, N'Перетащите куски кода')
SET IDENTITY_INSERT [dbo].[QuestionTypeSet] OFF
SET IDENTITY_INSERT [dbo].[ThemeSet] ON 

INSERT [dbo].[ThemeSet] ([ThemeId], [AuthorId], [ThemeName], [ThemeText], [ThemePoints], [CreateDate], [Visible]) VALUES (1, 1, N'Тестовая тема добавленная администратором, ДА!', N'Была лично отредактирована и добавлена на форум!', 0, CAST(N'2020-01-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ThemeSet] ([ThemeId], [AuthorId], [ThemeName], [ThemeText], [ThemePoints], [CreateDate], [Visible]) VALUES (3, 1, N'1234567989', N'123312321312321132312312132312231312312312', 0, CAST(N'2020-02-02T15:26:40.323' AS DateTime), 1)
INSERT [dbo].[ThemeSet] ([ThemeId], [AuthorId], [ThemeName], [ThemeText], [ThemePoints], [CreateDate], [Visible]) VALUES (1002, 1, N'C Sharp', N'C# (произносится си шарп) — объектно-ориентированный язык программирования. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота[7] как язык разработки приложений для платформы Microsoft .NET Framework. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270.

C# относится к семье языков с C-подобным синтаксисом, из них его синтаксис наиболее близок к C++ и Java. Язык имеет статическую типизацию, поддерживает полиморфизм, перегрузку операторов (в том числе операторов явного и неявного приведения типа), делегаты, атрибуты, события, свойства, обобщённые типы и методы, итераторы, анонимные функции с поддержкой замыканий, LINQ, исключения, комментарии в формате XML.

Переняв многое от своих предшественников — языков C++, Delphi, Модула, Smalltalk и, в особенности, Java — С#, опираясь на практику их использования, исключает некоторые модели, зарекомендовавшие себя как проблематичные при разработке программных систем, например, C# в отличие от C++ не поддерживает множественное наследование классов (между тем допускается множественное наследование интерфейсов).', 0, CAST(N'2020-03-23T19:19:45.727' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[ThemeSet] OFF
SET IDENTITY_INSERT [dbo].[TheoryLessonSet] ON 

INSERT [dbo].[TheoryLessonSet] ([TheoryId], [LessonId], [TheoryText], [Position], [CodeId]) VALUES (2007, 1, N'ТЕОРИЯ. Сегодня мы изучим что такое int.
Это тип данных в которым хранится целочисленные значения', 0, 2006)
INSERT [dbo].[TheoryLessonSet] ([TheoryId], [LessonId], [TheoryText], [Position], [CodeId]) VALUES (2008, 2, N'Теперь поговорим о типе string. Это строковой тип данных', 0, 2007)
SET IDENTITY_INSERT [dbo].[TheoryLessonSet] OFF
SET IDENTITY_INSERT [dbo].[TrainingProgressSet] ON 

INSERT [dbo].[TrainingProgressSet] ([TrainingProgressId], [TrainingId], [LessonId], [AccountId]) VALUES (4, 1005, 2, 1)
SET IDENTITY_INSERT [dbo].[TrainingProgressSet] OFF
SET IDENTITY_INSERT [dbo].[TrainingSet] ON 

INSERT [dbo].[TrainingSet] ([TrainingId], [TrainingName], [AuthorId], [TrainingDescrition], [LanguageId]) VALUES (1005, N'Первые типы данных', 1, N'В этом уроке вы узнаете о таких типах данных как int и string!', 1)
SET IDENTITY_INSERT [dbo].[TrainingSet] OFF
ALTER TABLE [dbo].[AccountSet] ADD  DEFAULT ('NoName') FOR [Name]
GO
ALTER TABLE [dbo].[AccountSet] ADD  CONSTRAINT [DF_AccountSet_Points]  DEFAULT ((0)) FOR [Points]
GO
ALTER TABLE [dbo].[AccountSet] ADD  CONSTRAINT [DF_AccountSet_Reputation]  DEFAULT ((0)) FOR [Reputation]
GO
ALTER TABLE [dbo].[AccountSet] ADD  DEFAULT (CONVERT([bit],(0))) FOR [EmailConfirmed]
GO
ALTER TABLE [dbo].[AccountSet] ADD  DEFAULT (CONVERT([bit],(0))) FOR [PhoneNumberConfirmed]
GO
ALTER TABLE [dbo].[ThemeSet] ADD  CONSTRAINT [DF_ThemeSet_ThemePoints]  DEFAULT ((0)) FOR [ThemePoints]
GO
ALTER TABLE [dbo].[ThemeSet] ADD  CONSTRAINT [DF_ThemeSet_Visible]  DEFAULT ((0)) FOR [Visible]
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
ALTER TABLE [dbo].[ConversationSet]  WITH CHECK ADD  CONSTRAINT [FK_ConversationSet_AccountSet_Recipient] FOREIGN KEY([RecipientId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[ConversationSet] CHECK CONSTRAINT [FK_ConversationSet_AccountSet_Recipient]
GO
ALTER TABLE [dbo].[ConversationSet]  WITH CHECK ADD  CONSTRAINT [FK_ConversationSet_AccountSet_Sender] FOREIGN KEY([SenderId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[ConversationSet] CHECK CONSTRAINT [FK_ConversationSet_AccountSet_Sender]
GO
ALTER TABLE [dbo].[LessonSet]  WITH CHECK ADD  CONSTRAINT [FK_LessonSet_TrainingSet] FOREIGN KEY([TrainingId])
REFERENCES [dbo].[TrainingSet] ([TrainingId])
GO
ALTER TABLE [dbo].[LessonSet] CHECK CONSTRAINT [FK_LessonSet_TrainingSet]
GO
ALTER TABLE [dbo].[MessageSet]  WITH CHECK ADD  CONSTRAINT [FK_MessageSet_ConversationSet] FOREIGN KEY([ConversationId])
REFERENCES [dbo].[ConversationSet] ([ConversationId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MessageSet] CHECK CONSTRAINT [FK_MessageSet_ConversationSet]
GO
ALTER TABLE [dbo].[QuestionListLessonSet]  WITH CHECK ADD  CONSTRAINT [FK_QuestionListLessonSet_LessonSet] FOREIGN KEY([LessonId])
REFERENCES [dbo].[LessonSet] ([LessonId])
GO
ALTER TABLE [dbo].[QuestionListLessonSet] CHECK CONSTRAINT [FK_QuestionListLessonSet_LessonSet]
GO
ALTER TABLE [dbo].[QuestionListLessonSet]  WITH CHECK ADD  CONSTRAINT [FK_QuestionListLessonSet_QuestionSet] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[QuestionSet] ([QuestionId])
GO
ALTER TABLE [dbo].[QuestionListLessonSet] CHECK CONSTRAINT [FK_QuestionListLessonSet_QuestionSet]
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
ALTER TABLE [dbo].[TheoryLessonSet]  WITH CHECK ADD  CONSTRAINT [FK_TheoryLessonSet_CodeSet] FOREIGN KEY([CodeId])
REFERENCES [dbo].[CodeSet] ([CodeId])
GO
ALTER TABLE [dbo].[TheoryLessonSet] CHECK CONSTRAINT [FK_TheoryLessonSet_CodeSet]
GO
ALTER TABLE [dbo].[TheoryLessonSet]  WITH CHECK ADD  CONSTRAINT [FK_TheoryLessonSet_LessonSet] FOREIGN KEY([LessonId])
REFERENCES [dbo].[LessonSet] ([LessonId])
GO
ALTER TABLE [dbo].[TheoryLessonSet] CHECK CONSTRAINT [FK_TheoryLessonSet_LessonSet]
GO
ALTER TABLE [dbo].[TrainingProgressSet]  WITH CHECK ADD  CONSTRAINT [FK_TrainingProgressSet_AccountSet] FOREIGN KEY([AccountId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[TrainingProgressSet] CHECK CONSTRAINT [FK_TrainingProgressSet_AccountSet]
GO
ALTER TABLE [dbo].[TrainingProgressSet]  WITH CHECK ADD  CONSTRAINT [FK_TrainingProgressSet_LessonSet] FOREIGN KEY([LessonId])
REFERENCES [dbo].[LessonSet] ([LessonId])
GO
ALTER TABLE [dbo].[TrainingProgressSet] CHECK CONSTRAINT [FK_TrainingProgressSet_LessonSet]
GO
ALTER TABLE [dbo].[TrainingProgressSet]  WITH CHECK ADD  CONSTRAINT [FK_TrainingProgressSet_TrainingSet] FOREIGN KEY([TrainingId])
REFERENCES [dbo].[TrainingSet] ([TrainingId])
GO
ALTER TABLE [dbo].[TrainingProgressSet] CHECK CONSTRAINT [FK_TrainingProgressSet_TrainingSet]
GO
ALTER TABLE [dbo].[TrainingSet]  WITH CHECK ADD  CONSTRAINT [FK_TrainingSet_AccountSet] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[AccountSet] ([AccountId])
GO
ALTER TABLE [dbo].[TrainingSet] CHECK CONSTRAINT [FK_TrainingSet_AccountSet]
GO
ALTER TABLE [dbo].[TrainingSet]  WITH CHECK ADD  CONSTRAINT [FK_TrainingSet_LanguageSet] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[LanguageSet] ([LanguageId])
GO
ALTER TABLE [dbo].[TrainingSet] CHECK CONSTRAINT [FK_TrainingSet_LanguageSet]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AccountSet_Recipient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConversationSet', @level2type=N'COLUMN',@level2name=N'RecipientId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AccountSet_Sender' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConversationSet', @level2type=N'COLUMN',@level2name=N'SenderId'
GO
