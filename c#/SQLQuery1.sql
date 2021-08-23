USE pubs --ESPECIFICAR LA BASE DE DATOS
GO --

--TABLA AUTHORS
--1-  	TRAER TODOS LOS AUTORES
--SELECT LISTA_COLUMNAS FROM TABLA
USE [pubs]
GO

SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
GO

--SELECT * FROM dbo.authors --en SSMS (*) NO USAR EN VISUAL STUDIO

--2-  	TRAER TODOS LOS AUTORES POR CIUDAD
--Berkeley -Oakland
SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
WHERE CITY='Oakland' and state--LAS CADENAS ENTRE COMILLAS SIMPLES

/* en C# EN LA CONDICION DE BUSQUEDA USAMOS PARAMETROS PARA PASAR LOS DATOS AL WHERE */
/* usamos parametros de entrada - en Sql Server se declaran con un @ adelante del nombre */
SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
WHERE CITY=@CITY

--3-    TRAER AUTORES POR ESTADO
SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
WHERE state='CA'

/* C# */

SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
WHERE STATE=@STATE

--4-  	TRAER UN AUTOR POR ID
SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
WHERE au_id='172-32-1176'

/* C# */

SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]
WHERE au_id=@au_id

USE [pubs]
GO

SELECT [pub_id], [pub_name], [city], [state], [country] FROM [dbo].[publishers]

GO

SELECT DISTINCT [city] FROM [dbo].[publishers]

