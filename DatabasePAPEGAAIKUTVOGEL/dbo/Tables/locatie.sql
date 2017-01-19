CREATE TABLE locatie
  (
     id         INT PRIMARY KEY NOT NULL,
     idkooilist INT FOREIGN KEY REFERENCES loctokooi(idloc) NOT NULL,
     toegang    BIT NOT NULL,
     naam       VARCHAR NOT NULL
  )