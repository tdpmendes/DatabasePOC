USE [EFPoc]
GO

/****** Object:  Table [dbo].[Disciplina]    Script Date: 17/01/2023 22:24:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Disciplinas](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](150) NOT NULL,
	[dataCriacao] [datetime] NOT NULL,
	[operationId] [uniqueidentifier] NOT NULL,
	[professor_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Disciplina]  WITH CHECK ADD  CONSTRAINT [FK_Disciplina_Professor] FOREIGN KEY([professor_id])
REFERENCES [dbo].[Professor] ([id])
GO

ALTER TABLE [dbo].[Disciplina] CHECK CONSTRAINT [FK_Disciplina_Professor]
GO


