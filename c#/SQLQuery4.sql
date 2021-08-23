USE DBCLINICA
GO

CREATE TABLE dbo.Medico

(
IdMedico INT PRIMARY KEY IDENTITY, --PRIMARY KEY NO ACEPTA NULOS NI REPETIDOS - IDENTITY ES AUTONUMERICO
Nombre Varchar(50) not null,
Apellido Varchar(50) not null,
Matricula INT not null,
Especialidad Varchar(50) not null
)

SELECT * FROM dbo.Medico

-------------------------------------------------
USE [DBCLINICA]
GO

INSERT INTO [dbo].[Medico]([Nombre],[Apellido],[Matricula],[Especialidad])
VALUES (<Nombre, varchar(50),>,<Apellido, varchar(50),>,<Matricula, int,>,<Especialidad, varchar(50),>)
GO
--C#
INSERT INTO [dbo].[Medico]([Nombre],[Apellido],[Matricula],[Especialidad])
VALUES (@Nombre, @Apellido, @Matricula, @Especialidad)


USE [DBCLINICA]
GO

UPDATE [dbo].[Medico]
SET [Nombre] = <Nombre, varchar(50),>,[Apellido] = <Apellido, varchar(50),>
      ,[Matricula] = <Matricula, int,>
      ,[Especialidad] = <Especialidad, varchar(50),>
 WHERE <Search Conditions,,>
GO
--C#
UPDATE [dbo].[Medico]
SET [Nombre] = <Nombre, varchar(50),>
      ,[Apellido] = <Apellido, varchar(50),>
      ,[Matricula] = <Matricula, int,>
      ,[Especialidad] = <Especialidad, varchar(50),>
 WHERE <Search Conditions,,>


USE [DBCLINICA]
GO

DELETE FROM [dbo].[Medico]
      WHERE <Search Conditions,,>
GO

SELECT * FROM dbo.Medico WHERE IdMedico
