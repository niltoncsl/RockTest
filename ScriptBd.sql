USE [dbRock]
GO

CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Total] [int] NOT NULL,
	CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArticleHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdArticle] [int] NOT NULL,
	[DateCreation] [datetime] NOT NULL,
	[IP] [varchar](10) NOT NULL,
	CONSTRAINT [PK_ArticleHistory] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ArticleHistory]  WITH CHECK ADD  CONSTRAINT [FK_Article] FOREIGN KEY([IdArticle])
REFERENCES [dbo].[Article] ([Id])
GO

ALTER TABLE [dbo].[ArticleHistory] CHECK CONSTRAINT [FK_Article]
GO

INSERT INTO [dbo].[Article]
(Name, Total)
VALUES
('Artigo 1', 0)

