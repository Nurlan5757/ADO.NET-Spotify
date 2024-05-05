--CREATE DATABASE ADONETSpotify

--USE ADONETSpotify

--CREATE TABLE Users(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(25) NOT NULL,
--Surname NVARCHAR(25) DEFAULT 'XXX',
--Gender VARCHAR(20),
--Username VARCHAR(128) NOT NULL UNIQUE,
--Password NVARCHAR(128) CHECK(LEN(Password)>=6)
--)

--CREATE TABLE Artists(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(25) NOT NULL,
--Surname NVARCHAR(25) DEFAULT 'XXX',
--Gender VARCHAR(20),
--BirthDay DATE
--)

--CREATE TABLE Categories(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(25) NOT NULL UNIQUE
--)

--CREATE TABLE Musics(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(25) NOT NULL,
--Duration INT CHECK(Duration>0),
--CategoryId INT REFERENCES Categories(Id)
--)

--CREATE TABLE ArtistMusics(
--ArtistId INT REFERENCES Artists(Id),
--MusicId INT REFERENCES Musics(Id )
--)

--CREATE TABLE Playlists(
--UserId INT REFERENCES Users(Id)  NOT NULL,
--MusicId INT REFERENCES Musics(Id) NOT NULL
--)

--CREATE VIEW GetMusics
--AS
--SELECT m.Name,m.Duration,c.Name AS Category, a.Name AS Artist FROM Musics AS m
--JOIN Categories AS c
--ON m.CategoryId=c.Id
--JOIN ArtistMusics As am
--ON m.Id=am.MusicId
--JOIN Artists AS a
--ON am.ArtistId=a.Id

SELECT * FROM GetMusics

--SELECT u.Username,m.Name,c.Name FROM Users AS u
--JOIN Playlists AS p
--ON u.Id=p.UserId
--JOIN Musics AS m
--ON p.MusicId=m.Id
--JOIN Categories AS c
--ON m.CategoryId=c.Id

--SELECT Name,Duration FROM Musics
--ORDER BY  Duration 

--CREATE VIEW GetMusicCount
--AS
--SELECT COUNT(m.Name) AS [Count],a.Name AS ARTIST FROM Musics AS m
--JOIN ArtistMusics As am
--ON m.Id=am.MusicId
--JOIN Artists AS a
--ON am.ArtistId=a.Id
--GROUP BY a.Name


--SELECT [Count],ARTIST FROM GetMusicCount WHERE (SELECT MAX(Count) FROM GetMusicCount)=Count


