CREATE TABLE Users (
    Id int NOT NULL,
	FirstName varchar(255),
    LastName varchar(255),
	PRIMARY KEY(ID)
);

CREATE TABLE Countries (
    Id int NOT NULL,
	Name varchar(255),
	PRIMARY KEY(ID)
);

CREATE TABLE Travels (
    UserId int NOT NULL,
	CountryId int NOT NULL,
	CONSTRAINT travels_PK PRIMARY KEY (UserId, CountryID),
	CONSTRAINT FK_user FOREIGN KEY (userId) REFERENCES dbo.Users (id),
	CONSTRAINT FK_country FOREIGN KEY (countryId) REFERENCES dbo.Countries (id)
);

INSERT INTO Users (Id,FirstName,LastName)
VALUES 
(1,'Konrad','Korf'),
(2,'Tom','Cruise'),
(3,'Martynka','Zajaczkowska'),
(4,'Anna','Nowak'),
(5,'River','Rose')

INSERT INTO Countries(Id, Name)
VALUES 
(1,'Poland'),
(2,'China'),
(3,'Portugal'),
(4,'Spain'),
(5,'Sweden')

Insert Into Travels(UserId,CountryId)
VALUES
(1,1),(1,2),(1,3),(2,4),(2,5),(3,3),(4,1),(5,5)

SELECT Users.FirstName, Users.LastName, Countries.Name FROM Countries
INNER JOIN Travels ON Countries.Id = Travels.CountryId
INNER JOIN Users ON Users.Id = Travels.UserId