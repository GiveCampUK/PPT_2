USE [master]
GO

IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'#DATABASE_NAME#')
DROP DATABASE [#DATABASE_NAME#]
GO

USE [master]
GO

/****** Object:  Database [#DATABASE_NAME#]    Script Date: 10/22/2011 22:00:22 ******/
CREATE DATABASE [#DATABASE_NAME#]
GO
