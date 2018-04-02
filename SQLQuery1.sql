--Create table
IF OBJECT_ID('Account') IS NOT NULL DROP TABLE Account;
CREATE TABLE Account (
	Username	nvarchar(50)	PRIMARY KEY,
	Password	nvarchar(50)	NOT NULL
);

CREATE TABLE Hanghoa (
	MaHang	nvarchar(50)	PRIMARY KEY,
	TenHang	nvarchar(50)	NOT NULL,
	SoLuongHang nchar(10)	NOT NULL,
	NoiChua nchar(10)		NOT NULL,
	GiaHang nchar(10)		NOT NULL,
);

--Insert data
INSERT INTO Account(Username,Password) VALUES ('admin','123456');
SELECT * FROM Account;

INSERT INTO Account VALUES ('HoaiNam','2144537');
DELETE FROM Account WHERE Account.Username = 'admin';

