-- TABLE
CREATE TABLE demo (ID integer primary key, Name varchar(20), Hint text );
CREATE TABLE Filmler (
    FilmId INTEGER PRIMARY KEY AUTOINCREMENT,
    Ad TEXT NOT NULL
);
CREATE TABLE Salonlar (
    SalonId INTEGER PRIMARY KEY AUTOINCREMENT,
    Ad TEXT NOT NULL,
    KoltukKapasitesi INTEGER NOT NULL
);
CREATE TABLE Seanslar (
    SeansId INTEGER PRIMARY KEY AUTOINCREMENT,
    TarihSaat TEXT NOT NULL,
    FilmId INTEGER,
    SalonId INTEGER,
    FOREIGN KEY (FilmId) REFERENCES Filmler (FilmId),
    FOREIGN KEY (SalonId) REFERENCES Salonlar (SalonId)
);
 
-- INDEX
 
-- TRIGGER
 
-- VIEW
 
