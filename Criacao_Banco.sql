CREATE DATABASE [User];

USE [User];

CREATE TABLE Users (
	[IdUser]		INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name]		VARCHAR(255) NOT NULL,
	[Email]		VARCHAR(255) NOT NULL,
	[Password]	VARCHAR(64) NOT NULL
);

SELECT * FROM Users;

INSERT INTO Users ([Name], Email, [Password])
VALUES ('admin', 'admin@email.com', 'admin123');
