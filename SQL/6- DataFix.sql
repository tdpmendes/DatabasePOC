USE EFPoc

declare @operationId uniqueidentifier 
set @operationId = newid();

declare @professorId bigint
declare @turmaId bigint
declare @disciplinaId bigint


select * from Aluno
select * from Disciplina
select * from Horario
select * from Professor
select * from Turma

BEGIN TRANSACTION

--1-- Professor
INSERT INTO [dbo].[Professor]
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

INSERT INTO [dbo].[Disciplina]
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

INSERT INTO [dbo].[Turma]
           ([nome]
           ,[dataCriacao]
           ,[operationId])
     VALUES
           ('Quinta B'
		   ,getdate()
		   ,@operationId)

set @turmaId = SCOPE_IDENTITY()

INSERT INTO [dbo].[Aluno]
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


	 INSERT INTO [dbo].[Horario]
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