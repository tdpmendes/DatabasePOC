USE [EFPoc]
GO

/****** Object:  Table [dbo].[Aluno]    Script Date: 17/01/2023 22:29:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Alunos](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[turma_id] [bigint] NOT NULL,
	[matrcula] [uniqueidentifier] NOT NULL,
	[nome] [varchar](150) NOT NULL,
	[dataCriacao] [datetime] NOT NULL,
	[operationId] [uniqueidentifier] NOT NULL,
	[dataNascimento] [datetime] NOT NULL,
	[altura] [float] NOT NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Aluno]  WITH CHECK ADD  CONSTRAINT [FK_Aluno_Turma] FOREIGN KEY([turma_id])
REFERENCES [dbo].[Turma] ([id])
GO

ALTER TABLE [dbo].[Aluno] CHECK CONSTRAINT [FK_Aluno_Turma]
GO


