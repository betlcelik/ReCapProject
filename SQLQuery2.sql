--CREATE TABLE Cars (
--Id int PRIMARY KEY IDENTITY (1,1),
--BrandId int,
--ColorId int,
--ModelYear nvarchar(25),
--DailyPrice decimal,
--Descriptions nvarchar(25),
--FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
--FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
--)


--CREATE TABLE Colors(
--ColorId int PRIMARY KEY IDENTITY(1,1),
--ColorName nvarchar(25)
--)

--CREATE TABLE Brands(
--BrandId int PRIMARY KEY IDENTITY(1,1) ,
--BrandName nvarchar(25))

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES 
(1,1,2012,'100','Manuel Dizel'),
(1,4,2014,'125','Otomstik Dizel'),
(2,2,2015,'150','Manuel Benzin');


INSERT INTO Colors(ColorName)
VALUES 
('BEYAZ'),
('SİYAH'),
('KIRMIZI'),
('GRİ')

INSERT INTO Brands(BrandName)
VALUES 
('Mercedes'),
('BMW'),
('Renasu,lt')

--select * from Brands
--select * from Colors
select * from Cars