-- Yeni bir db oluşturma

Create Database CarRentalDB;

-- kullanılacak db'ye geçiş
USE CarRentalDB;


--Brands Table

Create Table Brands (
    Id INT primary key identity(1,1),
	Name Varchar(50) NOT NULL Unique
);


Create Table Models (
    Id INT primary key identity(1,1),
	Name Varchar(50) NOT NULL Unique,
	BrandId INT foreign key references Brands(Id)
);


Create Table Transmissions (
    Id INT primary key identity(1,1),
	Name Varchar(50) NOT NULL Unique
);

Create Table Fuels (
    Id INT primary key identity(1,1),
	Name Varchar(50) NOT NULL Unique
);


Create Table ModelTransmissions (
    Id INT primary key identity(1,1),
	ModelId INT foreign key references Models(Id),
	TransmissionId INT foreign key references Transmissions(Id)
);

Create Table ModelFuels (
    Id INT primary key identity(1,1),
	ModelId INT foreign key references Models(Id),
	FuelId INT foreign key references Fuels(Id)
);


Create Table Colors (
    Id INT primary key identity(1,1),
	Name Varchar(50) NOT NULL Unique
)

Create Table Cars (
    Id INT primary key identity(1,1),
	ModelId INT foreign key references Models(Id),
	ColorId Int Foreign Key references Colors(Id),
	Plate Varchar(20) Not Null Unique,
	Kilometer Int Not Null,
	ModelYear Int Not Null,
);


--Brands Table
insert into Brands (Name) Values ('Toyota'),('Honda'),('BMW'),('Mercedes'),('Ford'),
('Audi'),('Hyundai'),('Nissan'),('Peugeot'),('Volkswagen');


INSERT INTO Models (Name, BrandId) VALUES 
('Corolla', 1), ('Civic', 2), ('320i', 3), ('C200', 4), ('Focus', 5),
('A4', 6), ('i30', 7), ('Qashqai', 8), ('208', 9), ('Golf', 10);

INSERT INTO Transmissions (Name) VALUES ('Manual'), ('Automatic'), ('CVT'),
('Semi-Automatic'), ('Dual-Clutch'), ('Tiptronic'), ('Electric'), ('Hybrid'), ('7-Speed'), ('8-Speed');


INSERT INTO Fuels (Name) VALUES ('Gasoline'), ('Diesel'), ('Electric'), ('Hybrid'),
('LPG'), ('Hydrogen'), ('Ethanol'), ('CNG'), ('Bio-Diesel'), ('Methanol');



INSERT INTO Colors (Name) VALUES ('Red'), ('Blue'), ('Black'),
('White'), ('Grey'), ('Silver'), ('Green'), ('Yellow'), ('Orange'), ('Purple');


INSERT INTO ModelTransmissions (ModelId, TransmissionId) VALUES 
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);

INSERT INTO ModelFuels (ModelId, FuelId) VALUES 
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);

INSERT INTO Cars (Plate, Kilometer, ModelYear, ColorId, ModelId) VALUES 
('34ABC123', 50000, 2020, 1, 1),
('06DEF456', 60000, 2019, 2, 2),
('35GHI789', 70000, 2021, 3, 3),
('16JKL012', 80000, 2018, 4, 4),
('07MNO345', 90000, 2022, 5, 5),
('44PQR678', 40000, 2023, 6, 6),
('22STU901', 55000, 2020, 7, 7),
('09VWX234', 30000, 2019, 8, 8),
('01YZA567', 20000, 2021, 9, 9),
('45BCD890', 10000, 2022, 10, 10);




--Select (Db'deki verileri sorgulamak için kullanılır)

--Tüm arabaları getir
Select * from Cars;

Select Plate,ModelId from Cars;



--Where (koşul kullanmak için)
--2020 sonrası üretilen arabaları getir
Select * from Cars where ModelYear>2020;


--Order By (Sorgu sonuçlarını artan veya azalan sırada sıralamk için kullanılır)

--ASC => artan
--DESC => azalan

Select * from Cars Order BY Kilometer ASC; -- Kilometresi en düşük arabaları listeler

Select * from Cars Order BY Kilometer Desc; --En yeni arabaları listele

--Group By (Aynı değerlere sahip satırları bir grup olarak toplamak)

--Model yılına göre araba sayısını grupla

Select ModelYear, Count(*) as ArabaSayısı from Cars Group By ModelYear;

Select Count(*) as ArabaSayısı from Cars; --araba sayısını ver


--JOIN
--Inner join iki tabloda eşleşen verileri döndürür
--Left join,Right join,Full outer join => ödev konusu

Select c.Plate,m.Name,b.Name from Cars as c
Inner join Models as m ON c.ModelId = m.Id
Inner join Brands as b ON m.BrandId=b.Id

--Arabaları markası,modeli,rengi ve yakıt tipi ile listele

Select c.Plate,b.Name,m.Name,cl.Name,f.Name from Cars as c
Inner join Models as m On c.ModelId=m.Id
inner join Brands as b on m.BrandId=b.Id
inner join Colors as cl on c.ColorId=cl.Id
inner join ModelFuels as mf on m.Id = mf.ModelId
inner join Fuels as f on mf.FuelId = f.Id


--Having (group by ile oluşturulan gruplar üzerinde filtreleme yapar)
--where yalnızca satırlara uygulanırken, Having gruplara uygulanır

-- En az 1 modeli olan markaları getir
Select b.Name,Count(m.Id) from Brands as b
inner join Models as m on b.Id=m.BrandId
Group by b.Name
Having Count(m.Id)>=1;


--Farklı vites türlerini destekleyen modelleri ve kaç fakrlı vites tipi desteklediklerini göster
-- en az 1 farklı vites türü olanları göster

Select m.Name,Count(Distinct mt.TransmissionId) from Models as m
inner join ModelTransmissions as mt on m.Id=mt.ModelId
Group by m.Name
Having Count(m.Id)>=1;



