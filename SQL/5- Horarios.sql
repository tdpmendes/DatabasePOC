USE [EFPoc]
GO

/****** Object:  Table [dbo].[Horario]    Script Date: 17/01/2023 22:29:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Horarios](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[turma_id] [bigint] NOT NULL,
	[disciplina_id] [bigint] NOT NULL,
	[nome] [varchar](150) NOT NULL,
	[dataCriacao] [datetime] NOT NULL,
	[operationId] [uniqueidentifier] NOT NULL,
	[InicioHorario] [time](7) NOT NULL,
	[FimHorario] [time](7) NOT NULL,
	[GerarAlerta] [bit] NOT NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Horario]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Disciplina] FOREIGN KEY([disciplina_id])
REFERENCES [dbo].[Disciplina] ([id])
GO

ALTER TABLE [dbo].[Horario] CHECK CONSTRAINT [FK_Horario_Disciplina]
GO

ALTER TABLE [dbo].[Horario]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Turma] FOREIGN KEY([turma_id])
REFERENCES [dbo].[Turma] ([id])
GO

ALTER TABLE [dbo].[Horario] CHECK CONSTRAINT [FK_Horario_Turma]
GO


