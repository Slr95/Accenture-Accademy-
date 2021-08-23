USE [Northwind]
GO

SELECT [CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax] FROM [dbo].[Customers]

GO

SELECT [CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax] FROM [dbo].[Customers] WHERE ContactTitle='Sales Associate'

SELECT [CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax] FROM [dbo].[Customers] WHERE CustomerID='COMMI'

USE [Northwind]
GO

SELECT [ProductID], [ProductName], [SupplierID], [CategoryID], [QuantityPerUnit],[UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]FROM [dbo].[Products]

GO

