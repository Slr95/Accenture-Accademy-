SELECT * FROM dbo.publishers

USE [pubs]
GO

INSERT INTO [dbo].[publishers]([pub_id],[pub_name],[city],[state],[country])
     VALUES
           ('8888'
           ,'Algo'
           ,'Cordoba'
           ,'CB'
           ,'ARG')
GO


USE [pubs]
GO

UPDATE [dbo].[publishers]
   SET 
      [pub_name] = 'Suquia'
      ,[city] = 'Alta Gracia'
      ,[state] = 'CB'
      ,[country] = 'ARG'
 WHERE pub_id = '8888'
GO


USE [pubs]
GO

DELETE FROM [dbo].[publishers]
      WHERE pub_id='8888'
GO

--C# SINTAXIS

USE [pubs]
GO

INSERT INTO [dbo].[publishers]([pub_id],[pub_name],[city],[state],[country]) VALUE (@pub_id,@pub_name,@city,@state,@country)
GO

USE [pubs]
GO

UPDATE [dbo].[publishers] SET [pub_id] = @pub_id, [pub_name] = @pub_name, [city] = @city, [state] = @state, [country] = @country WHERE pub_id = @pub_id
GO

USE [pubs]
GO

DELETE FROM [dbo].[publishers] WHERE pub_id = @pub_id
GO



