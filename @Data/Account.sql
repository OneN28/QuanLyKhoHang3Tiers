USE MSSV;

--Create table
IF OBJECT_ID('Account') IS NOT NULL DROP TABLE Account;
CREATE TABLE Account (
	Username	nvarchar(50)	PRIMARY KEY,
	Password	nvarchar(50)	NOT NULL
);

--Insert data
INSERT INTO Account(Username,Password) VALUES ('admin','123456');
SELECT * FROM Account;