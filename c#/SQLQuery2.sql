USE [pubs]
GO

SELECT [pub_id], [pub_name], [city], [state], [country]
  FROM [dbo].[publishers]

GO

SELECT [pub_id], [pub_name], [city], [state], [country]
  FROM [dbo].[publishers] WHERE city='Boston'

  SELECT [pub_id], [pub_name], [city], [state], [country]
  FROM [dbo].[publishers] WHERE city='Boston' AND country='USA'

  SELECT [pub_id], [pub_name], [city], [state], [country]
  FROM [dbo].[publishers] WHERE pub_id='0736'

  SELECT DISTINCT [city] FROM [dbo].[publishers]
