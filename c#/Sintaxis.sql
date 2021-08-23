--OPERACIONES DE MODIFICACION
--INDICAR LA BASE DE DATOS DE TRABAJO
USE pubs
GO
--INSERTAR UN AUTHOR
SELECT * FROM dbo.authors


USE [pubs]
GO

/*
au_id		au_lname	au_fname	phone			address			city		state	zip		contract
172-32-1176	White		Johnson		408 496-7223	10932 Bigge Rd.	Menlo Park	CA		94025	1
*/

INSERT INTO [dbo].[authors]
			([au_id]
           ,[au_lname]
           ,[au_fname]
           ,[phone]
           ,[address]
           ,[city]
           ,[state]
           ,[zip]
           ,[contract])
     VALUES
           ('172-32-8888'
           ,'Albornoz'
           ,'Carlos'
           ,'408 496-4444'
           ,'San Martin 233'
           ,'Quilmes'
           ,'Bs'
           ,'01878'
           ,1)
GO

/* USAR EL INSERT EN C# LOS DATOS SON REEMPLAZADOS POR PARAMETROS */

INSERT INTO dbo.authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)
-----------------------------------------------------------------------------

--MODIFICAR UN AUTHOR
SELECT * FROM dbo.authors

USE [pubs]
GO

UPDATE [dbo].[authors]
   SET 
      [au_lname] = 'Albornoz Fernandez'
      ,[au_fname] = 'Juan Carlos'
      ,[phone] = '408 496-4444'
      ,[address] = 'Alem 54'
      ,[city] = 'La Plata'
      ,[state] = 'BS'
      ,[zip] = '1254'
      ,[contract] = 1
 WHERE [au_id] = '172-32-8888'
GO

/* USAR EL INSERT EN C# LOS DATOS SON REEMPLAZADOS POR PARAMETROS */

UPDATE dbo.authors SET au_lname = @au_lname, au_fname = @au_fname, phone = @phone, address = @address, city = @city, state = @state, zip = @zip, contract = @contract WHERE au_id = @au_id
---------------------------------------------------------------------------------

--ELIMINAR UN AUTHOR

USE [pubs]
GO

DELETE FROM [dbo].[authors]
      WHERE [au_id] = '172-32-8888'
GO

/* USAR EL INSERT EN C# LOS DATOS SON REEMPLAZADOS POR PARAMETROS */
DELETE FROM dbo.authors WHERE au_id = @au_id
--------------------------------------------------------------------------------


