USE EFPoc

declare @operationId uniqueidentifier 
set @operationId = newid();

declare @professorId bigint
declare @turmaId bigint
declare @disciplinaId bigint


select * from Alunos
select * from Disciplinas
select * from Horarios
select * from Professores
select * from Turmas

BEGIN TRANSACTION

--1-- Professor
INSERT INTO [dbo].[Professores]
           ([nome]
           ,[dataCriacao]
           ,[operationId]
           ,[salario])
     VALUES
           ('Alberto Benedito Camargo'
           ,getdate()
           ,@operationId
           ,1200.00);

--2-- Disciplina

set @professorId = SCOPE_IDENTITY()

INSERT INTO [dbo].[Disciplinas]
           ([nome]
           ,[dataCriacao]
           ,[operationId]
           ,[professor_id])
     VALUES
           ('Matemática'
		   ,getDate()
		   ,@operationId
		   ,@professorId)

set @disciplinaId = SCOPE_IDENTITY()

COMMIT TRANSACTION

BEGIN TRANSACTION

INSERT INTO [dbo].[Turmas]
           ([nome]
           ,[dataCriacao]
           ,[operationId])
     VALUES
           ('Quinta B'
		   ,getdate()
		   ,@operationId)

set @turmaId = SCOPE_IDENTITY()

INSERT INTO [dbo].[Alunos]
           ([turma_id]
           ,[matrcula]
           ,[nome]
           ,[dataCriacao]
           ,[operationId]
           ,[dataNascimento]
           ,[altura])
     VALUES
           (@turmaId
		   ,newid()
		   ,'Adriano Borsato Cardoso'
		   ,getDate()
		   ,@operationId
		   ,'2010-05-29'
		   ,1.40)


	 INSERT INTO [dbo].[Horarios]
           ([turma_id]
           ,[disciplina_id]
           ,[nome]
           ,[dataCriacao]
           ,[operationId]
           ,[InicioHorario]
           ,[FimHorario]
           ,[GerarAlerta])
     VALUES
           (@turmaId
           ,@disciplinaId
           ,'Horario Turma 1'
           ,getDate()
           ,@operationId
           ,'13:30'
           ,'15:00'
           ,1)
COMMIT TRANSACTION